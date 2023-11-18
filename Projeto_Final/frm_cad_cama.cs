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
    public partial class frm_cad_cama : DevExpress.XtraEditors.XtraForm
    { validacoes validar = new validacoes();
        camaDTO camaDto = new camaDTO();
        camaBLL camaBll = new camaBLL();
        private bool cadastrar, alterar, remover;
   
        public frm_cad_cama()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Cama";
        }


        public frm_cad_cama(camaDTO _cama)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            camaDto = _cama;
            txt_numero_cama.Text = _cama.numero_cama.ToString();
            cbo_cod_cela.EditValue = _cama.cela.cod_cela;

            groupBox1.Text = "Alterar Cama";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_cama_Load(object sender, EventArgs e)
        {

            cbo_cod_cela.Properties.DataSource = (new camaBLL()).listaCela();
            cbo_cod_cela.Properties.ValueMember = "cod_cela";
            cbo_cod_cela.Properties.DisplayMember = "nome_cela";
        }

        private void txt_numero_cama_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.valida_mumero(e);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btn_salvar_Click(object sender, EventArgs e)
        {
            camaDto.numero_cama = txt_numero_cama.Text == "" ? camaDto.numero_cama : int.Parse(txt_numero_cama.Text);
            camaDto.cela = new celaDTO();
            camaDto.cela.cod_cela = int.Parse(cbo_cod_cela.EditValue.ToString());


            if (cadastrar)
            {
                if (camaBll.salvar(camaDto) == false) return;
            }

            if (alterar)
            {
                if (camaBll.alterar(camaDto) == false) return;
            }

            this.Close();
        }
    }
    
}