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
    public partial class frm_list_alimento : DevExpress.XtraEditors.XtraForm
    {
        alimentoBLL alimentoBll = new alimentoBLL();
        alimentoDTO alimentoDto = new alimentoDTO();
        int linha;

        public frm_list_alimento()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_alimento cad_alimento = new frm_cad_alimento();
            cad_alimento.ShowDialog();
            dgv_alimento.DataSource = alimentoBll.listaAlimento();
            gv_alimento.BestFitColumns();
        }

        private void frm_list_alimento_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar alimento"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar alimento"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar alimento"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir alimento"))
            {
                rib_remover.Enabled = true;
            }
            dgv_alimento.DataSource = alimentoBll.listaAlimento();
            gv_alimento.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_alimento.FocusedRowHandle;
                if (linha >= 0)
                {
                    alimentoDto.cod_alimento = int.Parse(gv_alimento.GetRowCellValue(linha, "cod_alimento").ToString());
                    alimentoDto.nome_alimento = gv_alimento.GetRowCellValue(linha, "nome_alimento").ToString();
                    alimentoDto.descricao_alimento = gv_alimento.GetRowCellValue(linha, "descricao_alimento").ToString();

                    frm_cad_alimento cad_alimento = new frm_cad_alimento(alimentoDto); 
                    cad_alimento.ShowDialog();
                    dgv_alimento.DataSource = alimentoBll.listaAlimento();
                    gv_alimento.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgv_alimento_Click(object sender, EventArgs e)
        {

        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            alimentoDto.cod_alimento = int.Parse(gv_alimento.GetRowCellValue(linha, "cod_alimento").ToString());
            alimentoBll.remover(alimentoDto);
            dgv_alimento.DataSource = alimentoBll.listaAlimento();
        }
    }
}