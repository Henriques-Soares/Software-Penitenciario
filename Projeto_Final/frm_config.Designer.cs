namespace Projeto_Final
{
    partial class frm_config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtporta = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtbd = new System.Windows.Forms.TextBox();
            this.txthost = new System.Windows.Forms.TextBox();
            this.bd = new System.Windows.Forms.Label();
            this.senha = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.txtporta);
            this.panel1.Controls.Add(this.txtsenha);
            this.panel1.Controls.Add(this.txtbd);
            this.panel1.Controls.Add(this.txthost);
            this.panel1.Controls.Add(this.bd);
            this.panel1.Controls.Add(this.senha);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.porta);
            this.panel1.Controls.Add(this.host);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 419);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 70);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(29, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(379, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Configuração da Base de Dados ";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(80, 350);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 50);
            this.btn_guardar.TabIndex = 27;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(246, 350);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(110, 50);
            this.btn_sair.TabIndex = 26;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(117, 178);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(301, 30);
            this.txtuser.TabIndex = 25;
            this.txtuser.Text = "root";
            // 
            // txtporta
            // 
            this.txtporta.Location = new System.Drawing.Point(80, 126);
            this.txtporta.Name = "txtporta";
            this.txtporta.Size = new System.Drawing.Size(338, 30);
            this.txtporta.TabIndex = 24;
            this.txtporta.Text = "3306";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(139, 277);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(279, 30);
            this.txtsenha.TabIndex = 23;
            // 
            // txtbd
            // 
            this.txtbd.BackColor = System.Drawing.Color.White;
            this.txtbd.Location = new System.Drawing.Point(218, 232);
            this.txtbd.Name = "txtbd";
            this.txtbd.Size = new System.Drawing.Size(200, 30);
            this.txtbd.TabIndex = 22;
            this.txtbd.Text = "orientacao";
            // 
            // txthost
            // 
            this.txthost.Location = new System.Drawing.Point(178, 79);
            this.txthost.Name = "txthost";
            this.txthost.Size = new System.Drawing.Size(240, 30);
            this.txthost.TabIndex = 21;
            this.txthost.Text = "localhost";
            // 
            // bd
            // 
            this.bd.AutoSize = true;
            this.bd.ForeColor = System.Drawing.Color.Black;
            this.bd.Location = new System.Drawing.Point(16, 235);
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(204, 22);
            this.bd.TabIndex = 20;
            this.bd.Text = "Nome da base de dados:";
            // 
            // senha
            // 
            this.senha.AutoSize = true;
            this.senha.ForeColor = System.Drawing.Color.Black;
            this.senha.Location = new System.Drawing.Point(16, 280);
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(125, 22);
            this.senha.TabIndex = 19;
            this.senha.Text = "Palavra Passe:";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.ForeColor = System.Drawing.Color.Black;
            this.nome.Location = new System.Drawing.Point(16, 181);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(95, 22);
            this.nome.TabIndex = 18;
            this.nome.Text = "Utilizador:";
            // 
            // porta
            // 
            this.porta.AutoSize = true;
            this.porta.ForeColor = System.Drawing.Color.Black;
            this.porta.Location = new System.Drawing.Point(11, 129);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(64, 22);
            this.porta.TabIndex = 17;
            this.porta.Text = "Porta::";
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.ForeColor = System.Drawing.Color.Black;
            this.host.Location = new System.Drawing.Point(11, 82);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(161, 22);
            this.host.TabIndex = 16;
            this.host.Text = "Nome do servidor:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 419);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtporta;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtbd;
        private System.Windows.Forms.TextBox txthost;
        private System.Windows.Forms.Label bd;
        private System.Windows.Forms.Label senha;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label porta;
        private System.Windows.Forms.Label host;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}