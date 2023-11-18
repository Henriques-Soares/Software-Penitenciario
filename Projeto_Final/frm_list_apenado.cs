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
    public partial class frm_list_apenado : DevExpress.XtraEditors.XtraForm
    {
        apenadoBLL apenadoBll = new apenadoBLL();
        apenadoDTO apenadoDto = new apenadoDTO();
        int linha;

        public frm_list_apenado()
        {
            InitializeComponent();
        }

        private void frm_list_apenado_Load(object sender, EventArgs e)
        {

            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar apenado"))
            {
                btn_novo.Enabled = false;

            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar apenado"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar apenado"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao excluir apenado"))
            {
                rib_remover.Enabled = true;

            }
            dgv_apenado.DataSource = apenadoBll.listarApenado();
            gv_apenado.BestFitColumns();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_apenado.FocusedRowHandle;
                if (linha >= 0)
                {
                    apenadoDto.cod_apenado = int.Parse(gv_apenado.GetRowCellValue(linha, "cod_apenado").ToString());
                    apenadoDto.nome_apenado = gv_apenado.GetRowCellValue(linha, "nome_apenado").ToString();
                    apenadoDto.data_nascimento = gv_apenado.GetRowCellValue(linha, "data_nascimento").ToString();
                    apenadoDto.genero = gv_apenado.GetRowCellValue(linha, "genero").ToString();
                    apenadoDto.bi = gv_apenado.GetRowCellValue(linha, "bi").ToString();
                    apenadoDto.nome_pai = gv_apenado.GetRowCellValue(linha, "nome_pai").ToString();
                    apenadoDto.nome_mae = gv_apenado.GetRowCellValue(linha, "nome_mae").ToString();
                    apenadoDto.provincia.codProvincia = int.Parse(gv_apenado.GetRowCellValue(gv_apenado.FocusedRowHandle, "cod_provincia").ToString());
                    apenadoDto.naturalidade = gv_apenado.GetRowCellValue(linha, "naturalidade").ToString();
                    apenadoDto.residencia = gv_apenado.GetRowCellValue(linha, "residencia").ToString();
                    apenadoDto.estado_civil = gv_apenado.GetRowCellValue(linha, "estado_civil").ToString();
                    apenadoDto.altura = float.Parse(gv_apenado.GetRowCellValue(gv_apenado.FocusedRowHandle, "altura").ToString());
                    apenadoDto.img = gv_apenado.GetRowCellValue(gv_apenado.FocusedRowHandle, "img").ToString();
                    apenadoDto.apelido = gv_apenado.GetRowCellValue(linha, "apelido").ToString();
                    apenadoDto.descricao = gv_apenado.GetRowCellValue(linha, "descricao_apenado").ToString();


                    frm_cad_apenado cad_apenado = new frm_cad_apenado(apenadoDto);
                    cad_apenado.ShowDialog();
                    dgv_apenado.DataSource = apenadoBll.listarApenado();
                    gv_apenado.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgv_apenado_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_apenado cad_apenado = new frm_cad_apenado();
            cad_apenado.ShowDialog();
            dgv_apenado.DataSource = apenadoBll.listarApenado();
            gv_apenado.BestFitColumns();
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            apenadoDto.cod_apenado = int.Parse(gv_apenado.GetRowCellValue(linha, "cod_apenado").ToString());
            apenadoBll.remover(apenadoDto);
            dgv_apenado.DataSource = apenadoBll.listarApenado();
        }
    }
}