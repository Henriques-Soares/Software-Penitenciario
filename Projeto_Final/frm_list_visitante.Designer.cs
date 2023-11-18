namespace Projeto_Final
{
    partial class frm_list_visitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_visitante));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_visitante = new DevExpress.XtraGrid.GridControl();
            this.gv_visitante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_visitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_visitante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.genero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.naturalidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.residencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_visitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
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
            this.ribbonPage1.Text = "Visitante";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_visitante
            // 
            this.dgv_visitante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_visitante.Location = new System.Drawing.Point(0, 140);
            this.dgv_visitante.MainView = this.gv_visitante;
            this.dgv_visitante.MenuManager = this.ribbonControl1;
            this.dgv_visitante.Name = "dgv_visitante";
            this.dgv_visitante.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_visitante.Size = new System.Drawing.Size(761, 302);
            this.dgv_visitante.TabIndex = 1;
            this.dgv_visitante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_visitante});
            this.dgv_visitante.Click += new System.EventHandler(this.dgv_visitante_Click);
            // 
            // gv_visitante
            // 
            this.gv_visitante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_visitante,
            this.nome_visitante,
            this.data_nascimento,
            this.genero,
            this.bi,
            this.naturalidade,
            this.residencia,
            this.contacto,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_visitante.GridControl = this.dgv_visitante;
            this.gv_visitante.Name = "gv_visitante";
            // 
            // cod_visitante
            // 
            this.cod_visitante.Caption = "Código Visitante";
            this.cod_visitante.FieldName = "cod_visitante";
            this.cod_visitante.Name = "cod_visitante";
            this.cod_visitante.Visible = true;
            this.cod_visitante.VisibleIndex = 0;
            // 
            // nome_visitante
            // 
            this.nome_visitante.Caption = "Nome do Visitante";
            this.nome_visitante.FieldName = "nome_visitante";
            this.nome_visitante.Name = "nome_visitante";
            this.nome_visitante.Visible = true;
            this.nome_visitante.VisibleIndex = 1;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Caption = "Data de Nascimento";
            this.data_nascimento.FieldName = "data_nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Visible = true;
            this.data_nascimento.VisibleIndex = 2;
            // 
            // genero
            // 
            this.genero.Caption = "Género";
            this.genero.FieldName = "genero";
            this.genero.Name = "genero";
            this.genero.Visible = true;
            this.genero.VisibleIndex = 3;
            // 
            // bi
            // 
            this.bi.Caption = "bi";
            this.bi.FieldName = "bi";
            this.bi.Name = "bi";
            this.bi.Visible = true;
            this.bi.VisibleIndex = 4;
            // 
            // naturalidade
            // 
            this.naturalidade.Caption = "Naturalidade";
            this.naturalidade.FieldName = "naturalidade";
            this.naturalidade.Name = "naturalidade";
            this.naturalidade.Visible = true;
            this.naturalidade.VisibleIndex = 5;
            // 
            // residencia
            // 
            this.residencia.Caption = "Residência";
            this.residencia.FieldName = "residencia";
            this.residencia.Name = "residencia";
            this.residencia.Visible = true;
            this.residencia.VisibleIndex = 6;
            // 
            // contacto
            // 
            this.contacto.Caption = "Contacto";
            this.contacto.FieldName = "contacto";
            this.contacto.Name = "contacto";
            this.contacto.Visible = true;
            this.contacto.VisibleIndex = 7;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 8;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 9;
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
            this.Remover.VisibleIndex = 10;
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
            // frm_list_visitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_visitante);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_list_visitante";
            this.Text = "frm_list_visitante";
            this.Load += new System.EventHandler(this.frm_list_visitante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_visitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl dgv_visitante;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_visitante;
        private DevExpress.XtraGrid.Columns.GridColumn cod_visitante;
        private DevExpress.XtraGrid.Columns.GridColumn nome_visitante;
        private DevExpress.XtraGrid.Columns.GridColumn data_nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn genero;
        private DevExpress.XtraGrid.Columns.GridColumn bi;
        private DevExpress.XtraGrid.Columns.GridColumn naturalidade;
        private DevExpress.XtraGrid.Columns.GridColumn residencia;
        private DevExpress.XtraGrid.Columns.GridColumn contacto;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
    }
}