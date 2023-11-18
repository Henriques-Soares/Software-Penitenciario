namespace Projeto_Final
{
    partial class frm_list_enfermaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_enfermaria));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_enfermaria = new DevExpress.XtraGrid.GridControl();
            this.gv_enfermaria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_enfermagem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_processo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_utilizador = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enfermaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_enfermaria)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(725, 140);
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
            this.ribbonPage1.Text = "Enfermaria";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_enfermaria
            // 
            this.dgv_enfermaria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_enfermaria.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_enfermaria.Location = new System.Drawing.Point(0, 140);
            this.dgv_enfermaria.MainView = this.gv_enfermaria;
            this.dgv_enfermaria.MenuManager = this.ribbonControl1;
            this.dgv_enfermaria.Name = "dgv_enfermaria";
            this.dgv_enfermaria.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_enfermaria.Size = new System.Drawing.Size(725, 264);
            this.dgv_enfermaria.TabIndex = 1;
            this.dgv_enfermaria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_enfermaria});
            this.dgv_enfermaria.Click += new System.EventHandler(this.dgv_enfermaria_Click);
            // 
            // gv_enfermaria
            // 
            this.gv_enfermaria.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_enfermagem,
            this.cod_processo,
            this.cod_utilizador,
            this.descricao,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_enfermaria.GridControl = this.dgv_enfermaria;
            this.gv_enfermaria.Name = "gv_enfermaria";
            // 
            // cod_enfermagem
            // 
            this.cod_enfermagem.Caption = "Código";
            this.cod_enfermagem.FieldName = "cod_enfermagem";
            this.cod_enfermagem.Name = "cod_enfermagem";
            this.cod_enfermagem.Visible = true;
            this.cod_enfermagem.VisibleIndex = 0;
            // 
            // cod_processo
            // 
            this.cod_processo.Caption = "Código do Processo";
            this.cod_processo.FieldName = "cod_processo";
            this.cod_processo.Name = "cod_processo";
            this.cod_processo.Visible = true;
            this.cod_processo.VisibleIndex = 1;
            // 
            // cod_utilizador
            // 
            this.cod_utilizador.Caption = "Registado por";
            this.cod_utilizador.FieldName = "nome_utilizador";
            this.cod_utilizador.Name = "cod_utilizador";
            this.cod_utilizador.Visible = true;
            this.cod_utilizador.VisibleIndex = 2;
            // 
            // descricao
            // 
            this.descricao.Caption = "Descrição";
            this.descricao.FieldName = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.Visible = true;
            this.descricao.VisibleIndex = 3;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 4;
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
            this.Remover.VisibleIndex = 6;
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
            // frm_list_enfermaria
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 404);
            this.Controls.Add(this.dgv_enfermaria);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_list_enfermaria";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_list_enfermaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_enfermaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_enfermaria)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgv_enfermaria;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_enfermaria;
        private DevExpress.XtraGrid.Columns.GridColumn cod_enfermagem;
        private DevExpress.XtraGrid.Columns.GridColumn cod_processo;
        private DevExpress.XtraGrid.Columns.GridColumn cod_utilizador;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}