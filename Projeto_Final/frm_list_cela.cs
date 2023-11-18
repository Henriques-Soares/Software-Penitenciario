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
    public partial class frm_list_cela : DevExpress.XtraEditors.XtraForm
    {
        celaBLL celaBll = new celaBLL();
        celaDTO celaDto = new celaDTO();
        int linha;

        public frm_list_cela()
        {
            InitializeComponent();
        }

        private void dgv_cela_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_cela cad_cela = new frm_cad_cela();
            cad_cela.ShowDialog();
            dgv_cela.DataSource = celaBll.listarCela();
            f.BestFitColumns();
        }

        private void frm_list_cela_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar cela"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar cela"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar cela"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir cela"))
            {
                rib_remover.Enabled = true;
            }
            dgv_cela.DataSource = celaBll.listarCela();
            f.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = f.FocusedRowHandle;
                if (linha >= 0)
                {
                    celaDto.cod_cela = int.Parse(f.GetRowCellValue(linha, "cod_cela").ToString());
                    celaDto.nome_cela = f.GetRowCellValue(linha, "nome_cela").ToString();
                    celaDto.bloco.cod_bloco = int.Parse(f.GetRowCellValue(f.FocusedRowHandle, "cod_bloco").ToString());

                    frm_cad_cela cad_cela = new frm_cad_cela(celaDto);
                    cad_cela.ShowDialog();
                    dgv_cela.DataSource = celaBll.listarCela();
                    f.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            celaDto.cod_cela = int.Parse(f.GetRowCellValue(linha, "cod_cela").ToString());
           celaBll.remover(celaDto);
            dgv_cela.DataSource = celaBll.listarCela();
        }
    }
}