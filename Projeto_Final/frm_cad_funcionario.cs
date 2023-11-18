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
    public partial class frm_cad_funcionario : DevExpress.XtraEditors.XtraForm
    {
        validacoes validar = new validacoes();
        funcionarioBLL funcionarioBll = new funcionarioBLL();
        funcionarioDTO funcionarioDto = new funcionarioDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_funcionario()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
        }

        public frm_cad_funcionario(funcionarioDTO _funcionario)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            funcionarioDto = _funcionario;

            txt_nome.Text = _funcionario.nome_funcionario;
            dtp_data_nascimento.Text = _funcionario.data_nascimento;
            cb_genero.Text = _funcionario.genero;
            txt_bi.Text = _funcionario.bi;
            txt_nomedoPai.Text = _funcionario.nome_pai;
            Txt_nomedaMae.Text = _funcionario.nome_mae;
            txt_residencia.Text = _funcionario.residencia;
            cb_estadoCivil.Text = _funcionario.estado_civil;
            txt_altura.Text = _funcionario.altura.ToString();
            txt_nip.Text = _funcionario.nip.ToString();
            txt_tel1.Text = _funcionario.tel1.ToString();
            txt_tel2.Text = _funcionario.tel2.ToString();

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
            cbo_provincia.Properties.DataSource = (new provinciaBLL()).listaProvincia();
            cbo_provincia.Properties.ValueMember = "cod_provincia";
            cbo_provincia.Properties.DisplayMember = "nome_provincia";

            cbo_tipo_funcionario.Properties.DataSource = (new tipo_funcionarioBLL()).index();
            cbo_tipo_funcionario.Properties.ValueMember = "cod_tipo_funcionario";
            cbo_tipo_funcionario.Properties.DisplayMember = "nome_tipo_funcionario";
            dtp_data_nascimento.Properties.MaxValue = DateTime.Now.AddYears(-18);
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

            if (validar.verifica_bi(txt_bi.Text) == false)
            {
                txt_bi.Text = "";
                return;

            }
            if (validar.vaerifica_nip(txt_nip.Text) == false)
            {
                txt_nip.Text = "";
                return;
            }
            if (validar.verifivar_Tl1(txt_tel1.Text) == false)
            {
                txt_tel1.Text = "";
                return;
            }

            if (validar.verifivar_Tl2(txt_tel2.Text) == false)
            {
                txt_tel2.Text = "";
                return;
            }
          

            if (validar.verificar_Altura(txt_altura.Text) == false)
            {
                txt_altura.Text = "";
                return;
            }



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

    

            if (cadastrar)
             {
                 if (!funcionarioBll.salvar(funcionarioDto)) return;
             }

             if(alterar)
             {
                 if (!funcionarioBll.alterar(funcionarioDto)) return;
             }

             this.Close();
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_estadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_tipo_funcionario_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_tel1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.valida_mumero(e);
        }

        private void txt_tel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.valida_mumero(e);
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void Txt_nomedaMae_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void txt_nip_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.valida_mumero(e);
        }

        private void txt_nomedoPai_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagem JPG (*.jpg)|*.jpg|Imagem PNG (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_img.ImageLocation = openFileDialog1.FileName;
                funcionarioDto.img = pb_img.ImageLocation;
                pb_img.Load();
            }
            
        }

        private void dtp_data_nascimento_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}