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
    public partial class frm_cadastrar_funcionario : DevExpress.XtraEditors.XtraForm
    {
        funcionarioBLL funcionarioBll = new funcionarioBLL();
        funcionarioDTO funcionarioDto = new funcionarioDTO();
        private bool cadastrar, editar;

        public frm_cadastrar_funcionario()
        {
            InitializeComponent();
            cadastrar = true;
            editar = false;
        }

        public frm_cadastrar_funcionario(funcionarioDTO _funcionario)
        {
            InitializeComponent();
            cadastrar = false;
            editar = true;
            funcionarioDto = _funcionario;
            txt_nome.Text = _funcionario.nome_funcionario;
            dtp_data_nascimento.Text = _funcionario.data_nascimento;
            cb_genero.Text = _funcionario.genero;
            txt_bi.Text = _funcionario.bi;
            groupControl1.Text = "Alterar funcionário";

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void frm_cadastrar_funcionario_Load(object sender, EventArgs e)
        {
            cbo_provincia.Properties.DataSource = funcionarioBll.listaProvincia();
            cbo_provincia.Properties.ValueMember = "cod_provincia";
            cbo_provincia.Properties.DisplayMember = "nome_provincia";
            cbo_tipo_funcionario.Properties.DataSource = (new tipo_funcionarioBLL()).index();
            cbo_tipo_funcionario.Properties.ValueMember = "cod_tipo_funcionario";
            cbo_tipo_funcionario.Properties.DisplayMember = "nome_tipo_funcionario";
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_provincia_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            funcionarioDto.nome_funcionario = txt_nome.Text;
            funcionarioDto.data_nascimento = dtp_data_nascimento.Text;
            funcionarioDto.genero = cb_genero.Text;
            funcionarioDto.bi = txt_bi.Text;
            funcionarioDto.nip =txt_nip.Text == "" ? funcionarioDto.nip : int.Parse(txt_nip.Text);
            funcionarioDto.nome_pai = txt_nomedoPai.Text;
            funcionarioDto.nome_mae = Txt_nomedaMae.Text;
            funcionarioDto.provincia = new provinciaDTO();
            funcionarioDto.provincia.codProvincia = int.Parse(cbo_provincia.EditValue.ToString());
            funcionarioDto.residencia = txt_residencia.Text;
            funcionarioDto.estado_civil = cb_estadoCivil.Text;
            funcionarioDto.altura = txt_altura.Text == "" ? funcionarioDto.altura : float.Parse(txt_altura.Text);
            funcionarioDto.tel1 = txt_tel1.Text == "" ? funcionarioDto.tel1 : int.Parse(txt_tel1.Text);
            funcionarioDto.tel2 = txt_tel2.Text == "" ? funcionarioDto.tel2 : int.Parse(txt_tel2.Text);
            funcionarioDto.tipoFuncionario = new tipo_funcionarioDTO();
            funcionarioDto.tipoFuncionario.codTipoFuncionario = int.Parse(cbo_tipo_funcionario.EditValue.ToString());
            
            if(cadastrar)
            {
                if (!funcionarioBll.salvar(funcionarioDto)) return;
            }

            if(editar)
            {

            }

            this.Close();
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}