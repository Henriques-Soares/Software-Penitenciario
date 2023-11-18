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
    public class tipo_crimeBLL : Acesso_BancoDados
    {
        //metodo para retornar a lista geral de tipo de crime
        public DataTable listaTipoCrime()
        {
            try
            {
                return retornarDados("select * from tipo_crime");
            }
            catch (Exception)
            {
                return null;
            }
        }

        //metodo para cadastrar tipo de crime
        public bool salvar(tipo_crimeDTO _tipoCrime)
        {
            try
            {
                if (_tipoCrime.nome_tipo_crime == string.Empty) return msgErro("Insira o nome do tipo de crime!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome", MySqlDbType.VarChar);

                string sql = "select * from tipo_crime where nome_tipo_crime like @nome";

                parametro.Value = _tipoCrime.nome_tipo_crime;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe tipo de crime com este nome!");

                listaParametro.Clear();

                sql = "insert into tipo_crime(nome_tipo_crime) values(@nome)";

                parametro.Value = _tipoCrime.nome_tipo_crime;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de crime cadastrado com sucesso!");
                return msgErro("Ocorreu um erro ao cadastrar o tipo de crime!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para actualizar tipo de crime
        public bool alterar(tipo_crimeDTO _tipoCrime)
        {
            try
            {
                if (_tipoCrime.nome_tipo_crime == string.Empty) return msgErro("Insira o nome do tipo de crime!");

                string sql = "update tipo_crime set nome_tipo_crime = @nome where +cod_tipo_crime = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                //parametro do nome
                MySqlParameter parametro = new MySqlParameter("@nome", MySqlDbType.VarChar);
                parametro.Value = _tipoCrime.nome_tipo_crime;
                listaParametro.Add(parametro);

                //parametro do codigo do tipo de crime
                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _tipoCrime.cod_tipo_crime;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de crime actualizado com sucesso!");
                return msgErro("Ocorreu um erro ao actualizar o tipo de crime!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para remover tipo de crime
        public bool remover(tipo_crimeDTO _tipoCrime)
        {
            try
            {
                string sql = "delete from tipo_crime where cod_tipo_crime = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _tipoCrime.cod_tipo_crime;
                listaParametro.Add(parametro);


                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de crime removido com sucesso!");

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
