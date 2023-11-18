namespace Projeto_Final
{
    partial class frm_list_visita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_visita));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_visita = new DevExpress.XtraGrid.GridControl();
            this.gv_visita = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_visita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_visitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_processo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipo_visita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_visita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hora_visita = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_visita)).BeginInit();
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
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
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
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Visita";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_visita
            // 
            this.dgv_visita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_visita.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_visita.Location = new System.Drawing.Point(0, 140);
            this.dgv_visita.MainView = this.gv_visita;
            this.dgv_visita.MenuManager = this.ribbonControl1;
            this.dgv_visita.Name = "dgv_visita";
            this.dgv_visita.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_visita.Size = new System.Drawing.Size(761, 302);
            this.dgv_visita.TabIndex = 1;
            this.dgv_visita.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_visita});
            this.dgv_visita.Click += new System.EventHandler(this.dgv_visita_Click);
            // 
            // gv_visita
            // 
            this.gv_visita.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_visita,
            this.cod_visitante,
            this.cod_processo,
            this.tipo_visita,
            this.data_visita,
            this.hora_visita,
            this.Editar,
            this.Remover});
            this.gv_visita.GridControl = this.dgv_visita;
            this.gv_visita.Name = "gv_visita";
            this.gv_visita.OptionsView.ShowFooter = true;
            this.gv_visita.OptionsView.ShowGroupPanel = false;
            // 
            // cod_visita
            // 
            this.cod_visita.Caption = "Código";
            this.cod_visita.FieldName = "cod_visita";
            this.cod_visita.Name = "cod_visita";
            this.cod_visita.Visible = true;
            this.cod_visita.VisibleIndex = 0;
            // 
            // cod_visitante
            // 
            this.cod_visitante.Caption = "Visitante";
            this.cod_visitante.FieldName = "nome_visitante";
            this.cod_visitante.Name = "cod_visitante";
            this.cod_visitante.Visible = true;
            this.cod_visitante.VisibleIndex = 1;
            // 
            // cod_processo
            // 
            this.cod_processo.Caption = "Processo";
            this.cod_processo.FieldName = "num_processo";
            this.cod_processo.Name = "cod_processo";
            this.cod_processo.Visible = true;
            this.cod_processo.VisibleIndex = 2;
            // 
            // tipo_visita
            // 
            this.tipo_visita.Caption = "Tipo de Visita";
            this.tipo_visita.FieldName = "tipo_visita";
            this.tipo_visita.Name = "tipo_visita";
            this.tipo_visita.Visible = true;
            this.tipo_visita.VisibleIndex = 3;
            // 
            // data_visita
            // 
            this.data_visita.Caption = "Data de Visita";
            this.data_visita.FieldName = "data_visita";
            this.data_visita.Name = "data_visita";
            this.data_visita.Visible = true;
            this.data_visita.VisibleIndex = 4;
            // 
            // hora_visita
            // 
            this.hora_visita.Caption = "Hora da Visita";
            this.hora_visita.FieldName = "hora_visita";
            this.hora_visita.Name = "hora_visita";
            this.hora_visita.Visible = true;
            this.hora_visita.VisibleIndex = 5;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.FieldName = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 6;
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
            this.Remover.VisibleIndex = 7;
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
            // frm_list_visita
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_visita);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_list_visita";
            this.Text = "frm_list_visita";
            this.Load += new System.EventHandler(this.frm_list_visita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_visita)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgv_visita;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_visita;
        private DevExpress.XtraGrid.Columns.GridColumn cod_visita;
        private DevExpress.XtraGrid.Columns.GridColumn cod_visitante;
        private DevExpress.XtraGrid.Columns.GridColumn cod_processo;
        private DevExpress.XtraGrid.Columns.GridColumn tipo_visita;
        private DevExpress.XtraGrid.Columns.GridColumn data_visita;
        private DevExpress.XtraGrid.Columns.GridColumn hora_visita;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}