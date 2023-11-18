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
    public partial class frm_cad_tipo_crime : DevExpress.XtraEditors.XtraForm
    {
        tipo_crimeDTO tipoCrimeDto = new tipo_crimeDTO();
        tipo_crimeBLL tipoCrimeBll = new tipo_crimeBLL();

        private bool cadastrar, alterar, remover;

        public frm_cad_tipo_crime()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
            groupBox1.Text = "Cadastrar tipo de crime";
        }

        public frm_cad_tipo_crime(tipo_crimeDTO _tipoCrime)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;
            groupBox1.Text = "Alterar tipo de crime";

            tipoCrimeDto = _tipoCrime;
            txt_nome_crime.Text = _tipoCrime.nome_tipo_crime;
        }

        private void frm_cad_tipo_crime_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_nome_crime_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            tipoCrimeDto.nome_tipo_crime = txt_nome_crime.Text;

            if(cadastrar)
            {
                if (tipoCrimeBll.salvar(tipoCrimeDto) == false) return;
            }

            if(alterar)
            {
                if (tipoCrimeBll.alterar(tipoCrimeDto) == false) return;
            }

            this.Close();
        }
    }
}