namespace Projeto_Final
{
    partial class frm_list_cela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_cela));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_cela = new DevExpress.XtraGrid.GridControl();
            this.f = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_cela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_cela = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_bloco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).BeginInit();
            this.SuspendLayout();
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
            this.ribbonPage1.Text = "Cela";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_cela
            // 
            this.dgv_cela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cela.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_cela.Location = new System.Drawing.Point(0, 140);
            this.dgv_cela.MainView = this.f;
            this.dgv_cela.MenuManager = this.ribbonControl1;
            this.dgv_cela.Name = "dgv_cela";
            this.dgv_cela.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_cela.Size = new System.Drawing.Size(761, 302);
            this.dgv_cela.TabIndex = 1;
            this.dgv_cela.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.f});
            this.dgv_cela.Click += new System.EventHandler(this.dgv_cela_Click);
            // 
            // f
            // 
            this.f.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_cela,
            this.nome_cela,
            this.cod_bloco,
            this.created_at,
            this.Editar,
            this.Remover});
            this.f.GridControl = this.dgv_cela;
            this.f.Name = "f";
            this.f.OptionsFind.AlwaysVisible = true;
            this.f.OptionsFind.FindNullPrompt = "Insira o texto para pesquisar";
            this.f.OptionsFind.ShowFindButton = false;
            this.f.OptionsView.ShowFooter = true;
            this.f.OptionsView.ShowGroupPanel = false;
            // 
            // cod_cela
            // 
            this.cod_cela.Caption = "Código da Cela";
            this.cod_cela.FieldName = "cod_cela";
            this.cod_cela.Name = "cod_cela";
            this.cod_cela.Visible = true;
            this.cod_cela.VisibleIndex = 0;
            // 
            // nome_cela
            // 
            this.nome_cela.Caption = "Nome da Cela";
            this.nome_cela.FieldName = "nome_cela";
            this.nome_cela.Name = "nome_cela";
            this.nome_cela.Visible = true;
            this.nome_cela.VisibleIndex = 1;
            // 
            // cod_bloco
            // 
            this.cod_bloco.Caption = "Código do Bloco";
            this.cod_bloco.FieldName = "cod_bloco";
            this.cod_bloco.Name = "cod_bloco";
            this.cod_bloco.Visible = true;
            this.cod_bloco.VisibleIndex = 2;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 3;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 4;
            // 
            // rib_editar
            // 
            this.rib_editar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.rib_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
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
            this.Remover.VisibleIndex = 5;
            // 
            // rib_remover
            // 
            this.rib_remover.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.rib_remover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_remover.Name = "rib_remover";
            this.rib_remover.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_remover.Click += new System.EventHandler(this.rib_remover_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_list_cela
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_cela);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_list_cela";
            this.Text = "frm_list_cela";
            this.Load += new System.EventHandler(this.frm_list_cela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dgv_cela;
        private DevExpress.XtraGrid.Views.Grid.GridView f;
        private DevExpress.XtraGrid.Columns.GridColumn cod_cela;
        private DevExpress.XtraGrid.Columns.GridColumn nome_cela;
        private DevExpress.XtraGrid.Columns.GridColumn cod_bloco;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}