namespace EncrypterVersion1
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
            this.OV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EV = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OV
            // 
            this.OV.BackColor = System.Drawing.SystemColors.InfoText;
            this.OV.ForeColor = System.Drawing.Color.Lime;
            this.OV.Location = new System.Drawing.Point(155, 12);
            this.OV.Name = "OV";
            this.OV.Size = new System.Drawing.Size(202, 20);
            this.OV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Value- ";
            // 
            // EV
            // 
            this.EV.BackColor = System.Drawing.SystemColors.InfoText;
            this.EV.ForeColor = System.Drawing.Color.Lime;
            this.EV.Location = new System.Drawing.Point(155, 167);
            this.EV.Name = "EV";
            this.EV.Size = new System.Drawing.Size(202, 20);
            this.EV.TabIndex = 2;
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.Lime;
            this.Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Decrypt.ForeColor = System.Drawing.Color.Black;
            this.Decrypt.Location = new System.Drawing.Point(266, 111);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(91, 23);
            this.Decrypt.TabIndex = 3;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encrypted Value -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(19, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Decrypted Value -";
            // 
            // DV
            // 
            this.DV.BackColor = System.Drawing.SystemColors.InfoText;
            this.DV.ForeColor = System.Drawing.Color.Lime;
            this.DV.Location = new System.Drawing.Point(155, 211);
            this.DV.Name = "DV";
            this.DV.Size = new System.Drawing.Size(202, 20);
            this.DV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Key - ";
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.SystemColors.InfoText;
            this.key.ForeColor = System.Drawing.Color.Lime;
            this.key.Location = new System.Drawing.Point(155, 56);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(202, 20);
            this.key.TabIndex = 7;
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Lime;
            this.Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Encrypt.ForeColor = System.Drawing.Color.Black;
            this.Encrypt.Location = new System.Drawing.Point(155, 111);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(93, 23);
            this.Encrypt.TabIndex = 9;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(385, 243);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.EV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Encrypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EV;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button Encrypt;
    }
}

