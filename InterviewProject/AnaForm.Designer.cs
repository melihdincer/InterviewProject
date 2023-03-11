namespace InterviewProject
{
    partial class AnaForm
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
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnSecond = new System.Windows.Forms.Button();
            this.BtnThird = new System.Windows.Forms.Button();
            this.BtnFourth = new System.Windows.Forms.Button();
            this.BtnFifth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.BackColor = System.Drawing.Color.DimGray;
            this.BtnFirst.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFirst.Location = new System.Drawing.Point(288, 186);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(387, 52);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "Birinci İşlevsellik";
            this.BtnFirst.UseVisualStyleBackColor = false;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnSecond
            // 
            this.BtnSecond.BackColor = System.Drawing.Color.DimGray;
            this.BtnSecond.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSecond.Location = new System.Drawing.Point(288, 244);
            this.BtnSecond.Name = "BtnSecond";
            this.BtnSecond.Size = new System.Drawing.Size(387, 52);
            this.BtnSecond.TabIndex = 1;
            this.BtnSecond.Text = "İkinci İşlevsellik";
            this.BtnSecond.UseVisualStyleBackColor = false;
            this.BtnSecond.Click += new System.EventHandler(this.BtnSecond_Click);
            // 
            // BtnThird
            // 
            this.BtnThird.BackColor = System.Drawing.Color.DimGray;
            this.BtnThird.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnThird.Location = new System.Drawing.Point(288, 302);
            this.BtnThird.Name = "BtnThird";
            this.BtnThird.Size = new System.Drawing.Size(387, 52);
            this.BtnThird.TabIndex = 2;
            this.BtnThird.Text = "Üçüncü İşlevsellik";
            this.BtnThird.UseVisualStyleBackColor = false;
            this.BtnThird.Click += new System.EventHandler(this.BtnThird_Click);
            // 
            // BtnFourth
            // 
            this.BtnFourth.BackColor = System.Drawing.Color.DimGray;
            this.BtnFourth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFourth.Location = new System.Drawing.Point(288, 360);
            this.BtnFourth.Name = "BtnFourth";
            this.BtnFourth.Size = new System.Drawing.Size(387, 52);
            this.BtnFourth.TabIndex = 3;
            this.BtnFourth.Text = " Dördüncü İşlevsellik";
            this.BtnFourth.UseVisualStyleBackColor = false;
            this.BtnFourth.Click += new System.EventHandler(this.BtnFourth_Click);
            // 
            // BtnFifth
            // 
            this.BtnFifth.BackColor = System.Drawing.Color.DimGray;
            this.BtnFifth.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFifth.Location = new System.Drawing.Point(288, 418);
            this.BtnFifth.Name = "BtnFifth";
            this.BtnFifth.Size = new System.Drawing.Size(387, 52);
            this.BtnFifth.TabIndex = 4;
            this.BtnFifth.Text = "Beşinci İşlevsellik";
            this.BtnFifth.UseVisualStyleBackColor = false;
            this.BtnFifth.Click += new System.EventHandler(this.BtnFifth_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(195, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giriş Paneline Hoşgeldiniz";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(109, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(977, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnFifth);
            this.Controls.Add(this.BtnFourth);
            this.Controls.Add(this.BtnThird);
            this.Controls.Add(this.BtnSecond);
            this.Controls.Add(this.BtnFirst);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnSecond;
        private System.Windows.Forms.Button BtnThird;
        private System.Windows.Forms.Button BtnFourth;
        private System.Windows.Forms.Button BtnFifth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}