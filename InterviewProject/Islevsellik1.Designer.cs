namespace InterviewProject
{
    partial class Islevsellik1
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
            this.TxtSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSayi2 = new System.Windows.Forms.TextBox();
            this.TxtSayi3 = new System.Windows.Forms.TextBox();
            this.TxtSonuc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSayi1
            // 
            this.TxtSayi1.Location = new System.Drawing.Point(182, 71);
            this.TxtSayi1.Name = "TxtSayi1";
            this.TxtSayi1.Size = new System.Drawing.Size(104, 30);
            this.TxtSayi1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayıyı giriniz:";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.BackColor = System.Drawing.SystemColors.Info;
            this.BtnHesapla.Location = new System.Drawing.Point(342, 138);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(164, 60);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.Text = "Sonucu Göster";
            this.BtnHesapla.UseVisualStyleBackColor = false;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Sayıyı giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Sayıyı giriniz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(544, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sonuç:";
            // 
            // TxtSayi2
            // 
            this.TxtSayi2.Location = new System.Drawing.Point(182, 129);
            this.TxtSayi2.Name = "TxtSayi2";
            this.TxtSayi2.Size = new System.Drawing.Size(104, 30);
            this.TxtSayi2.TabIndex = 6;
            // 
            // TxtSayi3
            // 
            this.TxtSayi3.Location = new System.Drawing.Point(182, 190);
            this.TxtSayi3.Name = "TxtSayi3";
            this.TxtSayi3.Size = new System.Drawing.Size(104, 30);
            this.TxtSayi3.TabIndex = 7;
            // 
            // TxtSonuc
            // 
            this.TxtSonuc.Location = new System.Drawing.Point(617, 154);
            this.TxtSonuc.Name = "TxtSonuc";
            this.TxtSonuc.Size = new System.Drawing.Size(104, 30);
            this.TxtSonuc.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.TxtSonuc);
            this.groupBox1.Controls.Add(this.TxtSayi1);
            this.groupBox1.Controls.Add(this.TxtSayi3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtSayi2);
            this.groupBox1.Controls.Add(this.BtnHesapla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(25, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(901, 328);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(22, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(934, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Not: Sayı girişi yapıldıktan sonra \"Sonucu Göster\" butonuna tıklandığında, \"Sonuç" +
    "\" kısmına; birinci ve ikinci sayının toplamının üçüncü sayı ile çarpımı yazdırıl" +
    "acaktır.";
            // 
            // Islevsellik1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 453);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Islevsellik1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlevsellik1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSayi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSayi2;
        private System.Windows.Forms.TextBox TxtSayi3;
        private System.Windows.Forms.TextBox TxtSonuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}

