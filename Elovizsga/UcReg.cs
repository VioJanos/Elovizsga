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
    public partial class UcReg : UserControl
    {
        public UcReg()
        {
            InitializeComponent();
        }
        Users uj = new Users();
        string felhnev = "";
        string jelszo = "";
        string jog = "";
        private void RegBT_Click(object sender, EventArgs e)
        {
            jog =comboBox1.SelectedItem.ToString();

            Users kesz = new Users(felhnev, jelszo, jog);
            uj.Felhasznalok.Add(kesz);

            string adat = "data.txt";
            StreamWriter iras = new StreamWriter(adat, true, Encoding.UTF8);
            iras.WriteLine(FelhnTB.Text + ";" + JelszoTB.Text + ";" + jog);
            iras.Close();

            this.Visible = false;

        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
            
            
        }

        private void FelhnTB_Leave(object sender, EventArgs e)
        {
            felhnev = FelhnTB.Text;
            uj.setFelhn(felhnev);
            FelhnTB.Text = uj.FelhN;
            
        }

        private void JelszoTB_Leave(object sender, EventArgs e)
        {
            jelszo = JelszoTB.Text;
            uj.setJelszo(jelszo);
            JelszoTB.Text = uj.Jelszo;
            comboBox1.Focus();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bejelentkezLL_Click(object sender, EventArgs e)
        {

        }

        private void UcReg_Load(object sender, EventArgs e)
        {
            
        }
    }
}
