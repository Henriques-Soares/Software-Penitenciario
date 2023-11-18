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
    public partial class frm_cad_cuidados : DevExpress.XtraEditors.XtraForm
    {
        cuidadosBLL cuidadoBll = new cuidadosBLL();
        cuidadosDTO cuidadoDto = new cuidadosDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_cuidados()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;

            groupBox1.Text = "Cadastrar Cuidados";
        }

        public frm_cad_cuidados(cuidadosDTO _cuidados)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            cuidadoDto = _cuidados;
            txt_acaoImplementada.Text = _cuidados.acao_implementada;
            txt_problema.Text = _cuidados.problema;
            dtp_data_registo.Text = _cuidados.data_registo;
            hora_cuidados.Text = _cuidados.hora;

            groupBox1.Text = "Alterar Visita";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void frm_cad_cuidados_Load(object sender, EventArgs e)
        {

            cbo_cod_enfermagem.Properties.DataSource = (new enfermariaBLL()).listarEnfermaria();
            cbo_cod_enfermagem.Properties.ValueMember = "cod_enfermagem";
            cbo_cod_enfermagem.Properties.DisplayMember = "descricao";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            cuidadoDto.enfermaria.cod_enfermagem = int.Parse(cbo_cod_enfermagem.EditValue.ToString());
            cuidadoDto.acao_implementada = txt_acaoImplementada.Text;
            cuidadoDto.problema = txt_problema.Text;
            cuidadoDto.data_registo = dtp_data_registo.Text;
            cuidadoDto.hora = hora_cuidados.Text;


            if (cadastrar)
            {
                if (!cuidadoBll.salvar(cuidadoDto)) return;
            }

            if (alterar)
            {
                if (!cuidadoBll.alterar(cuidadoDto)) return;
            }

            this.Close();
        }

        private void dtp_data_nascimento_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}