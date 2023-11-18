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
    public partial class frm_list_cuidados : DevExpress.XtraEditors.XtraForm
    {
        cuidadosBLL cuidadoBll = new cuidadosBLL();
        cuidadosDTO cuidadoDto = new cuidadosDTO();
        int linha;

        public frm_list_cuidados()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_cuidados_Load(object sender, EventArgs e)
        {
            dgv_cuidados.DataSource = cuidadoBll.ListarCuidado();
            gv_cuidados.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_cuidados.FocusedRowHandle;
                if (linha >= 0)
                {
                    cuidadoDto.cod_cuidado = int.Parse(gv_cuidados.GetRowCellValue(linha, "cod_cuidado").ToString());
                    cuidadoDto.enfermaria.cod_enfermagem = int.Parse(gv_cuidados.GetRowCellValue(gv_cuidados.FocusedRowHandle, "cod_enfermagem").ToString());
                    cuidadoDto.problema = gv_cuidados.GetRowCellValue(linha, "problema").ToString();
                    cuidadoDto.acao_implementada = gv_cuidados.GetRowCellValue(linha, "acao_implementada").ToString();
                    cuidadoDto.data_registo = gv_cuidados.GetRowCellValue(linha, "data_registo").ToString();
                    cuidadoDto.hora = gv_cuidados.GetRowCellValue(linha, "hora").ToString();


                    frm_cad_cuidados cad_Cuidados = new frm_cad_cuidados(cuidadoDto);
                    cad_Cuidados.ShowDialog();
                    dgv_cuidados.DataSource = cuidadoBll.ListarCuidado();
                    gv_cuidados.BestFitColumns();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            cuidadoDto.cod_cuidado = int.Parse(gv_cuidados.GetRowCellValue(linha, "cod_cuidado").ToString());
            cuidadoBll.remover(cuidadoDto);
            dgv_cuidados.DataSource = cuidadoBll.ListarCuidado();
        }

        private void btn_novo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_cuidados cad_Cuidados = new frm_cad_cuidados();
            cad_Cuidados.ShowDialog();
            dgv_cuidados.DataSource = cuidadoBll.ListarCuidado();
            gv_cuidados.BestFitColumns();
        }
    }
}