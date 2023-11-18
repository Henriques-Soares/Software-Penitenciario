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
    public partial class frm_list_utilizador : DevExpress.XtraEditors.XtraForm
    {
        utilizadorDTO utilizadorDto = new utilizadorDTO();
        utilizadorBLL utilizador = new utilizadorBLL();
        public frm_list_utilizador()
        {
            InitializeComponent();
        }

        private void btn_novo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cad_utilizador cad_utilizador = new frm_cad_utilizador();
            cad_utilizador.ShowDialog();
            dgv_utilizador.DataSource = utilizador.ListarUtilizador();
            f.BestFitColumns();
        }

        private void dgv_cela_Click(object sender, EventArgs e)
        {

        }

        private void frm_list_utilizador_Load(object sender, EventArgs e)
        {
            rib_remover.Enabled = false;
            rib_editar.Enabled = false;
            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar utilizador"))
            {
                btn_novo.Enabled = false;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao cadastrar utilizador"))
            {
                btn_novo.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao editar utilizador"))
            {
                rib_editar.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao excluir utilizador"))
            {
                rib_remover.Enabled = true;
            }
            dgv_utilizador.DataSource = utilizador.ListarUtilizador();
            f.BestFitColumns();
        }

        private void rib_funcao_Click(object sender, EventArgs e)
        {
            int linha;
            try
            {
                linha = f.FocusedRowHandle;
                if (linha >= 0)
                {
                    utilizadorDto.codUtilizador = int.Parse(f.GetRowCellValue(linha, "cod_utilizador").ToString());
                    utilizadorDto.nomeUtilizador = f.GetRowCellValue(linha, "nome_utilizador").ToString();
                    frm_utilizador_funcao cad_grupo_utilizador = new frm_utilizador_funcao(utilizadorDto);
                    cad_grupo_utilizador.ShowDialog();
                    dgv_utilizador.DataSource = utilizador.ListarUtilizador();
                    f.BestFitColumns();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}