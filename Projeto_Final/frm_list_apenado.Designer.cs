namespace Projeto_Final
{
    partial class frm_list_apenado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_apenado));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_apenado = new DevExpress.XtraGrid.GridControl();
            this.gv_apenado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_apenado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_apenado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.data_nascimento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.genero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_pai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nome_mae = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cod_provincia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.naturalidade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.residencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.estado_civil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.altura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.img = new DevExpress.XtraGrid.Columns.GridColumn();
            this.apelido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descricao_apenado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apenado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_apenado)).BeginInit();
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
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Apenado";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_apenado
            // 
            this.dgv_apenado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_apenado.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            gridLevelNode1.RelationName = "Level1";
            this.dgv_apenado.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgv_apenado.Location = new System.Drawing.Point(0, 140);
            this.dgv_apenado.MainView = this.gv_apenado;
            this.dgv_apenado.MenuManager = this.ribbonControl1;
            this.dgv_apenado.Name = "dgv_apenado";
            this.dgv_apenado.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_apenado.Size = new System.Drawing.Size(761, 302);
            this.dgv_apenado.TabIndex = 1;
            this.dgv_apenado.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_apenado});
            this.dgv_apenado.Click += new System.EventHandler(this.dgv_apenado_Click);
            // 
            // gv_apenado
            // 
            this.gv_apenado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_apenado,
            this.nome_apenado,
            this.data_nascimento,
            this.genero,
            this.bi,
            this.nome_pai,
            this.nome_mae,
            this.Cod_provincia,
            this.naturalidade,
            this.residencia,
            this.estado_civil,
            this.altura,
            this.img,
            this.apelido,
            this.descricao_apenado,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_apenado.GridControl = this.dgv_apenado;
            this.gv_apenado.Name = "gv_apenado";
            this.gv_apenado.OptionsView.ShowFooter = true;
            this.gv_apenado.OptionsView.ShowGroupPanel = false;
            // 
            // cod_apenado
            // 
            this.cod_apenado.Caption = "Código";
            this.cod_apenado.FieldName = "cod_apenado";
            this.cod_apenado.Name = "cod_apenado";
            this.cod_apenado.Visible = true;
            this.cod_apenado.VisibleIndex = 0;
            this.cod_apenado.Width = 40;
            // 
            // nome_apenado
            // 
            this.nome_apenado.Caption = "Nome do Apenado";
            this.nome_apenado.FieldName = "nome_apenado";
            this.nome_apenado.Name = "nome_apenado";
            this.nome_apenado.Visible = true;
            this.nome_apenado.VisibleIndex = 1;
            this.nome_apenado.Width = 40;
            // 
            // data_nascimento
            // 
            this.data_nascimento.Caption = "Data de Nascimento";
            this.data_nascimento.FieldName = "data_nascimento";
            this.data_nascimento.Name = "data_nascimento";
            this.data_nascimento.Visible = true;
            this.data_nascimento.VisibleIndex = 2;
            this.data_nascimento.Width = 40;
            // 
            // genero
            // 
            this.genero.Caption = "Genero";
            this.genero.FieldName = "genero";
            this.genero.Name = "genero";
            this.genero.Visible = true;
            this.genero.VisibleIndex = 3;
            this.genero.Width = 40;
            // 
            // bi
            // 
            this.bi.Caption = "BI";
            this.bi.FieldName = "bi";
            this.bi.Name = "bi";
            this.bi.Visible = true;
            this.bi.VisibleIndex = 4;
            this.bi.Width = 40;
            // 
            // nome_pai
            // 
            this.nome_pai.Caption = "Nome do Pai";
            this.nome_pai.FieldName = "nome_pai";
            this.nome_pai.Name = "nome_pai";
            this.nome_pai.Visible = true;
            this.nome_pai.VisibleIndex = 5;
            this.nome_pai.Width = 28;
            // 
            // nome_mae
            // 
            this.nome_mae.Caption = "Nome da mãe";
            this.nome_mae.FieldName = "nome_pai";
            this.nome_mae.Name = "nome_mae";
            this.nome_mae.Visible = true;
            this.nome_mae.VisibleIndex = 6;
            this.nome_mae.Width = 40;
            // 
            // Cod_provincia
            // 
            this.Cod_provincia.Caption = "Província";
            this.Cod_provincia.FieldName = "nome_provincia";
            this.Cod_provincia.Name = "Cod_provincia";
            this.Cod_provincia.Visible = true;
            this.Cod_provincia.VisibleIndex = 7;
            this.Cod_provincia.Width = 28;
            // 
            // naturalidade
            // 
            this.naturalidade.Caption = "Naturalidade";
            this.naturalidade.FieldName = "naturalidade";
            this.naturalidade.Name = "naturalidade";
            this.naturalidade.Visible = true;
            this.naturalidade.VisibleIndex = 8;
            this.naturalidade.Width = 40;
            // 
            // residencia
            // 
            this.residencia.Caption = "Residência";
            this.residencia.FieldName = "residencia";
            this.residencia.Name = "residencia";
            this.residencia.Visible = true;
            this.residencia.VisibleIndex = 9;
            this.residencia.Width = 40;
            // 
            // estado_civil
            // 
            this.estado_civil.Caption = "Estado Civil";
            this.estado_civil.FieldName = "estado_civil";
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.Visible = true;
            this.estado_civil.VisibleIndex = 10;
            this.estado_civil.Width = 40;
            // 
            // altura
            // 
            this.altura.Caption = "Altura";
            this.altura.FieldName = "altura";
            this.altura.Name = "altura";
            this.altura.Visible = true;
            this.altura.VisibleIndex = 11;
            this.altura.Width = 40;
            // 
            // img
            // 
            this.img.Caption = "Imagem";
            this.img.FieldName = "img";
            this.img.Name = "img";
            this.img.Visible = true;
            this.img.VisibleIndex = 12;
            this.img.Width = 40;
            // 
            // apelido
            // 
            this.apelido.Caption = "Apelido";
            this.apelido.FieldName = "apelido";
            this.apelido.Name = "apelido";
            this.apelido.Visible = true;
            this.apelido.VisibleIndex = 13;
            this.apelido.Width = 39;
            // 
            // descricao_apenado
            // 
            this.descricao_apenado.Caption = "Descrição do Apenado";
            this.descricao_apenado.FieldName = "descricao_apenado";
            this.descricao_apenado.Name = "descricao_apenado";
            this.descricao_apenado.Visible = true;
            this.descricao_apenado.VisibleIndex = 14;
            this.descricao_apenado.Width = 46;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 15;
            this.created_at.Width = 37;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 16;
            this.Editar.Width = 34;
            // 
            // rib_editar
            // 
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
            this.Remover.Width = 72;
            // 
            // rib_remover
            // 
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
            // frm_list_apenado
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_apenado);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_list_apenado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_list_apenado";
            this.Load += new System.EventHandler(this.frm_list_apenado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_apenado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_apenado)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgv_apenado;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_apenado;
        private DevExpress.XtraGrid.Columns.GridColumn cod_apenado;
        private DevExpress.XtraGrid.Columns.GridColumn nome_apenado;
        private DevExpress.XtraGrid.Columns.GridColumn data_nascimento;
        private DevExpress.XtraGrid.Columns.GridColumn genero;
        private DevExpress.XtraGrid.Columns.GridColumn bi;
        private DevExpress.XtraGrid.Columns.GridColumn nome_pai;
        private DevExpress.XtraGrid.Columns.GridColumn nome_mae;
        private DevExpress.XtraGrid.Columns.GridColumn Cod_provincia;
        private DevExpress.XtraGrid.Columns.GridColumn naturalidade;
        private DevExpress.XtraGrid.Columns.GridColumn residencia;
        private DevExpress.XtraGrid.Columns.GridColumn estado_civil;
        private DevExpress.XtraGrid.Columns.GridColumn altura;
        private DevExpress.XtraGrid.Columns.GridColumn img;
        private DevExpress.XtraGrid.Columns.GridColumn apelido;
        private DevExpress.XtraGrid.Columns.GridColumn descricao_apenado;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}