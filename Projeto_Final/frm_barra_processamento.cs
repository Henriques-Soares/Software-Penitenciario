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

namespace Projeto_Final
{
    public partial class frm_barra_processamento : DevExpress.XtraEditors.XtraForm
    {
        public frm_barra_processamento()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb_barraprocessamento.Value <= 99)
            {
                pb_barraprocessamento.Value += 1;
                label_contagem.Text = pb_barraprocessamento.Value.ToString() + "%";

                if (pb_barraprocessamento.Value == 10)
                {
                    label_comeco.Text = "Começando";
                }
                if (pb_barraprocessamento.Value == 30)
                {
                    label_comeco.Text = "Organizando os Recursos";
                }
                if (pb_barraprocessamento.Value == 60)
                {
                    label_comeco.Text = "Quase Terminando";
                }
                if (pb_barraprocessamento.Value == 70)
                {
                    label_comeco.Text = "Processando Sistema";
                }
                if (pb_barraprocessamento.Value == 100)
                {
                    label_comeco.Text = "Seja Bem-Vindo(a)";
                    frm_login entrar = new frm_login();
                    entrar.Show();
                    this.Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}