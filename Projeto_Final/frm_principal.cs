using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Final.Codigo.BLL;
using Projeto_Final.Codigo.DTO;


namespace Projeto_Final
{
    public partial class frm_principal : DevExpress.XtraEditors.XtraForm
    {
        tipo_funcionarioDTO _funcioario = new tipo_funcionarioDTO();

        public frm_principal()
        {
            InitializeComponent();
            //cp_apenado_morto.Size = new Size(233, 194);
            //cp_apenado_morto.Location = new Point(70, 41);
            timer1.Start();
        }
        public void Control_acessso()
        {
            btn_dashboard.Enabled = true;
            //Area para tipo Funcionario
            sti_tipoFuncionario.Enabled = true;
            pnl_tipoFuncionario.Enabled = true;
            //Area para Funcionario
            sti_funcionario.Enabled = true;
            pnl_funcionario.Enabled = true;
            //Area para Penetenciaria
                //processo
            sni_penitenciaria.Enabled = true;
            sti_processo.Enabled = true;
            pnl_processo.Enabled = true;
            // apenado
       
            sti_apenado.Enabled = true;
            pnl_apenado.Enabled = true;

            // visita

            sti_visita.Enabled = true;
            pnl_visita.Enabled = true;

            // visitante

            sti_visitante.Enabled = true;
            pnl_visitante.Enabled = true;

            // enfermaria

            sti_enfermaria.Enabled = true;
            pnl_enfermaria.Enabled = true;

            // cuidados

            sti_cuidados.Enabled = true;
            pnl_cuidados.Enabled = true;

            // Refeitorio

            sti_refeitorio.Enabled = true;
            pnl_refeitorio.Enabled = true;

            // Alimento

            sti_alimento.Enabled = true;
            pnl_alimento.Enabled = true;

            // Tipo crime

            sti_tipocrime.Enabled = true;
            pnl_tipocrime.Enabled = true;
            //unidade prisional
            //bloco
            sni_unidade_prisional.Enabled = true;
            sti_bloco.Enabled = true;
            pnl_bloco.Enabled = true;
            //cama
           
            sti_cama.Enabled = true;
            pnl_cama.Enabled = true;
            //cela
            sti_cela.Enabled = true;
            pnl_cela.Enabled = true;
            //control de acesso
            //funcao 
            sni_controlo_acesso.Enabled = true;
            sti_funcao.Enabled = true;
            stcp_funcao.Enabled = true;
            //utilizador
            sti_utilizador.Enabled = true;
            stcp_utilizador.Enabled = true;
            //BACKUP
            button1.Enabled = true;

            if (UtilizadorLogadoDTO.Permissao.Contains("permisao acessar tipo de funcionario"))
            {
                sti_tipoFuncionario.Enabled = true;
                pnl_tipoFuncionario.Enabled = true;
            }
          
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar funcionario"))
            {
                sti_funcionario.Enabled = true;
                pnl_funcionario.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar processo"))
            {
                sni_penitenciaria.Enabled = true;
                sti_processo.Enabled = true;
                pnl_processo.Enabled = true;


            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar apenado"))
            {
                sni_penitenciaria.Enabled = true;
                sti_apenado.Enabled = true;
                pnl_apenado.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar visita"))
            {
                sni_penitenciaria.Enabled = true;
                sti_visita.Enabled = true;
                pnl_visita.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar visitante"))
            {
                sni_penitenciaria.Enabled = true;
                sti_visitante.Enabled = true;
                pnl_visitante.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar enfermaria"))
            {
                sni_penitenciaria.Enabled = true;
                sti_enfermaria.Enabled = true;
                pnl_enfermaria.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar cuidados"))
            {
                sni_penitenciaria.Enabled = true;
                sti_cuidados.Enabled = true;
                pnl_cuidados.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar refeitorio"))
            {
                sni_penitenciaria.Enabled = true;
                sti_refeitorio.Enabled = true;
                pnl_refeitorio.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar alimento"))
            {
                sni_penitenciaria.Enabled = true;
                sti_alimento.Enabled = true;
                pnl_alimento.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar tipo de crime"))
            {
                sni_penitenciaria.Enabled = true;
                sti_tipocrime.Enabled = true;
                pnl_tipocrime.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar bloco"))
            {
                sni_unidade_prisional.Enabled = true;
                sti_bloco.Enabled = true;
                pnl_bloco.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar cela"))
            {
                sni_unidade_prisional.Enabled = true;
                sti_cela.Enabled = true;
                pnl_cela.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar cama"))
            {
                sni_unidade_prisional.Enabled = true;
                sti_cama.Enabled = true;
                pnl_cama.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar funcao"))
            {
                sni_controlo_acesso.Enabled = true;
                sti_funcao.Enabled = true;
                stcp_funcao.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("permissao acessar utilizador"))
            {
                sni_controlo_acesso.Enabled = true;
                sti_utilizador.Enabled = true;
                stcp_utilizador.Enabled = true;
            }
            if (UtilizadorLogadoDTO.Permissao.Contains("Permissao fazer backup"))
            {
                button1.Enabled = true;
              
            }

        }

        private void frm_principal_Load(object sender, EventArgs e)

        {
            Control_acessso();
            lbl_total_apenado.Text = "Total de Apenandos: " + (new dashbardBLL()).qtdApenado().ToString();
            lbl_total_processo.Text = "Total de Processos: " + (new dashbardBLL()).qtdProcesso().ToString();

            cp_processo_detido.Value = int.Parse((new dashbardBLL()).qtdApenadoDetido().ToString());
            cp_processo_solto.Value = int.Parse((new dashbardBLL()).qtdApenadoSolto().ToString());
            cp_processo_f.Value = int.Parse((new dashbardBLL()).qtdApenadoF().ToString());
            cp_processo_m.Value = int.Parse((new dashbardBLL()).qtdApenadoM().ToString());
        }

        private void sni_funcionarios_Click(object sender, EventArgs e)
        {
            if (stc_funcionario.Visible == true) return;
            stc_funcionario.Visible = true;
            stc_funcionario.SelectedTabIndex = 0;
           
            //adicionando o formulario de tipo de funcionario no panel
            frm_list_tipo_funcionario T_funcionario = new frm_list_tipo_funcionario();
            T_funcionario.TopLevel=false;
            T_funcionario.Dock = DockStyle.Fill;
            pnl_tipoFuncionario.Controls.Add(T_funcionario);
            T_funcionario.Show();

            //adicionando o formulario de funcionario no panel
            frm_list_funcionario funcionario = new frm_list_funcionario();
            funcionario.TopLevel = false;
            funcionario.Dock = DockStyle.Fill;
            pnl_funcionario.Controls.Add(funcionario);
            funcionario.Show();


        }

        private void sni_funcionarios_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void sni_funcionarios_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btn_dashboard_MouseHover(object sender, EventArgs e)
        {

            //btn_dashboard.Select();
        }

        private void sni_penitenciaria_Click(object sender, EventArgs e)
        {
            //adicionando o formulario de Processo no panel
            frm_list_processo processo = new frm_list_processo();
            processo.TopLevel = false;
            processo.Dock = DockStyle.Fill;
            pnl_processo.Controls.Add(processo);
            processo.Show();

            //adicionando o formulario de Apenado no panel
            frm_list_apenado apenado = new frm_list_apenado();
            apenado.TopLevel = false;
            apenado.Dock = DockStyle.Fill;
            pnl_apenado.Controls.Add(apenado);
            apenado.Show();

            //Adicionando o formulário de visita no panel
            frm_list_visita visita = new frm_list_visita();
            visita.TopLevel = false;
            visita.Dock = DockStyle.Fill;
            pnl_visita.Controls.Add(visita);
            visita.Show();

            //Adicionando o formulário de visitante no panel
            frm_list_visitante visitante = new frm_list_visitante();
            visitante.TopLevel = false;
            visitante.Dock = DockStyle.Fill;
            pnl_visitante.Controls.Add(visitante);
            visitante.Show();

            //Adicionando o formulário enfermaria no panel
            frm_list_enfermaria enfermaria = new frm_list_enfermaria();
            enfermaria.TopLevel = false;
            enfermaria.Dock = DockStyle.Fill;
            pnl_enfermaria.Controls.Add(enfermaria);
            enfermaria.Show();

            //Adicionando o formulário cuidados no panel tipo de cadastro cuidados
            frm_list_cuidados cuidados = new frm_list_cuidados();
            cuidados.TopLevel = false;
            cuidados.Dock = DockStyle.Fill;
            pnl_cuidados.Controls.Add(cuidados);
            cuidados.Show();

            //Adicionando o formulário refeitório no panel
            frm_list_refeitorio refeitorio = new frm_list_refeitorio();
            refeitorio.TopLevel = false;
            refeitorio.Dock = DockStyle.Fill;
            pnl_refeitorio.Controls.Add(refeitorio);
            refeitorio.Show();

            //Adicionando o formulário alimento no panel
            frm_list_alimento alimento = new frm_list_alimento();
            alimento.TopLevel = false;
            alimento.Dock = DockStyle.Fill;
            pnl_alimento.Controls.Add(alimento);
            alimento.Show();

            //Adicionando o formulário tipo_crime no panel tipo de cadastro tipo crime
            frm_list_tipocrime tipo_crime = new frm_list_tipocrime();
            tipo_crime.TopLevel = false;
            tipo_crime.Dock = DockStyle.Fill;
            pnl_tipocrime.Controls.Add(tipo_crime);
            tipo_crime.Show();

            
            

        }

        private void sni_penitenciaria_MouseHover(object sender, EventArgs e)
        {
        }

        private void sni_controlo_acesso_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void sideNavPanel6_MouseHover(object sender, EventArgs e)
        {
        }

        private void snp_penitenciaria_MouseHover(object sender, EventArgs e)
        {
        }

        private void snp_unidadePrisional_MouseHover(object sender, EventArgs e)
        {
        }

        private void sni_unidade_prisional_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void sni_configuracoes_MouseHover(object sender, EventArgs e)
        {
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login sair = new frm_login();
            sair.Show();
            this.Hide();
            //Application.Exit();
        }

        private void btn_logout_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void superTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void pnl_tipoFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void pnl_funcionario_Click(object sender, EventArgs e)
        {

        }

        private void pnl_processo_Click(object sender, EventArgs e)
        {
           
        }

        private void pnl_visita_Click(object sender, EventArgs e)
        {

        }

        private void superTabControlPanel3_Click(object sender, EventArgs e)
        {

        }


        private void sni_unidade_prisional_Click(object sender, EventArgs e)
        {

            //Adicionando o formulário cela no panel
            pnl_cela.Controls.Clear();
            frm_list_cela cela = new frm_list_cela();
            cela.TopLevel = false;
            cela.Dock = DockStyle.Fill;
            pnl_cela.Controls.Add(cela);
            cela.Show();

            //Adicionando o formulário cama no panel
            frm_list_cama cama = new frm_list_cama();
            cama.TopLevel = false;
            cama.Dock = DockStyle.Fill;
            pnl_cama.Controls.Add(cama);
            cama.Show();
            //Adicionando o formulário bloco no panel
            frm_list_bloco bloco = new frm_list_bloco();
            bloco.TopLevel = false;
            bloco.Dock = DockStyle.Fill;
            pnl_bloco.Controls.Add(bloco);
            bloco.Show();
        }

        private void pnl_cela_Click(object sender, EventArgs e)
        {

        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cp_processo_solto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cp_processo_m_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbdata.Text = DateTime.Now.ToLongDateString();
        }

        private void superTabControlPanel3_Click_1(object sender, EventArgs e)
        {
            

        }

        private void sni_controlo_acesso_Click(object sender, EventArgs e)
        {
            frm_list_funcao utilizador = new frm_list_funcao();
            utilizador.TopLevel = false;
            utilizador.Dock = DockStyle.Fill;
            stcp_funcao.Controls.Add(utilizador);
            utilizador.Show();

            //utilizador
            frm_list_utilizador utilizadors = new frm_list_utilizador();
            utilizadors.TopLevel = false;
            utilizadors.Dock = DockStyle.Fill;
            stcp_utilizador.Controls.Add(utilizadors);
            utilizadors.Show();
        }

        private void lbdata_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_backup Backup = new frm_backup();
            Backup.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_sobre_sistema sobre = new frm_sobre_sistema();
            sobre.ShowDialog();
        }

        private void snp_dashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_alterarsenha_Click(object sender, EventArgs e)
        {
            frm_senha senha = new frm_senha();
            senha.Show();
        }

        private void cp_processo_detido_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cp_processo_f_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }
    }
}
