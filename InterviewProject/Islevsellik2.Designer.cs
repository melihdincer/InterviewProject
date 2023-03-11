namespace SecondProject
{
    partial class Islevsellik2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbx1 = new System.Windows.Forms.ListBox();
            this.BtnSonuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Lbx1);
            this.groupBox1.Controls.Add(this.BtnSonuc);
            this.groupBox1.Location = new System.Drawing.Point(97, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(648, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "100\'e kadar olan sayıların hem 3 hem de 5\'in katı olanların  \'zigzag\', 100\'den so" +
    "nrakiler için \'zagzig\' yazdırılacaktır. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(18, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Not: \'Çalıştır\' butonuna bastıktan sonra, ekranda 1\'den 200\'e kadar sıralanmış ol" +
    "an sayıların; 3\'ün katı olanların yerinde \'zig\', 5\'in katı olanların \'zag\', ";
            // 
            // Lbx1
            // 
            this.Lbx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Lbx1.FormattingEnabled = true;
            this.Lbx1.ItemHeight = 23;
            this.Lbx1.Location = new System.Drawing.Point(21, 29);
            this.Lbx1.Name = "Lbx1";
            this.Lbx1.Size = new System.Drawing.Size(592, 372);
            this.Lbx1.TabIndex = 1;
            // 
            // BtnSonuc
            // 
            this.BtnSonuc.BackColor = System.Drawing.Color.Peru;
            this.BtnSonuc.Location = new System.Drawing.Point(650, 29);
            this.BtnSonuc.Name = "BtnSonuc";
            this.BtnSonuc.Size = new System.Drawing.Size(204, 52);
            this.BtnSonuc.TabIndex = 0;
            this.BtnSonuc.Text = "Çalıştır";
            this.BtnSonuc.UseVisualStyleBackColor = false;
            this.BtnSonuc.Click += new System.EventHandler(this.BtnSonuc_Click);
            // 
            // Islevsellik2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1202, 752);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Islevsellik2";
            this.Text = "İşlevsellik2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSonuc;
        private System.Windows.Forms.ListBox Lbx1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

