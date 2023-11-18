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
    public partial class frm_cad_cela : DevExpress.XtraEditors.XtraForm
    {

        celaBLL celaBll = new celaBLL();
        celaDTO celaDto = new celaDTO();
        private bool alterar, cadastrar, remover;

        public frm_cad_cela()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
            groupBox1.Text = "Cadastrar Cela";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_cad_cela_Load(object sender, EventArgs e)
        {
            cbo_cod_bloco.Properties.DataSource = (new celaBLL()).listaBloco();
            cbo_cod_bloco.Properties.ValueMember = "cod_bloco";
            cbo_cod_bloco.Properties.DisplayMember = "nome_bloco";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            celaDto.nome_cela = txt_nome_cela.Text;
            celaDto.bloco = new blocoDTO();
            celaDto.bloco.cod_bloco = int.Parse(cbo_cod_bloco.EditValue.ToString());


            if (cadastrar)
            {
                if (celaBll.salvar(celaDto) == false) return;
            }

            if (alterar)
            {
                if (celaBll.alterar(celaDto) == false) return;
            }

            this.Close();
        }
    

        public frm_cad_cela(celaDTO _cela)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            celaDto = _cela;
            txt_nome_cela.Text = _cela.nome_cela;
            cbo_cod_bloco.EditValue = _cela.bloco.cod_bloco;

            groupBox1.Text = "Alterar Cela";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}