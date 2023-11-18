using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.DAL;
using MySql.Data.MySqlClient;

namespace Projeto_Final.Codigo.BLL
{
    public class refeitorioBLL : Acesso_BancoDados
    {
        public DataTable listarRefeitorio()
        {
            return retornarDados("select * from refeitorio, processo, alimento where processo.cod_processo = refeitorio.cod_processo and alimento.cod_alimento = refeitorio.cod_alimento;");
        }

        //metodo para retornar a lista de processo
        public DataTable listaProcesso()
        {
            return retornarDados("select * from processo, apenado where apenado.cod_apenado = processo.cod_apenado");
        }

        //metodo para retornar a lista de alimento
        public DataTable listaalimento()
        {
            return retornarDados("select * from alimento");
        }

        //metodo para cadastrar refeitorio
        public bool salvar(refeitorioDTO _refeitorio)
        {
            try
            {
                if (_refeitorio.processo.cod_processo.ToString() == string.Empty || _refeitorio.processo.cod_processo <= 0) return msgErro("Informe o Número do Processo!");
                if (_refeitorio.alimento.cod_alimento.ToString() == string.Empty || _refeitorio.alimento.cod_alimento <= 0) return msgErro("Informe o Tipo de Alimento!");
                if (_refeitorio.tipo_refeicao == string.Empty) return msgErro("Insira o Tipo de Refeição!");    

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                
                string sql = "insert into refeitorio(cod_processo, cod_alimento, tipo_refereicao)" +
                    "values(@cod_processo, @cod_alimento, @tipo_refeicao)";

                MySqlParameter  parametro = new MySqlParameter("@cod_processo", MySqlDbType.Int32);
                parametro.Value = _refeitorio.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_alimento", MySqlDbType.Int32);
                parametro.Value = _refeitorio.alimento.cod_alimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tipo_refeicao", MySqlDbType.VarChar);
                parametro.Value = _refeitorio.tipo_refeicao;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Refeitorio Cadastrado com Sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o Refeitorio!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para alterar refeitorio
        public bool alterar(refeitorioDTO _refeitorio)
        {
            try
            {
                if (_refeitorio.processo.cod_processo.ToString() == string.Empty || _refeitorio.processo.cod_processo <= 0) return msgErro("Informe o Número do Processo!");
                if (_refeitorio.alimento.cod_alimento.ToString() == string.Empty || _refeitorio.alimento.cod_alimento <= 0) return msgErro("Informe o Tipo de Alimento!");
                if (_refeitorio.tipo_refeicao == string.Empty) return msgErro("Insira o Tipo de Refeição!");


                string sql = "update refeitorio set cod_processo = @processo, cod_alimento = @cod_alimento, tipo_refereicao = @tipo_refeicao where cod_refeitorio = @id_refeitorio";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@processo", MySqlDbType.Int32);
                parametro.Value = _refeitorio.processo.cod_processo;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_alimento", MySqlDbType.Int32);
                parametro.Value = _refeitorio.alimento.cod_alimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tipo_refeicao", MySqlDbType.Int32);
                parametro.Value = _refeitorio.cod_refeitorio;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@id_refeitorio", MySqlDbType.Int32);
                parametro.Value = _refeitorio.cod_refeitorio;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Refeitorio alterado com Sucesso!");
                return msgErro("Ocorreu um erro ao alterar o Refeitorio!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para remover refeitorio
        public bool remover(refeitorioDTO _refeitorio)
        {
            try
            {
                string sql = "delete from refeitorio where cod_refeitorio = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _refeitorio.cod_refeitorio;
                listaParametro.Add(parametro);


                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Refeitorio removido com Sucesso!");
                //return msgErro("Ocorreu um erro ao remover o Refeitorio!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
