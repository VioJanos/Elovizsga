using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Elovizsga
{
    
    public partial class RegForm : Form
    {

        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public RegForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                //MessageBox.Show("DB hozzáférés checked!");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        Users uj = new Users();
        string vezeteknev = "";
        string keresztnev = "";
        string jelszo = "";
        int jog;

        
        ControlPanel ss = new ControlPanel();
        private void closeLL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeLL_MouseEnter(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Red;
        }

        private void closeLL_MouseLeave(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Black;
        }

        private void vezetekNevTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void RegBT_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO vizga.User (`Employee_id`, `Password`, `First_name`, `Last_name`,`Admin`,`Leader`,`Operator`) VALUES('2', '" + JelszoTB.Text + "', '" + vezetekNevTB.Text + "', '" + keresztNevTB.Text + "', '1','0','0');";
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("Felhasználó létrehozva, bejelentkezhetsz!");
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Hiba!");
            }
            conn.Close();
        }

        private void vezetekNevTB_Leave(object sender, EventArgs e)
        {
            vezeteknev = vezetekNevTB.Text;
            uj.setVezet(vezeteknev);
            vezetekNevTB.Text = uj.VezetekNev;
        }

        private void keresztNevTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void keresztNevTB_Leave(object sender, EventArgs e)
        {
            keresztnev = keresztNevTB.Text;
            uj.setKereszt(keresztnev);
            keresztNevTB.Text = uj.KeresztNev;
        }

        private void JelszoTB_Leave(object sender, EventArgs e)
        {
            jelszo = JelszoTB.Text;
            uj.setJelszo(jelszo);
            JelszoTB.Text = uj.Jelszo;
            comboBox1.Focus();
        }

        private void toLoginLL_Click(object sender, EventArgs e)
        {
            //aa.Show();
            //aa.BringToFront();
        }

        private void toLoginLL_MouseEnter(object sender, EventArgs e)
        {
            toLoginLL.ForeColor = Color.BlueViolet;
        }

        private void toLoginLL_MouseLeave(object sender, EventArgs e)
        {
            toLoginLL.ForeColor = Color.Black;
        }
    }
}
