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
    public partial class frm_cad_tipo_funcionario : DevExpress.XtraEditors.XtraForm
    {
        tipo_funcionarioBLL tipo_funcionarioBll = new tipo_funcionarioBLL();
        tipo_funcionarioDTO tipo_funcionarioDto = new tipo_funcionarioDTO();
        private bool cadastrar, editar;

        public frm_cad_tipo_funcionario()
        {
            InitializeComponent();
            cadastrar = true;
            editar = false;
        }

        public frm_cad_tipo_funcionario(tipo_funcionarioDTO _tipoFuncionario)
        {
            InitializeComponent();
            cadastrar = false;
            editar = true;
            tipo_funcionarioDto = _tipoFuncionario;
            txt_designacao.Text = _tipoFuncionario.designacao;
            groupControl1.Text = "Alterar tipo de funcionário";
        }

        private void frm_cad_tipo_funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_designacao_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            tipo_funcionarioDto.designacao = txt_designacao.Text;

            if(cadastrar)
            {
                if (tipo_funcionarioBll.salvar(tipo_funcionarioDto) == false) return;
            }

            if(editar)
            {
                if (tipo_funcionarioBll.editar(tipo_funcionarioDto) == false) return;
            }
            this.Close();
        }
    }
}