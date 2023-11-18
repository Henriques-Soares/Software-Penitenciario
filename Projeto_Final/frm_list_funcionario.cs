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
    public partial class frm_list_funcionario : DevExpress.XtraEditors.XtraForm
    {
        funcionarioBLL funcionarioBll = new funcionarioBLL();
        funcionarioDTO funcionarioDto = new funcionarioDTO();
        int linha;

        public frm_list_funcionario()
        {
            InitializeComponent();
        }

        private void frm_funcionario_Load(object sender, EventArgs e)
        {
        }

        private void dgv_funcionario_Click(object sender, EventArgs e)
        {
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_funcionario.FocusedRowHandle;
                if (linha >= 0)
                {
                    funcionarioDto.cod_funcionario = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_funcionario").ToString());
                    funcionarioDto.tipoFuncionario.codTipoFuncionario = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_tipo_funcionario").ToString());
                    funcionarioDto.nome_funcionario = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_funcionario").ToString();
                    funcionarioDto.data_nascimento = gv_funcionario.GetRowCellValue(linha, "data_nascimento").ToString();
                    funcionarioDto.genero = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "genero").ToString();
                    funcionarioDto.nome_funcionario = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_funcionario").ToString();
                    funcionarioDto.bi = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "bi").ToString();
                    funcionarioDto.nome_pai = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_pai").ToString();
                    funcionarioDto.nome_mae = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_mae").ToString();
                    funcionarioDto.provincia.nomeProvincia = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_provincia").ToString();
                    funcionarioDto.residencia = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "residencia").ToString();
                    funcionarioDto.estado_civil = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "estado_civil").ToString();
                    funcionarioDto.altura = float.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "altura").ToString());
                    funcionarioDto.img = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "img").ToString();
                    funcionarioDto.nip = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nip").ToString());
                    funcionarioDto.tel1 = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "tel1").ToString());
                    funcionarioDto.tel2 = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "tel2").ToString());

                    frm_cad_funcionario cad_funcionario = new frm_cad_funcionario(funcionarioDto);
                    cad_funcionario.ShowDialog();
                    dgv_funcionario.DataSource = funcionarioBll.index();
                    gv_funcionario.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_funcionario cad_funcionario = new frm_cad_funcionario();
            cad_funcionario.ShowDialog();
            dgv_funcionario.DataSource = funcionarioBll.index();
            gv_funcionario.BestFitColumns();
        }

        private void frm_funcionario_Load_1(object sender, EventArgs e)
        {
            rib_editar.Enabled = false;
            rib_remover.Enabled = false;

            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar funcionario"))
            {
                btn_novo.Enabled = false;
                dgv_funcionario.Enabled = true;

            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar funcionario"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar funcionario"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir funcionario"))
            {
                rib_remover.Enabled = true;
            }
            dgv_funcionario.DataSource = funcionarioBll.index();
            gv_funcionario.BestFitColumns();
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            funcionarioDto.cod_funcionario = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_funcionario").ToString());
            funcionarioBll.remover(funcionarioDto);
            dgv_funcionario.DataSource = funcionarioBll.index();
        }
    }
}