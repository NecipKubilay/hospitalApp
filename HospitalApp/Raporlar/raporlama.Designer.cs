namespace HospitalApp.Raporlar
{
    partial class raporlama
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRandevuRaporla = new System.Windows.Forms.Button();
            this.dtgrdRandevu = new System.Windows.Forms.DataGridView();
            this.btnRandevupdf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRaporla = new System.Windows.Forms.Button();
            this.dtgrdAmeliyat = new System.Windows.Forms.DataGridView();
            this.btnAmeliyatpdf = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRandevu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAmeliyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRandevuRaporla);
            this.groupBox2.Controls.Add(this.dtgrdRandevu);
            this.groupBox2.Controls.Add(this.btnRandevupdf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(971, 356);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Bilgi";
            // 
            // btnRandevuRaporla
            // 
            this.btnRandevuRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRandevuRaporla.Location = new System.Drawing.Point(253, 286);
            this.btnRandevuRaporla.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandevuRaporla.Name = "btnRandevuRaporla";
            this.btnRandevuRaporla.Size = new System.Drawing.Size(200, 50);
            this.btnRandevuRaporla.TabIndex = 12;
            this.btnRandevuRaporla.Text = "Raporla";
            this.btnRandevuRaporla.UseVisualStyleBackColor = false;
            this.btnRandevuRaporla.Click += new System.EventHandler(this.btnRandevuRaporla_Click);
            // 
            // dtgrdRandevu
            // 
            this.dtgrdRandevu.AllowUserToAddRows = false;
            this.dtgrdRandevu.AllowUserToDeleteRows = false;
            this.dtgrdRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdRandevu.Location = new System.Drawing.Point(8, 43);
            this.dtgrdRandevu.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdRandevu.Name = "dtgrdRandevu";
            this.dtgrdRandevu.ReadOnly = true;
            this.dtgrdRandevu.RowHeadersWidth = 51;
            this.dtgrdRandevu.Size = new System.Drawing.Size(955, 235);
            this.dtgrdRandevu.TabIndex = 17;
            // 
            // btnRandevupdf
            // 
            this.btnRandevupdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRandevupdf.Location = new System.Drawing.Point(488, 286);
            this.btnRandevupdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandevupdf.Name = "btnRandevupdf";
            this.btnRandevupdf.Size = new System.Drawing.Size(176, 50);
            this.btnRandevupdf.TabIndex = 14;
            this.btnRandevupdf.Text = "PDF";
            this.btnRandevupdf.UseVisualStyleBackColor = false;
            this.btnRandevupdf.Click += new System.EventHandler(this.btnRandevupdf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRaporla);
            this.groupBox1.Controls.Add(this.dtgrdAmeliyat);
            this.groupBox1.Controls.Add(this.btnAmeliyatpdf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(971, 356);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ameliyat Bilgi";
            // 
            // btnRaporla
            // 
            this.btnRaporla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnRaporla.Location = new System.Drawing.Point(253, 286);
            this.btnRaporla.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporla.Name = "btnRaporla";
            this.btnRaporla.Size = new System.Drawing.Size(200, 50);
            this.btnRaporla.TabIndex = 12;
            this.btnRaporla.Text = "Raporla";
            this.btnRaporla.UseVisualStyleBackColor = false;
            this.btnRaporla.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // dtgrdAmeliyat
            // 
            this.dtgrdAmeliyat.AllowUserToAddRows = false;
            this.dtgrdAmeliyat.AllowUserToDeleteRows = false;
            this.dtgrdAmeliyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdAmeliyat.Location = new System.Drawing.Point(8, 43);
            this.dtgrdAmeliyat.Margin = new System.Windows.Forms.Padding(4);
            this.dtgrdAmeliyat.Name = "dtgrdAmeliyat";
            this.dtgrdAmeliyat.ReadOnly = true;
            this.dtgrdAmeliyat.RowHeadersWidth = 51;
            this.dtgrdAmeliyat.Size = new System.Drawing.Size(955, 235);
            this.dtgrdAmeliyat.TabIndex = 17;
            // 
            // btnAmeliyatpdf
            // 
            this.btnAmeliyatpdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.btnAmeliyatpdf.Location = new System.Drawing.Point(488, 286);
            this.btnAmeliyatpdf.Margin = new System.Windows.Forms.Padding(4);
            this.btnAmeliyatpdf.Name = "btnAmeliyatpdf";
            this.btnAmeliyatpdf.Size = new System.Drawing.Size(176, 50);
            this.btnAmeliyatpdf.TabIndex = 14;
            this.btnAmeliyatpdf.Text = "PDF";
            this.btnAmeliyatpdf.UseVisualStyleBackColor = false;
            this.btnAmeliyatpdf.Click += new System.EventHandler(this.btnAmeliyatpdf_Click);
            // 
            // raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1007, 786);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "raporlama";
            this.Text = "raporlama";
            this.Load += new System.EventHandler(this.raporlama_Load_1);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdRandevu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdAmeliyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRandevuRaporla;
        private System.Windows.Forms.DataGridView dtgrdRandevu;
        private System.Windows.Forms.Button btnRandevupdf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRaporla;
        private System.Windows.Forms.DataGridView dtgrdAmeliyat;
        private System.Windows.Forms.Button btnAmeliyatpdf;
    }
}