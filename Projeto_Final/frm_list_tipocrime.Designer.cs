namespace Projeto_Final
{
    partial class frm_list_tipocrime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_list_tipocrime));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_novo = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dgv_tipo_crime = new DevExpress.XtraGrid.GridControl();
            this.gv_tipo_crime = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cod_tipo_crime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nome_tipo_crime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.created_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Editar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_editar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Remover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rib_remover = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_crime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tipo_crime)).BeginInit();
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
            this.ribbonPage1.Text = "Tipo de Crime";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_novo);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // dgv_tipo_crime
            // 
            this.dgv_tipo_crime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tipo_crime.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.dgv_tipo_crime.Location = new System.Drawing.Point(0, 140);
            this.dgv_tipo_crime.MainView = this.gv_tipo_crime;
            this.dgv_tipo_crime.MenuManager = this.ribbonControl1;
            this.dgv_tipo_crime.Name = "dgv_tipo_crime";
            this.dgv_tipo_crime.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rib_editar,
            this.rib_remover});
            this.dgv_tipo_crime.Size = new System.Drawing.Size(761, 302);
            this.dgv_tipo_crime.TabIndex = 1;
            this.dgv_tipo_crime.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_tipo_crime});
            this.dgv_tipo_crime.Click += new System.EventHandler(this.dgv_tipo_crime_Click);
            // 
            // gv_tipo_crime
            // 
            this.gv_tipo_crime.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cod_tipo_crime,
            this.Nome_tipo_crime,
            this.created_at,
            this.Editar,
            this.Remover});
            this.gv_tipo_crime.GridControl = this.dgv_tipo_crime;
            this.gv_tipo_crime.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gv_tipo_crime.Name = "gv_tipo_crime";
            this.gv_tipo_crime.OptionsFind.AlwaysVisible = true;
            this.gv_tipo_crime.OptionsFind.FindNullPrompt = "Insira o texto para pesquisar";
            this.gv_tipo_crime.OptionsFind.ShowFindButton = false;
            this.gv_tipo_crime.OptionsView.ShowFooter = true;
            this.gv_tipo_crime.OptionsView.ShowGroupPanel = false;
            // 
            // cod_tipo_crime
            // 
            this.cod_tipo_crime.Caption = "Código";
            this.cod_tipo_crime.FieldName = "cod_tipo_crime";
            this.cod_tipo_crime.Name = "cod_tipo_crime";
            this.cod_tipo_crime.Visible = true;
            this.cod_tipo_crime.VisibleIndex = 0;
            // 
            // Nome_tipo_crime
            // 
            this.Nome_tipo_crime.Caption = "Nome do Tipo de Crime";
            this.Nome_tipo_crime.FieldName = "nome_tipo_crime";
            this.Nome_tipo_crime.Name = "Nome_tipo_crime";
            this.Nome_tipo_crime.Visible = true;
            this.Nome_tipo_crime.VisibleIndex = 1;
            // 
            // created_at
            // 
            this.created_at.Caption = "Data de Registo";
            this.created_at.FieldName = "created_at";
            this.created_at.Name = "created_at";
            this.created_at.Visible = true;
            this.created_at.VisibleIndex = 2;
            // 
            // Editar
            // 
            this.Editar.Caption = "Editar";
            this.Editar.ColumnEdit = this.rib_editar;
            this.Editar.Name = "Editar";
            this.Editar.Visible = true;
            this.Editar.VisibleIndex = 3;
            // 
            // rib_editar
            // 
            this.rib_editar.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.rib_editar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.rib_editar.Name = "rib_editar";
            this.rib_editar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.rib_editar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.rib_editar_ButtonClick);
            // 
            // Remover
            // 
            this.Remover.Caption = "Remover";
            this.Remover.ColumnEdit = this.rib_remover;
            this.Remover.Name = "Remover";
            this.Remover.Visible = true;
            this.Remover.VisibleIndex = 4;
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
            // frm_list_tipocrime
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 442);
            this.Controls.Add(this.dgv_tipo_crime);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frm_list_tipocrime";
            this.Text = "frm_list_tipocrime";
            this.Load += new System.EventHandler(this.frm_list_tipocrime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tipo_crime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_tipo_crime)).EndInit();
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
        private DevExpress.XtraGrid.GridControl dgv_tipo_crime;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_tipo_crime;
        private DevExpress.XtraGrid.Columns.GridColumn cod_tipo_crime;
        private DevExpress.XtraGrid.Columns.GridColumn Nome_tipo_crime;
        private DevExpress.XtraGrid.Columns.GridColumn created_at;
        private DevExpress.XtraGrid.Columns.GridColumn Editar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_editar;
        private DevExpress.XtraGrid.Columns.GridColumn Remover;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit rib_remover;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}