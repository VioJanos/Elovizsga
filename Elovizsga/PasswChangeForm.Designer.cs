﻿namespace Elovizsga
{
    partial class PasswChangeForm
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
            this.ujJelszoBT = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nemEggyezikLL = new System.Windows.Forms.Label();
            this.rosszJelszoLL = new System.Windows.Forms.Label();
            this.ujJelszoTB2 = new System.Windows.Forms.TextBox();
            this.ujJelszoTB = new System.Windows.Forms.TextBox();
            this.regiJelszoTB = new System.Windows.Forms.TextBox();
            this.elkuldBT = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ujJelszoGB = new System.Windows.Forms.GroupBox();
            this.ujJelszoOkLL = new System.Windows.Forms.Label();
            this.ujJelszoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // ujJelszoBT
            // 
            this.ujJelszoBT.Font = new System.Drawing.Font("Akashi_hun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujJelszoBT.Location = new System.Drawing.Point(43, 15);
            this.ujJelszoBT.Margin = new System.Windows.Forms.Padding(4);
            this.ujJelszoBT.Name = "ujJelszoBT";
            this.ujJelszoBT.Size = new System.Drawing.Size(327, 231);
            this.ujJelszoBT.TabIndex = 0;
            this.ujJelszoBT.Text = "Jelszó változtatás";
            this.ujJelszoBT.UseVisualStyleBackColor = true;
            this.ujJelszoBT.Click += new System.EventHandler(this.ujJelszoBT_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Akashi_hun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(53, 401);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(229, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Beállítom az új jelszót";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nemEggyezikLL
            // 
            this.nemEggyezikLL.AutoSize = true;
            this.nemEggyezikLL.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nemEggyezikLL.Location = new System.Drawing.Point(219, 352);
            this.nemEggyezikLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nemEggyezikLL.Name = "nemEggyezikLL";
            this.nemEggyezikLL.Size = new System.Drawing.Size(76, 24);
            this.nemEggyezikLL.TabIndex = 8;
            this.nemEggyezikLL.Text = "label4";
            this.nemEggyezikLL.Visible = false;
            // 
            // rosszJelszoLL
            // 
            this.rosszJelszoLL.AutoSize = true;
            this.rosszJelszoLL.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rosszJelszoLL.Location = new System.Drawing.Point(219, 161);
            this.rosszJelszoLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rosszJelszoLL.Name = "rosszJelszoLL";
            this.rosszJelszoLL.Size = new System.Drawing.Size(76, 24);
            this.rosszJelszoLL.TabIndex = 7;
            this.rosszJelszoLL.Text = "label4";
            this.rosszJelszoLL.Visible = false;
            // 
            // ujJelszoTB2
            // 
            this.ujJelszoTB2.Location = new System.Drawing.Point(383, 300);
            this.ujJelszoTB2.Margin = new System.Windows.Forms.Padding(4);
            this.ujJelszoTB2.Name = "ujJelszoTB2";
            this.ujJelszoTB2.PasswordChar = '*';
            this.ujJelszoTB2.Size = new System.Drawing.Size(307, 34);
            this.ujJelszoTB2.TabIndex = 6;
            this.ujJelszoTB2.TextChanged += new System.EventHandler(this.ujJelszoTB2_TextChanged);
            this.ujJelszoTB2.Leave += new System.EventHandler(this.ujJelszoTB2_Leave);
            // 
            // ujJelszoTB
            // 
            this.ujJelszoTB.Location = new System.Drawing.Point(383, 214);
            this.ujJelszoTB.Margin = new System.Windows.Forms.Padding(4);
            this.ujJelszoTB.Name = "ujJelszoTB";
            this.ujJelszoTB.PasswordChar = '*';
            this.ujJelszoTB.Size = new System.Drawing.Size(307, 34);
            this.ujJelszoTB.TabIndex = 5;
            this.ujJelszoTB.TextChanged += new System.EventHandler(this.ujJelszoTB_TextChanged);
            this.ujJelszoTB.Leave += new System.EventHandler(this.ujJelszoTB_Leave);
            // 
            // regiJelszoTB
            // 
            this.regiJelszoTB.Location = new System.Drawing.Point(383, 107);
            this.regiJelszoTB.Margin = new System.Windows.Forms.Padding(4);
            this.regiJelszoTB.Name = "regiJelszoTB";
            this.regiJelszoTB.PasswordChar = '*';
            this.regiJelszoTB.Size = new System.Drawing.Size(307, 34);
            this.regiJelszoTB.TabIndex = 4;
            this.regiJelszoTB.TextChanged += new System.EventHandler(this.regiJelszoTB_TextChanged);
            this.regiJelszoTB.Leave += new System.EventHandler(this.regiJelszoTB_Leave);
            // 
            // elkuldBT
            // 
            this.elkuldBT.Enabled = false;
            this.elkuldBT.Font = new System.Drawing.Font("Akashi_hun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elkuldBT.Location = new System.Drawing.Point(45, 462);
            this.elkuldBT.Margin = new System.Windows.Forms.Padding(4);
            this.elkuldBT.Name = "elkuldBT";
            this.elkuldBT.Size = new System.Drawing.Size(793, 81);
            this.elkuldBT.TabIndex = 3;
            this.elkuldBT.Text = "Elküldés";
            this.elkuldBT.UseVisualStyleBackColor = true;
            this.elkuldBT.Click += new System.EventHandler(this.elkuldBT_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Új jelszó megerősítése:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Új jelszó:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Régi jelszó:";
            // 
            // ujJelszoGB
            // 
            this.ujJelszoGB.Controls.Add(this.ujJelszoOkLL);
            this.ujJelszoGB.Controls.Add(this.checkBox1);
            this.ujJelszoGB.Controls.Add(this.nemEggyezikLL);
            this.ujJelszoGB.Controls.Add(this.rosszJelszoLL);
            this.ujJelszoGB.Controls.Add(this.ujJelszoTB2);
            this.ujJelszoGB.Controls.Add(this.ujJelszoTB);
            this.ujJelszoGB.Controls.Add(this.regiJelszoTB);
            this.ujJelszoGB.Controls.Add(this.elkuldBT);
            this.ujJelszoGB.Controls.Add(this.label3);
            this.ujJelszoGB.Controls.Add(this.label2);
            this.ujJelszoGB.Controls.Add(this.label1);
            this.ujJelszoGB.Font = new System.Drawing.Font("Akashi_hun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujJelszoGB.Location = new System.Drawing.Point(491, 228);
            this.ujJelszoGB.Margin = new System.Windows.Forms.Padding(4);
            this.ujJelszoGB.Name = "ujJelszoGB";
            this.ujJelszoGB.Padding = new System.Windows.Forms.Padding(4);
            this.ujJelszoGB.Size = new System.Drawing.Size(899, 577);
            this.ujJelszoGB.TabIndex = 1;
            this.ujJelszoGB.TabStop = false;
            this.ujJelszoGB.Text = "ÚJ jelszó beállítása:";
            this.ujJelszoGB.Visible = false;
            this.ujJelszoGB.Enter += new System.EventHandler(this.ujJelszoGB_Enter);
            // 
            // ujJelszoOkLL
            // 
            this.ujJelszoOkLL.AutoSize = true;
            this.ujJelszoOkLL.Font = new System.Drawing.Font("Akashi_hun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ujJelszoOkLL.Location = new System.Drawing.Point(219, 261);
            this.ujJelszoOkLL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ujJelszoOkLL.Name = "ujJelszoOkLL";
            this.ujJelszoOkLL.Size = new System.Drawing.Size(76, 24);
            this.ujJelszoOkLL.TabIndex = 10;
            this.ujJelszoOkLL.Text = "label4";
            this.ujJelszoOkLL.Visible = false;
            // 
            // PasswChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1880, 961);
            this.Controls.Add(this.ujJelszoGB);
            this.Controls.Add(this.ujJelszoBT);
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PasswChangeForm";
            this.Text = "PasswChangeForm";
            this.ujJelszoGB.ResumeLayout(false);
            this.ujJelszoGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ujJelszoBT;
        private System.Windows.Forms.TextBox ujJelszoTB2;
        private System.Windows.Forms.TextBox ujJelszoTB;
        private System.Windows.Forms.TextBox regiJelszoTB;
        private System.Windows.Forms.Button elkuldBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rosszJelszoLL;
        private System.Windows.Forms.Label nemEggyezikLL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox ujJelszoGB;
        private System.Windows.Forms.Label ujJelszoOkLL;
    }
}