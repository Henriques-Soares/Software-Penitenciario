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
    public partial class frm_list_funcao : DevExpress.XtraEditors.XtraForm
    {
        funcaoDTO funcaoDto = new funcaoDTO();
        funcaoBLL funcaoBll = new funcaoBLL();
        validacoes validar = new validacoes();
        int linha;

        public frm_list_funcao()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_funcao cad_grupo_utilizador = new frm_cad_funcao();
            cad_grupo_utilizador.ShowDialog();
            dgv_funcao.DataSource = funcaoBll.listarfuncao();
            gv_funcao.BestFitColumns();
        }

        private void dgv_cela_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_grupo_utilizador_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar funcao"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar funcao"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar funcao"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir funcao"))
            {
                rib_remover.Enabled = true;
            }
            dgv_funcao.DataSource = funcaoBll.listarfuncao();
            gv_funcao.BestFitColumns();
        }

        private void rib_editar_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_funcao.FocusedRowHandle;
                if (linha >= 0)
                {
                    funcaoDto.cod_funcao = int.Parse(gv_funcao.GetRowCellValue(linha, "cod_funcao").ToString());
                    funcaoDto.nome_funcao = gv_funcao.GetRowCellValue(linha, "nome_funcao").ToString();
                    funcaoDto.descricao_funcao = gv_funcao.GetRowCellValue(linha, "descricao_funcao").ToString();

                    frm_cad_funcao cad_grupo_utilizador = new frm_cad_funcao(funcaoDto);
                    cad_grupo_utilizador.ShowDialog();
                    dgv_funcao.DataSource = funcaoBll.listarfuncao();
                    gv_funcao.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_remover_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_funcao.FocusedRowHandle;
                if (linha >= 0)
                {
                    funcaoDto.cod_funcao = int.Parse(gv_funcao.GetRowCellValue(linha, "cod_funcao").ToString());
                    funcaoBll.remover(funcaoDto);
                    dgv_funcao.DataSource = funcaoBll.listarfuncao();
                }
            }
            catch (Exception)
            {

            }
        }

        private void rib_permissoes_Click(object sender, EventArgs e)
        {
            try
            {
                linha = gv_funcao.FocusedRowHandle;
                if (linha >= 0)
                {
                    funcaoDto.cod_funcao = int.Parse(gv_funcao.GetRowCellValue(linha, "cod_funcao").ToString());
                    funcaoDto.nome_funcao = gv_funcao.GetRowCellValue(linha, "nome_funcao").ToString();
                    Permissão_funcao cad_grupo_utilizador = new Permissão_funcao(funcaoDto);
                    cad_grupo_utilizador.ShowDialog();
                    dgv_funcao.DataSource = funcaoBll.listarfuncao();
                    gv_funcao.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }

        }
    }
}