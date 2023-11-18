namespace Projeto_Final
{
    partial class frm_list_processo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_processo));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_processo = new DevExpress.XtraGrid.GridControl();
            this.gv_processo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_processo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.num_processo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.apenado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Soltura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_soltura = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_processo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_soltura)).BeginInit();
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
            this.btn_novo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Processo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // dgv_processo
            // 
            this.dgv_processo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_processo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.dgv_processo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.dgv_processo.Location = new System.Drawing.Point(0, 140);
            this.dgv_processo.MainView = this.gv_processo;
            this.dgv_processo.MenuManager = this.ribbonControl1;
            this.dgv_processo.Name = "dgv_processo";
            this.dgv_processo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_soltura,
            this.rib_remover});
            this.dgv_processo.Size = new System.Drawing.Size(761, 302);
            this.dgv_processo.TabIndex = 1;
            this.dgv_processo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_processo});
            this.dgv_processo.Load += new System.EventHandler(this.dgv_processo_Load);
            this.dgv_processo.Click += new System.EventHandler(this.dgv_processo_Click);
            // 
            // gv_processo
            // 
            this.gv_processo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_processo,
            this.num_processo,
            this.apenado,
            this.gridColumn2,
            this.descricao,
            this.gridColumn1,
            this.created_at,
            this.Soltura,
            this.Remover});
            this.gv_processo.GridControl = this.dgv_processo;
            this.gv_processo.Name = "gv_processo";
            // 
            // cod_processo
            // 
            this.cod_processo.Caption = "Código";
            this.cod_processo.FieldName = "cod_processo";
            this.cod_processo.Name = "cod_processo";
            this.cod_processo.Visible = true;
            this.cod_processo.VisibleIndex = 0;
            // 
            // num_processo
            // 
            this.num_processo.Caption = "Número de Processo";
            this.num_processo.FieldName = "num_processo";
            this.num_processo.Name = "num_processo";
            this.num_processo.Visible = true;
            this.num_processo.VisibleIndex = 1;
            // 
            // apenado
            // 
            this.apenado.Caption = "Apenado";
            this.apenado.FieldName = "nome_apenado";
            this.apenado.Name = "apenado";
            this.apenado.Visible = true;
            this.apenado.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cama";
            this.gridColumn2.FieldName = "numero_cama";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // descricao
            // 
            this.descricao.Caption = "Descrição";
            this.descricao.FieldName = "descricao";
            this.descricao.Name = "descricao";
            this.descricao.Visible = true;
            this.descricao.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Estado";
            this.gridColumn1.FieldName = "estado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 6;
            // 
            // Soltura
            // 
            this.Soltura.Caption = "Soltura";
            this.Soltura.ColumnEdit = this.rib_soltura;
            this.Soltura.Name = "Soltura";
            this.Soltura.Visible = true;
            this.Soltura.VisibleIndex = 7;
            // 
            // rib_soltura
            // 
            this.rib_soltura.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.rib_soltura.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_soltura.Name = "rib_soltura";
            this.rib_soltura.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_soltura.Click += new System.EventHandler(this.rib_editar_Click);
            // 
            // Remover
            // 
            this.Remover.Caption = "Remover";
            this.Remover.ColumnEdit = this.rib_remover;
            this.Remover.Name = "Remover";
            this.Remover.Visible = true;
            this.Remover.VisibleIndex = 8;
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
            // frm_list_processo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_processo);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_list_processo";
            this.Text = "frm_processo";
            this.Load += new System.EventHandler(this.frm_list_processo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_processo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_processo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_soltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraGrid.GridControl dgv_processo;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_processo;
        private DevExpress.XtraGrid.Columns.GridColumn cod_processo;
        private DevExpress.XtraGrid.Columns.GridColumn num_processo;
        private DevExpress.XtraGrid.Columns.GridColumn apenado;
        private DevExpress.XtraGrid.Columns.GridColumn descricao;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Soltura;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_soltura;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}