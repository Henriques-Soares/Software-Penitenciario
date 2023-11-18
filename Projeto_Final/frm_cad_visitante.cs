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
    public partial class frm_cad_visitante : DevExpress.XtraEditors.XtraForm
    {
        validacoes validar = new validacoes();
        visitanteDTO visitanteDto = new visitanteDTO();
        visitanteBLL visitanteBll = new visitanteBLL();

        bool cadastrar, alterar, remover;


        public frm_cad_visitante()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
            groupBox1.Text = "Cadastrar Visitante";
        }

        public frm_cad_visitante(visitanteDTO _visitante)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;
            groupBox1.Text = "Alterar Visitante";

            visitanteDto = _visitante;
            txt_nome_visitante.Text = _visitante.nome_visitante;
            dta_data_visitante.Text = _visitante.data_nascimento;
            txt_residencia_visitante.Text = _visitante.residencia;
            txt_naturalidade_visitante.Text = _visitante.naturalidade;
            cbo_genero_visitante.Text = _visitante.genero;
            txt_bi.Text = _visitante.bi;
            txt_contacto_visitante.Text = _visitante.contacto.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_visitante_Load(object sender, EventArgs e)
        {

        }

        private void txt_contacto_visitante_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_contacto_visitante_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_nome_visitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.validar_letras(e);
        }

        private void txt_contacto_visitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.valida_mumero(e);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (validar.verifica_bi(txt_bi.Text) == false)
            {
                txt_bi.Text = "";
                return;
            }

            visitanteDto.nome_visitante = txt_nome_visitante.Text;
            visitanteDto.data_nascimento = dta_data_visitante.Text;
            visitanteDto.residencia = txt_residencia_visitante.Text;
            visitanteDto.naturalidade = txt_naturalidade_visitante.Text;
            visitanteDto.genero = cbo_genero_visitante.Text;
            visitanteDto.bi = txt_bi.Text;
            visitanteDto.contacto = txt_contacto_visitante.Text == "" ? visitanteDto.contacto : int.Parse(txt_contacto_visitante.Text);
        
            if (cadastrar)
            {
                if (visitanteBll.salvar(visitanteDto) == false) return;
            }

            if (alterar)
            {
                if (visitanteBll.alterar(visitanteDto) == false) return;
            }

            this.Close();
        }
    }
}