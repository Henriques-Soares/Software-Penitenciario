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
    public partial class frm_cad_visita : DevExpress.XtraEditors.XtraForm
    {
        visitaBLL visitaBll = new visitaBLL();
        visitaDTO visitaDto = new visitaDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_visita()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Visita";
        }

        public frm_cad_visita(visitaDTO _visita)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            visitaDto = _visita;
            cb_tipo_visita.Text = _visita.tipo_visita;
            dca_data_visita.Text = _visita.data_visita;
            hora_visita.Text = _visita.hora_visita;

            groupBox1.Text = "Alterar Visita";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            visitaDto.visitante = new visitanteDTO();
            visitaDto.visitante.cod_visitate = int.Parse(cbo_visitante.EditValue.ToString());
            visitaDto.processo = new processoDTO();
            visitaDto.processo.cod_processo = int.Parse(cbo_processo.EditValue.ToString());
            visitaDto.tipo_visita = cb_tipo_visita.Text;
            visitaDto.data_visita = dca_data_visita.Text;
            visitaDto.hora_visita = hora_visita.Text;

            if (cadastrar)
            {
                if (visitaBll.salvar(visitaDto) == false) return;
            }

            if (alterar)
            {
                if (!visitaBll.alterar(visitaDto) == false) return;
            }

            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dca_data_visita_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cbo_processo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_cad_visita_Load(object sender, EventArgs e)
        {
            cbo_visitante.Properties.DataSource = (new visitaBLL()).listarVisitante();
            cbo_visitante.Properties.ValueMember = "cod_visitante";
            cbo_visitante.Properties.DisplayMember = "nome_visitante";

            cbo_processo.Properties.DataSource = (new visitaBLL()).listarProcesso();
            cbo_processo.Properties.ValueMember = "cod_processo";
            cbo_processo.Properties.DisplayMember = "nome_apenado";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}