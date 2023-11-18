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
    public partial class frm_list_tipocrime : DevExpress.XtraEditors.XtraForm
    {
        tipo_crimeBLL tipoCrimeBll = new tipo_crimeBLL();
        tipo_crimeDTO tipoCrimeDto = new tipo_crimeDTO();
        int linha;

        public frm_list_tipocrime()
        {
            InitializeComponent();
        }

        private void frm_list_tipocrime_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar tipo de crime"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar tipo de crime"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar tipo de crime"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir tipo de crime"))
            {
                rib_remover.Enabled = true;
            }
            dgv_tipo_crime.DataSource = tipoCrimeBll.listaTipoCrime();
            gv_tipo_crime.BestFitColumns();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_tipo_crime cad_tipo_crime = new frm_cad_tipo_crime();
            cad_tipo_crime.ShowDialog();
            dgv_tipo_crime.DataSource = tipoCrimeBll.listaTipoCrime();
            gv_tipo_crime.BestFitColumns();
        }

        private void rib_editar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                linha = gv_tipo_crime.FocusedRowHandle;
                if(linha >= 0)
                {
                    tipoCrimeDto.cod_tipo_crime = int.Parse(gv_tipo_crime.GetRowCellValue(linha, "cod_tipo_crime").ToString());
                    tipoCrimeDto.nome_tipo_crime = gv_tipo_crime.GetRowCellValue(linha, "nome_tipo_crime").ToString();

                    frm_cad_tipo_crime cad_tipo_crime = new frm_cad_tipo_crime(tipoCrimeDto);
                    cad_tipo_crime.ShowDialog();
                    dgv_tipo_crime.DataSource = tipoCrimeBll.listaTipoCrime();
                    gv_tipo_crime.BestFitColumns();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void dgv_tipo_crime_Click(object sender, EventArgs e)
        {
           
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            tipoCrimeDto.cod_tipo_crime = int.Parse(gv_tipo_crime.GetRowCellValue(linha, "cod_tipo_crime").ToString());
            tipoCrimeBll.remover(tipoCrimeDto);
            dgv_tipo_crime.DataSource = tipoCrimeBll.listaTipoCrime();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}