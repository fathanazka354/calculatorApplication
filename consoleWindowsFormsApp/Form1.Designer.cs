namespace consoleWindowsFormsApp
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
            this.txtBil1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBil2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bHitung = new System.Windows.Forms.Button();
            this.txtHasil = new System.Windows.Forms.ListBox();
            this.bPilihan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBil1
            // 
            this.txtBil1.Location = new System.Drawing.Point(96, 56);
            this.txtBil1.Name = "txtBil1";
            this.txtBil1.Size = new System.Drawing.Size(100, 20);
            this.txtBil1.TabIndex = 0;
            this.txtBil1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nilai A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBil2
            // 
            this.txtBil2.Location = new System.Drawing.Point(96, 96);
            this.txtBil2.Name = "txtBil2";
            this.txtBil2.Size = new System.Drawing.Size(100, 20);
            this.txtBil2.TabIndex = 2;
            this.txtBil2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai B";
            // 
            // bHitung
            // 
            this.bHitung.Location = new System.Drawing.Point(96, 132);
            this.bHitung.Name = "bHitung";
            this.bHitung.Size = new System.Drawing.Size(75, 23);
            this.bHitung.TabIndex = 4;
            this.bHitung.Text = "Hitung";
            this.bHitung.UseVisualStyleBackColor = true;
            this.bHitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHasil
            // 
            this.txtHasil.FormattingEnabled = true;
            this.txtHasil.Location = new System.Drawing.Point(38, 202);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(469, 173);
            this.txtHasil.TabIndex = 5;
            this.txtHasil.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bPilihan
            // 
            this.bPilihan.FormattingEnabled = true;
            this.bPilihan.Items.AddRange(new object[] {
            "Pertambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.bPilihan.Location = new System.Drawing.Point(96, 12);
            this.bPilihan.Name = "bPilihan";
            this.bPilihan.Size = new System.Drawing.Size(121, 21);
            this.bPilihan.TabIndex = 6;
            this.bPilihan.SelectedIndexChanged += new System.EventHandler(this.txt_operasi);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operasi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bPilihan);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.bHitung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBil2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBil1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBil1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBil2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bHitung;
        private System.Windows.Forms.ListBox txtHasil;
        private System.Windows.Forms.ComboBox bPilihan;
        private System.Windows.Forms.Label label3;
    }
}

