namespace Elovizsga
{
    partial class UcLogin
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
            this.bejelentkezLL = new System.Windows.Forms.Label();
            this.RegBT = new System.Windows.Forms.Button();
            this.loginBT = new System.Windows.Forms.Button();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.FelhnTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(412, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Felhasználó név:";
            // 
            // bejelentkezLL
            // 
            this.bejelentkezLL.AutoSize = true;
            this.bejelentkezLL.Font = new System.Drawing.Font("Akashi_hun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bejelentkezLL.Location = new System.Drawing.Point(581, 103);
            this.bejelentkezLL.Name = "bejelentkezLL";
            this.bejelentkezLL.Size = new System.Drawing.Size(236, 34);
            this.bejelentkezLL.TabIndex = 11;
            this.bejelentkezLL.Text = "Bejelentkezés";
            this.bejelentkezLL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegBT
            // 
            this.RegBT.FlatAppearance.BorderSize = 0;
            this.RegBT.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBT.Location = new System.Drawing.Point(598, 595);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(153, 35);
            this.RegBT.TabIndex = 10;
            this.RegBT.Text = "Regisztráció";
            this.RegBT.UseVisualStyleBackColor = true;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // loginBT
            // 
            this.loginBT.FlatAppearance.BorderSize = 0;
            this.loginBT.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBT.Location = new System.Drawing.Point(587, 500);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(182, 62);
            this.loginBT.TabIndex = 9;
            this.loginBT.Text = "Bejelentkezés";
            this.loginBT.UseVisualStyleBackColor = true;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // JelszoTB
            // 
            this.JelszoTB.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JelszoTB.Location = new System.Drawing.Point(587, 347);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(188, 29);
            this.JelszoTB.TabIndex = 8;
            // 
            // FelhnTB
            // 
            this.FelhnTB.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FelhnTB.Location = new System.Drawing.Point(587, 256);
            this.FelhnTB.Name = "FelhnTB";
            this.FelhnTB.Size = new System.Drawing.Size(188, 29);
            this.FelhnTB.TabIndex = 7;
            this.FelhnTB.MouseEnter += new System.EventHandler(this.FelhnTB_MouseEnter);
            // 
            // UcLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bejelentkezLL);
            this.Controls.Add(this.RegBT);
            this.Controls.Add(this.loginBT);
            this.Controls.Add(this.JelszoTB);
            this.Controls.Add(this.FelhnTB);
            this.Name = "UcLogin";
            this.Size = new System.Drawing.Size(1426, 820);
            this.Load += new System.EventHandler(this.UcLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bejelentkezLL;
        private System.Windows.Forms.Button RegBT;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.TextBox FelhnTB;
    }
}
