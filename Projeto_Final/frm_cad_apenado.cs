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
using Projeto_Final.Codigo.DTO;
using Projeto_Final.Codigo.BLL;

namespace Projeto_Final
{
    public partial class frm_cad_apenado : DevExpress.XtraEditors.XtraForm
    {
        validacoes validar = new validacoes();
        apenadoDTO apenadoDto = new apenadoDTO();
        apenadoBLL apenadoBll = new apenadoBLL();

        private bool cadastrar, alterar;

        public frm_cad_apenado()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Apenado";

        }

        public frm_cad_apenado(apenadoDTO _apenado)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;
            apenadoDto = _apenado;

            
            txt_nome_apenado.Text = _apenado.nome_apenado;
            dca_data_nascimento_apenado.Text = _apenado.data_nascimento;
            txt_naturalidade.Text = _apenado.naturalidade;
            txt_nomedoPai_apenado.Text = _apenado.nome_pai;
            Txt_nomedaMae_apenado.Text = _apenado.nome_mae;
            cb_estadoCivil_apenado.Text = _apenado.estado_civil;
            txt_residencia_apenado.Text = _apenado.residencia;
            cb_genero_apenado.Text = _apenado.genero;
            txt_bi_apenado.Text = _apenado.bi;
            txt_altura_apenado.Text = _apenado.altura.ToString();
            txt_apelido_apenado.Text = _apenado.apelido;
            rtb_descricao_apenado.Text = _apenado.descricao;
            pb_img.ImageLocation = _apenado.img;
            

            groupBox1.Text = "Alterar Apenado";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_apenado_Load(object sender, EventArgs e)
        {
            cbo_provincia_apenado.Properties.DataSource = (new provinciaBLL()).listaProvincia();
            cbo_provincia_apenado.Properties.ValueMember = "cod_provincia";
            cbo_provincia_apenado.Properties.DisplayMember = "nome_provincia";
            dca_data_nascimento_apenado.Properties.MaxValue = DateTime.Now.AddYears(-18);

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nome_apenado_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            validar.validar_letras(e);
        }

        private void txt_nome_apenado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_naturalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
           
        }

        private void txt_nomedoPai_apenado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void Txt_nomedaMae_apenado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imagem JPG (*.jpg)|*.jpg|Imagem PNG (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pb_img.ImageLocation = openFileDialog1.FileName;
                apenadoDto.img = pb_img.ImageLocation;
                pb_img.Load();
            }
        }

        private void txt_bi_apenado_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if(validar.verifica_bi_Opcional(txt_bi_apenado.Text)==false)
            {
                txt_bi_apenado.Text = "";
                return;
            }
            
            if(validar.verificar_Altura(txt_altura_apenado.Text) == false)
            {
                txt_altura_apenado.Text = "";
                return;
            }
            
            apenadoDto.nome_apenado = txt_nome_apenado.Text;
            apenadoDto.data_nascimento = dca_data_nascimento_apenado.Text;
            apenadoDto.genero = cb_genero_apenado.Text;
            apenadoDto.bi = txt_bi_apenado.Text;
            apenadoDto.nome_pai = txt_nomedoPai_apenado.Text;
            apenadoDto.nome_mae = Txt_nomedaMae_apenado.Text;
            apenadoDto.provincia.codProvincia = int.Parse(cbo_provincia_apenado.EditValue.ToString());
            apenadoDto.naturalidade = txt_naturalidade.Text;
            apenadoDto.residencia = txt_residencia_apenado.Text;
            apenadoDto.estado_civil = cb_estadoCivil_apenado.Text;
            apenadoDto.altura = txt_altura_apenado.Text == "" ? apenadoDto.altura : float.Parse(txt_altura_apenado.Text);
            apenadoDto.apelido = txt_apelido_apenado.Text;
            apenadoDto.descricao = rtb_descricao_apenado.Text;


          
            
            if (cadastrar)
            {
                if (!apenadoBll.salvar(apenadoDto)) return;
            }

            if (alterar)
            {
                if (!apenadoBll.alterar(apenadoDto)) return;
            }

            this.Close();
        }
    }
}