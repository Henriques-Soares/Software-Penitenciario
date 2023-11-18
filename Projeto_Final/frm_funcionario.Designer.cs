namespace Projeto_Final
{
    partial class frm_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_funcionario));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_funcionario = new DevExpress.XtraGrid.GridControl();
            this.gv_funcionario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cod_tipo_funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_funcionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.genero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_pai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_mae = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_provincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.residencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado_civil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.altura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.img = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tel1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcionario)).BeginInit();
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
            this.btn_novo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_novo_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Funcionário";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.Glyph")));
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_funcionario.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            gridLevelNode1.RelationName = "Level1";
            this.dgv_funcionario.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_funcionario.Location = new System.Drawing.Point(0, 140);
            this.dgv_funcionario.MainView = this.gv_funcionario;
            this.dgv_funcionario.MenuManager = this.ribbonControl1;
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_funcionario.Size = new System.Drawing.Size(761, 302);
            this.dgv_funcionario.TabIndex = 1;
            this.dgv_funcionario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_funcionario});
            this.dgv_funcionario.Click += new System.EventHandler(this.dgv_funcionario_Click);
            // 
            // gv_funcionario
            // 
            this.gv_funcionario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_funcionario,
            this.cod_tipo_funcionario,
            this.nome_funcionario,
            this.data_nascimento,
            this.genero,
            this.bi,
            this.nome_pai,
            this.nome_mae,
            this.nome_provincia,
            this.residencia,
            this.estado_civil,
            this.altura,
            this.img,
            this.nip,
            this.tel1,
            this.tel2,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_funcionario.GridControl = this.dgv_funcionario;
            this.gv_funcionario.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gv_funcionario.Name = "gv_funcionario";
            this.gv_funcionario.OptionsFind.AlwaysVisible = true;
            this.gv_funcionario.OptionsFind.FindNullPrompt = "Informe o valor para pesquisar";
            this.gv_funcionario.OptionsFind.ShowFindButton = false;
            this.gv_funcionario.OptionsView.ShowFooter = true;
            this.gv_funcionario.OptionsView.ShowGroupPanel = false;
            // 
            // cod_funcionario
            // 
            this.cod_funcionario.Caption = "Código";
            this.cod_funcionario.FieldName = "cod_funcionario";
            this.cod_funcionario.Name = "cod_funcionario";
            this.cod_funcionario.OptionsColumn.AllowEdit = false;
            this.cod_funcionario.Visible = true;
            this.cod_funcionario.VisibleIndex = 0;
            // 
            // cod_tipo_funcionario
            // 
            this.cod_tipo_funcionario.Caption = "Tipo de  Funcionário";
            this.cod_tipo_funcionario.FieldName = "nome_tipo_funcionario";
            this.cod_tipo_funcionario.Name = "cod_tipo_funcionario";
            this.cod_tipo_funcionario.OptionsColumn.AllowEdit = false;
            this.cod_tipo_funcionario.Visible = true;
            this.cod_tipo_funcionario.VisibleIndex = 1;
            // 
            // nome_funcionario
            // 
            this.nome_funcionario.Caption = "Nome do Funcionario";
            this.nome_funcionario.FieldName = "nome_funcionario";
            this.nome_funcionario.Name = "nome_funcionario";
            this.nome_funcionario.OptionsColumn.AllowEdit = false;
            this.nome_funcionario.Visible = true;
            this.nome_funcionario.VisibleIndex = 2;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Caption = "Data de Nascimento";
            this.data_nascimento.FieldName = "data_nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.OptionsColumn.AllowEdit = false;
            this.data_nascimento.Visible = true;
            this.data_nascimento.VisibleIndex = 3;
            // 
            // genero
            // 
            this.genero.Caption = "Genero";
            this.genero.FieldName = "genero";
            this.genero.Name = "genero";
            this.genero.OptionsColumn.AllowEdit = false;
            this.genero.Visible = true;
            this.genero.VisibleIndex = 4;
            // 
            // bi
            // 
            this.bi.Caption = "BI";
            this.bi.FieldName = "bi";
            this.bi.Name = "bi";
            this.bi.OptionsColumn.AllowEdit = false;
            this.bi.Visible = true;
            this.bi.VisibleIndex = 5;
            // 
            // nome_pai
            // 
            this.nome_pai.Caption = "Nome do pai";
            this.nome_pai.FieldName = "nome_pai";
            this.nome_pai.Name = "nome_pai";
            this.nome_pai.OptionsColumn.AllowEdit = false;
            this.nome_pai.Visible = true;
            this.nome_pai.VisibleIndex = 6;
            // 
            // nome_mae
            // 
            this.nome_mae.Caption = "Nome da mãe";
            this.nome_mae.FieldName = "nome_mae";
            this.nome_mae.Name = "nome_mae";
            this.nome_mae.OptionsColumn.AllowEdit = false;
            this.nome_mae.Visible = true;
            this.nome_mae.VisibleIndex = 7;
            // 
            // nome_provincia
            // 
            this.nome_provincia.Caption = "Provincia";
            this.nome_provincia.FieldName = "nome_provincia";
            this.nome_provincia.Name = "nome_provincia";
            this.nome_provincia.OptionsColumn.AllowEdit = false;
            this.nome_provincia.Visible = true;
            this.nome_provincia.VisibleIndex = 8;
            // 
            // residencia
            // 
            this.residencia.Caption = "Residencia";
            this.residencia.FieldName = "residencia";
            this.residencia.Name = "residencia";
            this.residencia.OptionsColumn.AllowEdit = false;
            this.residencia.Visible = true;
            this.residencia.VisibleIndex = 9;
            // 
            // estado_civil
            // 
            this.estado_civil.Caption = "Estado Civil";
            this.estado_civil.FieldName = "estado_civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.OptionsColumn.AllowEdit = false;
            this.estado_civil.Visible = true;
            this.estado_civil.VisibleIndex = 10;
            // 
            // altura
            // 
            this.altura.Caption = "Altura";
            this.altura.FieldName = "altura";
            this.altura.Name = "altura";
            this.altura.OptionsColumn.AllowEdit = false;
            this.altura.Visible = true;
            this.altura.VisibleIndex = 11;
            // 
            // img
            // 
            this.img.Caption = "Imagem";
            this.img.FieldName = "img";
            this.img.Name = "img";
            this.img.OptionsColumn.AllowEdit = false;
            // 
            // nip
            // 
            this.nip.Caption = "NIP";
            this.nip.FieldName = "nip";
            this.nip.Name = "nip";
            this.nip.OptionsColumn.AllowEdit = false;
            this.nip.Visible = true;
            this.nip.VisibleIndex = 12;
            // 
            // tel1
            // 
            this.tel1.Caption = "Telefone1";
            this.tel1.FieldName = "tel1";
            this.tel1.Name = "tel1";
            this.tel1.OptionsColumn.AllowEdit = false;
            this.tel1.Visible = true;
            this.tel1.VisibleIndex = 13;
            // 
            // tel2
            // 
            this.tel2.Caption = "Telefone2";
            this.tel2.FieldName = "tel2";
            this.tel2.Name = "tel2";
            this.tel2.OptionsColumn.AllowEdit = false;
            this.tel2.Visible = true;
            this.tel2.VisibleIndex = 14;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.OptionsColumn.AllowEdit = false;
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 15;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 16;
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
            this.Remover.VisibleIndex = 17;
            // 
            // rib_remover
            // 
            this.rib_remover.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.rib_remover.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_remover.Name = "rib_remover";
            this.rib_remover.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // frm_funcionario
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_funcionario";
            this.Text = "S";
            this.Load += new System.EventHandler(this.frm_funcionario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_funcionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rib_remover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btn_novo;
        private DevExpress.XtraGrid.GridControl dgv_funcionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn cod_funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn cod_tipo_funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn nome_funcionario;
        private DevExpress.XtraGrid.Columns.GridColumn data_nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn genero;
        private DevExpress.XtraGrid.Columns.GridColumn bi;
        private DevExpress.XtraGrid.Columns.GridColumn nome_pai;
        private DevExpress.XtraGrid.Columns.GridColumn nome_mae;
        private DevExpress.XtraGrid.Columns.GridColumn nome_provincia;
        private DevExpress.XtraGrid.Columns.GridColumn residencia;
        private DevExpress.XtraGrid.Columns.GridColumn estado_civil;
        private DevExpress.XtraGrid.Columns.GridColumn altura;
        private DevExpress.XtraGrid.Columns.GridColumn img;
        private DevExpress.XtraGrid.Columns.GridColumn nip;
        private DevExpress.XtraGrid.Columns.GridColumn tel1;
        private DevExpress.XtraGrid.Columns.GridColumn tel2;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}