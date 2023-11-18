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
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.BLL;

namespace Projeto_Final
{
    public partial class frm_senha : DevExpress.XtraEditors.XtraForm
    {
        utilizadorBLL utilizadorBll = new utilizadorBLL();
        utilizadorDTO utilizadorDto = new utilizadorDTO();

        public frm_senha()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

            if (utilizadorBll.verificar_senha(pass_atual.Text) == false)
            {
                MessageBox.Show("Senha atual errada");
                return;
            }
            if (pass_nova.Text != pass_confirma.Text)
            {
                MessageBox.Show("As Senhas Não Correspondem");
                return;
            }
                utilizadorDto.senha = pass_nova.Text;
                utilizadorBll.Alterar_pass_utilizador(utilizadorDto);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}