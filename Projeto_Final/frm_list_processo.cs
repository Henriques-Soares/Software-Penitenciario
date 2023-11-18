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
    public partial class frm_list_processo : DevExpress.XtraEditors.XtraForm
    {
        processoBLL processoBll = new processoBLL();
        processoDTO ProcessoDto = new processoDTO();
        int linha;

        public frm_list_processo()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_processo cad_processo = new frm_cad_processo();
            cad_processo.ShowDialog();
            dgv_processo.DataSource = processoBll.index();
            gv_processo.BestFitColumns();
        }

        private void dgv_processo_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_processo_Load(object sender, EventArgs e)
        {

        }

        private void frm_list_processo_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_soltura.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar processo"))
            {
                btn_novo.Enabled = false;
       
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar processo"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao dar soltura "))
            {
                rib_soltura.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir processo"))
            {
                rib_remover.Enabled = true;

            }
            dgv_processo.DataSource = processoBll.index();
            gv_processo.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            ProcessoDto.cod_processo = int.Parse(gv_processo.GetRowCellValue(gv_processo.FocusedRowHandle, "cod_processo").ToString());
            ProcessoDto.estado = "Solto";
            processoBll.Soltura(ProcessoDto);
            dgv_processo.DataSource = processoBll.index();
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            ProcessoDto.cod_processo = int.Parse(gv_processo.GetRowCellValue(gv_processo.FocusedRowHandle, "cod_processo").ToString());
            processoBll.removerProcesso(ProcessoDto);
            dgv_processo.DataSource = processoBll.index();

        }
    }
}