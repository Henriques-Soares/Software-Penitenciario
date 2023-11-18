﻿using System;
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
    public partial class frm_list_tipo_funcionario : DevExpress.XtraEditors.XtraForm
    {
        tipo_funcionarioBLL T_funcionario = new tipo_funcionarioBLL();
        tipo_funcionarioDTO tipo_funcionarioDto = new tipo_funcionarioDTO();

        public frm_list_tipo_funcionario()
        {
            InitializeComponent();
        }

        private void frm_tipo_funcionario_Load(object sender, EventArgs e)
        {
           
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar tipo de funcionario"))
            {
                btn_novo.Enabled = false;
                gc_TFuncionario.Enabled = true;

            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar tipo de funcionario"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar tipo de funcionario"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir tipo de funcionario"))
            {
                rib_remover.Enabled = true;
            }
            
            
               
            

            gc_TFuncionario.DataSource = T_funcionario.index();
            gv_tipo_funcionario.BestFitColumns();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_tipo_funcionario cad_tipo_funcionario = new frm_cad_tipo_funcionario();
            cad_tipo_funcionario.ShowDialog();
            gc_TFuncionario.DataSource = T_funcionario.index();
            gv_tipo_funcionario.BestFitColumns();
        }

        private void gc_TFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                tipo_funcionarioDto.codTipoFuncionario = int.Parse(gv_tipo_funcionario.GetRowCellValue(gv_tipo_funcionario.FocusedRowHandle, "cod_tipo_funcionario").ToString());
                tipo_funcionarioDto.designacao = gv_tipo_funcionario.GetRowCellValue(gv_tipo_funcionario.FocusedRowHandle, "nome_tipo_funcionario").ToString();
               
            }
            catch (Exception)
            {
                
            }
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                tipo_funcionarioDto.codTipoFuncionario = int.Parse(gv_tipo_funcionario.GetRowCellValue(gv_tipo_funcionario.FocusedRowHandle, "cod_tipo_funcionario").ToString());
                tipo_funcionarioDto.designacao = gv_tipo_funcionario.GetRowCellValue(gv_tipo_funcionario.FocusedRowHandle, "nome_tipo_funcionario").ToString();
                frm_cad_tipo_funcionario cad_tipo_funcionario = new frm_cad_tipo_funcionario(tipo_funcionarioDto);
                cad_tipo_funcionario.ShowDialog();
                gc_TFuncionario.DataSource = T_funcionario.index();
                gv_tipo_funcionario.BestFitColumns();
            }
            catch (Exception)
            {

            }
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            tipo_funcionarioDto.codTipoFuncionario = int.Parse(gv_tipo_funcionario.GetRowCellValue(gv_tipo_funcionario.FocusedRowHandle, "cod_tipo_funcionario").ToString());

            T_funcionario.remover(tipo_funcionarioDto);
            gc_TFuncionario.DataSource = T_funcionario.index();
        }
    }
}