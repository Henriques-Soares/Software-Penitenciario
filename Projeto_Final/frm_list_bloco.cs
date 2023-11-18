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
    public partial class frm_list_bloco : DevExpress.XtraEditors.XtraForm
    {
        blocoBLL blocoBll = new blocoBLL();
        blocoDTO blocoDto = new blocoDTO();
        int linha;

        public frm_list_bloco()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_bloco cad_bloco = new frm_cad_bloco();
            cad_bloco.ShowDialog();
            dgv_bloco.DataSource = blocoBll.listarBloco();
            gv_bloco.BestFitColumns();
        }

        private void dgv_bloco_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_bloco_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar bloco"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar bloco"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar bloco"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir bloco"))
            {
                rib_remover.Enabled = true;
            }
            dgv_bloco.DataSource = blocoBll.listarBloco();
            gv_bloco.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_bloco.FocusedRowHandle;
                if (linha >= 0)
                {
                    blocoDto.cod_bloco= int.Parse(gv_bloco.GetRowCellValue(linha, "cod_bloco").ToString());
                    blocoDto.nome_bloco = gv_bloco.GetRowCellValue(linha, "nome_bloco").ToString();


                    frm_cad_bloco cad_bloco = new frm_cad_bloco(blocoDto);
                    cad_bloco.ShowDialog();
                    dgv_bloco.DataSource = blocoBll.listarBloco();
                    gv_bloco.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            blocoDto.cod_bloco = int.Parse(gv_bloco.GetRowCellValue(linha, "cod_bloco").ToString());
             blocoBll.remover(blocoDto);
            dgv_bloco.DataSource = blocoBll.listarBloco();
        }
    }
}