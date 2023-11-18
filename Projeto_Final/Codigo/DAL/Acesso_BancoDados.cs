using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DevExpress.XtraEditors;
using Projeto_Final.Codigo.DTO;


namespace Projeto_Final.Codigo.DAL
{
    public class Acesso_BancoDados
    {
        private MySqlConnection conexao = null;
        private DataTable tabela;
        private MySqlDataAdapter adaptador;

        //metodo para mensagem de informacao
        public bool msgInformacao(string msg)
        {
            XtraMessageBox.Show(msg, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        //metodo para mensagem de erro
        public bool msgErro(string msg)
        {
            XtraMessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        //metodo para mensagem de confirmacao
        public bool msgConfirmacao(string msg)
        {
            if (XtraMessageBox.Show(msg, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) return true;
            return false;
        }

        protected bool conectar()
        {
            try
            {
                if (conexao_DTO.host == "" || conexao_DTO.port == "" || conexao_DTO.user == "" || conexao_DTO.bd == "") return msgErro("Preencha os campos obrigatórios para conexão!");

                if (conexao != null) conexao.Close();

                conexao = new MySqlConnection("datasource = " + conexao_DTO.host + "; port = " + conexao_DTO.port + "; protocol = TCP; username = " + conexao_DTO.user + "; password = " + conexao_DTO.senha + "; database = " + conexao_DTO.bd);
                conexao.Open();
                return true;
            }
            catch (Exception ex)
            {
                return msgErro("Erro ao conectar-se com a base de dados!");
            }
        }

        //metodo para excutar comandos(insert, update e delete)
        protected bool executarComando(string sqlComando, List<MySqlParameter> parametros = null)
        {
            try
            {
                if (!conectar()) return msgErro("Erro de conexão a base de dados!");

                //instanciando o mysqlcomand para especificar instrucoes por executar
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sqlComando;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conexao;
                    if (parametros != null)
                    {
                        foreach (var item in parametros)
                            cmd.Parameters.Add(item);
                    }
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                }
            }
            catch (Exception ex)
            {
                return msgErro("Ocorreu um erro ao executar está ação: " + ex.Message);
            }
            return true;
        }

        //metodo para retornar os resultados do select
        protected DataTable retornarDados(string sqlComando, List<MySqlParameter> parametros = null)
        {
            tabela = new DataTable();
            tabela.Clear();
            try
            {
                if (!conectar())
                {
                    msgErro("Erro de conexão a base de dados!");
                    return null;
                }

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = sqlComando;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conexao;
                    if (parametros != null)
                    {
                        foreach (var item in parametros)
                            cmd.Parameters.Add(item);
                    }
                    adaptador = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    adaptador.Fill(tabela);
                    conexao.Close();
                }
            }
            catch (Exception)
            {
                return null;
            }
            return tabela;
        }
        public void Restaurar(String localhost, String port, String username, String password, String database, String pach)
        {
            string conexao = "datasource =" + localhost + "; port =" + port + "; protocol = TCP; username =" + username + "; password =" + password + " ; database =" + database + "";
            string file = pach;
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                        MessageBox.Show("Backup Restaurado com Sucesso!");
                    }
                }
            }
        }
        public void Backup(String localhost, String port, String username, String password, String database, String pach)
        {
            string conexao = "datasource =" + localhost + "; port =" + port + "; protocol = TCP; username =" + username + "; password =" + password + " ; database =" + database + "";
            string file = pach;
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        MessageBox.Show("Backup Efetuado com Sucesso!");
                    }
                }
            }
        }
    }
}
