using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Elovizsga
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainBT_Click(object sender, EventArgs e)
        {

        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            string log = "log.txt";
            StreamReader olvas = new StreamReader(log, Encoding.UTF8);
            string sor = "";
            while (!olvas.EndOfStream)
            {
                sor = olvas.ReadLine();
                string[] ideig = sor.Split(';');
                if (!sor.Equals(""))
                {
                    label3.Text = ideig[0];
                    label6.Text = ideig[2];
                    label4.Text = ideig[3];
                }
            }
            olvas.Close();
        }
    }
}
