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
    public class funcaoBLL : Acesso_BancoDados
    {
        //metodo para retornar a lista de utilizador
            public DataTable listarfuncao()
            {
                try
                {
                    return retornarDados("select * from funcao");
                }
                catch (Exception)
                {
                    return null;
                }
            }
        public DataTable ListarFuncaoUtilizador(int id)
        {
            return retornarDados("select * from utilizador_funcao where cod_utilizador = " + id);
        }

        public bool salvar(funcaoDTO _funcao)
        {
            try
            {
                if (_funcao.nome_funcao == string.Empty) return msgErro("Insira o nome da Função!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome_funcao", MySqlDbType.VarChar);
                parametro.Value = _funcao.nome_funcao;
                listaParametro.Add(parametro);

                if (retornarDados("select * from funcao where funcao.nome_funcao like @nome_funcao", listaParametro).Rows.Count > 0) return msgErro("Já Existente Função com este nome!");
                listaParametro.Clear();


                string sql = "insert into funcao(nome_funcao, descricao_funcao) values(@nome_funcao, @descricao_funcao)";
                parametro = new MySqlParameter("@nome_funcao", MySqlDbType.VarChar);
                parametro.Value = _funcao.nome_funcao;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao_funcao", MySqlDbType.Text);
                parametro.Value = _funcao.descricao_funcao;
                listaParametro.Add(parametro);
                
                if (executarComando(sql, listaParametro) == true) return msgInformacao("Função Cadastrado com Sucesso!");

                return msgErro("Ocorreu um erro ao cadastrar Função!");
            }
            catch (Exception)
            {
                return false;
            }
        }
           

        public bool alterar(funcaoDTO _funcao)
        {
            try
            {
                if (_funcao.nome_funcao == string.Empty) return msgErro("Insira o nome do tipo de crime!");

                string sql = "update funcao set nome_funcao = @nome_funcao, descricao_funcao = @descricao_funcao where cod_funcao = @id";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@nome_funcao", MySqlDbType.VarChar);
                parametro.Value = _funcao.nome_funcao;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@descricao_funcao", MySqlDbType.VarChar);
                parametro.Value = _funcao.descricao_funcao;
                listaParametro.Add(parametro);

                //parametro do codigo do tipo de crime
                parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _funcao.cod_funcao;
                listaParametro.Add(parametro);

                if (executarComando(sql, listaParametro) == true) return msgInformacao("Função Alterado com sucesso!");
                return msgErro("Ocorreu um erro ao Alterar a Função!");
            }
                catch (Exception)
            {
                return false;
            }
        }

        public bool remover(funcaoDTO _funcao)
        {
            try
            {
                string sql = "delete from funcao where cod_funcao = @id";

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@id", MySqlDbType.Int32);
                parametro.Value = _funcao.cod_funcao;
                listaParametro.Add(parametro);


                if (msgConfirmacao("Tem a certeza que deseja Eliminar este Conteúdo?"))
                    if (executarComando(sql, listaParametro) == true) return msgInformacao("Função removido com sucesso!");

                //return msgErro("Ocorreu um erro ao remover o tipo de crime!");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Utilizador_permissao(utilizadorDTO utilizador, List<funcaoDTO> listfuncao)
        {
            try
            {

                // if (listpermissao.Count == 0) return msgErro("Selecione as Permissões!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("utilizador", MySqlDbType.VarChar);

                executarComando("delete from utilizador_funcao where cod_utilizador = " + utilizador.codUtilizador);
                //
                foreach (var item in listfuncao)
                {
                    listaParametro.Clear();


                    string sql = "insert into utilizador_funcao(cod_utilizador, cod_funcao) " +
                        "values(@cod_utilizador, @cod_funcao)";

                    parametro = new MySqlParameter("cod_utilizador", MySqlDbType.Int32);
                    parametro.Value = utilizador.codUtilizador;
                    listaParametro.Add(parametro);

                    parametro = new MySqlParameter("cod_funcao", MySqlDbType.Int32);
                    parametro.Value = item.cod_funcao;
                    listaParametro.Add(parametro);
                    executarComando(sql, listaParametro);
                }

                return msgInformacao("Permissão cadastrada com sucesso!");

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
