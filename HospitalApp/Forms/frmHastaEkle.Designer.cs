namespace HospitalApp.Forms
{
    partial class frmHastaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaEkle));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTelAra = new System.Windows.Forms.TextBox();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.lblToplamKadin = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblToplamErkek = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToplamHasta = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgrdHastaAra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pctrbxİptal = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpcDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.rdbtnK = new System.Windows.Forms.RadioButton();
            this.rdbtnE = new System.Windows.Forms.RadioButton();
            this.msktxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.msktxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdHastaAra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxİptal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTelAra);
            this.groupBox2.Controls.Add(this.txtTcAra);
            this.groupBox2.Controls.Add(this.lblToplamKadin);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblToplamErkek);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblToplamHasta);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dtgrdHastaAra);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(640, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(613, 501);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Listeleme ve Arama";
            // 
            // txtTelAra
            // 
            this.txtTelAra.Location = new System.Drawing.Point(229, 97);
            this.txtTelAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelAra.Name = "txtTelAra";
            this.txtTelAra.Size = new System.Drawing.Size(219, 30);
            this.txtTelAra.TabIndex = 32;
            this.txtTelAra.TextChanged += new System.EventHandler(this.txtTelAra_TextChanged);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(229, 48);
            this.txtTcAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(219, 30);
            this.txtTcAra.TabIndex = 31;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // lblToplamKadin
            // 
            this.lblToplamKadin.AutoSize = true;
            this.lblToplamKadin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKadin.Location = new System.Drawing.Point(228, 423);
            this.lblToplamKadin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamKadin.Name = "lblToplamKadin";
            this.lblToplamKadin.Size = new System.Drawing.Size(30, 35);
            this.lblToplamKadin.TabIndex = 30;
            this.lblToplamKadin.Text = "...";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(9, 428);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Kadın Hasta Sayısı: ";
            // 
            // lblToplamErkek
            // 
            this.lblToplamErkek.AutoSize = true;
            this.lblToplamErkek.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamErkek.Location = new System.Drawing.Point(225, 458);
            this.lblToplamErkek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamErkek.Name = "lblToplamErkek";
            this.lblToplamErkek.Size = new System.Drawing.Size(30, 35);
            this.lblToplamErkek.TabIndex = 28;
            this.lblToplamErkek.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(10, 463);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Erkek Hasta Sayısı: ";
            // 
            // lblToplamHasta
            // 
            this.lblToplamHasta.AutoSize = true;
            this.lblToplamHasta.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamHasta.Location = new System.Drawing.Point(548, 438);
            this.lblToplamHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamHasta.Name = "lblToplamHasta";
            this.lblToplamHasta.Size = new System.Drawing.Size(30, 35);
            this.lblToplamHasta.TabIndex = 26;
            this.lblToplamHasta.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(293, 443);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(226, 25);
            this.label13.TabIndex = 25;
            this.label13.Text = "Listelenen Hasta Sayısı: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hasta TC Ara:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Hasta Telefon Ara:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(472, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dtgrdHastaAra
            // 
            this.dtgrdHastaAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdHastaAra.Location = new System.Drawing.Point(8, 151);
            this.dtgrdHastaAra.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdHastaAra.Name = "dtgrdHastaAra";
            this.dtgrdHastaAra.RowHeadersWidth = 51;
            this.dtgrdHastaAra.Size = new System.Drawing.Size(579, 268);
            this.dtgrdHastaAra.TabIndex = 14;
            this.dtgrdHastaAra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdHastaAra_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.pctrbxİptal);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.dtpcDogumTarih);
            this.groupBox1.Controls.Add(this.rdbtnK);
            this.groupBox1.Controls.Add(this.rdbtnE);
            this.groupBox1.Controls.Add(this.msktxtTelefon);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.msktxtTC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(32, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(584, 507);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgi";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnSil.Location = new System.Drawing.Point(272, 410);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 57);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // pctrbxİptal
            // 
            this.pctrbxİptal.Image = ((System.Drawing.Image)(resources.GetObject("pctrbxİptal.Image")));
            this.pctrbxİptal.Location = new System.Drawing.Point(175, 410);
            this.pctrbxİptal.Margin = new System.Windows.Forms.Padding(4);
            this.pctrbxİptal.Name = "pctrbxİptal";
            this.pctrbxİptal.Size = new System.Drawing.Size(73, 54);
            this.pctrbxİptal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxİptal.TabIndex = 14;
            this.pctrbxİptal.TabStop = false;
            this.pctrbxİptal.Click += new System.EventHandler(this.pctrbxİptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnEkle.Location = new System.Drawing.Point(367, 410);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(176, 57);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpcDogumTarih
            // 
            this.dtpcDogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dtpcDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcDogumTarih.Location = new System.Drawing.Point(269, 305);
            this.dtpcDogumTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpcDogumTarih.Name = "dtpcDogumTarih";
            this.dtpcDogumTarih.Size = new System.Drawing.Size(272, 41);
            this.dtpcDogumTarih.TabIndex = 10;
            this.dtpcDogumTarih.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // rdbtnK
            // 
            this.rdbtnK.AutoSize = true;
            this.rdbtnK.Location = new System.Drawing.Point(272, 353);
            this.rdbtnK.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnK.Name = "rdbtnK";
            this.rdbtnK.Size = new System.Drawing.Size(57, 40);
            this.rdbtnK.TabIndex = 11;
            this.rdbtnK.TabStop = true;
            this.rdbtnK.Text = "K";
            this.rdbtnK.UseVisualStyleBackColor = true;
            // 
            // rdbtnE
            // 
            this.rdbtnE.AutoSize = true;
            this.rdbtnE.Location = new System.Drawing.Point(383, 353);
            this.rdbtnE.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtnE.Name = "rdbtnE";
            this.rdbtnE.Size = new System.Drawing.Size(57, 40);
            this.rdbtnE.TabIndex = 10;
            this.rdbtnE.TabStop = true;
            this.rdbtnE.Text = "E";
            this.rdbtnE.UseVisualStyleBackColor = true;
            // 
            // msktxtTelefon
            // 
            this.msktxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.msktxtTelefon.Location = new System.Drawing.Point(269, 244);
            this.msktxtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.msktxtTelefon.Mask = "(999) 000-0000";
            this.msktxtTelefon.Name = "msktxtTelefon";
            this.msktxtTelefon.Size = new System.Drawing.Size(272, 41);
            this.msktxtTelefon.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtSoyad.Location = new System.Drawing.Point(269, 182);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(272, 41);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtAd.Location = new System.Drawing.Point(269, 123);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(272, 41);
            this.txtAd.TabIndex = 7;
            // 
            // msktxtTC
            // 
            this.msktxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.msktxtTC.Location = new System.Drawing.Point(269, 63);
            this.msktxtTC.Margin = new System.Windows.Forms.Padding(4);
            this.msktxtTC.Mask = "00000000000";
            this.msktxtTC.Name = "msktxtTC";
            this.msktxtTC.Size = new System.Drawing.Size(272, 41);
            this.msktxtTC.TabIndex = 6;
            this.msktxtTC.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cinsiyet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 171);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doğum Tarihi:";
            // 
            // addPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1282, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addPatient";
            this.Text = "addPatient";
            this.Load += new System.EventHandler(this.addPatient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdHastaAra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxİptal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelAra;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label lblToplamKadin;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblToplamErkek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToplamHasta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgrdHastaAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.PictureBox pctrbxİptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpcDogumTarih;
        private System.Windows.Forms.RadioButton rdbtnK;
        private System.Windows.Forms.RadioButton rdbtnE;
        private System.Windows.Forms.MaskedTextBox msktxtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox msktxtTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}