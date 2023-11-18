namespace Projeto_Final
{
    partial class frm_cad_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cad_funcionario));
            this.lb_nome_funcionario = new DevExpress.XtraEditors.LabelControl();
            this.txt_nome = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cb_genero = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_bi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_nomedoPai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Txt_nomedaMae = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_residencia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cb_estadoCivil = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_altura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tel1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tel2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_nip = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.dtp_data_nascimento = new DevExpress.XtraEditors.DateEdit();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_tipo_funcionario = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbo_provincia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_salvar = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_genero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nomedoPai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_nomedaMae.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_residencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_estadoCivil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_altura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_data_nascimento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_data_nascimento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tipo_funcionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_provincia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome_funcionario
            // 
            this.lb_nome_funcionario.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.lb_nome_funcionario.Appearance.Options.UseFont = true;
            this.lb_nome_funcionario.Location = new System.Drawing.Point(20, 26);
            this.lb_nome_funcionario.Name = "lb_nome_funcionario";
            this.lb_nome_funcionario.Size = new System.Drawing.Size(176, 22);
            this.lb_nome_funcionario.TabIndex = 0;
            this.lb_nome_funcionario.Text = "Nome do funcionário:";
            this.lb_nome_funcionario.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(20, 54);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_nome.Properties.Appearance.Options.UseFont = true;
            this.txt_nome.Size = new System.Drawing.Size(217, 28);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nome_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(20, 88);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 22);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Data Nascimento:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(258, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 22);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Género:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // cb_genero
            // 
            this.cb_genero.EditValue = "";
            this.cb_genero.Location = new System.Drawing.Point(258, 178);
            this.cb_genero.Name = "cb_genero";
            this.cb_genero.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_genero.Properties.Appearance.Options.UseFont = true;
            this.cb_genero.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_genero.Properties.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cb_genero.Size = new System.Drawing.Size(217, 28);
            this.cb_genero.TabIndex = 6;
            // 
            // txt_bi
            // 
            this.txt_bi.Location = new System.Drawing.Point(258, 240);
            this.txt_bi.Name = "txt_bi";
            this.txt_bi.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_bi.Properties.Appearance.Options.UseFont = true;
            this.txt_bi.Properties.MaxLength = 14;
            this.txt_bi.Size = new System.Drawing.Size(217, 28);
            this.txt_bi.TabIndex = 8;
            this.txt_bi.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(258, 212);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 22);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Bi:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // txt_nomedoPai
            // 
            this.txt_nomedoPai.Location = new System.Drawing.Point(19, 240);
            this.txt_nomedoPai.Name = "txt_nomedoPai";
            this.txt_nomedoPai.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_nomedoPai.Properties.Appearance.Options.UseFont = true;
            this.txt_nomedoPai.Size = new System.Drawing.Size(225, 28);
            this.txt_nomedoPai.TabIndex = 10;
            this.txt_nomedoPai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomedoPai_KeyPress);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 212);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(107, 22);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Nome do Pai:";
            // 
            // Txt_nomedaMae
            // 
            this.Txt_nomedaMae.Location = new System.Drawing.Point(19, 302);
            this.Txt_nomedaMae.Name = "Txt_nomedaMae";
            this.Txt_nomedaMae.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.Txt_nomedaMae.Properties.Appearance.Options.UseFont = true;
            this.Txt_nomedaMae.Size = new System.Drawing.Size(225, 28);
            this.Txt_nomedaMae.TabIndex = 12;
            this.Txt_nomedaMae.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_nomedaMae_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(20, 274);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 22);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Nome da Mãe:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(19, 150);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(111, 22);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Naturalidade:";
            // 
            // txt_residencia
            // 
            this.txt_residencia.Location = new System.Drawing.Point(258, 116);
            this.txt_residencia.Name = "txt_residencia";
            this.txt_residencia.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_residencia.Properties.Appearance.Options.UseFont = true;
            this.txt_residencia.Size = new System.Drawing.Size(217, 28);
            this.txt_residencia.TabIndex = 16;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(258, 88);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 22);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Residência:";
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.EditValue = "";
            this.cb_estadoCivil.Location = new System.Drawing.Point(258, 54);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadoCivil.Properties.Appearance.Options.UseFont = true;
            this.cb_estadoCivil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_estadoCivil.Properties.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "Viuvo(a)",
            "Uniao de facto"});
            this.cb_estadoCivil.Size = new System.Drawing.Size(217, 28);
            this.cb_estadoCivil.TabIndex = 18;
            this.cb_estadoCivil.SelectedIndexChanged += new System.EventHandler(this.cb_estadoCivil_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(258, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 22);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Estado Civil:";
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(258, 302);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_altura.Properties.Appearance.Options.UseFont = true;
            this.txt_altura.Properties.MaxLength = 4;
            this.txt_altura.Size = new System.Drawing.Size(217, 28);
            this.txt_altura.TabIndex = 20;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(258, 274);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(56, 22);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Altura:";
            // 
            // txt_tel1
            // 
            this.txt_tel1.Location = new System.Drawing.Point(492, 178);
            this.txt_tel1.Name = "txt_tel1";
            this.txt_tel1.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_tel1.Properties.Appearance.Options.UseFont = true;
            this.txt_tel1.Properties.MaxLength = 9;
            this.txt_tel1.Size = new System.Drawing.Size(217, 28);
            this.txt_tel1.TabIndex = 22;
            this.txt_tel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel1_KeyPress);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(492, 150);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(41, 22);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Tel1:";
            // 
            // txt_tel2
            // 
            this.txt_tel2.Location = new System.Drawing.Point(492, 240);
            this.txt_tel2.Name = "txt_tel2";
            this.txt_tel2.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_tel2.Properties.Appearance.Options.UseFont = true;
            this.txt_tel2.Properties.MaxLength = 9;
            this.txt_tel2.Size = new System.Drawing.Size(217, 28);
            this.txt_tel2.TabIndex = 24;
            this.txt_tel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel2_KeyPress);
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(492, 212);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(41, 22);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Tel2:";
            // 
            // txt_nip
            // 
            this.txt_nip.Location = new System.Drawing.Point(492, 116);
            this.txt_nip.Name = "txt_nip";
            this.txt_nip.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.txt_nip.Properties.Appearance.Options.UseFont = true;
            this.txt_nip.Properties.MaxLength = 8;
            this.txt_nip.Size = new System.Drawing.Size(217, 28);
            this.txt_nip.TabIndex = 26;
            this.txt_nip.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.txt_nip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nip_KeyPress);
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(492, 88);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(35, 22);
            this.labelControl12.TabIndex = 25;
            this.labelControl12.Text = "NIP:";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(740, 184);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(152, 22);
            this.labelControl13.TabIndex = 27;
            this.labelControl13.Text = "Selecionar Imagem";
            this.labelControl13.Click += new System.EventHandler(this.labelControl13_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(19, 12);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(181, 22);
            this.labelControl14.TabIndex = 29;
            this.labelControl14.Text = "Cadastrar Funcionário";
            // 
            // dtp_data_nascimento
            // 
            this.dtp_data_nascimento.EditValue = new System.DateTime(2022, 6, 13, 0, 0, 0, 0);
            this.dtp_data_nascimento.Location = new System.Drawing.Point(20, 116);
            this.dtp_data_nascimento.Name = "dtp_data_nascimento";
            this.dtp_data_nascimento.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data_nascimento.Properties.Appearance.Options.UseFont = true;
            this.dtp_data_nascimento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_data_nascimento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_data_nascimento.Size = new System.Drawing.Size(224, 28);
            this.dtp_data_nascimento.TabIndex = 32;
            this.dtp_data_nascimento.EditValueChanged += new System.EventHandler(this.dtp_data_nascimento_EditValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.pb_img);
            this.groupControl1.Controls.Add(this.labelControl15);
            this.groupControl1.Controls.Add(this.cbo_tipo_funcionario);
            this.groupControl1.Controls.Add(this.cbo_provincia);
            this.groupControl1.Controls.Add(this.lb_nome_funcionario);
            this.groupControl1.Controls.Add(this.txt_nome);
            this.groupControl1.Controls.Add(this.dtp_data_nascimento);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_salvar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cb_genero);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_bi);
            this.groupControl1.Controls.Add(this.labelControl13);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_nip);
            this.groupControl1.Controls.Add(this.txt_nomedoPai);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txt_tel2);
            this.groupControl1.Controls.Add(this.Txt_nomedaMae);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_tel1);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.txt_residencia);
            this.groupControl1.Controls.Add(this.txt_altura);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.cb_estadoCivil);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(904, 383);
            this.groupControl1.TabIndex = 34;
            this.groupControl1.Text = "Cadastro de Funcionario";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_img.Location = new System.Drawing.Point(727, 26);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(165, 150);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 37;
            this.pb_img.TabStop = false;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(492, 26);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(168, 22);
            this.labelControl15.TabIndex = 36;
            this.labelControl15.Text = "Tipo de Funcionário:";
            this.labelControl15.Click += new System.EventHandler(this.labelControl15_Click);
            // 
            // cbo_tipo_funcionario
            // 
            this.cbo_tipo_funcionario.EditValue = "";
            this.cbo_tipo_funcionario.Location = new System.Drawing.Point(492, 54);
            this.cbo_tipo_funcionario.Name = "cbo_tipo_funcionario";
            this.cbo_tipo_funcionario.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo_funcionario.Properties.Appearance.Options.UseFont = true;
            this.cbo_tipo_funcionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_tipo_funcionario.Properties.View = this.gridView1;
            this.cbo_tipo_funcionario.Size = new System.Drawing.Size(217, 28);
            this.cbo_tipo_funcionario.TabIndex = 35;
            this.cbo_tipo_funcionario.EditValueChanged += new System.EventHandler(this.cbo_tipo_funcionario_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Código";
            this.gridColumn3.FieldName = "cod_tipo_funcionario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tipo de funcionário";
            this.gridColumn4.FieldName = "nome_tipo_funcionario";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // cbo_provincia
            // 
            this.cbo_provincia.EditValue = "";
            this.cbo_provincia.Location = new System.Drawing.Point(19, 178);
            this.cbo_provincia.Name = "cbo_provincia";
            this.cbo_provincia.Properties.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_provincia.Properties.Appearance.Options.UseFont = true;
            this.cbo_provincia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_provincia.Properties.View = this.searchLookUpEdit1View;
            this.cbo_provincia.Size = new System.Drawing.Size(225, 28);
            this.cbo_provincia.TabIndex = 34;
            this.cbo_provincia.EditValueChanged += new System.EventHandler(this.cbo_provincia_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Código";
            this.gridColumn1.FieldName = "cod_provincia";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Provincia";
            this.gridColumn2.FieldName = "nome_provincia";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.Appearance.Options.UseFont = true;
            this.btn_salvar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_salvar.ImageOptions.Image")));
            this.btn_salvar.Location = new System.Drawing.Point(758, 314);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(119, 35);
            this.btn_salvar.TabIndex = 31;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(633, 314);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(119, 35);
            this.simpleButton1.TabIndex = 30;
            this.simpleButton1.Text = "Cancelar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_cad_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 361);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cad_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadastrar_funcionario";
            this.Load += new System.EventHandler(this.frm_cadastrar_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_nome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_genero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nomedoPai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_nomedaMae.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_residencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_estadoCivil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_altura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_data_nascimento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_data_nascimento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_tipo_funcionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_provincia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lb_nome_funcionario;
        private DevExpress.XtraEditors.TextEdit txt_nome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_genero;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_nomedoPai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit Txt_nomedaMae;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_residencia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cb_estadoCivil;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_altura;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_tel1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_tel2;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_nip;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_salvar;
        private DevExpress.XtraEditors.DateEdit dtp_data_nascimento;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbo_provincia;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SearchLookUpEdit cbo_tipo_funcionario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        public DevExpress.XtraEditors.TextEdit txt_bi;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}