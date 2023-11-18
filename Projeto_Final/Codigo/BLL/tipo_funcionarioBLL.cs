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
    public class tipo_funcionarioBLL : Acesso_BancoDados
    {

        //metodo para retornar a lista geral do tipo de funcionário
        public DataTable index()
        {
            return retornarDados("Select * from tipo_funcionario");
        }

        //metodo para Cadastrar o tipo de funcionário
        public bool salvar(tipo_funcionarioDTO _tipoFuncionario)
        {
            try
            {
                if (_tipoFuncionario.designacao == "") return msgErro("Informe a designação do tipo de funcionário!");

                string sql = "insert into tipo_funcionario(nome_tipo_funcionario) values(@designacao)";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@designacao", MySqlDbType.VarChar);
                parametro.Value = _tipoFuncionario.designacao;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de funcionário cadastrado com sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar este tipo de funcionário!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para Editar o tipo de funcionário
        public bool editar(tipo_funcionarioDTO _tipoFuncionario)
        {
            try
            {
                if (_tipoFuncionario.designacao == "") return msgErro("Informe a designação do tipo de funcionário!");

                string sql = "update tipo_funcionario set nome_tipo_funcionario = @designacao where cod_tipo_funcionario = @cod";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@designacao", MySqlDbType.VarChar);
                parametro.Value = _tipoFuncionario.designacao;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod", MySqlDbType.Int16);
                parametro.Value = _tipoFuncionario.codTipoFuncionario;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de funcionário alterado com sucesso!");

                return msgErro("Ocorreu um erro ao alterar este tipo de funcionário!");
            }
            catch (Exception)
            {
                return false;
            }
        }
        //metodo para remover o tipo de funcionário
        public bool remover(tipo_funcionarioDTO _tipoFuncionario)
        {
            try
            {
                string sql = "delete from tipo_funcionario where cod_tipo_funcionario = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _tipoFuncionario.codTipoFuncionario;
                listaParametro.Add(parametro);

                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Tipo de Funcionário removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o tipo de funcionário!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
