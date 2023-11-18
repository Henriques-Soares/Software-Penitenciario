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
    public partial class frm_cad_refeitorio : DevExpress.XtraEditors.XtraForm
    {
        refeitorioBLL refeitorioBll = new refeitorioBLL();
        refeitorioDTO refeitorioDto = new refeitorioDTO();
        private bool cadastrar, alterar, remover;

        public frm_cad_refeitorio()
        {
            InitializeComponent();
            cadastrar = true;
            alterar = false;
        }

        public frm_cad_refeitorio(refeitorioDTO _refeitorio)
        {
            InitializeComponent();
            cadastrar = false;
            alterar = true;

            refeitorioDto = _refeitorio;
            cbo_cod_processo.EditValue = _refeitorio.processo.cod_processo;
            cbo_cod_alimento.EditValue = _refeitorio.alimento.cod_alimento;
            cb_tipoRefeicao.Text = _refeitorio.tipo_refeicao;
            groupBox1.Text = "Alterar Refeitório";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_cad_refeitório_Load(object sender, EventArgs e)
        {
            cbo_cod_processo.Properties.DataSource = (new refeitorioBLL()).listaProcesso();
            cbo_cod_processo.Properties.ValueMember = "cod_processo";
            cbo_cod_processo.Properties.DisplayMember = "nome_apenado";

            cbo_cod_alimento.Properties.DataSource = refeitorioBll.listaalimento();
            cbo_cod_alimento.Properties.ValueMember = "cod_alimento";
            cbo_cod_alimento.Properties.DisplayMember = "nome_alimento";

        }


        private void btn_salvar_Click(object sender, EventArgs e)
        {
            refeitorioDto.processo = new processoDTO();
            refeitorioDto.processo.cod_processo = int.Parse(cbo_cod_processo.EditValue.ToString());
            refeitorioDto.alimento = new alimentoDTO();
            refeitorioDto.alimento.cod_alimento = int.Parse(cbo_cod_alimento.EditValue.ToString());
            refeitorioDto.tipo_refeicao = cb_tipoRefeicao.Text;


            if (cadastrar)
            {
                if (refeitorioBll.salvar(refeitorioDto) == false) return;
            }

            if (alterar)
            {
                if (refeitorioBll.alterar(refeitorioDto) == false) return;
            }

            this.Close();
        }
    }
}