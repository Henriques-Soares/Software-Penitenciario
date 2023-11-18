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
    public class permissaoBLL : Acesso_BancoDados
    {
        public DataTable ListarPermissao()
        {
            return retornarDados("select * from permissao");
        }

        public DataTable ListarPermissaoDaFuncao(int id)
        {
            return retornarDados("select * from funcao_permissao where cod_funcao = " + id);
        }

        public bool salvar(funcaoDTO _funcao, List<permissaoDTO> listpermissao)
        {
            try
            {

                // if (listpermissao.Count == 0) return msgErro("Selecione as Permissões!");

                List<MySqlParameter> listaParametro = new List<MySqlParameter>();
                MySqlParameter parametro = new MySqlParameter("permissao", MySqlDbType.VarChar);

                executarComando("delete from funcao_permissao where cod_funcao = " + _funcao.cod_funcao);
                //
                foreach (var item in listpermissao)
                {
                    listaParametro.Clear();


                    string sql = "insert into funcao_permissao(cod_funcao, cod_permissao) " +
                        "values(@cod_funcao, @cod_permissao)";
                    
                    parametro = new MySqlParameter("cod_funcao", MySqlDbType.Int32);
                    parametro.Value = _funcao.cod_funcao;
                    listaParametro.Add(parametro);

                    parametro = new MySqlParameter("cod_permissao", MySqlDbType.Int32);
                    parametro.Value = item.cod_permissao;
                    listaParametro.Add(parametro);
                    executarComando(sql, listaParametro);
                }

                return msgInformacao("Função cadastrada com sucesso!");

            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
