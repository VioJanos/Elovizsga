namespace Elovizsga
{
    partial class RegForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.toLoginLL = new System.Windows.Forms.Label();
            this.RegBT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.keresztNevTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.JelszoTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vezetekNevTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.closeLL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.toLoginLL);
            this.panel1.Controls.Add(this.RegBT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.keresztNevTB);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.JelszoTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vezetekNevTB);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 566);
            this.panel1.TabIndex = 0;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // toLoginLL
            // 
            this.toLoginLL.AutoSize = true;
            this.toLoginLL.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLoginLL.Location = new System.Drawing.Point(113, 512);
            this.toLoginLL.Name = "toLoginLL";
            this.toLoginLL.Size = new System.Drawing.Size(254, 18);
            this.toLoginLL.TabIndex = 29;
            this.toLoginLL.Text = "Már van fiókod? Bejelentkezés";
            this.toLoginLL.Click += new System.EventHandler(this.toLoginLL_Click);
            this.toLoginLL.MouseEnter += new System.EventHandler(this.toLoginLL_MouseEnter);
            this.toLoginLL.MouseLeave += new System.EventHandler(this.toLoginLL_MouseLeave);
            // 
            // RegBT
            // 
            this.RegBT.FlatAppearance.BorderSize = 0;
            this.RegBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBT.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegBT.Location = new System.Drawing.Point(12, 386);
            this.RegBT.Name = "RegBT";
            this.RegBT.Size = new System.Drawing.Size(494, 82);
            this.RegBT.TabIndex = 28;
            this.RegBT.Text = "Regisztráció";
            this.RegBT.UseVisualStyleBackColor = true;
            this.RegBT.Click += new System.EventHandler(this.RegBT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Keresztnév:";
            // 
            // keresztNevTB
            // 
            this.keresztNevTB.Location = new System.Drawing.Point(171, 203);
            this.keresztNevTB.Name = "keresztNevTB";
            this.keresztNevTB.Size = new System.Drawing.Size(152, 20);
            this.keresztNevTB.TabIndex = 26;
            this.keresztNevTB.TextChanged += new System.EventHandler(this.keresztNevTB_TextChanged);
            this.keresztNevTB.Leave += new System.EventHandler(this.keresztNevTB_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Felhasználó",
            "Vezető"});
            this.comboBox1.Location = new System.Drawing.Point(171, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Jogosultság:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Jelszó:";
            // 
            // JelszoTB
            // 
            this.JelszoTB.Location = new System.Drawing.Point(171, 259);
            this.JelszoTB.Name = "JelszoTB";
            this.JelszoTB.PasswordChar = '*';
            this.JelszoTB.Size = new System.Drawing.Size(152, 20);
            this.JelszoTB.TabIndex = 22;
            this.JelszoTB.Leave += new System.EventHandler(this.JelszoTB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vezetéknév:";
            // 
            // vezetekNevTB
            // 
            this.vezetekNevTB.Location = new System.Drawing.Point(171, 146);
            this.vezetekNevTB.Name = "vezetekNevTB";
            this.vezetekNevTB.Size = new System.Drawing.Size(152, 20);
            this.vezetekNevTB.TabIndex = 13;
            this.vezetekNevTB.TextChanged += new System.EventHandler(this.vezetekNevTB_TextChanged);
            this.vezetekNevTB.Leave += new System.EventHandler(this.vezetekNevTB_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.closeLL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 100);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Regisztráció";
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
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 566);
            this.Controls.Add(this.panel1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label closeLL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vezetekNevTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox keresztNevTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JelszoTB;
        private System.Windows.Forms.Label toLoginLL;
        private System.Windows.Forms.Button RegBT;
    }
}