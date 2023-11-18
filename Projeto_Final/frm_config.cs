using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.BLL;
using System.IO;

namespace Projeto_Final
{
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
           
        }

        private void frm_config_Load(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            frm_login voltar = new frm_login();
            voltar.Show();
            this.Hide();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            String Caminho = Application.StartupPath + "\\dados.txt";
            using (StreamWriter tx = new StreamWriter(Caminho))
            {
                conexao_DTO.host = txthost.Text;
                conexao_DTO.port = txtporta.Text;
                conexao_DTO.user = txtuser.Text;
                conexao_DTO.bd = txtbd.Text;
                conexao_DTO.senha = txtsenha.Text;

                utilizadorBLL utilizador_bll = new utilizadorBLL();
                if(!utilizador_bll.inicializar()) return;

                tx.WriteLine(txthost.Text);
                tx.WriteLine(txtporta.Text);
                tx.WriteLine(txtuser.Text);
                tx.WriteLine(txtbd.Text);
                tx.WriteLine(txtsenha.Text);                

                MessageBox.Show("Foi salvo com Sucesso");

            }
            
            
            frm_login login = new frm_login();
            this.Hide();
            login.Show();
        }
    }
}
