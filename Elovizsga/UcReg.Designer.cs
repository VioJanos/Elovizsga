﻿namespace Elovizsga
{
    partial class UcReg
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regisztracioLL = new System.Windows.Forms.Label();
            this.RegBT = new System.Windows.Forms.Button();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.FelhnTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Felhasználó név:";
            // 
            // regisztracioLL
            // 
            this.regisztracioLL.AutoSize = true;
            this.regisztracioLL.Font = new System.Drawing.Font("Sitka Text Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.regisztracioLL.Location = new System.Drawing.Point(85, 10);
            this.regisztracioLL.Name = "regisztracioLL";
            this.regisztracioLL.Size = new System.Drawing.Size(134, 29);
            this.regisztracioLL.TabIndex = 11;
            this.regisztracioLL.Text = "Regisztráció";
            this.regisztracioLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regisztracioLL.Click += new System.EventHandler(this.bejelentkezLL_Click);
            // 
            // RegBT
            // 
            this.RegBT.FlatAppearance.BorderSize = 0;
            this.RegBT.Location = new System.Drawing.Point(90, 309);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(158, 84);
            this.RegBT.TabIndex = 10;
            this.RegBT.Text = "Regisztráció";
            this.RegBT.UseVisualStyleBackColor = true;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // JelszoTB
            // 
            this.JelszoTB.Location = new System.Drawing.Point(90, 156);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(152, 20);
            this.JelszoTB.TabIndex = 8;
            this.JelszoTB.Leave += new System.EventHandler(this.JelszoTB_Leave);
            // 
            // FelhnTB
            // 
            this.FelhnTB.Location = new System.Drawing.Point(90, 82);
            this.FelhnTB.Name = "FelhnTB";
            this.FelhnTB.Size = new System.Drawing.Size(152, 20);
            this.FelhnTB.TabIndex = 7;
            this.FelhnTB.Leave += new System.EventHandler(this.FelhnTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jogosultság:";
            // 
            // LoginBT
            // 
            this.LoginBT.Location = new System.Drawing.Point(114, 408);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(105, 44);
            this.LoginBT.TabIndex = 16;
            this.LoginBT.Text = "Bejelentkezés";
            this.LoginBT.UseVisualStyleBackColor = true;
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Felhasználó",
            "Vezető"});
            this.comboBox1.Location = new System.Drawing.Point(90, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UcReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regisztracioLL);
            this.Controls.Add(this.RegBT);
            this.Controls.Add(this.JelszoTB);
            this.Controls.Add(this.FelhnTB);
            this.Name = "UcReg";
            this.Size = new System.Drawing.Size(358, 468);
            this.Load += new System.EventHandler(this.UcReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label regisztracioLL;
        private System.Windows.Forms.Button RegBT;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.TextBox FelhnTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
