namespace ThirdProject
{
    partial class Islevsellik3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbx1 = new System.Windows.Forms.ListBox();
            this.BtnYenile = new System.Windows.Forms.Button();
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.Lbx1);
            this.groupBox1.Controls.Add(this.BtnYenile);
            this.groupBox1.Controls.Add(this.BtnOlustur);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtSayi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(83, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 575);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Lbx1
            // 
            this.Lbx1.FormattingEnabled = true;
            this.Lbx1.ItemHeight = 23;
            this.Lbx1.Location = new System.Drawing.Point(6, 284);
            this.Lbx1.Name = "Lbx1";
            this.Lbx1.Size = new System.Drawing.Size(1120, 234);
            this.Lbx1.TabIndex = 10;
            // 
            // BtnYenile
            // 
            this.BtnYenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnYenile.Location = new System.Drawing.Point(280, 191);
            this.BtnYenile.Name = "BtnYenile";
            this.BtnYenile.Size = new System.Drawing.Size(156, 41);
            this.BtnYenile.TabIndex = 8;
            this.BtnYenile.Text = "Yenile";
            this.BtnYenile.UseVisualStyleBackColor = false;
            this.BtnYenile.Click += new System.EventHandler(this.BtnYenile_Click);
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnOlustur.Location = new System.Drawing.Point(109, 191);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(156, 41);
            this.BtnOlustur.TabIndex = 6;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = false;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oluşturulan Çarpım Tablosu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(7, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(547, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not: Sayıyı girip butona tıkladıktan sonra, o sayıya kadar olan çarpım tablonuz o" +
    "luşturulacaktır.";
            // 
            // TxtSayi
            // 
            this.TxtSayi.Location = new System.Drawing.Point(271, 133);
            this.TxtSayi.Name = "TxtSayi";
            this.TxtSayi.Size = new System.Drawing.Size(156, 30);
            this.TxtSayi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "1 - 15 arasında bir sayı giriniz:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇARPIM TABLOSU OLUŞTURUCU";
            // 
            // Islevsellik3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1327, 606);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Islevsellik3";
            this.Text = "İşlevsellik3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSayi;
        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Button BtnYenile;
        private System.Windows.Forms.ListBox Lbx1;
    }
}

