namespace pegasusProject
{
    partial class Form1
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
            this.matTabTMS = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbAltUrun = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.rbKurumsal = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBireysel = new MaterialSkin.Controls.MaterialRadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbKurumXDSL = new System.Windows.Forms.ComboBox();
            this.dGridXDSL = new System.Windows.Forms.DataGridView();
            this.cbXDSL = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbKurumsalTahakkuk = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBireyselTahakkuk = new MaterialSkin.Controls.MaterialRadioButton();
            this.dGridTahakuk = new System.Windows.Forms.DataGridView();
            this.cbUrunTahakkuk = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dGridTelaura = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rbToptan = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbSoho = new MaterialSkin.Controls.MaterialRadioButton();
            this.dGridSiebel = new System.Windows.Forms.DataGridView();
            this.rbKurumsalSiebel = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbBireyselSiebel = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.rbBAU = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbUAT = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnGetir = new MaterialSkin.Controls.MaterialFlatButton();
            this.labelBekle = new System.Windows.Forms.Label();
            this.rbBireyselTelaura = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbKurumsalTelaura = new MaterialSkin.Controls.MaterialRadioButton();
            this.matTabTMS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridXDSL)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTahakuk)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTelaura)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiebel)).BeginInit();
            this.SuspendLayout();
            // 
            // matTabTMS
            // 
            this.matTabTMS.Controls.Add(this.tabPage1);
            this.matTabTMS.Controls.Add(this.tabPage2);
            this.matTabTMS.Controls.Add(this.tabPage3);
            this.matTabTMS.Controls.Add(this.tabPage4);
            this.matTabTMS.Controls.Add(this.tabPage5);
            this.matTabTMS.Depth = 0;
            this.matTabTMS.Location = new System.Drawing.Point(0, 134);
            this.matTabTMS.MouseState = MaterialSkin.MouseState.HOVER;
            this.matTabTMS.Name = "matTabTMS";
            this.matTabTMS.SelectedIndex = 0;
            this.matTabTMS.Size = new System.Drawing.Size(669, 248);
            this.matTabTMS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbAltUrun);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.cbUrun);
            this.tabPage1.Controls.Add(this.rbKurumsal);
            this.tabPage1.Controls.Add(this.rbBireysel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TMS";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbAltUrun
            // 
            this.cbAltUrun.FormattingEnabled = true;
            this.cbAltUrun.Location = new System.Drawing.Point(166, 68);
            this.cbAltUrun.Name = "cbAltUrun";
            this.cbAltUrun.Size = new System.Drawing.Size(121, 21);
            this.cbAltUrun.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 134);
            this.dataGridView1.TabIndex = 3;
            // 
            // cbUrun
            // 
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(166, 23);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(121, 21);
            this.cbUrun.TabIndex = 2;
            this.cbUrun.SelectedValueChanged += new System.EventHandler(this.cbUrun_SelectedValueChanged);
            // 
            // rbKurumsal
            // 
            this.rbKurumsal.AutoSize = true;
            this.rbKurumsal.Depth = 0;
            this.rbKurumsal.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbKurumsal.Location = new System.Drawing.Point(10, 68);
            this.rbKurumsal.Margin = new System.Windows.Forms.Padding(0);
            this.rbKurumsal.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbKurumsal.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbKurumsal.Name = "rbKurumsal";
            this.rbKurumsal.Ripple = true;
            this.rbKurumsal.Size = new System.Drawing.Size(88, 30);
            this.rbKurumsal.TabIndex = 1;
            this.rbKurumsal.Text = "Kurumsal";
            this.rbKurumsal.UseVisualStyleBackColor = true;
            this.rbKurumsal.CheckedChanged += new System.EventHandler(this.rbKurumsal_CheckedChanged_1);
            // 
            // rbBireysel
            // 
            this.rbBireysel.AutoSize = true;
            this.rbBireysel.Checked = true;
            this.rbBireysel.Depth = 0;
            this.rbBireysel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBireysel.Location = new System.Drawing.Point(10, 23);
            this.rbBireysel.Margin = new System.Windows.Forms.Padding(0);
            this.rbBireysel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBireysel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBireysel.Name = "rbBireysel";
            this.rbBireysel.Ripple = true;
            this.rbBireysel.Size = new System.Drawing.Size(78, 30);
            this.rbBireysel.TabIndex = 0;
            this.rbBireysel.TabStop = true;
            this.rbBireysel.Text = "Bireysel";
            this.rbBireysel.UseVisualStyleBackColor = true;
            this.rbBireysel.CheckedChanged += new System.EventHandler(this.rbBireysel_CheckedChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbKurumXDSL);
            this.tabPage2.Controls.Add(this.dGridXDSL);
            this.tabPage2.Controls.Add(this.cbXDSL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "xDSL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbKurumXDSL
            // 
            this.cbKurumXDSL.FormattingEnabled = true;
            this.cbKurumXDSL.Items.AddRange(new object[] {
            "TTNET",
            "TURK TELEKOM",
            "VODAFONE VAE"});
            this.cbKurumXDSL.Location = new System.Drawing.Point(35, 69);
            this.cbKurumXDSL.Name = "cbKurumXDSL";
            this.cbKurumXDSL.Size = new System.Drawing.Size(121, 21);
            this.cbKurumXDSL.TabIndex = 4;
            // 
            // dGridXDSL
            // 
            this.dGridXDSL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridXDSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridXDSL.Location = new System.Drawing.Point(187, 13);
            this.dGridXDSL.Name = "dGridXDSL";
            this.dGridXDSL.Size = new System.Drawing.Size(445, 127);
            this.dGridXDSL.TabIndex = 3;
            // 
            // cbXDSL
            // 
            this.cbXDSL.AutoCompleteCustomSource.AddRange(new string[] {
            "ADSL"});
            this.cbXDSL.FormattingEnabled = true;
            this.cbXDSL.Items.AddRange(new object[] {
            "ADSL",
            "NDSL",
            "VDSL",
            "NVDSL",
            "GSHDSL",
            "GSHDSL YALIN",
            "FTTX",
            "NN ADSL",
            "NN GHSDSL",
            "NN GSHDSL(İKİ UÇ)"});
            this.cbXDSL.Location = new System.Drawing.Point(35, 32);
            this.cbXDSL.Name = "cbXDSL";
            this.cbXDSL.Size = new System.Drawing.Size(121, 21);
            this.cbXDSL.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rbKurumsalTahakkuk);
            this.tabPage3.Controls.Add(this.rbBireyselTahakkuk);
            this.tabPage3.Controls.Add(this.dGridTahakuk);
            this.tabPage3.Controls.Add(this.cbUrunTahakkuk);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 222);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tahakkuk";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbKurumsalTahakkuk
            // 
            this.rbKurumsalTahakkuk.AutoSize = true;
            this.rbKurumsalTahakkuk.Depth = 0;
            this.rbKurumsalTahakkuk.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbKurumsalTahakkuk.Location = new System.Drawing.Point(19, 56);
            this.rbKurumsalTahakkuk.Margin = new System.Windows.Forms.Padding(0);
            this.rbKurumsalTahakkuk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbKurumsalTahakkuk.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbKurumsalTahakkuk.Name = "rbKurumsalTahakkuk";
            this.rbKurumsalTahakkuk.Ripple = true;
            this.rbKurumsalTahakkuk.Size = new System.Drawing.Size(88, 30);
            this.rbKurumsalTahakkuk.TabIndex = 3;
            this.rbKurumsalTahakkuk.Text = "Kurumsal";
            this.rbKurumsalTahakkuk.UseVisualStyleBackColor = true;
            this.rbKurumsalTahakkuk.CheckedChanged += new System.EventHandler(this.rbKurumsalTahakkuk_CheckedChanged);
            // 
            // rbBireyselTahakkuk
            // 
            this.rbBireyselTahakkuk.AutoSize = true;
            this.rbBireyselTahakkuk.Checked = true;
            this.rbBireyselTahakkuk.Depth = 0;
            this.rbBireyselTahakkuk.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBireyselTahakkuk.Location = new System.Drawing.Point(19, 11);
            this.rbBireyselTahakkuk.Margin = new System.Windows.Forms.Padding(0);
            this.rbBireyselTahakkuk.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBireyselTahakkuk.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBireyselTahakkuk.Name = "rbBireyselTahakkuk";
            this.rbBireyselTahakkuk.Ripple = true;
            this.rbBireyselTahakkuk.Size = new System.Drawing.Size(78, 30);
            this.rbBireyselTahakkuk.TabIndex = 2;
            this.rbBireyselTahakkuk.TabStop = true;
            this.rbBireyselTahakkuk.Text = "Bireysel";
            this.rbBireyselTahakkuk.UseVisualStyleBackColor = true;
            this.rbBireyselTahakkuk.CheckedChanged += new System.EventHandler(this.rbBireyselTahakkuk_CheckedChanged);
            // 
            // dGridTahakuk
            // 
            this.dGridTahakuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridTahakuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridTahakuk.Location = new System.Drawing.Point(307, 6);
            this.dGridTahakuk.Name = "dGridTahakuk";
            this.dGridTahakuk.Size = new System.Drawing.Size(354, 198);
            this.dGridTahakuk.TabIndex = 1;
            // 
            // cbUrunTahakkuk
            // 
            this.cbUrunTahakkuk.FormattingEnabled = true;
            this.cbUrunTahakkuk.Items.AddRange(new object[] {
            "PSTN"});
            this.cbUrunTahakkuk.Location = new System.Drawing.Point(150, 20);
            this.cbUrunTahakkuk.Name = "cbUrunTahakkuk";
            this.cbUrunTahakkuk.Size = new System.Drawing.Size(145, 21);
            this.cbUrunTahakkuk.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rbKurumsalTelaura);
            this.tabPage4.Controls.Add(this.rbBireyselTelaura);
            this.tabPage4.Controls.Add(this.dGridTelaura);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(661, 222);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Telaura";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dGridTelaura
            // 
            this.dGridTelaura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridTelaura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridTelaura.Location = new System.Drawing.Point(257, 9);
            this.dGridTelaura.Name = "dGridTelaura";
            this.dGridTelaura.Size = new System.Drawing.Size(346, 129);
            this.dGridTelaura.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.rbToptan);
            this.tabPage5.Controls.Add(this.rbSoho);
            this.tabPage5.Controls.Add(this.dGridSiebel);
            this.tabPage5.Controls.Add(this.rbKurumsalSiebel);
            this.tabPage5.Controls.Add(this.rbBireyselSiebel);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(661, 222);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Siebel";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rbToptan
            // 
            this.rbToptan.AutoSize = true;
            this.rbToptan.Depth = 0;
            this.rbToptan.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbToptan.Location = new System.Drawing.Point(19, 103);
            this.rbToptan.Margin = new System.Windows.Forms.Padding(0);
            this.rbToptan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbToptan.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbToptan.Name = "rbToptan";
            this.rbToptan.Ripple = true;
            this.rbToptan.Size = new System.Drawing.Size(72, 30);
            this.rbToptan.TabIndex = 4;
            this.rbToptan.TabStop = true;
            this.rbToptan.Text = "Toptan";
            this.rbToptan.UseVisualStyleBackColor = true;
            this.rbToptan.CheckedChanged += new System.EventHandler(this.rbToptan_CheckedChanged);
            // 
            // rbSoho
            // 
            this.rbSoho.AutoSize = true;
            this.rbSoho.Depth = 0;
            this.rbSoho.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbSoho.Location = new System.Drawing.Point(19, 73);
            this.rbSoho.Margin = new System.Windows.Forms.Padding(0);
            this.rbSoho.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbSoho.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbSoho.Name = "rbSoho";
            this.rbSoho.Ripple = true;
            this.rbSoho.Size = new System.Drawing.Size(60, 30);
            this.rbSoho.TabIndex = 3;
            this.rbSoho.TabStop = true;
            this.rbSoho.Text = "Soho";
            this.rbSoho.UseVisualStyleBackColor = true;
            this.rbSoho.CheckedChanged += new System.EventHandler(this.rbSoho_CheckedChanged);
            // 
            // dGridSiebel
            // 
            this.dGridSiebel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridSiebel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridSiebel.Location = new System.Drawing.Point(187, 13);
            this.dGridSiebel.Name = "dGridSiebel";
            this.dGridSiebel.Size = new System.Drawing.Size(468, 127);
            this.dGridSiebel.TabIndex = 2;
            // 
            // rbKurumsalSiebel
            // 
            this.rbKurumsalSiebel.AutoSize = true;
            this.rbKurumsalSiebel.Depth = 0;
            this.rbKurumsalSiebel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbKurumsalSiebel.Location = new System.Drawing.Point(19, 43);
            this.rbKurumsalSiebel.Margin = new System.Windows.Forms.Padding(0);
            this.rbKurumsalSiebel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbKurumsalSiebel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbKurumsalSiebel.Name = "rbKurumsalSiebel";
            this.rbKurumsalSiebel.Ripple = true;
            this.rbKurumsalSiebel.Size = new System.Drawing.Size(88, 30);
            this.rbKurumsalSiebel.TabIndex = 1;
            this.rbKurumsalSiebel.TabStop = true;
            this.rbKurumsalSiebel.Text = "Kurumsal";
            this.rbKurumsalSiebel.UseVisualStyleBackColor = true;
            this.rbKurumsalSiebel.CheckedChanged += new System.EventHandler(this.rbKurumsalSiebel_CheckedChanged);
            // 
            // rbBireyselSiebel
            // 
            this.rbBireyselSiebel.AutoSize = true;
            this.rbBireyselSiebel.Checked = true;
            this.rbBireyselSiebel.Depth = 0;
            this.rbBireyselSiebel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBireyselSiebel.Location = new System.Drawing.Point(19, 13);
            this.rbBireyselSiebel.Margin = new System.Windows.Forms.Padding(0);
            this.rbBireyselSiebel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBireyselSiebel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBireyselSiebel.Name = "rbBireyselSiebel";
            this.rbBireyselSiebel.Ripple = true;
            this.rbBireyselSiebel.Size = new System.Drawing.Size(78, 30);
            this.rbBireyselSiebel.TabIndex = 0;
            this.rbBireyselSiebel.TabStop = true;
            this.rbBireyselSiebel.Text = "Bireysel";
            this.rbBireyselSiebel.UseVisualStyleBackColor = true;
            this.rbBireyselSiebel.CheckedChanged += new System.EventHandler(this.rbBireyselSiebel_CheckedChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.matTabTMS;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 114);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(755, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.materialTabSelector1_Click);
            // 
            // rbBAU
            // 
            this.rbBAU.AutoSize = true;
            this.rbBAU.Checked = true;
            this.rbBAU.Depth = 0;
            this.rbBAU.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBAU.Location = new System.Drawing.Point(14, 75);
            this.rbBAU.Margin = new System.Windows.Forms.Padding(0);
            this.rbBAU.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBAU.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBAU.Name = "rbBAU";
            this.rbBAU.Ripple = true;
            this.rbBAU.Size = new System.Drawing.Size(102, 30);
            this.rbBAU.TabIndex = 2;
            this.rbBAU.TabStop = true;
            this.rbBAU.Text = "Test Ortamı";
            this.rbBAU.UseVisualStyleBackColor = true;
            this.rbBAU.CheckedChanged += new System.EventHandler(this.rbBAU_CheckedChanged_1);
            // 
            // rbUAT
            // 
            this.rbUAT.AutoSize = true;
            this.rbUAT.Depth = 0;
            this.rbUAT.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbUAT.Location = new System.Drawing.Point(136, 75);
            this.rbUAT.Margin = new System.Windows.Forms.Padding(0);
            this.rbUAT.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbUAT.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbUAT.Name = "rbUAT";
            this.rbUAT.Ripple = true;
            this.rbUAT.Size = new System.Drawing.Size(139, 30);
            this.rbUAT.TabIndex = 3;
            this.rbUAT.Text = "Regresyon Ortamı";
            this.rbUAT.UseVisualStyleBackColor = true;
            this.rbUAT.CheckedChanged += new System.EventHandler(this.rbUAT_CheckedChanged_1);
            // 
            // btnGetir
            // 
            this.btnGetir.AutoSize = true;
            this.btnGetir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGetir.Depth = 0;
            this.btnGetir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnGetir.Location = new System.Drawing.Point(595, 72);
            this.btnGetir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Primary = false;
            this.btnGetir.Size = new System.Drawing.Size(64, 36);
            this.btnGetir.TabIndex = 4;
            this.btnGetir.Text = "SEARCH";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // labelBekle
            // 
            this.labelBekle.AutoSize = true;
            this.labelBekle.BackColor = System.Drawing.Color.Black;
            this.labelBekle.Location = new System.Drawing.Point(251, 9);
            this.labelBekle.Name = "labelBekle";
            this.labelBekle.Size = new System.Drawing.Size(123, 13);
            this.labelBekle.TabIndex = 5;
            this.labelBekle.Text = "LÜTFEN BEKLEYİNİZ...";
            // 
            // rbBireyselTelaura
            // 
            this.rbBireyselTelaura.AutoSize = true;
            this.rbBireyselTelaura.Checked = true;
            this.rbBireyselTelaura.Depth = 0;
            this.rbBireyselTelaura.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbBireyselTelaura.Location = new System.Drawing.Point(39, 29);
            this.rbBireyselTelaura.Margin = new System.Windows.Forms.Padding(0);
            this.rbBireyselTelaura.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbBireyselTelaura.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbBireyselTelaura.Name = "rbBireyselTelaura";
            this.rbBireyselTelaura.Ripple = true;
            this.rbBireyselTelaura.Size = new System.Drawing.Size(78, 30);
            this.rbBireyselTelaura.TabIndex = 2;
            this.rbBireyselTelaura.TabStop = true;
            this.rbBireyselTelaura.Text = "Bireysel";
            this.rbBireyselTelaura.UseVisualStyleBackColor = true;
            this.rbBireyselTelaura.CheckedChanged += new System.EventHandler(this.rbBireyselTelaura_CheckedChanged);
            // 
            // rbKurumsalTelaura
            // 
            this.rbKurumsalTelaura.AutoSize = true;
            this.rbKurumsalTelaura.Depth = 0;
            this.rbKurumsalTelaura.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbKurumsalTelaura.Location = new System.Drawing.Point(39, 73);
            this.rbKurumsalTelaura.Margin = new System.Windows.Forms.Padding(0);
            this.rbKurumsalTelaura.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbKurumsalTelaura.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbKurumsalTelaura.Name = "rbKurumsalTelaura";
            this.rbKurumsalTelaura.Ripple = true;
            this.rbKurumsalTelaura.Size = new System.Drawing.Size(88, 30);
            this.rbKurumsalTelaura.TabIndex = 3;
            this.rbKurumsalTelaura.Text = "Kurumsal";
            this.rbKurumsalTelaura.UseVisualStyleBackColor = true;
            this.rbKurumsalTelaura.CheckedChanged += new System.EventHandler(this.rbKurumsalTelaura_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(691, 311);
            this.Controls.Add(this.labelBekle);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.rbUAT);
            this.Controls.Add(this.rbBAU);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.matTabTMS);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.matTabTMS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridXDSL)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTahakuk)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridTelaura)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridSiebel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl matTabTMS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbUrun;
        private MaterialSkin.Controls.MaterialRadioButton rbKurumsal;
        private MaterialSkin.Controls.MaterialRadioButton rbBireysel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRadioButton rbBAU;
        private MaterialSkin.Controls.MaterialRadioButton rbUAT;
        private MaterialSkin.Controls.MaterialFlatButton btnGetir;
        private System.Windows.Forms.DataGridView dGridXDSL;
        private System.Windows.Forms.ComboBox cbXDSL;
        private System.Windows.Forms.DataGridView dGridTelaura;
        private System.Windows.Forms.ComboBox cbUrunTahakkuk;
        private System.Windows.Forms.DataGridView dGridTahakuk;
        private MaterialSkin.Controls.MaterialRadioButton rbKurumsalTahakkuk;
        private MaterialSkin.Controls.MaterialRadioButton rbBireyselTahakkuk;
        private System.Windows.Forms.DataGridView dGridSiebel;
        private MaterialSkin.Controls.MaterialRadioButton rbKurumsalSiebel;
        private MaterialSkin.Controls.MaterialRadioButton rbBireyselSiebel;
        private System.Windows.Forms.ComboBox cbKurumXDSL;
        private System.Windows.Forms.ComboBox cbAltUrun;
        private MaterialSkin.Controls.MaterialRadioButton rbToptan;
        private MaterialSkin.Controls.MaterialRadioButton rbSoho;
        private System.Windows.Forms.Label labelBekle;
        private MaterialSkin.Controls.MaterialRadioButton rbKurumsalTelaura;
        private MaterialSkin.Controls.MaterialRadioButton rbBireyselTelaura;
    }
}

