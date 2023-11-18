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
    public partial class frm_cad_bloco : DevExpress.XtraEditors.XtraForm
    {
        blocoDTO blocoDTO = new blocoDTO();
        blocoBLL blocoBll = new blocoBLL();

        private bool cadastrar, alterar, remover;

        public frm_cad_bloco()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Bloco";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frm_cad_bloco(blocoDTO _bloco)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            blocoDTO = _bloco;
            txt_bloco.Text = _bloco.nome_bloco;
            groupBox1.Text = "Alterar Bloco";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            blocoDTO.nome_bloco = txt_bloco.Text;

            if (cadastrar)
            {
                if (blocoBll.salvar(blocoDTO) == false) return;
            }

            if (alterar)
            {
                if (blocoBll.alterar(blocoDTO) == false) return;
            }

            this.Close();
        }
    }
}