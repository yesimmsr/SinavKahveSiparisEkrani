
namespace SinavKahveSiparisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.TxtAdress = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.gbUrunler = new System.Windows.Forms.GroupBox();
            this.numSicakIcecekler = new System.Windows.Forms.NumericUpDown();
            this.numSogukIcecekler = new System.Windows.Forms.NumericUpDown();
            this.numKahveler = new System.Windows.Forms.NumericUpDown();
            this.lblAdet = new System.Windows.Forms.Label();
            this.cmbSicakIcecekler = new System.Windows.Forms.ComboBox();
            this.cmbSogukIcecekler = new System.Windows.Forms.ComboBox();
            this.cmbKahveler = new System.Windows.Forms.ComboBox();
            this.lblSogukIcecekler = new System.Windows.Forms.Label();
            this.lblSicakIcecekler = new System.Windows.Forms.Label();
            this.lblKahveler = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gbEkstralar = new System.Windows.Forms.GroupBox();
            this.rdbTall = new System.Windows.Forms.RadioButton();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbVenti = new System.Windows.Forms.RadioButton();
            this.lblIcecekBoyutu = new System.Windows.Forms.Label();
            this.rdbSutSoya = new System.Windows.Forms.RadioButton();
            this.rdbSutYagsiz = new System.Windows.Forms.RadioButton();
            this.lblSut = new System.Windows.Forms.Label();
            this.lblShot = new System.Windows.Forms.Label();
            this.chbShot2 = new System.Windows.Forms.CheckBox();
            this.chbShot1 = new System.Windows.Forms.CheckBox();
            this.gbSiparisler = new System.Windows.Forms.GroupBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.pnlBaslik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMusteriBilgileri.SuspendLayout();
            this.gbUrunler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSicakIcecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSogukIcecekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKahveler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gbEkstralar.SuspendLayout();
            this.gbSiparisler.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBaslik
            // 
            this.pnlBaslik.Controls.Add(this.pictureBox1);
            this.pnlBaslik.Controls.Add(this.label1);
            this.pnlBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBaslik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(725, 100);
            this.pnlBaslik.TabIndex = 0;
            this.pnlBaslik.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBaslik_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilge Kahve Evi Sipariş Ekranı";
            // 
            // gbMusteriBilgileri
            // 
            this.gbMusteriBilgileri.Controls.Add(this.txtTelefon);
            this.gbMusteriBilgileri.Controls.Add(this.TxtAdress);
            this.gbMusteriBilgileri.Controls.Add(this.txtAdSoyad);
            this.gbMusteriBilgileri.Controls.Add(this.lblAdress);
            this.gbMusteriBilgileri.Controls.Add(this.lblTelefon);
            this.gbMusteriBilgileri.Controls.Add(this.lblAdSoyad);
            this.gbMusteriBilgileri.Location = new System.Drawing.Point(0, 106);
            this.gbMusteriBilgileri.Name = "gbMusteriBilgileri";
            this.gbMusteriBilgileri.Size = new System.Drawing.Size(369, 165);
            this.gbMusteriBilgileri.TabIndex = 1;
            this.gbMusteriBilgileri.TabStop = false;
            this.gbMusteriBilgileri.Text = "Müşter Bilgileri";
            // 
            // TxtAdress
            // 
            this.TxtAdress.Location = new System.Drawing.Point(89, 91);
            this.TxtAdress.Name = "TxtAdress";
            this.TxtAdress.Size = new System.Drawing.Size(250, 25);
            this.TxtAdress.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(89, 24);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(250, 25);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(6, 99);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(56, 17);
            this.lblAdress.TabIndex = 2;
            this.lblAdress.Text = "Adress :";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 63);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(58, 17);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 32);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(77, 17);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad : ";
            // 
            // gbUrunler
            // 
            this.gbUrunler.Controls.Add(this.numSicakIcecekler);
            this.gbUrunler.Controls.Add(this.numSogukIcecekler);
            this.gbUrunler.Controls.Add(this.numKahveler);
            this.gbUrunler.Controls.Add(this.lblAdet);
            this.gbUrunler.Controls.Add(this.cmbSicakIcecekler);
            this.gbUrunler.Controls.Add(this.cmbSogukIcecekler);
            this.gbUrunler.Controls.Add(this.cmbKahveler);
            this.gbUrunler.Controls.Add(this.lblSogukIcecekler);
            this.gbUrunler.Controls.Add(this.lblSicakIcecekler);
            this.gbUrunler.Controls.Add(this.lblKahveler);
            this.gbUrunler.Controls.Add(this.pictureBox4);
            this.gbUrunler.Controls.Add(this.pictureBox3);
            this.gbUrunler.Controls.Add(this.pictureBox2);
            this.gbUrunler.Location = new System.Drawing.Point(0, 270);
            this.gbUrunler.Name = "gbUrunler";
            this.gbUrunler.Size = new System.Drawing.Size(369, 188);
            this.gbUrunler.TabIndex = 2;
            this.gbUrunler.TabStop = false;
            this.gbUrunler.Text = "Ürünler";
            // 
            // numSicakIcecekler
            // 
            this.numSicakIcecekler.Location = new System.Drawing.Point(309, 142);
            this.numSicakIcecekler.Name = "numSicakIcecekler";
            this.numSicakIcecekler.Size = new System.Drawing.Size(54, 25);
            this.numSicakIcecekler.TabIndex = 15;
            // 
            // numSogukIcecekler
            // 
            this.numSogukIcecekler.Location = new System.Drawing.Point(309, 94);
            this.numSogukIcecekler.Name = "numSogukIcecekler";
            this.numSogukIcecekler.Size = new System.Drawing.Size(54, 25);
            this.numSogukIcecekler.TabIndex = 14;
            // 
            // numKahveler
            // 
            this.numKahveler.Location = new System.Drawing.Point(309, 44);
            this.numKahveler.Name = "numKahveler";
            this.numKahveler.Size = new System.Drawing.Size(54, 25);
            this.numKahveler.TabIndex = 13;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(321, 21);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(37, 17);
            this.lblAdet.TabIndex = 12;
            this.lblAdet.Text = "Adet";
            // 
            // cmbSicakIcecekler
            // 
            this.cmbSicakIcecekler.FormattingEnabled = true;
            this.cmbSicakIcecekler.Location = new System.Drawing.Point(168, 147);
            this.cmbSicakIcecekler.Name = "cmbSicakIcecekler";
            this.cmbSicakIcecekler.Size = new System.Drawing.Size(121, 25);
            this.cmbSicakIcecekler.TabIndex = 8;
            // 
            // cmbSogukIcecekler
            // 
            this.cmbSogukIcecekler.FormattingEnabled = true;
            this.cmbSogukIcecekler.Location = new System.Drawing.Point(168, 94);
            this.cmbSogukIcecekler.Name = "cmbSogukIcecekler";
            this.cmbSogukIcecekler.Size = new System.Drawing.Size(121, 25);
            this.cmbSogukIcecekler.TabIndex = 7;
            // 
            // cmbKahveler
            // 
            this.cmbKahveler.FormattingEnabled = true;
            this.cmbKahveler.Location = new System.Drawing.Point(168, 43);
            this.cmbKahveler.Name = "cmbKahveler";
            this.cmbKahveler.Size = new System.Drawing.Size(121, 25);
            this.cmbKahveler.TabIndex = 6;
            // 
            // lblSogukIcecekler
            // 
            this.lblSogukIcecekler.AutoSize = true;
            this.lblSogukIcecekler.Location = new System.Drawing.Point(57, 102);
            this.lblSogukIcecekler.Name = "lblSogukIcecekler";
            this.lblSogukIcecekler.Size = new System.Drawing.Size(113, 17);
            this.lblSogukIcecekler.TabIndex = 5;
            this.lblSogukIcecekler.Text = "Soğuk İçecekler : ";
            // 
            // lblSicakIcecekler
            // 
            this.lblSicakIcecekler.AutoSize = true;
            this.lblSicakIcecekler.Location = new System.Drawing.Point(57, 150);
            this.lblSicakIcecekler.Name = "lblSicakIcecekler";
            this.lblSicakIcecekler.Size = new System.Drawing.Size(105, 17);
            this.lblSicakIcecekler.TabIndex = 4;
            this.lblSicakIcecekler.Text = "Sıcak İçecekler : ";
            // 
            // lblKahveler
            // 
            this.lblKahveler.AutoSize = true;
            this.lblKahveler.Location = new System.Drawing.Point(57, 46);
            this.lblKahveler.Name = "lblKahveler";
            this.lblKahveler.Size = new System.Drawing.Size(71, 17);
            this.lblKahveler.TabIndex = 3;
            this.lblKahveler.Text = "Kahveler : ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gbEkstralar
            // 
            this.gbEkstralar.Controls.Add(this.chbShot2);
            this.gbEkstralar.Controls.Add(this.rdbTall);
            this.gbEkstralar.Controls.Add(this.rdbGrande);
            this.gbEkstralar.Controls.Add(this.rdbVenti);
            this.gbEkstralar.Controls.Add(this.lblIcecekBoyutu);
            this.gbEkstralar.Controls.Add(this.rdbSutSoya);
            this.gbEkstralar.Controls.Add(this.rdbSutYagsiz);
            this.gbEkstralar.Controls.Add(this.lblSut);
            this.gbEkstralar.Controls.Add(this.lblShot);
            this.gbEkstralar.Controls.Add(this.chbShot1);
            this.gbEkstralar.Location = new System.Drawing.Point(0, 464);
            this.gbEkstralar.Name = "gbEkstralar";
            this.gbEkstralar.Size = new System.Drawing.Size(369, 154);
            this.gbEkstralar.TabIndex = 3;
            this.gbEkstralar.TabStop = false;
            this.gbEkstralar.Text = "Ekstralar";
            // 
            // rdbTall
            // 
            this.rdbTall.AutoSize = true;
            this.rdbTall.Location = new System.Drawing.Point(318, 115);
            this.rdbTall.Name = "rdbTall";
            this.rdbTall.Size = new System.Drawing.Size(45, 21);
            this.rdbTall.TabIndex = 11;
            this.rdbTall.TabStop = true;
            this.rdbTall.Text = "Tall";
            this.rdbTall.UseVisualStyleBackColor = true;
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(248, 115);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(70, 21);
            this.rdbGrande.TabIndex = 10;
            this.rdbGrande.TabStop = true;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            // 
            // rdbVenti
            // 
            this.rdbVenti.AutoSize = true;
            this.rdbVenti.Location = new System.Drawing.Point(168, 115);
            this.rdbVenti.Name = "rdbVenti";
            this.rdbVenti.Size = new System.Drawing.Size(56, 21);
            this.rdbVenti.TabIndex = 9;
            this.rdbVenti.TabStop = true;
            this.rdbVenti.Text = "Venti";
            this.rdbVenti.UseVisualStyleBackColor = true;
            // 
            // lblIcecekBoyutu
            // 
            this.lblIcecekBoyutu.AutoSize = true;
            this.lblIcecekBoyutu.Location = new System.Drawing.Point(28, 119);
            this.lblIcecekBoyutu.Name = "lblIcecekBoyutu";
            this.lblIcecekBoyutu.Size = new System.Drawing.Size(100, 17);
            this.lblIcecekBoyutu.TabIndex = 8;
            this.lblIcecekBoyutu.Text = "İçecek Boyutu :";
            // 
            // rdbSutSoya
            // 
            this.rdbSutSoya.AutoSize = true;
            this.rdbSutSoya.Location = new System.Drawing.Point(248, 71);
            this.rdbSutSoya.Name = "rdbSutSoya";
            this.rdbSutSoya.Size = new System.Drawing.Size(55, 21);
            this.rdbSutSoya.TabIndex = 7;
            this.rdbSutSoya.TabStop = true;
            this.rdbSutSoya.Text = "Soya";
            this.rdbSutSoya.UseVisualStyleBackColor = true;
            // 
            // rdbSutYagsiz
            // 
            this.rdbSutYagsiz.AutoSize = true;
            this.rdbSutYagsiz.Location = new System.Drawing.Point(168, 71);
            this.rdbSutYagsiz.Name = "rdbSutYagsiz";
            this.rdbSutYagsiz.Size = new System.Drawing.Size(63, 21);
            this.rdbSutYagsiz.TabIndex = 6;
            this.rdbSutYagsiz.TabStop = true;
            this.rdbSutYagsiz.Text = "Yağsız";
            this.rdbSutYagsiz.UseVisualStyleBackColor = true;
            // 
            // lblSut
            // 
            this.lblSut.AutoSize = true;
            this.lblSut.Location = new System.Drawing.Point(28, 75);
            this.lblSut.Name = "lblSut";
            this.lblSut.Size = new System.Drawing.Size(39, 17);
            this.lblSut.TabIndex = 5;
            this.lblSut.Text = "Süt : ";
            // 
            // lblShot
            // 
            this.lblShot.AutoSize = true;
            this.lblShot.Location = new System.Drawing.Point(28, 28);
            this.lblShot.Name = "lblShot";
            this.lblShot.Size = new System.Drawing.Size(40, 17);
            this.lblShot.TabIndex = 4;
            this.lblShot.Text = "Shot ";
            // 
            // chbShot2
            // 
            this.chbShot2.AutoSize = true;
            this.chbShot2.Location = new System.Drawing.Point(248, 24);
            this.chbShot2.Name = "chbShot2";
            this.chbShot2.Size = new System.Drawing.Size(41, 21);
            this.chbShot2.TabIndex = 1;
            this.chbShot2.Text = "2x";
            this.chbShot2.UseVisualStyleBackColor = true;
            // 
            // chbShot1
            // 
            this.chbShot1.AutoSize = true;
            this.chbShot1.Location = new System.Drawing.Point(168, 24);
            this.chbShot1.Name = "chbShot1";
            this.chbShot1.Size = new System.Drawing.Size(39, 21);
            this.chbShot1.TabIndex = 0;
            this.chbShot1.Text = "1x";
            this.chbShot1.UseVisualStyleBackColor = true;
            // 
            // gbSiparisler
            // 
            this.gbSiparisler.Controls.Add(this.lstSiparisler);
            this.gbSiparisler.Location = new System.Drawing.Point(388, 106);
            this.gbSiparisler.Name = "gbSiparisler";
            this.gbSiparisler.Size = new System.Drawing.Size(325, 450);
            this.gbSiparisler.TabIndex = 5;
            this.gbSiparisler.TabStop = false;
            this.gbSiparisler.Text = "Siparişler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 17;
            this.lstSiparisler.Location = new System.Drawing.Point(13, 23);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(306, 412);
            this.lstSiparisler.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(398, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Toplam Sipariş tutarı : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(0, 641);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(369, 35);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(388, 641);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(337, 35);
            this.btnSiparisVer.TabIndex = 8;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(89, 55);
            this.txtTelefon.Mask = "(###)-###-##-##";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(250, 25);
            this.txtTelefon.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 688);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSiparisler);
            this.Controls.Add(this.gbEkstralar);
            this.Controls.Add(this.gbUrunler);
            this.Controls.Add(this.gbMusteriBilgileri);
            this.Controls.Add(this.pnlBaslik);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilge Kahve Evi v1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMusteriBilgileri.ResumeLayout(false);
            this.gbMusteriBilgileri.PerformLayout();
            this.gbUrunler.ResumeLayout(false);
            this.gbUrunler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSicakIcecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSogukIcecekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKahveler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gbEkstralar.ResumeLayout(false);
            this.gbEkstralar.PerformLayout();
            this.gbSiparisler.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbMusteriBilgileri;
        private System.Windows.Forms.TextBox TxtAdress;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.GroupBox gbUrunler;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.ComboBox cmbSicakIcecekler;
        private System.Windows.Forms.ComboBox cmbSogukIcecekler;
        private System.Windows.Forms.ComboBox cmbKahveler;
        private System.Windows.Forms.Label lblSogukIcecekler;
        private System.Windows.Forms.Label lblSicakIcecekler;
        private System.Windows.Forms.Label lblKahveler;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbEkstralar;
        private System.Windows.Forms.RadioButton rdbTall;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbVenti;
        private System.Windows.Forms.Label lblIcecekBoyutu;
        private System.Windows.Forms.RadioButton rdbSutSoya;
        private System.Windows.Forms.RadioButton rdbSutYagsiz;
        private System.Windows.Forms.Label lblSut;
        private System.Windows.Forms.Label lblShot;
        private System.Windows.Forms.CheckBox chbShot2;
        private System.Windows.Forms.CheckBox chbShot1;
        private System.Windows.Forms.GroupBox gbSiparisler;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.NumericUpDown numSicakIcecekler;
        private System.Windows.Forms.NumericUpDown numSogukIcecekler;
        private System.Windows.Forms.NumericUpDown numKahveler;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
    }
}

