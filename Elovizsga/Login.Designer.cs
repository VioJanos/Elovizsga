namespace Elovizsga
{
    partial class Login
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
            this.ucLogin1 = new Elovizsga.UcLogin();
            this.ucReg1 = new Elovizsga.UcReg();
            this.SuspendLayout();
            // 
            // ucLogin1
            // 
            this.ucLogin1.Location = new System.Drawing.Point(12, 12);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(324, 439);
            this.ucLogin1.TabIndex = 0;
            this.ucLogin1.Load += new System.EventHandler(this.ucLogin1_Load);
            // 
            // ucReg1
            // 
            this.ucReg1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReg1.Location = new System.Drawing.Point(0, 0);
            this.ucReg1.Name = "ucReg1";
            this.ucReg1.Size = new System.Drawing.Size(310, 533);
            this.ucReg1.TabIndex = 1;
            this.ucReg1.Load += new System.EventHandler(this.ucReg1_Load);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 533);
            this.Controls.Add(this.ucReg1);
            this.Controls.Add(this.ucLogin1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UcLogin ucLogin1;
        private UcReg ucReg1;
    }
}

