namespace Projeto_Final
{
    partial class frm_cad_funcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_funcao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salvar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.rtb_descricao_funcao = new System.Windows.Forms.RichTextBox();
            this.txt_nomefuncao = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nomefuncao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.rtb_descricao_funcao);
            this.groupBox1.Controls.Add(this.txt_nomefuncao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Função";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Appearance.Options.UseFont = true;
            this.btn_salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.ImageOptions.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(159, 298);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(119, 35);
            this.btn_salvar.TabIndex = 64;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 298);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 35);
            this.simpleButton1.TabIndex = 63;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // rtb_descricao_funcao
            // 
            this.rtb_descricao_funcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.rtb_descricao_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_descricao_funcao.ForeColor = System.Drawing.Color.White;
            this.rtb_descricao_funcao.Location = new System.Drawing.Point(32, 138);
            this.rtb_descricao_funcao.Name = "rtb_descricao_funcao";
            this.rtb_descricao_funcao.Size = new System.Drawing.Size(219, 139);
            this.rtb_descricao_funcao.TabIndex = 62;
            this.rtb_descricao_funcao.Text = "";
            // 
            // txt_nomefuncao
            // 
            this.txt_nomefuncao.Location = new System.Drawing.Point(32, 68);
            this.txt_nomefuncao.Name = "txt_nomefuncao";
            this.txt_nomefuncao.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_nomefuncao.Properties.Appearance.Options.UseFont = true;
            this.txt_nomefuncao.Size = new System.Drawing.Size(219, 28);
            this.txt_nomefuncao.TabIndex = 54;
            this.txt_nomefuncao.EditValueChanged += new System.EventHandler(this.txt_nomefuncao_EditValueChanged);
            this.txt_nomefuncao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomefuncao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição da função";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de função:";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_cad_funcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 369);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cad_funcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cad_grupo_utilizador";
            this.Load += new System.EventHandler(this.frm_cad_funcao_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_cad_funcao_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nomefuncao.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_salvar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox rtb_descricao_funcao;
        private DevExpress.XtraEditors.TextEdit txt_nomefuncao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}