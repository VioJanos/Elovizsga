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
using MySql.Data.MySqlClient;

namespace Elovizsga
{
    public partial class UcReg : UserControl
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        
        public UcReg()
        {
            InitializeComponent();
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
        private void RegBT_Click(object sender, EventArgs e)
        {
            //jog =comboBox1.SelectedItem.ToString();

            //Users kesz = new Users(felhnev, jelszo, jog);
            //uj.Felhasznalok.Add(kesz);

            //string adat = "data.txt";
            //StreamWriter iras = new StreamWriter(adat, true, Encoding.UTF8);
            //iras.WriteLine(vezetekNevTB.Text + ";" + JelszoTB.Text + ";" + jog);
            //iras.Close();

            //this.Visible = false;
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO vizga.User (`Employee_id`, `Password`, `First_name`, `Last_name`,`Admin`,`Leader`,`Operator`) VALUES('2', '" + JelszoTB.Text+"', '" + vezetekNevTB.Text + "', '"+keresztNevTB.Text+"', '1','0','0');";
            dr = cmd.ExecuteReader();
            if(!dr.Read())
            {
                MessageBox.Show("Felhasználó létrehozva!");
            }
            else
            {
                MessageBox.Show("Hiba!");
            }
            conn.Close();
        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UcLogin ses = new UcLogin();
            ses.Visible = true;
            ses.Show();
            ses.BringToFront();
            
            
        }

        private void vezetekNevTB_Leave(object sender, EventArgs e)
        {
            vezeteknev = vezetekNevTB.Text;         
            uj.setVezet(vezeteknev);
            vezetekNevTB.Text = uj.VezetekNev;
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
