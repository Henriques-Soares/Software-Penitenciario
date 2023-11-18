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
    public partial class frm_cad_processo : DevExpress.XtraEditors.XtraForm
    {
        validacoes validar = new validacoes();
        processoDTO processoDto = new processoDTO();
        processoBLL processoBll = new processoBLL();
        private bool soltar, cadastrar;

        public frm_cad_processo()
        {
            InitializeComponent();
            cadastrar = true;
            soltar = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_processo_Load(object sender, EventArgs e)
        {
            dgv_tipo_crime.DataSource = (new tipo_crimeBLL()).listaTipoCrime();

            cbo_apenado.Properties.DataSource = (new apenadoBLL()).listarApenado();
            cbo_apenado.Properties.DisplayMember = "nome_apenado";
            cbo_apenado.Properties.ValueMember = "cod_apenado";

            cbo_cama.Properties.DataSource = (new camaBLL()).listaCamaDisponivel();
            cbo_cama.Properties.DisplayMember = "numero_cama";
            cbo_cama.Properties.ValueMember = "cod_cama";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            processoDto.numero_processo = txt_numero_processo.Text;
            processoDto.apenado.cod_apenado = cbo_apenado.EditValue.ToString() == string.Empty ? processoDto.apenado.cod_apenado : int.Parse(cbo_apenado.EditValue.ToString());
            processoDto.cama.cod_cama = cbo_cama.EditValue.ToString() == string.Empty ? processoDto.cama.cod_cama : int.Parse(cbo_cama.EditValue.ToString());

            List<tipo_crimeDTO> listaTipoCrime = new List<tipo_crimeDTO>();
            tipo_crimeDTO tipoCrime = new tipo_crimeDTO();

            for (int i = 0; i < gv_tipo_crime.RowCount; i++)
            {
                if (gv_tipo_crime.IsRowSelected(i))
                {
                    tipoCrime = new tipo_crimeDTO();
                    tipoCrime.cod_tipo_crime = int.Parse(gv_tipo_crime.GetRowCellValue(i, "cod_tipo_crime").ToString());
                    listaTipoCrime.Add(tipoCrime);
                }
            }

            if(cadastrar)
            {
                if (!processoBll.cadastrarProcesso(processoDto, listaTipoCrime)) return;
            }
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_numero_processo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dgv_tipo_crime_Click(object sender, EventArgs e)
        {

        }

        private void cbo_apenado_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}