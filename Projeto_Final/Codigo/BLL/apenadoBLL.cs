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
    public class apenadoBLL : Acesso_BancoDados
    {
        //metodo para retornar a lista de apenados
        public DataTable listarApenado()
        {
                return retornarDados("select * from apenado, provincia where provincia.cod_provincia=apenado.cod_provincia");
            
        }

        public DataTable listarProvincia()
        {
            return retornarDados("select * from provincia");
        }

        //metodo para cadastrar um apenado
        public bool salvar(apenadoDTO _apenado)
        {
            try
            {
                if (_apenado.nome_apenado == string.Empty) return msgErro("Insira o nome do Apenado!");
                if (_apenado.data_nascimento == string.Empty) return msgErro("Informe a Data de Nascimento do Apenado!");
                if (_apenado.genero == string.Empty) return msgErro("Informe o Genero do apenado!");
                if (_apenado.provincia.codProvincia.ToString() == string.Empty || _apenado.provincia.codProvincia <= 0) return msgErro("Informe a Província do apenado!");
                if (_apenado.naturalidade == string.Empty) return msgErro("Informe a Naturalidade do apenado!");
                if (_apenado.altura.ToString() == string.Empty || _apenado.altura <= 0) return msgErro("Informe a Altura do apenado!");
                if (_apenado.apelido == string.Empty) return msgErro("Insira o apelido do Apenado!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome", MySqlDbType.VarChar);
               
                string sql = "select * from apenado where nome_apenado like @nome";

                parametro.Value = _apenado.nome_apenado;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe tipo de crime com este nome!");

                listaParametro.Clear();

                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                sql = "select * from apenado where bi = @bi";

                parametro.Value = _apenado.bi;
                listaParametro.Add(parametro);

                if (retornarDados(sql, listaParametro).Rows.Count > 0) return msgErro("Já existe Este BI no Sistema!");

                listaParametro.Clear();


                sql = "insert into apenado(nome_apenado, data_nascimento, genero, bi, nome_pai, nome_mae, cod_provincia, naturalidade, residencia, estado_civil, altura, img, apelido, descricao_apenado) " +
                    " values(@nome_apenado, @data_nascimento, @genero, @bi, @nome_pai, @nome_mae, @cod_provincia, @naturalidade, @residencia, @estado_civil, @altura, @img, @apelido, @descricao_apenado)";

                parametro = new MySqlParameter("@nome_apenado", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_apenado;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
                parametro.Value = _apenado.data_nascimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
                parametro.Value = _apenado.genero;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                parametro.Value = _apenado.bi;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_pai", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_pai;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_mae", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_mae;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_provincia", MySqlDbType.Int32);
                parametro.Value = _apenado.provincia.codProvincia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@naturalidade", MySqlDbType.VarChar);
                parametro.Value = _apenado.naturalidade;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
                parametro.Value = _apenado.residencia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@estado_civil", MySqlDbType.Enum);
                parametro.Value = _apenado.estado_civil;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@altura", MySqlDbType.Float);
                parametro.Value = _apenado.altura;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@img", MySqlDbType.Blob);
                parametro.Value = _apenado.img;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@apelido", MySqlDbType.VarChar);
                parametro.Value = _apenado.apelido;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao_apenado", MySqlDbType.Text);
                parametro.Value = _apenado.descricao;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("apenado cadastrado com sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar este Apenado!");

            }
            catch (Exception)
            {
                return false;   
            }
        }

        //metodo para alterar um apenado
        public bool alterar(apenadoDTO _apenado)
        {
            try
            {
                if (_apenado.nome_apenado == "") return msgErro("Informe o nome do apenado!");

                string sql = "update apenado set nome_apenado = @nome_apenado, data_nascimento = @data_nascimento," +
                    " genero = @genero, bi = @bi, nome_pai = @nome_pai, nome_mae = @nome_mae, cod_provincia = @cod_provincia," +
                    " naturalidade = @naturalidade, residencia = @residencia, estado_civil = @estado_civil, altura = @altura," +
                    " img = @img, apelido = @apelido, descricao_apenado = @descricao_apenado where cod_apenado = @cod_apenado";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@nome_apenado", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_apenado;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@data_nascimento", MySqlDbType.VarChar);
                parametro.Value = _apenado.data_nascimento;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@genero", MySqlDbType.Enum);
                parametro.Value = _apenado.genero;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@bi", MySqlDbType.VarChar);
                parametro.Value = _apenado.bi;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_pai", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_pai;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@nome_mae", MySqlDbType.VarChar);
                parametro.Value = _apenado.nome_mae;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_provincia", MySqlDbType.Int32);
                parametro.Value = _apenado.provincia.codProvincia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@naturalidade", MySqlDbType.VarChar);
                parametro.Value = _apenado.naturalidade;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@residencia", MySqlDbType.VarChar);
                parametro.Value = _apenado.residencia;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@estado_civil", MySqlDbType.Enum);
                parametro.Value = _apenado.estado_civil;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@altura", MySqlDbType.Float);
                parametro.Value = _apenado.altura;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@img", MySqlDbType.Blob);
                parametro.Value = _apenado.img;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@apelido", MySqlDbType.VarChar);
                parametro.Value = _apenado.apelido;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao_apenado", MySqlDbType.Text);
                parametro.Value = _apenado.descricao;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@cod_apenado", MySqlDbType.Int32);
                parametro.Value = _apenado.cod_apenado;
                listaParametro.Add(parametro);



                if (executarComando(sql, listaParametro) == true) return msgInformacao("Apenado alterado com sucesso!");

                return msgErro("Ocorreu um erro ao alterar este Apenado!");
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para remover um apenado
        public bool remover(apenadoDTO _apenado)
        {
            try
            {
                string sql = "delete from apenado where cod_apenado = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _apenado.cod_apenado;
                listaParametro.Add(parametro);
                if(msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Apenado removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o Apenado!");
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
