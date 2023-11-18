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
    public partial class frm_cad_funcao : DevExpress.XtraEditors.XtraForm
    {
        funcaoDTO funcaoDto = new funcaoDTO();
        funcaoBLL funcaoBll = new funcaoBLL();
        validacoes validar = new validacoes();
        private bool cadastrar, alterar, remover;

        public frm_cad_funcao()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
            groupBox1.Text = "Cadastrar Função";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            funcaoDto.nome_funcao = txt_nomefuncao.Text;
            funcaoDto.descricao_funcao = rtb_descricao_funcao.Text;

            if (cadastrar)
            {
                if (funcaoBll.salvar(funcaoDto) == false) return;

            }

            if (alterar)
            {
                if (funcaoBll.alterar(funcaoDto) == false) return;
            }

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nomefuncao_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_cad_funcao_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt_nomefuncao_KeyPress(object sender, KeyPressEventArgs e)
        {

            validar.validar_letras(e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_cad_funcao_Load(object sender, EventArgs e)
        {
          
        }

        public frm_cad_funcao(funcaoDTO _funcao)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;
            groupBox1.Text = "Alterar Função";

            funcaoDto = _funcao;
            txt_nomefuncao.Text = _funcao.nome_funcao;
            rtb_descricao_funcao.Text = _funcao.descricao_funcao;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}