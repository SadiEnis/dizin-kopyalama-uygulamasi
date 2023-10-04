namespace hafta7_odev1_dizinKopyalamaUygulaması
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
            this.bttn_DosyaSec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_KaydedilecekDosya = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bttn_Kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bttn_DosyaSec
            // 
            this.bttn_DosyaSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_DosyaSec.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_DosyaSec.Location = new System.Drawing.Point(60, 22);
            this.bttn_DosyaSec.Name = "bttn_DosyaSec";
            this.bttn_DosyaSec.Size = new System.Drawing.Size(195, 32);
            this.bttn_DosyaSec.TabIndex = 0;
            this.bttn_DosyaSec.Text = "Kaynak Dizini Seç";
            this.bttn_DosyaSec.UseVisualStyleBackColor = true;
            this.bttn_DosyaSec.Click += new System.EventHandler(this.bttn_DosyaSec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = " ";
            // 
            // bttn_KaydedilecekDosya
            // 
            this.bttn_KaydedilecekDosya.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_KaydedilecekDosya.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_KaydedilecekDosya.Location = new System.Drawing.Point(60, 120);
            this.bttn_KaydedilecekDosya.Name = "bttn_KaydedilecekDosya";
            this.bttn_KaydedilecekDosya.Size = new System.Drawing.Size(195, 32);
            this.bttn_KaydedilecekDosya.TabIndex = 2;
            this.bttn_KaydedilecekDosya.Text = "Hedef Dizini Seç";
            this.bttn_KaydedilecekDosya.UseVisualStyleBackColor = true;
            this.bttn_KaydedilecekDosya.Click += new System.EventHandler(this.bttn_KaydedilecekDosya_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = " ";
            // 
            // bttn_Kaydet
            // 
            this.bttn_Kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttn_Kaydet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttn_Kaydet.Location = new System.Drawing.Point(168, 218);
            this.bttn_Kaydet.Name = "bttn_Kaydet";
            this.bttn_Kaydet.Size = new System.Drawing.Size(87, 32);
            this.bttn_Kaydet.TabIndex = 4;
            this.bttn_Kaydet.Text = "Kaydet";
            this.bttn_Kaydet.UseVisualStyleBackColor = true;
            this.bttn_Kaydet.Click += new System.EventHandler(this.bttn_Kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 44);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 46);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(441, 275);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttn_Kaydet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_KaydedilecekDosya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttn_DosyaSec);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dosya Kopyalama Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_DosyaSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_KaydedilecekDosya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttn_Kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

