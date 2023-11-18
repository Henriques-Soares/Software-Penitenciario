using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DAL;
using Projeto_Final.Codigo.DTO;

namespace Projeto_Final.Codigo.BLL
{
    public class utilizadorBLL : Acesso_BancoDados
    {
        public DataTable ListarFuncionario()
        {
            return retornarDados("select * from funcionario");
        }


        public DataTable ListarUtilizador()
        {
            return retornarDados(" select * from utilizador, funcionario where funcionario.cod_funcionario = utilizador.cod_funcionario");
        }
        //metodo para gerar o utilizador padrao do sistema
        public bool inicializar()
        {
            try
            {
               //cadastrando utilizador padrao
                if (retornarDados("select * from utilizador").Rows.Count <= 0)
                {
                    string sqlComando = "insert into utilizador(nome_utilizador, senha) values('HP', md5('HP2022'))";
                    executarComando(sqlComando);
                }

                //cadastrando funcao padrao
                if (retornarDados("select * from funcao where nome_funcao like 'Admin'").Rows.Count <= 0)
                {
                    string sqlComando = "insert into funcao(nome_funcao, descricao_funcao) values('Admin', 'Função para Administrador do Sistema')";
                    executarComando(sqlComando);

                    //atribuir todas as permissoes do sistema na funcao Admin
                    string sql = "select * from permissao";
                    string sqlu = "select * from utilizador,funcao where utilizador.cod_utilizador=funcao.cod_funcao";
                    DataTable dt2 = new DataTable();
                    DataTable dt3 = new DataTable();
                    dt2.Clear();
                    dt2 = retornarDados(sql);
                    int n = int.Parse(retornarDados("select * from funcao where nome_funcao like 'Admin'").Rows[0]["cod_funcao"].ToString());
                    
                    
                    for(int cod_permissao=0; cod_permissao < dt2.Rows.Count; cod_permissao++)
                    {
                        sqlComando = "insert into funcao_permissao(cod_funcao, cod_permissao) values("+n+","+int.Parse(dt2.Rows[cod_permissao]["cod_permissao"].ToString())+")";
                        executarComando(sqlComando);
                    }
                   executarComando("insert into utilizador_funcao(cod_utilizador, cod_funcao) values((select cod_utilizador from utilizador where nome_utilizador like 'HP' limit 1), (select cod_funcao from funcao where nome_funcao like 'Admin' limit 1))");
               }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //metodo para efectuar login
        public bool login(utilizadorDTO utilizador)
        {
            try
            {
                string sql = "select * from utilizador where nome_utilizador = @nome and senha = md5(@senha)";
                List<MySqlParameter> listaParametro = new List<MySqlParameter>();

                MySqlParameter parametro = new MySqlParameter("@nome", MySqlDbType.VarChar);
                parametro.Value = utilizador.nomeUtilizador;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@senha", MySqlDbType.Text);
                parametro.Value = utilizador.senha;
                listaParametro.Add(parametro);

                DataTable dt = new DataTable();
                dt.Clear();

                dt = retornarDados(sql, listaParametro);

                if (dt != null && dt.Rows.Count > 0)
                {
                    sql = "select * from permissao where cod_permissao in(select cod_permissao from funcao_permissao where cod_funcao in(select cod_funcao from utilizador_funcao where cod_utilizador = "+ dt.Rows[0]["cod_utilizador"].ToString() + "))";

                    DataTable dt2 = new DataTable();
                    dt2.Clear();
                    dt2 = retornarDados(sql);
                    
                    if (dt2 != null && dt2.Rows.Count > 0)
                    {
                        bool permissao_login = false;
                        UtilizadorLogadoDTO.Permissao.Clear();
                        for (int i = 0; i < dt2.Rows.Count; i++)
                        {
                            UtilizadorLogadoDTO.Permissao.Add(dt2.Rows[i]["nome_permissao"].ToString());
                            if (dt2.Rows[i]["nome_permissao"].ToString() == "permissao efectuar login") permissao_login = true;
                           
                        }
                        

                        if (permissao_login == true)
                        {
                            UtilizadorLogadoDTO.codUtilizador = int.Parse(dt.Rows[0]["cod_utilizador"].ToString());
                            UtilizadorLogadoDTO.codFuncionario = dt.Rows[0]["cod_funcionario"].ToString() != string.Empty ? int.Parse(dt.Rows[0]["cod_funcionario"].ToString()) : UtilizadorLogadoDTO.codFuncionario;
                            UtilizadorLogadoDTO.nomeUtilizador = dt.Rows[0]["nome_utilizador"].ToString();
                            UtilizadorLogadoDTO.senha = dt.Rows[0]["senha"].ToString();

                            return true;
                        }
                        else
                        {
                            UtilizadorLogadoDTO.Permissao.Clear();
                            return msgErro("Acesso negado!");
                        }
                    }
                    else return msgErro("Acesso negado!");                    
                }
                else return msgErro("Dados incorrectos!");
            } 
            catch (Exception ex)
            {
                return msgErro(ex.Message.ToString());
            }
        }

        public bool cadastrarUtilizador(utilizadorDTO utilizador)
        {
            try
            {
                if (utilizador.nomeUtilizador == string.Empty) return msgErro("Insira o nome do Utilizador!");
                if (utilizador.senha == string.Empty) return msgErro("Insira o Senha do Utilizador!");


                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("@nome_utilizador", MySqlDbType.VarChar);
                parametro.Value = utilizador.nomeUtilizador;
                listaParametro.Add(parametro);
                
                if (retornarDados("select * from utilizador where nome_utilizador like @nome_utilizador", listaParametro).Rows.Count > 0) return msgErro("Já Existente um utilizador com esse nome!");
                listaParametro.Clear();


                string sql = "insert into utilizador(cod_funcionario,nome_utilizador, senha) values(@cod_funcionario, @nome_utilizador,md5(@senha))"; 
                

                parametro = new MySqlParameter("@cod_funcionario", MySqlDbType.Int32);
                parametro.Value = utilizador.codFuncionario;
                listaParametro.Add(parametro);


                parametro = new MySqlParameter("@nome_utilizador", MySqlDbType.VarChar);
                parametro.Value = utilizador.nomeUtilizador;
                listaParametro.Add(parametro);

                parametro = new MySqlParameter("@senha", MySqlDbType.Text);
                parametro.Value = utilizador.senha;
                listaParametro.Add(parametro);

                if (!executarComando(sql, listaParametro)) return msgErro("Ocorreu um erro ao criar o utilizador!");

                //executarComando("delete from utilizador_funcao where cod_utilizador = " + utilizador.codUtilizador);
                
                return msgInformacao("Utilizador cadastrado com sucesso!");

            }
            catch (Exception)
            {
                return false;
            }
            
        }
        public bool Alterar_pass_utilizador(utilizadorDTO utilizador)
        {
            List<MySqlParameter> listaParametro = new List<MySqlParameter>();
            string sql = "update utilizador set senha = @senha where cod_utilizador = @id";
            //parametro do nome
            MySqlParameter parametro = new MySqlParameter("@senha", MySqlDbType.Text);
            parametro.Value = utilizador.senha;
            listaParametro.Add(parametro);

            //parametro do codigo do tipo de crime
            parametro = new MySqlParameter("@id", MySqlDbType.Int32);
            parametro.Value = utilizador.codUtilizador;
            listaParametro.Add(parametro);

            if (executarComando(sql, listaParametro) == true) return msgInformacao("Palavra Passe Alterada com sucesso!");
            return msgErro("Ocorreu um erro ao Alterar a Palavra Passe!");
           
        }
        public bool verificar_senha(string senha)
        {
            List<MySqlParameter> listaParametro = new List<MySqlParameter>();
            MySqlParameter parametro = new MySqlParameter("@senha", MySqlDbType.Text);
            parametro.Value = senha;
            listaParametro.Add(parametro);
            if (retornarDados("select * from utilizador where utilizador.senha = @senha", listaParametro).Rows.Count > 0) return true;
            
            return false;
        }
        
    }
}


