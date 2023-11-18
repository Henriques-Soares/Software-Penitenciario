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
    public partial class frm_cad_alimento : DevExpress.XtraEditors.XtraForm
    {
        validacoes validar = new validacoes();
        alimentoDTO alimentoDto = new alimentoDTO();
        alimentoBLL alimentoBll = new alimentoBLL();

        bool cadastrar, alterar, remover;

        public frm_cad_alimento()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
            groupBox1.Text = "Cadastrar Alimento";
        }

        public frm_cad_alimento(alimentoDTO _alimento)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;
            
            alimentoDto = _alimento;
            txt_nome_alimento.Text = _alimento.nome_alimento;
            rtb_descricao_alimento.Text = _alimento.descricao_alimento;

            groupBox1.Text = "Alterar Alimento";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rtb_descricao_alimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_alimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            validar.validar_letras(e);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            alimentoDto.nome_alimento = txt_nome_alimento.Text;
            alimentoDto.descricao_alimento = rtb_descricao_alimento.Text;

            if (cadastrar)
            {
                if (alimentoBll.salvar(alimentoDto) == false) return;
            }

            if (alterar)
            {
                if (alimentoBll.alterar(alimentoDto) == false) return;
            }

            this.Close();
        }
    }
}