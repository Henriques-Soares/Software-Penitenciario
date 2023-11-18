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
    public partial class frm_utilizador_funcao : DevExpress.XtraEditors.XtraForm
    {
        funcaoBLL funcaoBll = new funcaoBLL();
        funcaoDTO funcaoDto = new funcaoDTO();
        utilizadorDTO utilizadorDto = new utilizadorDTO();
        private bool cadastrarUtilizador;

        public frm_utilizador_funcao(utilizadorDTO _utilizadorDto)
        {
            InitializeComponent();

            utilizadorDto = _utilizadorDto;
            groupBox1.Text = "Funções para o Utilizador - " + utilizadorDto.nomeUtilizador;
            cadastrarUtilizador = true;
        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            List<funcaoDTO> listfuncao = new List<funcaoDTO>();
            funcaoDTO funcao = new funcaoDTO();

            for (int i = 0; i < gv_funcao_utilizador.RowCount; i++)
            {
                if (gv_funcao_utilizador.IsRowSelected(i))
                {
                    funcao = new funcaoDTO();
                    funcao.cod_funcao = int.Parse(gv_funcao_utilizador.GetRowCellValue(i, "cod_funcao").ToString());
                    listfuncao.Add(funcao);
                }
            }

            if (cadastrarUtilizador)
            {
                if (!funcaoBll.Utilizador_permissao(utilizadorDto, listfuncao)) return;
            }
            this.Close();
        }

        private void frm_utilizador_funcao_Load(object sender, EventArgs e)
        {
            dgv_funcao_utilizador.DataSource = (new funcaoBLL()).listarfuncao();

            DataTable dt = new DataTable();
            dt.Clear();

            dt = (new funcaoBLL()).ListarFuncaoUtilizador(utilizadorDto.codUtilizador);

            for (int i = 0; i < gv_funcao_utilizador.RowCount; i++)
            {
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (gv_funcao_utilizador.GetRowCellValue(i, "cod_funcao").ToString() == dt.Rows[j]["cod_funcao"].ToString())
                    {
                        gv_funcao_utilizador.SelectRow(i);
                        break;
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}