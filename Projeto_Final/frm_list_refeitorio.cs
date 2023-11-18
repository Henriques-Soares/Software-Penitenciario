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
    public partial class frm_list_refeitorio : DevExpress.XtraEditors.XtraForm
    {
        refeitorioBLL refeitorioBll = new refeitorioBLL();
        refeitorioDTO refeitorioDto = new refeitorioDTO();
        int linha;

        public frm_list_refeitorio()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_refeitorio cad_Refeitorio = new frm_cad_refeitorio();
            cad_Refeitorio.ShowDialog();
            dgv_refeitorio.DataSource = refeitorioBll.listarRefeitorio();
            gv_refeitorio.BestFitColumns();
        }

        private void frm_list_refeitorio_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar refeitorio"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar refeitorio"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar refeitorio"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir refeitorio"))
            {
                rib_remover.Enabled = true;
            }
            dgv_refeitorio.DataSource = refeitorioBll.listarRefeitorio();
            gv_refeitorio.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_refeitorio.FocusedRowHandle;
                if (linha >= 0)
                {
                    refeitorioDto.processo.cod_processo = int.Parse(gv_refeitorio.GetRowCellValue(linha, "cod_processo").ToString());
                    refeitorioDto.alimento.cod_alimento = int.Parse(gv_refeitorio.GetRowCellValue(linha, "cod_alimento").ToString());
                    refeitorioDto.tipo_refeicao = gv_refeitorio.GetRowCellValue(linha, "tipo_refereicao").ToString();

                    frm_cad_refeitorio cad_refeitorio = new frm_cad_refeitorio(refeitorioDto);
                    cad_refeitorio.ShowDialog();
                    dgv_refeitorio.DataSource = refeitorioBll.listarRefeitorio();
                    gv_refeitorio.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgv_refeitorio_Click(object sender, EventArgs e)
        {

        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            refeitorioDto.cod_refeitorio = int.Parse(gv_refeitorio.GetRowCellValue(linha, "cod_refeitorio").ToString());
             refeitorioBll.remover(refeitorioDto);
            dgv_refeitorio.DataSource = refeitorioBll.listarRefeitorio();
        }
    }
}