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
    public class camaBLL : Acesso_BancoDados
    {
       
        public DataTable listaCamaDisponivel()
        {
            try
            {
                return retornarDados("select * from cama, cela, bloco where bloco.cod_bloco = cela.cod_bloco and cela.cod_cela = cama.cod_cela and cama.cod_cama not in(select cod_cama from processo where estado = 'Detido')");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable listaCela()
        {
            return retornarDados("select * from cela");
        }

        public bool salvar(camaDTO _cama)
        {
            try
            {
                if (_cama.numero_cama.ToString() == string.Empty || _cama.numero_cama <= 0) return msgErro("Insira o número da Cama!");
                if (_cama.cela.cod_cela.ToString() == string.Empty || _cama.cela.cod_cela <= 0) return msgErro("Informe a Cela!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@cama", MySqlDbType.VarChar);

                string sql = "insert into cama(numero_cama, cod_cela) values(@numero_cama, @cod_cela)";

                parametro = new MySqlParameter("@numero_cama", MySqlDbType.Int32);
                parametro.Value = _cama.numero_cama;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_cela", MySqlDbType.Int32);
                parametro.Value = _cama.cela.cod_cela;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cama cadastrado com sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o Cama!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterar(camaDTO _cama)
        {
            try
            {
                if (_cama.numero_cama.ToString() == string.Empty || _cama.numero_cama <= 0) return msgErro("Insira o número da Cama!");
                if (_cama.cela.cod_cela.ToString() == string.Empty || _cama.cela.cod_cela <= 0) return msgErro("Informe a Cela!");

                string sql = "update cama set numero_cama = @numero_cama, cod_cela = @cod_cela where cod_cama = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@numero_cama", MySqlDbType.Int32);
                parametro.Value = _cama.numero_cama;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_cela", MySqlDbType.Int32);
                parametro.Value = _cama.cela.cod_cela;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _cama.cod_cama;
                listaParametro.Add(parametro);
                
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cama alterada com Sucesso!");
                return msgErro("Ocorreu um erro ao alterar a Cama!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool remover(camaDTO _cama)
        {
            try
            {
                string sql = "delete from cama where cod_cama = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _cama.cod_cama;
                listaParametro.Add(parametro);
                

                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cama removida com Sucesso!");
                //return msgErro("Ocorreu um erro ao remover a Cama!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
