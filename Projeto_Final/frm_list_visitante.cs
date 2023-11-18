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
    public partial class frm_list_visitante : DevExpress.XtraEditors.XtraForm
    {
        visitanteDTO visitanteDto = new visitanteDTO();
        visitanteBLL visitanteBll = new visitanteBLL();
        int linha;

        public frm_list_visitante()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_visitante cad_Visitante = new frm_cad_visitante();
            cad_Visitante.ShowDialog();
            dgv_visitante.DataSource = visitanteBll.ListarVisitante();
            gv_visitante.BestFitColumns();
        }

        private void frm_list_visitante_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar visitante"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar visitante"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar visitante"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir visitante"))
            {
                rib_remover.Enabled = true;
            }
            dgv_visitante.DataSource = visitanteBll.ListarVisitante();
            gv_visitante.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_visitante.FocusedRowHandle;
                if (linha >= 0)
                {
                    visitanteDto.cod_visitate = int.Parse(gv_visitante.GetRowCellValue(linha, "cod_visitante").ToString());
                    visitanteDto.nome_visitante = gv_visitante.GetRowCellValue(linha, "nome_visitante").ToString();
                    visitanteDto.data_nascimento = gv_visitante.GetRowCellValue(linha, "data_nascimento").ToString();
                    visitanteDto.genero = gv_visitante.GetRowCellValue(linha, "genero").ToString();
                    visitanteDto.bi = gv_visitante.GetRowCellValue(linha, "bi").ToString();
                    visitanteDto.naturalidade = gv_visitante.GetRowCellValue(linha, "naturalidade").ToString();
                    visitanteDto.residencia = gv_visitante.GetRowCellValue(linha, "residencia").ToString();
                    visitanteDto.contacto = int.Parse(gv_visitante.GetRowCellValue(gv_visitante.FocusedRowHandle, "contacto").ToString());

                    frm_cad_visitante cad_visitante = new frm_cad_visitante(visitanteDto);
                    cad_visitante.ShowDialog();
                    dgv_visitante.DataSource = visitanteBll.ListarVisitante();
                    gv_visitante.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgv_visitante_Click(object sender, EventArgs e)
        {

        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            visitanteDto.cod_visitate = int.Parse(gv_visitante.GetRowCellValue(linha, "cod_visitante").ToString());
            visitanteBll.remover(visitanteDto);
            dgv_visitante.DataSource = visitanteBll.ListarVisitante();
        }
    }
}