using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Final.Codigo.BLL;
using Projeto_Final.Codigo.DTO;
using System.IO;

namespace Projeto_Final
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            String Caminho = Application.StartupPath + "\\dados.txt";
            using (StreamReader mostrar = new StreamReader(Caminho))
            {
                conexao_DTO.host = mostrar.ReadLine();
                conexao_DTO.port = mostrar.ReadLine();
                conexao_DTO.user = mostrar.ReadLine();
                conexao_DTO.bd = mostrar.ReadLine();
                conexao_DTO.senha = mostrar.ReadLine();

            }
            if(!(new utilizadorBLL()).inicializar())
                (new utilizadorBLL()).msgErro("Configuração de conexão a base de dados incorrecta!");
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            utilizadorDTO utilizador = new utilizadorDTO();
            DataTable dt = new DataTable();
            dt.Clear();
            utilizador.nomeUtilizador = txt_nome.Text;
            utilizador.senha = txt_senha.Text;

            if (utilizador.nomeUtilizador == string.Empty || utilizador.senha == string.Empty)
            {
                (new utilizadorBLL()).msgErro("Informe o nome e a senha de utilizador para entrar!");
                return;
            }
            
            if ((new utilizadorBLL()).login(utilizador))
            {

                frm_principal fp = new frm_principal();
                fp.Show();
                this.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_conf_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_conf_Click_1(object sender, EventArgs e)
        {
            frm_config config = new frm_config();
            config.Show();
            this.Hide();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) btn_entrar.PerformClick();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) btn_entrar.PerformClick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
