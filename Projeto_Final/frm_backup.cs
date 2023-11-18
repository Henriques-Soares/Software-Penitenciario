using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Projeto_Final.Codigo.DAL;

namespace Projeto_Final
{
    public partial class frm_backup : DevExpress.XtraEditors.XtraForm
    {
        public frm_backup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String pach;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SaveFileDialog salvarPasta = new SaveFileDialog();
                salvarPasta.Filter = "database file(*.sql)|*.sql";
                salvarPasta.FilterIndex = 2;
                salvarPasta.DefaultExt = "sql";
                salvarPasta.RestoreDirectory = true;
                salvarPasta.Title = "save database file";
                if (salvarPasta.ShowDialog() == DialogResult.OK)
                {
                    pach = salvarPasta.FileName;
                    txt_caminho.Text = pach;
                }
            }if(radioButton2.Checked == true)
            {
                OpenFileDialog abrir = new OpenFileDialog();
                abrir.Title = "Abrir Pasta na Base de Dados";
                abrir.DefaultExt = "sql";
                abrir.Filter = "database file(*.sql)|*.sql";
                abrir.FilterIndex = 2;
                
                abrir.RestoreDirectory = true;
                if (abrir.ShowDialog() == DialogResult.OK)
                {
                    pach = abrir.FileName;
                    txt_caminho.Text = pach;
                }
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Acesso_BancoDados backup = new Acesso_BancoDados();
                backup.Backup(txtservidor.Text, txtporta.Text, txtutilizador.Text, txt_senha.Text, txtbasedados.Text, pach);
            }
            if (radioButton2.Checked == true)
            {
                Acesso_BancoDados restaurar = new Acesso_BancoDados();
                restaurar.Restaurar(txtservidor.Text, txtporta.Text, txtutilizador.Text, txt_senha.Text, txtbasedados.Text, pach);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}