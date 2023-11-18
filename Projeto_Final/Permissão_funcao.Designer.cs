namespace Projeto_Final
{
    partial class Permissão_funcao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permissão_funcao));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_salvar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_permissao_funcao = new DevExpress.XtraGrid.GridControl();
            this.gv_permissao_funcao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_permissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_permissao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissao_funcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_permissao_funcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.dgv_permissao_funcao);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 434);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Appearance.Options.UseFont = true;
            this.btn_salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.ImageOptions.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(266, 387);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(119, 35);
            this.btn_salvar.TabIndex = 68;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(113, 387);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 35);
            this.simpleButton1.TabIndex = 67;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dgv_permissao_funcao
            // 
            this.dgv_permissao_funcao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_permissao_funcao.Location = new System.Drawing.Point(12, 31);
            this.dgv_permissao_funcao.MainView = this.gv_permissao_funcao;
            this.dgv_permissao_funcao.Name = "dgv_permissao_funcao";
            this.dgv_permissao_funcao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_permissao_funcao.Size = new System.Drawing.Size(518, 347);
            this.dgv_permissao_funcao.TabIndex = 66;
            this.dgv_permissao_funcao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_permissao_funcao});
            this.dgv_permissao_funcao.Click += new System.EventHandler(this.dgv_permissao_funcao_Click);
            // 
            // gv_permissao_funcao
            // 
            this.gv_permissao_funcao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_permissao,
            this.nome_permissao});
            this.gv_permissao_funcao.GridControl = this.dgv_permissao_funcao;
            this.gv_permissao_funcao.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gv_permissao_funcao.Name = "gv_permissao_funcao";
            this.gv_permissao_funcao.OptionsFind.AlwaysVisible = true;
            this.gv_permissao_funcao.OptionsFind.FindNullPrompt = "Insira o texto para pesquisar";
            this.gv_permissao_funcao.OptionsFind.ShowFindButton = false;
            this.gv_permissao_funcao.OptionsSelection.MultiSelect = true;
            this.gv_permissao_funcao.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_permissao_funcao.OptionsView.ShowFooter = true;
            this.gv_permissao_funcao.OptionsView.ShowGroupPanel = false;
            // 
            // cod_permissao
            // 
            this.cod_permissao.Caption = "Código";
            this.cod_permissao.FieldName = "cod_permissao";
            this.cod_permissao.Name = "cod_permissao";
            this.cod_permissao.Visible = true;
            this.cod_permissao.VisibleIndex = 1;
            // 
            // nome_permissao
            // 
            this.nome_permissao.Caption = "Permissão";
            this.nome_permissao.FieldName = "nome_permissao";
            this.nome_permissao.Name = "nome_permissao";
            this.nome_permissao.Visible = true;
            this.nome_permissao.VisibleIndex = 2;
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
            // Permissão_funcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 434);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permissão_funcao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permissão_funcao";
            this.Load += new System.EventHandler(this.Permissão_funcao_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_permissao_funcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_permissao_funcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgv_permissao_funcao;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_permissao_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn cod_permissao;
        private DevExpress.XtraGrid.Columns.GridColumn nome_permissao;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.XtraEditors.SimpleButton btn_salvar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}