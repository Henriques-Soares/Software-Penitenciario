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
    public partial class frm_cad_enfermagem : DevExpress.XtraEditors.XtraForm
    {
        enfermariaBLL enfermariaBll = new enfermariaBLL();
        enfermariaDTO enfermariaDto = new enfermariaDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_enfermagem()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
        }

        public frm_cad_enfermagem(enfermariaDTO _enfermaria)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            enfermariaDto = _enfermaria;
            cbo_cod_processo.EditValue = _enfermaria.processo.cod_processo;
            txt_descricao.Text = _enfermaria.descricao;
            groupBox1.Text = "Alterar Enfermagem";
            
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            
            enfermariaDto.processo = new processoDTO();
            enfermariaDto.processo.cod_processo = int.Parse(cbo_cod_processo.EditValue.ToString());
            enfermariaDto.utilizador = new utilizadorDTO();
            enfermariaDto.utilizador.codUtilizador = UtilizadorLogadoDTO.codUtilizador;
            enfermariaDto.descricao = txt_descricao.Text;


            if (cadastrar)
            {
                if (enfermariaBll.salvar(enfermariaDto) == false) return;
            }

            if (alterar)
            {
                if (enfermariaBll.alterar(enfermariaDto) == false) return;
            }

            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_enfermagem_Load(object sender, EventArgs e)
        {
            cbo_cod_processo.Properties.DataSource = (new processoBLL()).processoApenado();
            cbo_cod_processo.Properties.ValueMember = "cod_processo";
            cbo_cod_processo.Properties.DisplayMember = "nome_apenado";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           
        }
    }
}