namespace Elovizsga
{
    partial class AdminControllUC
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
            this.FelhasznalokDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.newBT = new System.Windows.Forms.Button();
            this.editBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwdTB = new System.Windows.Forms.TextBox();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FelhasznalokDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FelhasznalokDGV
            // 
            this.FelhasznalokDGV.AllowUserToAddRows = false;
            this.FelhasznalokDGV.AllowUserToDeleteRows = false;
            this.FelhasznalokDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FelhasznalokDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FelhasznalokDGV.Location = new System.Drawing.Point(26, 324);
            this.FelhasznalokDGV.Name = "FelhasznalokDGV";
            this.FelhasznalokDGV.ReadOnly = true;
            this.FelhasznalokDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FelhasznalokDGV.Size = new System.Drawing.Size(1223, 511);
            this.FelhasznalokDGV.TabIndex = 0;
            this.FelhasznalokDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FelhasznalokDGV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akashi_hun", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Összes felhasználó:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newBT
            // 
            this.newBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.newBT.FlatAppearance.BorderSize = 0;
            this.newBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.newBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.newBT.Location = new System.Drawing.Point(1281, 413);
            this.newBT.Name = "newBT";
            this.newBT.Size = new System.Drawing.Size(159, 62);
            this.newBT.TabIndex = 3;
            this.newBT.Text = "Új hozzáadása";
            this.newBT.UseVisualStyleBackColor = false;
            // 
            // editBT
            // 
            this.editBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.editBT.FlatAppearance.BorderSize = 0;
            this.editBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.editBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.editBT.Location = new System.Drawing.Point(1281, 496);
            this.editBT.Name = "editBT";
            this.editBT.Size = new System.Drawing.Size(159, 62);
            this.editBT.TabIndex = 4;
            this.editBT.Text = "Szerkeztés";
            this.editBT.UseVisualStyleBackColor = false;
            this.editBT.Click += new System.EventHandler(this.editBT_Click);
            // 
            // deleteBT
            // 
            this.deleteBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.deleteBT.FlatAppearance.BorderSize = 0;
            this.deleteBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.deleteBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteBT.Location = new System.Drawing.Point(1281, 583);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(159, 62);
            this.deleteBT.TabIndex = 5;
            this.deleteBT.Text = "Törlés";
            this.deleteBT.UseVisualStyleBackColor = false;
            this.deleteBT.Click += new System.EventHandler(this.deleteBT_Click);
            // 
            // saveBT
            // 
            this.saveBT.BackColor = System.Drawing.Color.MediumTurquoise;
            this.saveBT.FlatAppearance.BorderSize = 0;
            this.saveBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.saveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBT.Font = new System.Drawing.Font("Akashi_hun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.saveBT.Location = new System.Drawing.Point(1281, 670);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(159, 62);
            this.saveBT.TabIndex = 6;
            this.saveBT.Text = "Mentés";
            this.saveBT.UseVisualStyleBackColor = false;
            this.saveBT.Click += new System.EventHandler(this.saveBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee_id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Felhasználónév:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jelszó:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(598, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vezetéknév:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1055, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Születési idő:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(598, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Keresztnév:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Akashi_hun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1060, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Jogosultság:";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(158, 124);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(177, 20);
            this.idTB.TabIndex = 15;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(158, 175);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(177, 20);
            this.usernameTB.TabIndex = 16;
            // 
            // passwdTB
            // 
            this.passwdTB.Location = new System.Drawing.Point(158, 238);
            this.passwdTB.Name = "passwdTB";
            this.passwdTB.Size = new System.Drawing.Size(177, 20);
            this.passwdTB.TabIndex = 17;
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(753, 122);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(177, 20);
            this.lastnameTB.TabIndex = 18;
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(753, 175);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(177, 20);
            this.firstnameTB.TabIndex = 19;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(753, 238);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(177, 20);
            this.mailTB.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1184, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Admin",
            "Felhasználó",
            "Vezető"});
            this.comboBox1.Location = new System.Drawing.Point(1184, 236);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // AdminControllUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.firstnameTB);
            this.Controls.Add(this.lastnameTB);
            this.Controls.Add(this.passwdTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.editBT);
            this.Controls.Add(this.newBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FelhasznalokDGV);
            this.Name = "AdminControllUC";
            this.Size = new System.Drawing.Size(1483, 848);
            this.Load += new System.EventHandler(this.AdminControllUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FelhasznalokDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FelhasznalokDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newBT;
        private System.Windows.Forms.Button editBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwdTB;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
