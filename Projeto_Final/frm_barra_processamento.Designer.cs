namespace Projeto_Final
{
    partial class frm_barra_processamento
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
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_comeco = new System.Windows.Forms.Label();
            this.label_contagem = new System.Windows.Forms.Label();
            this.pb_barraprocessamento = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_comeco
            // 
            this.label_comeco.AutoSize = true;
            this.label_comeco.BackColor = System.Drawing.Color.Transparent;
            this.label_comeco.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_comeco.ForeColor = System.Drawing.Color.White;
            this.label_comeco.Location = new System.Drawing.Point(12, 427);
            this.label_comeco.Name = "label_comeco";
            this.label_comeco.Size = new System.Drawing.Size(105, 25);
            this.label_comeco.TabIndex = 2;
            this.label_comeco.Text = "Iniciando";
            // 
            // label_contagem
            // 
            this.label_contagem.AutoSize = true;
            this.label_contagem.BackColor = System.Drawing.Color.Transparent;
            this.label_contagem.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_contagem.ForeColor = System.Drawing.Color.White;
            this.label_contagem.Location = new System.Drawing.Point(748, 427);
            this.label_contagem.Name = "label_contagem";
            this.label_contagem.Size = new System.Drawing.Size(44, 25);
            this.label_contagem.TabIndex = 3;
            this.label_contagem.Text = "0%";
            // 
            // pb_barraprocessamento
            // 
            this.pb_barraprocessamento.Location = new System.Drawing.Point(0, 487);
            this.pb_barraprocessamento.Name = "pb_barraprocessamento";
            this.pb_barraprocessamento.Size = new System.Drawing.Size(803, 10);
            this.pb_barraprocessamento.TabIndex = 4;
            // 
            // frm_barra_processamento
            // 
            this.Appearance.BackColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Projeto_Final.Properties.Resources.CELAS_E_LOGO0_800x500_1;
            this.ClientSize = new System.Drawing.Size(803, 497);
            this.Controls.Add(this.pb_barraprocessamento);
            this.Controls.Add(this.label_contagem);
            this.Controls.Add(this.label_comeco);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_barra_processamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_barra_processamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_comeco;
        private System.Windows.Forms.Label label_contagem;
        private System.Windows.Forms.ProgressBar pb_barraprocessamento;
    }
}