namespace HospitalApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Secretary = new System.Windows.Forms.PictureBox();
            this.Doctor = new System.Windows.Forms.PictureBox();
            this.Admin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Secretary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Secretary
            // 
            this.Secretary.Image = ((System.Drawing.Image)(resources.GetObject("Secretary.Image")));
            this.Secretary.Location = new System.Drawing.Point(393, 192);
            this.Secretary.Name = "Secretary";
            this.Secretary.Size = new System.Drawing.Size(200, 200);
            this.Secretary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Secretary.TabIndex = 0;
            this.Secretary.TabStop = false;
            this.Secretary.Click += new System.EventHandler(this.Secretary_Click);
            // 
            // Doctor
            // 
            this.Doctor.Image = ((System.Drawing.Image)(resources.GetObject("Doctor.Image")));
            this.Doctor.Location = new System.Drawing.Point(690, 192);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(200, 200);
            this.Doctor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Doctor.TabIndex = 1;
            this.Doctor.TabStop = false;
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Admin
            // 
            this.Admin.Image = ((System.Drawing.Image)(resources.GetObject("Admin.Image")));
            this.Admin.Location = new System.Drawing.Point(91, 192);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(200, 200);
            this.Admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Admin.TabIndex = 2;
            this.Admin.TabStop = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(393, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hospital App";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(840, 59);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(50, 50);
            this.exitButton.TabIndex = 4;
            this.exitButton.TabStop = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.Secretary);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Secretary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Doctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Secretary;
        private System.Windows.Forms.PictureBox Doctor;
        private System.Windows.Forms.PictureBox Admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox exitButton;
    }
}

