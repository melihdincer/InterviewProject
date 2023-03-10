namespace FifthProject
{
    partial class Form5
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LblFibonacci = new System.Windows.Forms.Label();
            this.Lbx1 = new System.Windows.Forms.ListBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(230, 25);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(136, 26);
            this.Txt1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bir sayı giriniz:";
            // 
            // BtnButton
            // 
            this.BtnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnButton.Location = new System.Drawing.Point(230, 66);
            this.BtnButton.Name = "BtnButton";
            this.BtnButton.Size = new System.Drawing.Size(136, 31);
            this.BtnButton.TabIndex = 2;
            this.BtnButton.Text = "Çalıştır";
            this.BtnButton.UseVisualStyleBackColor = false;
            this.BtnButton.Click += new System.EventHandler(this.BtnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Girilen satır sayısındaki Fibonacci sayısı:";
            // 
            // LblFibonacci
            // 
            this.LblFibonacci.AutoSize = true;
            this.LblFibonacci.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFibonacci.Location = new System.Drawing.Point(316, 182);
            this.LblFibonacci.Name = "LblFibonacci";
            this.LblFibonacci.Size = new System.Drawing.Size(31, 31);
            this.LblFibonacci.TabIndex = 4;
            this.LblFibonacci.Text = "0";
            // 
            // Lbx1
            // 
            this.Lbx1.FormattingEnabled = true;
            this.Lbx1.ItemHeight = 20;
            this.Lbx1.Location = new System.Drawing.Point(18, 50);
            this.Lbx1.Name = "Lbx1";
            this.Lbx1.Size = new System.Drawing.Size(425, 224);
            this.Lbx1.TabIndex = 5;
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.Color.Firebrick;
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSil.Location = new System.Drawing.Point(230, 103);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(136, 31);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Temizle";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt1);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnButton);
            this.groupBox1.Controls.Add(this.LblFibonacci);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 440);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Linen;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Lbx1);
            this.groupBox2.Location = new System.Drawing.Point(420, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 348);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fibonacci Dizisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(885, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Not: Bir sayı girdikten sonra çalıştır butonuna tıklayarak girmiş olduğunuz sayın" +
    "ın fibonacci sayı dizisinde bulunan satırdaki değerine erişebileceksiniz.";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 479);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblFibonacci;
        private System.Windows.Forms.ListBox Lbx1;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
    }
}

