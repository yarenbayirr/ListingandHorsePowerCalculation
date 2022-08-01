
namespace _30_07_2022Odev
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
            this.dgwList = new System.Windows.Forms.DataGridView();
            this.grpBisiklet = new System.Windows.Forms.GroupBox();
            this.btnBisikletEkle = new System.Windows.Forms.Button();
            this.chkSeles = new System.Windows.Forms.CheckBox();
            this.chkVites = new System.Windows.Forms.CheckBox();
            this.grpMotosiklet = new System.Windows.Forms.GroupBox();
            this.txtMotorGucuMotor = new System.Windows.Forms.TextBox();
            this.btnMotorEkle = new System.Windows.Forms.Button();
            this.btnMotorGucuMotor = new System.Windows.Forms.Button();
            this.nmrBeygirMotor = new System.Windows.Forms.NumericUpDown();
            this.cmbYakitMotor = new System.Windows.Forms.ComboBox();
            this.cmbVitesMotor = new System.Windows.Forms.ComboBox();
            this.lblMotorGucuMotor = new System.Windows.Forms.Label();
            this.lblBeygirMptpr = new System.Windows.Forms.Label();
            this.lblYakitMotor = new System.Windows.Forms.Label();
            this.lblVitesMotor = new System.Windows.Forms.Label();
            this.lblMarkaArac = new System.Windows.Forms.Label();
            this.txtMarkaArac = new System.Windows.Forms.TextBox();
            this.grpArac = new System.Windows.Forms.GroupBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.nmrB = new System.Windows.Forms.NumericUpDown();
            this.nmrG = new System.Windows.Forms.NumericUpDown();
            this.nmrKoltukSayisi = new System.Windows.Forms.NumericUpDown();
            this.nmrR = new System.Windows.Forms.NumericUpDown();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.lblRenkArac = new System.Windows.Forms.Label();
            this.lblUretimTarihiArac = new System.Windows.Forms.Label();
            this.lblModelArac = new System.Windows.Forms.Label();
            this.txtModelArac = new System.Windows.Forms.TextBox();
            this.grpAraba = new System.Windows.Forms.GroupBox();
            this.txtMotorGucuAraba = new System.Windows.Forms.TextBox();
            this.btnArabaEkle = new System.Windows.Forms.Button();
            this.lblVitesAraba = new System.Windows.Forms.Label();
            this.btnMotorAraba = new System.Windows.Forms.Button();
            this.lblYakitAraba = new System.Windows.Forms.Label();
            this.lblBeygirAraba = new System.Windows.Forms.Label();
            this.nmrBeygirAraba = new System.Windows.Forms.NumericUpDown();
            this.lblMotorGucuAraba = new System.Windows.Forms.Label();
            this.cmbYakitAraba = new System.Windows.Forms.ComboBox();
            this.cmbVitesAraba = new System.Windows.Forms.ComboBox();
            this.grpTekne = new System.Windows.Forms.GroupBox();
            this.txtMotorTekne = new System.Windows.Forms.TextBox();
            this.btnTekneEkle = new System.Windows.Forms.Button();
            this.lblYakitTekne = new System.Windows.Forms.Label();
            this.lblBeygirTekne = new System.Windows.Forms.Label();
            this.btnMotorTekne = new System.Windows.Forms.Button();
            this.lblMotorTekne = new System.Windows.Forms.Label();
            this.nmrBeygirTekne = new System.Windows.Forms.NumericUpDown();
            this.cmbYakitTekne = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).BeginInit();
            this.grpBisiklet.SuspendLayout();
            this.grpMotosiklet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirMotor)).BeginInit();
            this.grpArac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKoltukSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrR)).BeginInit();
            this.grpAraba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirAraba)).BeginInit();
            this.grpTekne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirTekne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwList
            // 
            this.dgwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwList.Location = new System.Drawing.Point(14, 13);
            this.dgwList.Name = "dgwList";
            this.dgwList.RowHeadersWidth = 51;
            this.dgwList.RowTemplate.Height = 24;
            this.dgwList.Size = new System.Drawing.Size(680, 445);
            this.dgwList.TabIndex = 0;
            this.dgwList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwList_CellClick);
            // 
            // grpBisiklet
            // 
            this.grpBisiklet.Controls.Add(this.btnBisikletEkle);
            this.grpBisiklet.Controls.Add(this.chkSeles);
            this.grpBisiklet.Controls.Add(this.chkVites);
            this.grpBisiklet.Location = new System.Drawing.Point(14, 466);
            this.grpBisiklet.Name = "grpBisiklet";
            this.grpBisiklet.Size = new System.Drawing.Size(310, 203);
            this.grpBisiklet.TabIndex = 1;
            this.grpBisiklet.TabStop = false;
            this.grpBisiklet.Text = "Bisiklet Ekle";
            // 
            // btnBisikletEkle
            // 
            this.btnBisikletEkle.Location = new System.Drawing.Point(176, 158);
            this.btnBisikletEkle.Name = "btnBisikletEkle";
            this.btnBisikletEkle.Size = new System.Drawing.Size(128, 37);
            this.btnBisikletEkle.TabIndex = 1;
            this.btnBisikletEkle.Text = "Bisiklet Ekle";
            this.btnBisikletEkle.UseVisualStyleBackColor = true;
            this.btnBisikletEkle.Click += new System.EventHandler(this.btnBisikletEkle_Click);
            // 
            // chkSeles
            // 
            this.chkSeles.AutoSize = true;
            this.chkSeles.Location = new System.Drawing.Point(6, 60);
            this.chkSeles.Name = "chkSeles";
            this.chkSeles.Size = new System.Drawing.Size(118, 21);
            this.chkSeles.TabIndex = 0;
            this.chkSeles.Text = "Selesi var mı?";
            this.chkSeles.UseVisualStyleBackColor = true;
            // 
            // chkVites
            // 
            this.chkVites.AutoSize = true;
            this.chkVites.Location = new System.Drawing.Point(7, 33);
            this.chkVites.Name = "chkVites";
            this.chkVites.Size = new System.Drawing.Size(93, 21);
            this.chkVites.TabIndex = 0;
            this.chkVites.Text = "Vitesli mi?";
            this.chkVites.UseVisualStyleBackColor = true;
            // 
            // grpMotosiklet
            // 
            this.grpMotosiklet.Controls.Add(this.txtMotorGucuMotor);
            this.grpMotosiklet.Controls.Add(this.btnMotorEkle);
            this.grpMotosiklet.Controls.Add(this.btnMotorGucuMotor);
            this.grpMotosiklet.Controls.Add(this.nmrBeygirMotor);
            this.grpMotosiklet.Controls.Add(this.cmbYakitMotor);
            this.grpMotosiklet.Controls.Add(this.cmbVitesMotor);
            this.grpMotosiklet.Controls.Add(this.lblMotorGucuMotor);
            this.grpMotosiklet.Controls.Add(this.lblBeygirMptpr);
            this.grpMotosiklet.Controls.Add(this.lblYakitMotor);
            this.grpMotosiklet.Controls.Add(this.lblVitesMotor);
            this.grpMotosiklet.Location = new System.Drawing.Point(330, 469);
            this.grpMotosiklet.Name = "grpMotosiklet";
            this.grpMotosiklet.Size = new System.Drawing.Size(364, 203);
            this.grpMotosiklet.TabIndex = 1;
            this.grpMotosiklet.TabStop = false;
            this.grpMotosiklet.Text = "Motorsiklet Ekle";
            // 
            // txtMotorGucuMotor
            // 
            this.txtMotorGucuMotor.Location = new System.Drawing.Point(176, 121);
            this.txtMotorGucuMotor.Name = "txtMotorGucuMotor";
            this.txtMotorGucuMotor.Size = new System.Drawing.Size(173, 22);
            this.txtMotorGucuMotor.TabIndex = 3;
            // 
            // btnMotorEkle
            // 
            this.btnMotorEkle.Location = new System.Drawing.Point(210, 158);
            this.btnMotorEkle.Name = "btnMotorEkle";
            this.btnMotorEkle.Size = new System.Drawing.Size(139, 37);
            this.btnMotorEkle.TabIndex = 1;
            this.btnMotorEkle.Text = "Motorsiklet Ekle";
            this.btnMotorEkle.UseVisualStyleBackColor = true;
            this.btnMotorEkle.Click += new System.EventHandler(this.btnMotorEkle_Click);
            // 
            // btnMotorGucuMotor
            // 
            this.btnMotorGucuMotor.Location = new System.Drawing.Point(6, 159);
            this.btnMotorGucuMotor.Name = "btnMotorGucuMotor";
            this.btnMotorGucuMotor.Size = new System.Drawing.Size(146, 37);
            this.btnMotorGucuMotor.TabIndex = 1;
            this.btnMotorGucuMotor.Text = "Motor Gücü Hesapla";
            this.btnMotorGucuMotor.UseVisualStyleBackColor = true;
            this.btnMotorGucuMotor.Click += new System.EventHandler(this.btnMotorGucuMotor_Click);
            // 
            // nmrBeygirMotor
            // 
            this.nmrBeygirMotor.Location = new System.Drawing.Point(176, 93);
            this.nmrBeygirMotor.Name = "nmrBeygirMotor";
            this.nmrBeygirMotor.Size = new System.Drawing.Size(173, 22);
            this.nmrBeygirMotor.TabIndex = 2;
            // 
            // cmbYakitMotor
            // 
            this.cmbYakitMotor.FormattingEnabled = true;
            this.cmbYakitMotor.Location = new System.Drawing.Point(176, 63);
            this.cmbYakitMotor.Name = "cmbYakitMotor";
            this.cmbYakitMotor.Size = new System.Drawing.Size(173, 24);
            this.cmbYakitMotor.TabIndex = 1;
            // 
            // cmbVitesMotor
            // 
            this.cmbVitesMotor.FormattingEnabled = true;
            this.cmbVitesMotor.Location = new System.Drawing.Point(176, 32);
            this.cmbVitesMotor.Name = "cmbVitesMotor";
            this.cmbVitesMotor.Size = new System.Drawing.Size(173, 24);
            this.cmbVitesMotor.TabIndex = 1;
            // 
            // lblMotorGucuMotor
            // 
            this.lblMotorGucuMotor.Location = new System.Drawing.Point(6, 124);
            this.lblMotorGucuMotor.Name = "lblMotorGucuMotor";
            this.lblMotorGucuMotor.Size = new System.Drawing.Size(98, 23);
            this.lblMotorGucuMotor.TabIndex = 0;
            this.lblMotorGucuMotor.Text = "Motor Gücü:";
            // 
            // lblBeygirMptpr
            // 
            this.lblBeygirMptpr.Location = new System.Drawing.Point(6, 94);
            this.lblBeygirMptpr.Name = "lblBeygirMptpr";
            this.lblBeygirMptpr.Size = new System.Drawing.Size(98, 23);
            this.lblBeygirMptpr.TabIndex = 0;
            this.lblBeygirMptpr.Text = "Beygir Gücü:";
            // 
            // lblYakitMotor
            // 
            this.lblYakitMotor.Location = new System.Drawing.Point(6, 66);
            this.lblYakitMotor.Name = "lblYakitMotor";
            this.lblYakitMotor.Size = new System.Drawing.Size(85, 23);
            this.lblYakitMotor.TabIndex = 0;
            this.lblYakitMotor.Text = "Yakıt Türü:";
            // 
            // lblVitesMotor
            // 
            this.lblVitesMotor.Location = new System.Drawing.Point(6, 35);
            this.lblVitesMotor.Name = "lblVitesMotor";
            this.lblVitesMotor.Size = new System.Drawing.Size(85, 23);
            this.lblVitesMotor.TabIndex = 0;
            this.lblVitesMotor.Text = "Vites Türü:";
            // 
            // lblMarkaArac
            // 
            this.lblMarkaArac.Location = new System.Drawing.Point(6, 32);
            this.lblMarkaArac.Name = "lblMarkaArac";
            this.lblMarkaArac.Size = new System.Drawing.Size(98, 23);
            this.lblMarkaArac.TabIndex = 0;
            this.lblMarkaArac.Text = "Marka:";
            // 
            // txtMarkaArac
            // 
            this.txtMarkaArac.Location = new System.Drawing.Point(137, 32);
            this.txtMarkaArac.Name = "txtMarkaArac";
            this.txtMarkaArac.Size = new System.Drawing.Size(225, 22);
            this.txtMarkaArac.TabIndex = 3;
            this.txtMarkaArac.TextChanged += new System.EventHandler(this.txtMarkaArac_TextChanged);
            // 
            // grpArac
            // 
            this.grpArac.Controls.Add(this.btnAracEkle);
            this.grpArac.Controls.Add(this.nmrB);
            this.grpArac.Controls.Add(this.nmrG);
            this.grpArac.Controls.Add(this.nmrKoltukSayisi);
            this.grpArac.Controls.Add(this.nmrR);
            this.grpArac.Controls.Add(this.dtpUretimTarihi);
            this.grpArac.Controls.Add(this.label10);
            this.grpArac.Controls.Add(this.label9);
            this.grpArac.Controls.Add(this.label8);
            this.grpArac.Controls.Add(this.lblKoltukSayisi);
            this.grpArac.Controls.Add(this.lblRenkArac);
            this.grpArac.Controls.Add(this.lblUretimTarihiArac);
            this.grpArac.Controls.Add(this.lblModelArac);
            this.grpArac.Controls.Add(this.lblMarkaArac);
            this.grpArac.Controls.Add(this.txtModelArac);
            this.grpArac.Controls.Add(this.txtMarkaArac);
            this.grpArac.Location = new System.Drawing.Point(700, 13);
            this.grpArac.Name = "grpArac";
            this.grpArac.Size = new System.Drawing.Size(379, 229);
            this.grpArac.TabIndex = 2;
            this.grpArac.TabStop = false;
            this.grpArac.Text = "Araç Ekle";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(234, 184);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(128, 37);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // nmrB
            // 
            this.nmrB.Location = new System.Drawing.Point(311, 124);
            this.nmrB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmrB.Name = "nmrB";
            this.nmrB.Size = new System.Drawing.Size(51, 22);
            this.nmrB.TabIndex = 5;
            // 
            // nmrG
            // 
            this.nmrG.Location = new System.Drawing.Point(234, 124);
            this.nmrG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmrG.Name = "nmrG";
            this.nmrG.Size = new System.Drawing.Size(47, 22);
            this.nmrG.TabIndex = 5;
            // 
            // nmrKoltukSayisi
            // 
            this.nmrKoltukSayisi.Location = new System.Drawing.Point(137, 156);
            this.nmrKoltukSayisi.Name = "nmrKoltukSayisi";
            this.nmrKoltukSayisi.Size = new System.Drawing.Size(225, 22);
            this.nmrKoltukSayisi.TabIndex = 5;
            // 
            // nmrR
            // 
            this.nmrR.Location = new System.Drawing.Point(162, 124);
            this.nmrR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmrR.Name = "nmrR";
            this.nmrR.Size = new System.Drawing.Size(48, 22);
            this.nmrR.TabIndex = 5;
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Location = new System.Drawing.Point(137, 94);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(225, 22);
            this.dtpUretimTarihi.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(287, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "B:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(216, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "G:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(134, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "R:";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.Location = new System.Drawing.Point(6, 157);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(98, 23);
            this.lblKoltukSayisi.TabIndex = 0;
            this.lblKoltukSayisi.Text = "Koltuk Sayısı:";
            // 
            // lblRenkArac
            // 
            this.lblRenkArac.Location = new System.Drawing.Point(6, 125);
            this.lblRenkArac.Name = "lblRenkArac";
            this.lblRenkArac.Size = new System.Drawing.Size(98, 23);
            this.lblRenkArac.TabIndex = 0;
            this.lblRenkArac.Text = "Renk:";
            // 
            // lblUretimTarihiArac
            // 
            this.lblUretimTarihiArac.Location = new System.Drawing.Point(6, 93);
            this.lblUretimTarihiArac.Name = "lblUretimTarihiArac";
            this.lblUretimTarihiArac.Size = new System.Drawing.Size(98, 23);
            this.lblUretimTarihiArac.TabIndex = 0;
            this.lblUretimTarihiArac.Text = "Üretim Tarihi:";
            // 
            // lblModelArac
            // 
            this.lblModelArac.Location = new System.Drawing.Point(6, 62);
            this.lblModelArac.Name = "lblModelArac";
            this.lblModelArac.Size = new System.Drawing.Size(98, 23);
            this.lblModelArac.TabIndex = 0;
            this.lblModelArac.Text = "Model:";
            // 
            // txtModelArac
            // 
            this.txtModelArac.Location = new System.Drawing.Point(137, 60);
            this.txtModelArac.Name = "txtModelArac";
            this.txtModelArac.Size = new System.Drawing.Size(225, 22);
            this.txtModelArac.TabIndex = 3;
            // 
            // grpAraba
            // 
            this.grpAraba.Controls.Add(this.txtMotorGucuAraba);
            this.grpAraba.Controls.Add(this.btnArabaEkle);
            this.grpAraba.Controls.Add(this.lblVitesAraba);
            this.grpAraba.Controls.Add(this.btnMotorAraba);
            this.grpAraba.Controls.Add(this.lblYakitAraba);
            this.grpAraba.Controls.Add(this.lblBeygirAraba);
            this.grpAraba.Controls.Add(this.nmrBeygirAraba);
            this.grpAraba.Controls.Add(this.lblMotorGucuAraba);
            this.grpAraba.Controls.Add(this.cmbYakitAraba);
            this.grpAraba.Controls.Add(this.cmbVitesAraba);
            this.grpAraba.Location = new System.Drawing.Point(709, 249);
            this.grpAraba.Name = "grpAraba";
            this.grpAraba.Size = new System.Drawing.Size(370, 209);
            this.grpAraba.TabIndex = 3;
            this.grpAraba.TabStop = false;
            this.grpAraba.Text = "Araba Ekle";
            // 
            // txtMotorGucuAraba
            // 
            this.txtMotorGucuAraba.Location = new System.Drawing.Point(128, 116);
            this.txtMotorGucuAraba.Name = "txtMotorGucuAraba";
            this.txtMotorGucuAraba.Size = new System.Drawing.Size(225, 22);
            this.txtMotorGucuAraba.TabIndex = 3;
            // 
            // btnArabaEkle
            // 
            this.btnArabaEkle.Location = new System.Drawing.Point(214, 157);
            this.btnArabaEkle.Name = "btnArabaEkle";
            this.btnArabaEkle.Size = new System.Drawing.Size(139, 37);
            this.btnArabaEkle.TabIndex = 1;
            this.btnArabaEkle.Text = "Araba Ekle";
            this.btnArabaEkle.UseVisualStyleBackColor = true;
            this.btnArabaEkle.Click += new System.EventHandler(this.btnArabaEkle_Click);
            // 
            // lblVitesAraba
            // 
            this.lblVitesAraba.Location = new System.Drawing.Point(6, 30);
            this.lblVitesAraba.Name = "lblVitesAraba";
            this.lblVitesAraba.Size = new System.Drawing.Size(85, 23);
            this.lblVitesAraba.TabIndex = 0;
            this.lblVitesAraba.Text = "Vites Türü:";
            // 
            // btnMotorAraba
            // 
            this.btnMotorAraba.Location = new System.Drawing.Point(6, 157);
            this.btnMotorAraba.Name = "btnMotorAraba";
            this.btnMotorAraba.Size = new System.Drawing.Size(146, 37);
            this.btnMotorAraba.TabIndex = 1;
            this.btnMotorAraba.Text = "Motor Gücü Hesapla";
            this.btnMotorAraba.UseVisualStyleBackColor = true;
            this.btnMotorAraba.Click += new System.EventHandler(this.btnMotorAraba_Click);
            // 
            // lblYakitAraba
            // 
            this.lblYakitAraba.Location = new System.Drawing.Point(6, 61);
            this.lblYakitAraba.Name = "lblYakitAraba";
            this.lblYakitAraba.Size = new System.Drawing.Size(85, 23);
            this.lblYakitAraba.TabIndex = 0;
            this.lblYakitAraba.Text = "Yakıt Türü:";
            // 
            // lblBeygirAraba
            // 
            this.lblBeygirAraba.Location = new System.Drawing.Point(6, 89);
            this.lblBeygirAraba.Name = "lblBeygirAraba";
            this.lblBeygirAraba.Size = new System.Drawing.Size(98, 23);
            this.lblBeygirAraba.TabIndex = 0;
            this.lblBeygirAraba.Text = "Beygir Gücü:";
            // 
            // nmrBeygirAraba
            // 
            this.nmrBeygirAraba.Location = new System.Drawing.Point(128, 88);
            this.nmrBeygirAraba.Name = "nmrBeygirAraba";
            this.nmrBeygirAraba.Size = new System.Drawing.Size(225, 22);
            this.nmrBeygirAraba.TabIndex = 2;
            // 
            // lblMotorGucuAraba
            // 
            this.lblMotorGucuAraba.Location = new System.Drawing.Point(6, 119);
            this.lblMotorGucuAraba.Name = "lblMotorGucuAraba";
            this.lblMotorGucuAraba.Size = new System.Drawing.Size(98, 23);
            this.lblMotorGucuAraba.TabIndex = 0;
            this.lblMotorGucuAraba.Text = "Motor Gücü:";
            // 
            // cmbYakitAraba
            // 
            this.cmbYakitAraba.FormattingEnabled = true;
            this.cmbYakitAraba.Location = new System.Drawing.Point(128, 58);
            this.cmbYakitAraba.Name = "cmbYakitAraba";
            this.cmbYakitAraba.Size = new System.Drawing.Size(225, 24);
            this.cmbYakitAraba.TabIndex = 1;
            // 
            // cmbVitesAraba
            // 
            this.cmbVitesAraba.FormattingEnabled = true;
            this.cmbVitesAraba.Location = new System.Drawing.Point(128, 27);
            this.cmbVitesAraba.Name = "cmbVitesAraba";
            this.cmbVitesAraba.Size = new System.Drawing.Size(225, 24);
            this.cmbVitesAraba.TabIndex = 1;
            // 
            // grpTekne
            // 
            this.grpTekne.Controls.Add(this.txtMotorTekne);
            this.grpTekne.Controls.Add(this.btnTekneEkle);
            this.grpTekne.Controls.Add(this.lblYakitTekne);
            this.grpTekne.Controls.Add(this.lblBeygirTekne);
            this.grpTekne.Controls.Add(this.btnMotorTekne);
            this.grpTekne.Controls.Add(this.lblMotorTekne);
            this.grpTekne.Controls.Add(this.nmrBeygirTekne);
            this.grpTekne.Controls.Add(this.cmbYakitTekne);
            this.grpTekne.Location = new System.Drawing.Point(709, 468);
            this.grpTekne.Name = "grpTekne";
            this.grpTekne.Size = new System.Drawing.Size(370, 204);
            this.grpTekne.TabIndex = 4;
            this.grpTekne.TabStop = false;
            this.grpTekne.Text = "Tekne Ekle";
            // 
            // txtMotorTekne
            // 
            this.txtMotorTekne.Location = new System.Drawing.Point(180, 91);
            this.txtMotorTekne.Name = "txtMotorTekne";
            this.txtMotorTekne.Size = new System.Drawing.Size(173, 22);
            this.txtMotorTekne.TabIndex = 3;
            // 
            // btnTekneEkle
            // 
            this.btnTekneEkle.Location = new System.Drawing.Point(217, 159);
            this.btnTekneEkle.Name = "btnTekneEkle";
            this.btnTekneEkle.Size = new System.Drawing.Size(139, 37);
            this.btnTekneEkle.TabIndex = 1;
            this.btnTekneEkle.Text = "Tekne Ekle";
            this.btnTekneEkle.UseVisualStyleBackColor = true;
            this.btnTekneEkle.Click += new System.EventHandler(this.btnTekneEkle_Click);
            // 
            // lblYakitTekne
            // 
            this.lblYakitTekne.Location = new System.Drawing.Point(6, 36);
            this.lblYakitTekne.Name = "lblYakitTekne";
            this.lblYakitTekne.Size = new System.Drawing.Size(85, 23);
            this.lblYakitTekne.TabIndex = 0;
            this.lblYakitTekne.Text = "Yakıt Türü:";
            // 
            // lblBeygirTekne
            // 
            this.lblBeygirTekne.Location = new System.Drawing.Point(6, 64);
            this.lblBeygirTekne.Name = "lblBeygirTekne";
            this.lblBeygirTekne.Size = new System.Drawing.Size(98, 23);
            this.lblBeygirTekne.TabIndex = 0;
            this.lblBeygirTekne.Text = "Beygir Gücü:";
            // 
            // btnMotorTekne
            // 
            this.btnMotorTekne.Location = new System.Drawing.Point(9, 159);
            this.btnMotorTekne.Name = "btnMotorTekne";
            this.btnMotorTekne.Size = new System.Drawing.Size(146, 37);
            this.btnMotorTekne.TabIndex = 1;
            this.btnMotorTekne.Text = "Motor Gücü Hesapla";
            this.btnMotorTekne.UseVisualStyleBackColor = true;
            this.btnMotorTekne.Click += new System.EventHandler(this.btnMotorTekne_Click);
            // 
            // lblMotorTekne
            // 
            this.lblMotorTekne.Location = new System.Drawing.Point(6, 94);
            this.lblMotorTekne.Name = "lblMotorTekne";
            this.lblMotorTekne.Size = new System.Drawing.Size(98, 23);
            this.lblMotorTekne.TabIndex = 0;
            this.lblMotorTekne.Text = "Motor Gücü:";
            // 
            // nmrBeygirTekne
            // 
            this.nmrBeygirTekne.Location = new System.Drawing.Point(180, 63);
            this.nmrBeygirTekne.Name = "nmrBeygirTekne";
            this.nmrBeygirTekne.Size = new System.Drawing.Size(173, 22);
            this.nmrBeygirTekne.TabIndex = 2;
            // 
            // cmbYakitTekne
            // 
            this.cmbYakitTekne.FormattingEnabled = true;
            this.cmbYakitTekne.Location = new System.Drawing.Point(180, 33);
            this.cmbYakitTekne.Name = "cmbYakitTekne";
            this.cmbYakitTekne.Size = new System.Drawing.Size(173, 24);
            this.cmbYakitTekne.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 684);
            this.Controls.Add(this.grpTekne);
            this.Controls.Add(this.grpAraba);
            this.Controls.Add(this.grpArac);
            this.Controls.Add(this.grpMotosiklet);
            this.Controls.Add(this.grpBisiklet);
            this.Controls.Add(this.dgwList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwList)).EndInit();
            this.grpBisiklet.ResumeLayout(false);
            this.grpBisiklet.PerformLayout();
            this.grpMotosiklet.ResumeLayout(false);
            this.grpMotosiklet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirMotor)).EndInit();
            this.grpArac.ResumeLayout(false);
            this.grpArac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKoltukSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrR)).EndInit();
            this.grpAraba.ResumeLayout(false);
            this.grpAraba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirAraba)).EndInit();
            this.grpTekne.ResumeLayout(false);
            this.grpTekne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBeygirTekne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwList;
        private System.Windows.Forms.GroupBox grpBisiklet;
        private System.Windows.Forms.Button btnBisikletEkle;
        private System.Windows.Forms.CheckBox chkSeles;
        private System.Windows.Forms.CheckBox chkVites;
        private System.Windows.Forms.GroupBox grpMotosiklet;
        private System.Windows.Forms.Button btnMotorEkle;
        private System.Windows.Forms.Button btnMotorGucuMotor;
        private System.Windows.Forms.NumericUpDown nmrBeygirMotor;
        private System.Windows.Forms.ComboBox cmbYakitMotor;
        private System.Windows.Forms.ComboBox cmbVitesMotor;
        private System.Windows.Forms.Label lblBeygirMptpr;
        private System.Windows.Forms.Label lblYakitMotor;
        private System.Windows.Forms.Label lblVitesMotor;
        private System.Windows.Forms.Label lblMarkaArac;
        private System.Windows.Forms.TextBox txtMarkaArac;
        private System.Windows.Forms.GroupBox grpArac;
        private System.Windows.Forms.Label lblModelArac;
        private System.Windows.Forms.TextBox txtModelArac;
        private System.Windows.Forms.DateTimePicker dtpUretimTarihi;
        private System.Windows.Forms.Label lblRenkArac;
        private System.Windows.Forms.Label lblUretimTarihiArac;
        private System.Windows.Forms.TextBox txtMotorGucuMotor;
        private System.Windows.Forms.Label lblMotorGucuMotor;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.NumericUpDown nmrB;
        private System.Windows.Forms.NumericUpDown nmrG;
        private System.Windows.Forms.NumericUpDown nmrKoltukSayisi;
        private System.Windows.Forms.NumericUpDown nmrR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKoltukSayisi;
        private System.Windows.Forms.GroupBox grpAraba;
        private System.Windows.Forms.TextBox txtMotorGucuAraba;
        private System.Windows.Forms.Button btnArabaEkle;
        private System.Windows.Forms.Label lblVitesAraba;
        private System.Windows.Forms.Button btnMotorAraba;
        private System.Windows.Forms.Label lblYakitAraba;
        private System.Windows.Forms.Label lblBeygirAraba;
        private System.Windows.Forms.NumericUpDown nmrBeygirAraba;
        private System.Windows.Forms.Label lblMotorGucuAraba;
        private System.Windows.Forms.ComboBox cmbYakitAraba;
        private System.Windows.Forms.ComboBox cmbVitesAraba;
        private System.Windows.Forms.GroupBox grpTekne;
        private System.Windows.Forms.TextBox txtMotorTekne;
        private System.Windows.Forms.Button btnTekneEkle;
        private System.Windows.Forms.Label lblYakitTekne;
        private System.Windows.Forms.Label lblBeygirTekne;
        private System.Windows.Forms.Button btnMotorTekne;
        private System.Windows.Forms.Label lblMotorTekne;
        private System.Windows.Forms.NumericUpDown nmrBeygirTekne;
        private System.Windows.Forms.ComboBox cmbYakitTekne;
    }
}

