using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.DAL;

namespace Projeto_Final.Codigo.BLL
{
    public class alimentoBLL : Acesso_BancoDados
    {
        //metodo para retornar a lista geral de Alimento
        public DataTable listaAlimento()
        {
            try
            {
                return retornarDados("select * from alimento");
            }
            catch (Exception)
            {
                return null;
            }
        }

        //metodo para cadastrar alimento
        public bool salvar(alimentoDTO _alimento)
        {
            try
            {
                if (_alimento.nome_alimento == string.Empty) return msgErro("Insira o nome do alimento!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome_alimento", MySqlDbType.VarChar);

                string sql = "select * from alimento where nome_alimento like @nome_alimento";

                parametro.Value = _alimento.nome_alimento;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe alimento com este nome!");

                listaParametro.Clear();

                sql = "insert into alimento(nome_alimento, descricao_alimento) values(@nome_alimento, @descricao_alimento)";

                parametro.Value = _alimento.nome_alimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao_alimento", MySqlDbType.Text);
                parametro.Value = _alimento.descricao_alimento;
                listaParametro.Add(parametro);
                
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Alimento cadastrado com sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o Alimento!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para actualizar Alimento
        public bool alterar(alimentoDTO _alimento)
        {
            try
            {
                if (_alimento.nome_alimento == string.Empty) return msgErro("Insira o nome do Alimento!");

                string sql = "update alimento set nome_alimento = @nome_alimento, descricao_alimento = @descricao_alimento where cod_alimento = @id_alimento";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                //parametro do nome do alimento
                MySqlParameter parametro = new MySqlParameter("@nome_alimento", MySqlDbType.VarChar);
                parametro.Value = _alimento.nome_alimento;
                listaParametro.Add(parametro);


                //Paramentro da descricao do alimento
                parametro = new MySqlParameter("descricao_alimento", MySqlDbType.Text);
                parametro.Value = _alimento.descricao_alimento;
                listaParametro.Add(parametro);


                //parametro do codigo do alimento
                parametro = new MySqlParameter("@id_alimento", MySqlDbType.Int32);
                parametro.Value = _alimento.cod_alimento;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Alimento actualizado com sucesso!");
                return msgErro("Ocorreu um erro ao actualizar o Alimento!");
            }
            catch (Exception)
            {
                return false;
            }
        }
        //metodo para remover Alimento
        public bool remover(alimentoDTO _alimento)
        {
            try
            {
                string sql = "delete from alimento where cod_alimento = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _alimento.cod_alimento;
                listaParametro.Add(parametro);
                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Alimento removido com sucesso!");
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}

