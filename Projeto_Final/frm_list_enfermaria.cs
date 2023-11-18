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
    public partial class frm_list_enfermaria : DevExpress.XtraEditors.XtraForm
    {
        enfermariaBLL enfermariaBll = new enfermariaBLL();
        enfermariaDTO enfermariaDto = new enfermariaDTO();
        int linha;

        public frm_list_enfermaria()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_enfermagem cad_enfermagem = new frm_cad_enfermagem();
            cad_enfermagem.ShowDialog();
            dgv_enfermaria.DataSource = enfermariaBll.listarEnfermaria();
            gv_enfermaria.BestFitColumns();
        }

        private void dgv_enfermaria_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_enfermaria_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar enfermaria"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar enfermaria"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar enfermaria"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir enfermaria"))
            {
                rib_remover.Enabled = true;
            }
            dgv_enfermaria.DataSource = enfermariaBll.listarEnfermaria();
            gv_enfermaria.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_enfermaria.FocusedRowHandle;
                if (linha >= 0)
                {
                    enfermariaDto.cod_enfermagem = int.Parse(gv_enfermaria.GetRowCellValue(linha, "cod_enfermagem").ToString());
                    enfermariaDto.processo.cod_processo = int.Parse(gv_enfermaria.GetRowCellValue(linha, "cod_processo").ToString());
                    enfermariaDto.descricao = gv_enfermaria.GetRowCellValue(linha, "descricao").ToString();

                    frm_cad_enfermagem cad_enfermagem = new frm_cad_enfermagem(enfermariaDto);
                    cad_enfermagem.ShowDialog();
                    dgv_enfermaria.DataSource = enfermariaBll.listarEnfermaria();
                    gv_enfermaria.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            enfermariaDto.cod_enfermagem = int.Parse(gv_enfermaria.GetRowCellValue(linha, "cod_enfermagem").ToString());
            enfermariaBll.remover(enfermariaDto);
            dgv_enfermaria.DataSource = enfermariaBll.listarEnfermaria();
        }
    }
}