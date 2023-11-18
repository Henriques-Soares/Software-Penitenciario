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
    public class funcionarioBLL : Acesso_BancoDados
    {
        public DataTable index()
        {
            return retornarDados("select * from funcionario, tipo_funcionario, provincia where tipo_funcionario.cod_tipo_funcionario = funcionario.cod_tipo_funcionario and provincia.cod_provincia = funcionario.cod_provincia");
        }

        //metodo para retornar a lista de provincias
        public DataTable listaProvincia()
        {
            return retornarDados("select * from provincia");
        }

        //metodo para Cadastrar funcionário
        public bool salvar(funcionarioDTO _Funcionario)
        {
            try
            {
                if (_Funcionario.nome_funcionario == string.Empty) return msgErro("Informe o nome do funcionário!");
                if (_Funcionario.data_nascimento == string.Empty) return msgErro("Informe a Data de Nascimento do Funcionário!");
                if (_Funcionario.genero == string.Empty) return msgErro("Informe o Genero do funcionário!");
                if (_Funcionario.bi == string.Empty) return msgErro("Informe o BI do funcionário!");
                if (_Funcionario.altura.ToString() == string.Empty || _Funcionario.altura <= 0) return msgErro("Informe a Altura do funcionário!");
                if (_Funcionario.nip.ToString() == string.Empty || _Funcionario.nip <= 0) return msgErro("Informe o NIP do funcionário!");
                if (_Funcionario.tel1.ToString() == string.Empty || _Funcionario.tel1 <= 0) return msgErro("Informe o Número de Telefone do funcionário!");


                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                listaParametro.Clear();


                MySqlParameter parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                string  sql = "select * from funcionario where bi = @bi";

                parametro.Value = _Funcionario.bi;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe Este BI no Sistema!");

                listaParametro.Clear();

                parametro = new MySqlParameter("@nome", MySqlDbType.VarChar);

                sql = "select * from funcionario where nome_funcionario like @nome";

                parametro.Value = _Funcionario.nome_funcionario;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe um funcionário com este nome!");

                listaParametro.Clear();

                sql = "insert into funcionario(cod_tipo_funcionario, nome_funcionario, data_nascimento, genero, bi, nome_pai, nome_mae, cod_provincia, residencia, estado_civil, altura, img, nip, tel1, tel2) " +
                    "values(@cod_tipo_funcionario, @nome_funcionario, @data_nascimento, @genero, @bi, @nome_pai, @nome_mae, @cod_provincia, @residencia, @estado_civil, @altura, @img, @nip, @tel1, @tel2)";
                
                parametro = new MySqlParameter("@cod_tipo_funcionario", MySqlDbType.Int32);
                parametro.Value = _Funcionario.tipoFuncionario.codTipoFuncionario;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_funcionario", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_funcionario;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.data_nascimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
                parametro.Value = _Funcionario.genero;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.bi;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_pai", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_pai;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_mae", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_mae;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@naturalidade", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.naturalidade;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_provincia", MySqlDbType.Int32);
                parametro.Value = _Funcionario.provincia.codProvincia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.residencia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@estado_civil", MySqlDbType.Enum);
                parametro.Value = _Funcionario.estado_civil;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@altura", MySqlDbType.Float);
                parametro.Value = _Funcionario.altura;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@img", MySqlDbType.Blob);
                parametro.Value = _Funcionario.img;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nip", MySqlDbType.Int16);
                parametro.Value = _Funcionario.nip;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tel1", MySqlDbType.Int16);
                parametro.Value = _Funcionario.tel1;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tel2", MySqlDbType.Int16);
                parametro.Value = _Funcionario.tel2;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Funcionário cadastrado com sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar este tipo de funcionário!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para Editar funcionário
        public bool alterar(funcionarioDTO _Funcionario)
        {
            try
            {
                if (_Funcionario.nome_funcionario == string.Empty) return msgErro("Informe o nome do funcionário!");
                if (_Funcionario.data_nascimento == string.Empty) return msgErro("Informe a Data de Nascimento do Funcionário!");
                if (_Funcionario.genero == string.Empty) return msgErro("Informe o Genero do funcionário!");
                if (_Funcionario.bi == string.Empty) return msgErro("Informe o BI do funcionário!");
                if (_Funcionario.altura.ToString() == string.Empty || _Funcionario.altura <= 0) return msgErro("Informe a Altura do funcionário!");
                if (_Funcionario.nip.ToString() == string.Empty || _Funcionario.nip <= 0) return msgErro("Informe o NIP do funcionário!");
                if (_Funcionario.tel1.ToString() == string.Empty || _Funcionario.tel1 <= 0) return msgErro("Informe o Número de Telefone do funcionário!");


                string sql = "update funcionario set cod_tipo_funcionario = @cod_tipo_funcionario, nome_funcionario = @nome_funcionario," +
                    " data_nascimento = @data_nascimento, genero = @genero, bi = @bi, nome_pai = @nome_pai, nome_mae = @nome_mae, " +
                    "cod_provincia = @cod_provincia, residencia = @residencia, estado_civil = @estado_civil, altura = @altura, img = @img, " +
                    "nip = @nip, tel1 = @tel1, tel2 = @tel2 where cod_funcionario = @cod_funcionario";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@cod_tipo_funcionario", MySqlDbType.Int32);
                parametro.Value = _Funcionario.tipoFuncionario.codTipoFuncionario;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_funcionario", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_funcionario;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.data_nascimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
                parametro.Value = _Funcionario.genero;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.bi;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_pai", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_pai;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_mae", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.nome_mae;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_provincia", MySqlDbType.Int32);
                parametro.Value = _Funcionario.provincia.codProvincia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
                parametro.Value = _Funcionario.residencia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@estado_civil", MySqlDbType.Enum);
                parametro.Value = _Funcionario.estado_civil;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@altura", MySqlDbType.Float);
                parametro.Value = _Funcionario.altura;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@img", MySqlDbType.Blob);
                parametro.Value = _Funcionario.img;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nip", MySqlDbType.Int16);
                parametro.Value = _Funcionario.nip;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tel1", MySqlDbType.Int16);
                parametro.Value = _Funcionario.tel1;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@tel2", MySqlDbType.Int16);
                parametro.Value = _Funcionario.tel2;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_funcionario", MySqlDbType.Int16);
                parametro.Value = _Funcionario.cod_funcionario;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Funcionário alterado com sucesso!");

                return msgErro("Ocorreu um erro ao alterar este tipo de funcionário!");
            }
            catch (Exception)
            {
                return false;
            }
        }
        //metodo para remover funcionário
        public bool remover(funcionarioDTO _Funcionario)
        {
            try
            {
                string sql = "delete from funcionario where cod_funcionario = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _Funcionario.cod_funcionario;
                listaParametro.Add(parametro);


                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Funcionário removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o Funcionário!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

    }
}
