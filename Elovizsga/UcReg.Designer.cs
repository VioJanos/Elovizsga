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
            this.vezetekNevTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginBT = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.keresztNevTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vezetéknév:";
            // 
            // regisztracioLL
            // 
            this.regisztracioLL.AutoSize = true;
            this.regisztracioLL.Font = new System.Drawing.Font("Akashi_hun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regisztracioLL.Location = new System.Drawing.Point(564, 98);
            this.regisztracioLL.Name = "regisztracioLL";
            this.regisztracioLL.Size = new System.Drawing.Size(209, 34);
            this.regisztracioLL.TabIndex = 11;
            this.regisztracioLL.Text = "Regisztráció";
            this.regisztracioLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.regisztracioLL.Click += new System.EventHandler(this.bejelentkezLL_Click);
            // 
            // RegBT
            // 
            this.RegBT.FlatAppearance.BorderSize = 0;
            this.RegBT.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBT.Location = new System.Drawing.Point(548, 541);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(225, 84);
            this.RegBT.TabIndex = 10;
            this.RegBT.Text = "Regisztráció";
            this.RegBT.UseVisualStyleBackColor = true;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // JelszoTB
            // 
            this.JelszoTB.Location = new System.Drawing.Point(603, 396);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(152, 20);
            this.JelszoTB.TabIndex = 8;
            this.JelszoTB.Leave += new System.EventHandler(this.JelszoTB_Leave);
            // 
            // vezetekNevTB
            // 
            this.vezetekNevTB.Location = new System.Drawing.Point(603, 263);
            this.vezetekNevTB.Name = "vezetekNevTB";
            this.vezetekNevTB.Size = new System.Drawing.Size(152, 20);
            this.vezetekNevTB.TabIndex = 7;
            this.vezetekNevTB.Leave += new System.EventHandler(this.vezetekNevTB_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(416, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jogosultság:";
            // 
            // LoginBT
            // 
            this.LoginBT.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBT.Location = new System.Drawing.Point(570, 663);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(172, 44);
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
            this.comboBox1.Location = new System.Drawing.Point(603, 470);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Keresztnév:";
            // 
            // keresztNevTB
            // 
            this.keresztNevTB.Location = new System.Drawing.Point(603, 330);
            this.keresztNevTB.Name = "keresztNevTB";
            this.keresztNevTB.Size = new System.Drawing.Size(152, 20);
            this.keresztNevTB.TabIndex = 20;
            // 
            // UcReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keresztNevTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regisztracioLL);
            this.Controls.Add(this.RegBT);
            this.Controls.Add(this.JelszoTB);
            this.Controls.Add(this.vezetekNevTB);
            this.Name = "UcReg";
            this.Size = new System.Drawing.Size(1426, 820);
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
        private System.Windows.Forms.TextBox vezetekNevTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBT;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keresztNevTB;
    }
}