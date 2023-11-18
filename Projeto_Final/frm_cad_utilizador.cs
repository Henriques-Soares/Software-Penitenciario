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
using Projeto_Final.Codigo.BLL;
using Projeto_Final.Codigo.DTO;
namespace Projeto_Final
{
    public partial class frm_cad_utilizador : DevExpress.XtraEditors.XtraForm
    {
        utilizadorBLL utilizadorBll = new utilizadorBLL();
        utilizadorDTO utilizadorDto = new utilizadorDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_utilizador()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Utilizador";
        }
        public frm_cad_utilizador(utilizadorDTO _utilizador)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            utilizadorDto = _utilizador;
            
            utilizadorDto.codFuncionario = int.Parse(cbo_nome_funcionario.EditValue.ToString());
            txt_nome.Text = _utilizador.nomeUtilizador;
            txt_senha.Text = _utilizador.senha;


            groupBox1.Text = "Alterar Utilizador";
        }

        private void cbo_nome_funcionario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_utilizador_Load(object sender, EventArgs e)
        {
            cbo_nome_funcionario.Properties.DataSource = (new funcionarioBLL()).index();
            cbo_nome_funcionario.Properties.ValueMember = "cod_funcionario";
            cbo_nome_funcionario.Properties.DisplayMember = "nome_funcionario";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            utilizadorDto.codFuncionario = int.Parse(cbo_nome_funcionario.EditValue.ToString());
            utilizadorDto.nomeUtilizador= txt_nome.Text;
            utilizadorDto.senha=txt_senha.Text;
         
            if (cadastrar)
            {
                if (!utilizadorBll.cadastrarUtilizador(utilizadorDto)) return;
            }

            if (alterar)
            {
               // if (!utilizadorBll.alterar(visitaDto)) return;
            }

            this.Close();

        }
    }
}