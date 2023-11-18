namespace Projeto_Final
{
    partial class frm_list_refeitorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_refeitorio));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_refeitorio = new DevExpress.XtraGrid.GridControl();
            this.gv_refeitorio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_refeitorio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_processo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_alimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_refereicao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_refeitorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_refeitorio)).BeginInit();
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
            this.ribbonPage1.Text = "Refeitório";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_refeitorio
            // 
            this.dgv_refeitorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_refeitorio.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_refeitorio.Location = new System.Drawing.Point(0, 140);
            this.dgv_refeitorio.MainView = this.gv_refeitorio;
            this.dgv_refeitorio.MenuManager = this.ribbonControl1;
            this.dgv_refeitorio.Name = "dgv_refeitorio";
            this.dgv_refeitorio.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_refeitorio.Size = new System.Drawing.Size(761, 302);
            this.dgv_refeitorio.TabIndex = 1;
            this.dgv_refeitorio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_refeitorio});
            this.dgv_refeitorio.Click += new System.EventHandler(this.dgv_refeitorio_Click);
            // 
            // gv_refeitorio
            // 
            this.gv_refeitorio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_refeitorio,
            this.cod_processo,
            this.cod_alimento,
            this.tipo_refereicao,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_refeitorio.GridControl = this.dgv_refeitorio;
            this.gv_refeitorio.Name = "gv_refeitorio";
            this.gv_refeitorio.OptionsView.ShowFooter = true;
            this.gv_refeitorio.OptionsView.ShowGroupPanel = false;
            // 
            // cod_refeitorio
            // 
            this.cod_refeitorio.Caption = "Código";
            this.cod_refeitorio.FieldName = "cod_refeitorio";
            this.cod_refeitorio.Name = "cod_refeitorio";
            this.cod_refeitorio.Visible = true;
            this.cod_refeitorio.VisibleIndex = 0;
            // 
            // cod_processo
            // 
            this.cod_processo.Caption = "Código do Processo";
            this.cod_processo.FieldName = "cod_processo";
            this.cod_processo.Name = "cod_processo";
            this.cod_processo.Visible = true;
            this.cod_processo.VisibleIndex = 1;
            // 
            // cod_alimento
            // 
            this.cod_alimento.Caption = "Código do Alimento";
            this.cod_alimento.FieldName = "cod_alimento";
            this.cod_alimento.Name = "cod_alimento";
            this.cod_alimento.Visible = true;
            this.cod_alimento.VisibleIndex = 2;
            // 
            // tipo_refereicao
            // 
            this.tipo_refereicao.Caption = "Tipo de Refeição";
            this.tipo_refereicao.FieldName = "tipo_refereicao";
            this.tipo_refereicao.Name = "tipo_refereicao";
            this.tipo_refereicao.Visible = true;
            this.tipo_refereicao.VisibleIndex = 3;
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
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.rib_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions3, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
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
            editorButtonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions4.Image")));
            this.rib_remover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions4, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_remover.Name = "rib_remover";
            this.rib_remover.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_remover.Click += new System.EventHandler(this.rib_remover_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_list_refeitorio
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_refeitorio);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_list_refeitorio";
            this.Text = "frm_list_refeitorio";
            this.Load += new System.EventHandler(this.frm_list_refeitorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_refeitorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_refeitorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraGrid.GridControl dgv_refeitorio;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_refeitorio;
        private DevExpress.XtraGrid.Columns.GridColumn cod_refeitorio;
        private DevExpress.XtraGrid.Columns.GridColumn cod_processo;
        private DevExpress.XtraGrid.Columns.GridColumn cod_alimento;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_refereicao;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}