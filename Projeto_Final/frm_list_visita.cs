using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.BLL;

namespace Projeto_Final
{
    public partial class frm_list_visita : DevExpress.XtraEditors.XtraForm
    {

        visitaBLL visitaBll = new visitaBLL();
        visitaDTO visitaDto = new visitaDTO();
        int linha;

        public frm_list_visita()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_visita cada_visita = new frm_cad_visita();
            cada_visita.ShowDialog();
            dgv_visita.DataSource = visitaBll.ListarVisita();
            gv_visita.BestFitColumns();

        }

        private void dgv_visita_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_visita_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar visita"))
            {
                btn_novo.Enabled = false;
               
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar visita"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar visita"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir visita"))
            {
                rib_remover.Enabled = true;
            }
            dgv_visita.DataSource = visitaBll.ListarVisita();
            gv_visita.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_visita.FocusedRowHandle;
                if (linha >= 0)
                {
                    visitaDto.cod_visita = int.Parse(gv_visita.GetRowCellValue(linha, "cod_visita").ToString());
                    visitaDto.visitante.cod_visitate = int.Parse(gv_visita.GetRowCellValue(gv_visita.FocusedRowHandle, "cod_visitante").ToString());
                    visitaDto.processo.cod_processo = int.Parse(gv_visita.GetRowCellValue(gv_visita.FocusedRowHandle, "cod_processo").ToString());
                    visitaDto.tipo_visita = gv_visita.GetRowCellValue(linha, "tipo_visita").ToString();
                    visitaDto.data_visita = gv_visita.GetRowCellValue(linha, "data_visita").ToString();
                    visitaDto.hora_visita = gv_visita.GetRowCellValue(linha, "hora_visita").ToString();


                    frm_cad_visita cada_visita = new frm_cad_visita(visitaDto);
                    cada_visita.ShowDialog();
                    dgv_visita.DataSource = visitaBll.ListarVisita();
                    gv_visita.BestFitColumns();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            visitaDto.cod_visita = int.Parse(gv_visita.GetRowCellValue(linha, "cod_visita").ToString());
            visitaBll.remover(visitaDto);
            dgv_visita.DataSource = visitaBll.ListarVisita();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}