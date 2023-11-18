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
    public class blocoBLL : Acesso_BancoDados
    {
        public DataTable listarBloco()
        {
            try
            {
                return retornarDados("select * from bloco");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool salvar (blocoDTO _bloco)
        {
            try
            {
                if (_bloco.nome_bloco == string.Empty) return msgErro("Insira o nome do Bloco!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome_bloco", MySqlDbType.VarChar);

                string sql = "select * from bloco where nome_bloco like @nome_bloco";

                parametro.Value = _bloco.nome_bloco;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe um Bloco com este nome!");

                listaParametro.Clear();

                sql = "insert into bloco(nome_bloco) values(@nome_bloco)";

                parametro.Value = _bloco.nome_bloco;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Bloco cadastrado com sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o Bloco!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool alterar (blocoDTO _bloco)
        {
            try
            {
                if (_bloco.nome_bloco == string.Empty) return msgErro("Insira o nome do Bloco!");

                string sql = "update bloco set nome_bloco = @nome_bloco where cod_bloco = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                //parametro do nome
                MySqlParameter parametro = new MySqlParameter("@nome_bloco", MySqlDbType.VarChar);
                parametro.Value = _bloco.nome_bloco;
                listaParametro.Add(parametro);

                //parametro do codigo do tipo de crime
                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _bloco.cod_bloco;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Bloco Alterado com sucesso!");
                return msgErro("Ocorreu um erro ao Alterar o Bloco!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool remover(blocoDTO _bloco)
        {
            try
            {
                string sql = "delete from bloco where cod_bloco = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _bloco.cod_bloco;
                listaParametro.Add(parametro);
                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Bloco Removido com sucesso!");
                //return msgErro("Ocorreu um erro ao Remover o Bloco!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

