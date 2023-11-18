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
    public partial class Permissão_funcao : DevExpress.XtraEditors.XtraForm
    {
        permissaoBLL permissaoBll = new permissaoBLL();
        funcaoDTO funcaoDto = new funcaoDTO();
        permissaoDTO permissaoDto = new permissaoDTO();
        private bool salvar;

        public Permissão_funcao(funcaoDTO _funcaoDto)
        {
            InitializeComponent();
            funcaoDto = _funcaoDto;

            groupBox1.Text = "Permissões para a Função - " + funcaoDto.nome_funcao;
            salvar = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Permissão_funcao_Load(object sender, EventArgs e)
        {
            dgv_permissao_funcao.DataSource = (new permissaoBLL()).ListarPermissao();

            DataTable dt = new DataTable();
            dt.Clear();
            dt = (new permissaoBLL()).ListarPermissaoDaFuncao(funcaoDto.cod_funcao);

            for (int i = 0; i < gv_permissao_funcao.RowCount; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if(gv_permissao_funcao.GetRowCellValue(i, "cod_permissao").ToString() == dt.Rows[j]["cod_permissao"].ToString())
                    {
                        gv_permissao_funcao.SelectRow(i);
                        break;
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            List<permissaoDTO> listpermissao = new List<permissaoDTO>();
            permissaoDTO permissao = new permissaoDTO();

            for (int i = 0; i < gv_permissao_funcao.RowCount; i++)
            {
                if (gv_permissao_funcao.IsRowSelected(i))
                {
                    permissao = new permissaoDTO();
                    permissao.cod_permissao = int.Parse(gv_permissao_funcao.GetRowCellValue(i, "cod_permissao").ToString());
                    listpermissao.Add(permissao);
                }
            }

            if (salvar)
            {
                if (!permissaoBll.salvar(funcaoDto, listpermissao)) return;
            }
            this.Close();
        }

        private void dgv_permissao_funcao_Click(object sender, EventArgs e)
        {
        }
    }
}