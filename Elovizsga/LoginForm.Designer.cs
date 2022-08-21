namespace Elovizsga
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toRegLL = new System.Windows.Forms.Label();
            this.loginBT = new System.Windows.Forms.Button();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.FelhnTB = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeLL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.toRegLL);
            this.panel1.Controls.Add(this.loginBT);
            this.panel1.Controls.Add(this.JelszoTB);
            this.panel1.Controls.Add(this.FelhnTB);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 566);
            this.panel1.TabIndex = 0;
            // 
            // toRegLL
            // 
            this.toRegLL.AutoSize = true;
            this.toRegLL.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegLL.Location = new System.Drawing.Point(123, 518);
            this.toRegLL.Name = "toRegLL";
            this.toRegLL.Size = new System.Drawing.Size(241, 18);
            this.toRegLL.TabIndex = 6;
            this.toRegLL.Text = "Még nincs fiókod? Regisztrálj";
            this.toRegLL.Click += new System.EventHandler(this.toRegLL_Click);
            this.toRegLL.MouseEnter += new System.EventHandler(this.toRegLL_MouseEnter);
            this.toRegLL.MouseLeave += new System.EventHandler(this.toRegLL_MouseLeave);
            this.toRegLL.MouseHover += new System.EventHandler(this.toRegLL_MouseHover);
            // 
            // loginBT
            // 
            this.loginBT.BackColor = System.Drawing.Color.Silver;
            this.loginBT.FlatAppearance.BorderSize = 0;
            this.loginBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBT.Font = new System.Drawing.Font("Akashi_hun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBT.Location = new System.Drawing.Point(12, 419);
            this.loginBT.Name = "loginBT";
            this.loginBT.Size = new System.Drawing.Size(485, 68);
            this.loginBT.TabIndex = 5;
            this.loginBT.Text = "Bejelentkezés";
            this.loginBT.UseVisualStyleBackColor = false;
            this.loginBT.Click += new System.EventHandler(this.loginBT_Click);
            // 
            // JelszoTB
            // 
            this.JelszoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JelszoTB.Location = new System.Drawing.Point(96, 298);
            this.JelszoTB.Multiline = true;
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(365, 65);
            this.JelszoTB.TabIndex = 4;
            // 
            // FelhnTB
            // 
            this.FelhnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FelhnTB.Location = new System.Drawing.Point(96, 174);
            this.FelhnTB.Multiline = true;
            this.FelhnTB.Name = "FelhnTB";
            this.FelhnTB.Size = new System.Drawing.Size(365, 65);
            this.FelhnTB.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.closeLL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            // 
            // closeLL
            // 
            this.closeLL.AutoSize = true;
            this.closeLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeLL.Location = new System.Drawing.Point(493, 3);
            this.closeLL.Name = "closeLL";
            this.closeLL.Size = new System.Drawing.Size(21, 20);
            this.closeLL.TabIndex = 0;
            this.closeLL.Text = "X";
            this.closeLL.Click += new System.EventHandler(this.closeLL_Click);
            this.closeLL.MouseEnter += new System.EventHandler(this.closeLL_MouseEnter);
            this.closeLL.MouseLeave += new System.EventHandler(this.closeLL_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 566);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeLL;
        private System.Windows.Forms.Button loginBT;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.TextBox FelhnTB;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label toRegLL;
    }
}