namespace Projeto_Final
{
    partial class frm_list_funcao
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_funcao));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions5 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions6 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.dgv_funcao = new DevExpress.XtraGrid.GridControl();
            this.gv_funcao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_funcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_funcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao_funcao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_permissoes = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_permissoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_funcao
            // 
            this.dgv_funcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funcao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_funcao.Location = new System.Drawing.Point(0, 140);
            this.dgv_funcao.MainView = this.gv_funcao;
            this.dgv_funcao.MenuManager = this.ribbonControl1;
            this.dgv_funcao.Name = "dgv_funcao";
            this.dgv_funcao.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover,
            this.rib_permissoes});
            this.dgv_funcao.Size = new System.Drawing.Size(761, 302);
            this.dgv_funcao.TabIndex = 4;
            this.dgv_funcao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_funcao});
            this.dgv_funcao.Click += new System.EventHandler(this.dgv_cela_Click);
            // 
            // gv_funcao
            // 
            this.gv_funcao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_funcao,
            this.nome_funcao,
            this.descricao_funcao,
            this.created_at,
            this.gridColumn1,
            this.Editar,
            this.Remover});
            this.gv_funcao.GridControl = this.dgv_funcao;
            this.gv_funcao.Name = "gv_funcao";
            this.gv_funcao.OptionsFind.AlwaysVisible = true;
            this.gv_funcao.OptionsFind.FindNullPrompt = "Insira o texto para pesquisar";
            this.gv_funcao.OptionsFind.ShowFindButton = false;
            this.gv_funcao.OptionsView.ShowFooter = true;
            this.gv_funcao.OptionsView.ShowGroupPanel = false;
            // 
            // cod_funcao
            // 
            this.cod_funcao.Caption = "Código da função";
            this.cod_funcao.FieldName = "cod_funcao";
            this.cod_funcao.Name = "cod_funcao";
            this.cod_funcao.Visible = true;
            this.cod_funcao.VisibleIndex = 0;
            // 
            // nome_funcao
            // 
            this.nome_funcao.Caption = "Nome da função";
            this.nome_funcao.FieldName = "nome_funcao";
            this.nome_funcao.Name = "nome_funcao";
            this.nome_funcao.Visible = true;
            this.nome_funcao.VisibleIndex = 1;
            // 
            // descricao_funcao
            // 
            this.descricao_funcao.Caption = "Descrição da função";
            this.descricao_funcao.FieldName = "descricao_funcao";
            this.descricao_funcao.Name = "descricao_funcao";
            this.descricao_funcao.Visible = true;
            this.descricao_funcao.VisibleIndex = 2;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Permissões";
            this.gridColumn1.ColumnEdit = this.rib_permissoes;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // rib_permissoes
            // 
            this.rib_permissoes.AutoHeight = false;
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.rib_permissoes.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_permissoes.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rib_permissoes.ContextImageOptions.Image")));
            this.rib_permissoes.Name = "rib_permissoes";
            this.rib_permissoes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_permissoes.Click += new System.EventHandler(this.rib_permissoes_Click);
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 5;
            // 
            // rib_editar
            // 
            this.rib_editar.AutoHeight = false;
            editorButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions5.Image")));
            this.rib_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions5, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_editar.Name = "rib_editar";
            this.rib_editar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_editar.Click += new System.EventHandler(this.rib_editar_Click);
            // 
            // Remover
            // 
            this.Remover.Caption = "Remover";
            this.Remover.ColumnEdit = this.rib_remover;
            this.Remover.Name = "Remover";
            this.Remover.Visible = true;
            this.Remover.VisibleIndex = 6;
            // 
            // rib_remover
            // 
            this.rib_remover.AutoHeight = false;
            editorButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions6.Image")));
            this.rib_remover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions6, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_remover.Name = "rib_remover";
            this.rib_remover.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_remover.Click += new System.EventHandler(this.rib_remover_Click);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btn_novo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(761, 140);
            // 
            // btn_novo
            // 
            this.btn_novo.Caption = "Novo";
            this.btn_novo.Id = 1;
            this.btn_novo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_novo.ImageOptions.Image")));
            this.btn_novo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_novo.ImageOptions.LargeImage")));
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_novo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Função";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // frm_list_funcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_funcao);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_list_funcao";
            this.Text = "frm_list_grupo_utilizador";
            this.Load += new System.EventHandler(this.frm_list_grupo_utilizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_permissoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_funcao;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn cod_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn nome_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn descricao_funcao;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_permissoes;
    }
}