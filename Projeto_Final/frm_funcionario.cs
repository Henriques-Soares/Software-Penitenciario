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
    public partial class frm_funcionario : DevExpress.XtraEditors.XtraForm
    {
        funcionarioBLL funcionarioBll = new funcionarioBLL();
        funcionarioDTO funcionarioDto = new funcionarioDTO();

        public frm_funcionario()
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
                /*funcionarioDto.cod_funcionario = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_funcionario").ToString());
                funcionarioDto.//cod_tipo_funcionario = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_tipo_funcionario").ToString());
                //funcionarioDto.nome_funcionario = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_funcionario").ToString();
                //funcionarioDto.genero = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "genero").ToString();
                funcionarioDto.nome_funcionario = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_funcionario").ToString();
                funcionarioDto.bi = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "bi").ToString();
                funcionarioDto.nome_pai = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_pai").ToString();
                funcionarioDto.nome_mae = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nome_mae").ToString();
                //funcionarioDto.cod_provincia = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "cod_provincia").ToString());
                funcionarioDto.naturalidade = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "naturalidade").ToString();
                funcionarioDto.residencia = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "residencia").ToString();
                funcionarioDto.estado_civil = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "estado_civil").ToString();
                funcionarioDto.altura = float.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "altura").ToString());
                funcionarioDto.img = gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "img").ToString();
                funcionarioDto.nip = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "nip").ToString());
                funcionarioDto.tel1 = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "tel1").ToString());
                funcionarioDto.tel2 = int.Parse(gv_funcionario.GetRowCellValue(gv_funcionario.FocusedRowHandle, "tel2").ToString());
             */   
            }
            catch (Exception)
            {

            }
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cadastrar_funcionario cad_funcionario = new frm_cadastrar_funcionario();
            cad_funcionario.ShowDialog();
            dgv_funcionario.DataSource = funcionarioBll.index();
            gv_funcionario.BestFitColumns();
        }

        private void frm_funcionario_Load_1(object sender, EventArgs e)
        {
            dgv_funcionario.DataSource = funcionarioBll.index();
            gv_funcionario.BestFitColumns();
        }
    }
}