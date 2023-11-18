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
    public partial class frm_list_cama : DevExpress.XtraEditors.XtraForm
    {
        camaBLL camaBll = new camaBLL();
        camaDTO camaDto = new camaDTO();
        int linha;

        public frm_list_cama()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_cama cad_cama = new frm_cad_cama();
            cad_cama.ShowDialog();
            dgv_cama.DataSource = camaBll.listaCamaDisponivel();
            gv_cama.BestFitColumns();
        }

        private void dgv_cama_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_cama_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar cama"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar cama"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar cama"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir cama"))
            {
                rib_remover.Enabled = true;
            }
            dgv_cama.DataSource = camaBll.listaCamaDisponivel();
            gv_cama.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_cama.FocusedRowHandle;
                if (linha >= 0)
                {
                    camaDto.cod_cama = int.Parse(gv_cama.GetRowCellValue(linha, "cod_cama").ToString());
                    camaDto.numero_cama = int.Parse(gv_cama.GetRowCellValue(linha, "numero_cama").ToString());
                    camaDto.cela.cod_cela = int.Parse(gv_cama.GetRowCellValue(gv_cama.FocusedRowHandle, "cod_cela").ToString());

                    frm_cad_cama cad_cama = new frm_cad_cama(camaDto);
                    cad_cama.ShowDialog();
                    dgv_cama.DataSource = camaBll.listaCamaDisponivel();
                    gv_cama.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            camaDto.cod_cama = int.Parse(gv_cama.GetRowCellValue(linha, "cod_cama").ToString());
            dgv_cama.DataSource = camaBll.remover(camaDto);
            dgv_cama.DataSource = camaBll.listaCamaDisponivel();
        }
    }
}