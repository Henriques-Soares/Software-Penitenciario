using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Final.Codigo.DAL;
using Projeto_Final.Codigo.DTO;

namespace Projeto_Final.Codigo.BLL
{
    public class processoBLL : Acesso_BancoDados
    {
        public DataTable index()
        {
            return retornarDados("Select * from processo, apenado, cama where apenado.cod_apenado = processo.cod_apenado and cama.cod_cama = processo.cod_cama");
        }

        public DataTable processoApenado()
        {
            return retornarDados("select * from processo, apenado where processo.estado = 'Detido' and apenado.cod_apenado = processo.cod_apenado");

        }

        public bool cadastrarProcesso(processoDTO processo, List<tipo_crimeDTO> listTipoCrime)
        {
            try
            {
                //validando os campos
                if (processo.numero_processo == string.Empty) return msgErro("Informe o número do processo!");
                if (processo.apenado.cod_apenado.ToString() == string.Empty || processo.apenado.cod_apenado <=0) return msgErro("Escolha o apenado!");
                if (processo.cama.cod_cama.ToString() == string.Empty || processo.cama.cod_cama <=0) return msgErro("Escolha a cama!");
                if (listTipoCrime.Count == 0) return msgErro("Selecione os crimes cometidos!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("processo", MySqlDbType.VarChar);
                parametro.Value = processo.numero_processo;
                listaParametro.Add(parametro);

                if (retornarDados("select * from processo where num_processo like @processo", listaParametro).Rows.Count > 0) return msgErro("Já Existente processo com este número!");
                listaParametro.Clear();


                parametro = new MySqlParameter("cod_apenado", MySqlDbType.Int32);
                parametro.Value = processo.apenado.cod_apenado;
                listaParametro.Add(parametro);
                if (retornarDados("select * from processo, apenado where processo.estado = 'Detido' and @cod_apenado = processo.cod_apenado", listaParametro).Rows.Count > 0) return msgErro("Este apenado ainda Esta Detido!");

                listaParametro.Clear();


                string sql = "insert into processo(num_processo, cod_apenado, cod_cama, descricao, estado) " +
                    "values(@num_processo, @cod_apenado, @cod_cama, @descricao, 'Detido')";

                parametro = new MySqlParameter("num_processo", MySqlDbType.VarChar);
                parametro.Value = processo.numero_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("cod_apenado", MySqlDbType.Int32);
                parametro.Value = processo.apenado.cod_apenado;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("cod_cama", MySqlDbType.Int32);
                parametro.Value = processo.cama.cod_cama;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("descricao", MySqlDbType.Text);
                parametro.Value = processo.descricao;
                listaParametro.Add(parametro);
                if (!executarComando(sql, listaParametro)) return msgErro("Ocorreu um erro ao criar o processo!");

                sql = "insert into processo_crime(cod_processo, cod_tipo_crime) " +
                    "values((select cod_processo from processo where num_processo = @num_processo limit 1)," +
                    " @cod_tipo_crime)";

                foreach(var item in listTipoCrime)
                {
                    listaParametro.Clear();
                    parametro = new MySqlParameter("num_processo", MySqlDbType.VarChar);
                    parametro.Value = processo.numero_processo;
                    listaParametro.Add(parametro);

                    parametro = new MySqlParameter("cod_tipo_crime", MySqlDbType.Text);
                    parametro.Value = item.cod_tipo_crime;
                    listaParametro.Add(parametro);
                    executarComando(sql, listaParametro);
                }

                return msgInformacao("Processo cadastrado com sucesso!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Soltura(processoDTO processo)
        {
            try
            {
            string sql = "update processo set estado = 'Solto' where cod_processo = @cod_processo";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@cod_processo", MySqlDbType.Int32);
                parametro.Value = processo.cod_processo;
                listaParametro.Add(parametro);

                if (msgConfirmacao("Tem a certeza que deseja Soltar este Apenado?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Apenado Solto com sucesso!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool removerProcesso(processoDTO _processso)
        {
            try
            {
                string sql = "delete from processo where cod_processo = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _processso.cod_processo;
                listaParametro.Add(parametro);


                if (msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                    if (executarComando(sql, listaParametro) == true) return msgInformacao("Processo removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o tipo de crime!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
