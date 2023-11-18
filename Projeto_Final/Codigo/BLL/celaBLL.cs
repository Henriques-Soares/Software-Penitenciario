using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.DAL;
using MySql.Data.MySqlClient;


namespace Projeto_Final
{
    class celaBLL : Acesso_BancoDados
    {
        public DataTable listarCela()
        {      
            return retornarDados("select * from cela, bloco where bloco.cod_bloco = cela.cod_bloco");
        }
        public DataTable listaBloco()
        {
            return retornarDados("select * from bloco");
        }

        public bool salvar(celaDTO _cela)
        {
            try
            {
                if (_cela.nome_cela == string.Empty) return msgErro("Insira o nome da Cela!");
                if (_cela.bloco.cod_bloco.ToString() == string.Empty || _cela.bloco.cod_bloco <= 0) return msgErro("Informe o Bloco!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome_cela", MySqlDbType.VarChar);

                string sql = "select * from cela where nome_cela like @nome_cela";

                parametro = new MySqlParameter("@nome_cela", MySqlDbType.VarChar);
                parametro.Value = _cela.nome_cela;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe uma cela com este nome!");

                listaParametro.Clear();

                sql = "insert into cela(nome_cela, cod_bloco) values(@nome_cela, @cod_bloco)";

                parametro = new MySqlParameter("@nome_cela", MySqlDbType.VarChar);
                parametro.Value = _cela.nome_cela;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_bloco", MySqlDbType.Int32);
                parametro.Value = _cela.bloco.cod_bloco;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cela cadastrado com sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o Cela!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterar(celaDTO _cela)
        {
            try
            {
                if (_cela.nome_cela == string.Empty) return msgErro("Insira o nome da Cela!");
                if (_cela.bloco.cod_bloco.ToString() == string.Empty || _cela.bloco.cod_bloco <= 0) return msgErro("Informe o Bloco!");

                string sql = "update cela set nome_cela = @nome_cela, cod_bloco = @cod_bloco where cod_cela = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@nome_cela", MySqlDbType.VarChar);
                parametro.Value = _cela.nome_cela;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_bloco", MySqlDbType.Int32);
                parametro.Value = _cela.bloco.cod_bloco;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _cela.cod_cela;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cela alterada com Sucesso!");
                return msgErro("Ocorreu um erro ao alterar a Cela!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool remover(celaDTO _cela)
        {
            try
            {
                string sql = "delete from cela where cod_cela = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _cela.cod_cela;
                listaParametro.Add(parametro);


                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Cela removida com Sucesso!");
                //return msgErro("Ocorreu um erro ao remover a Cela!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
