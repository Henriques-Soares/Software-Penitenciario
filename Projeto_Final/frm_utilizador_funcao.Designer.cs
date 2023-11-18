namespace Projeto_Final
{
    partial class frm_utilizador_funcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_utilizador_funcao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salvar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_funcao_utilizador = new DevExpress.XtraGrid.GridControl();
            this.gv_funcao_utilizador = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_funcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome_funcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcao_utilizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcao_utilizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.dgv_funcao_utilizador);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Função";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Appearance.Options.UseFont = true;
            this.btn_salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.ImageOptions.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(371, 314);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(119, 35);
            this.btn_salvar.TabIndex = 79;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(218, 314);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 35);
            this.simpleButton1.TabIndex = 78;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dgv_funcao_utilizador
            // 
            this.dgv_funcao_utilizador.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_funcao_utilizador.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_funcao_utilizador.Location = new System.Drawing.Point(3, 28);
            this.dgv_funcao_utilizador.MainView = this.gv_funcao_utilizador;
            this.dgv_funcao_utilizador.Name = "dgv_funcao_utilizador";
            this.dgv_funcao_utilizador.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_funcao_utilizador.Size = new System.Drawing.Size(689, 264);
            this.dgv_funcao_utilizador.TabIndex = 77;
            this.dgv_funcao_utilizador.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_funcao_utilizador});
            // 
            // gv_funcao_utilizador
            // 
            this.gv_funcao_utilizador.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_funcao,
            this.Nome_funcao});
            this.gv_funcao_utilizador.GridControl = this.dgv_funcao_utilizador;
            this.gv_funcao_utilizador.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gv_funcao_utilizador.Name = "gv_funcao_utilizador";
            this.gv_funcao_utilizador.OptionsFind.AlwaysVisible = true;
            this.gv_funcao_utilizador.OptionsFind.FindNullPrompt = "Insira o texto para pesquisar";
            this.gv_funcao_utilizador.OptionsFind.ShowFindButton = false;
            this.gv_funcao_utilizador.OptionsSelection.MultiSelect = true;
            this.gv_funcao_utilizador.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_funcao_utilizador.OptionsView.ShowFooter = true;
            this.gv_funcao_utilizador.OptionsView.ShowGroupPanel = false;
            // 
            // cod_funcao
            // 
            this.cod_funcao.Caption = "Código";
            this.cod_funcao.FieldName = "cod_funcao";
            this.cod_funcao.Name = "cod_funcao";
            this.cod_funcao.Visible = true;
            this.cod_funcao.VisibleIndex = 1;
            // 
            // Nome_funcao
            // 
            this.Nome_funcao.Caption = "Função";
            this.Nome_funcao.FieldName = "nome_funcao";
            this.Nome_funcao.Name = "Nome_funcao";
            this.Nome_funcao.Visible = true;
            this.Nome_funcao.VisibleIndex = 2;
            // 
            // rib_editar
            // 
            this.rib_editar.AutoHeight = false;
            this.rib_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.rib_editar.Name = "rib_editar";
            this.rib_editar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // rib_remover
            // 
            this.rib_remover.AutoHeight = false;
            this.rib_remover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.rib_remover.Name = "rib_remover";
            this.rib_remover.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // frm_utilizador_funcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_utilizador_funcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_utilizador_funcao";
            this.Load += new System.EventHandler(this.frm_utilizador_funcao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcao_utilizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcao_utilizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgv_funcao_utilizador;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_funcao_utilizador;
        private DevExpress.XtraGrid.Columns.GridColumn cod_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn Nome_funcao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.XtraEditors.SimpleButton btn_salvar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}