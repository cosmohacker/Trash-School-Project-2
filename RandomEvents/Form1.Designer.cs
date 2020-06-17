namespace RandomEvents
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
            this.btnDene = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblHak = new System.Windows.Forms.Label();
            this.lblRandom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(101, 126);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(75, 23);
            this.btnDene.TabIndex = 0;
            this.btnDene.Text = "Sorgula";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(88, 100);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(100, 20);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.Text = "Rakam";
            this.txtTahmin.Click += new System.EventHandler(this.txtTahmin_Click);
            this.txtTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahmin_KeyPress);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(98, 162);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(0, 13);
            this.lblCevap.TabIndex = 2;
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Location = new System.Drawing.Point(85, 24);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(36, 13);
            this.lblHak.TabIndex = 3;
            this.lblHak.Text = "Hak : ";
            this.lblHak.TextChanged += new System.EventHandler(this.lblHak_TextChanged);
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Location = new System.Drawing.Point(91, 199);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(94, 13);
            this.lblRandom.TabIndex = 4;
            this.lblRandom.Text = "Tahmin edilen sayı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblRandom);
            this.Controls.Add(this.lblHak);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.btnDene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.Label lblRandom;
    }
}

