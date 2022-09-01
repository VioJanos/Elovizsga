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
using System.IO;

namespace Elovizsga
{
    public partial class PasswChangeForm : Form
    {
        Users u1 = new Users();
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public PasswChangeForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        string username;
        string datum;
        private void ujJelszoBT_Click(object sender, EventArgs e)
        {
            ujJelszoGB.Visible = true;
            ujJelszoTB.Enabled = false;
            ujJelszoTB2.Enabled = false;
        }

        private void ujJelszoGB_Enter(object sender, EventArgs e)
        {
            fajlbolOlv();   
        }

        public void getJelszo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT PASSWORD FROM vizga.User where Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (regiJelszoTB.Text == dr["PASSWORD"].ToString())
                {
                    ujJelszoTB.Enabled = true;
                    ujJelszoTB2.Enabled = true;
                    conn.Close();
                    rosszJelszoLL.Visible = false;

                }
                else
                {
                    rosszJelszoLL.ForeColor = Color.Red;
                    rosszJelszoLL.Text = "Nem eggyezik a régi jelszavaddal!";
                    rosszJelszoLL.Visible = true;
                    conn.Close();
                }

            }
        }
        public void setUjJelszo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE vizga.User SET PASSWORD = '" + u1.Jelszo + "' WHERE Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("Beállt az új jelszó!");
                conn.Close();
            }
            else
            {

                conn.Close();
            }
        }

        private void elkuldBT_Click(object sender, EventArgs e)
        {
            setUjJelszo();
            this.Close();

        }

        private void ujJelszoTB2_TextChanged(object sender, EventArgs e)
        {
            //if (ujJelszoTB.Text != ujJelszoTB2.Text)
            //{
            //    nemEggyezikLL.ForeColor = Color.Red;
            //    nemEggyezikLL.Text = "Az új jelszók nem eggyeznek egymással.";
            //    nemEggyezikLL.Visible = true;
            //}
            //else
            //{
            //    nemEggyezikLL.Visible = false;
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            
                elkuldBT.Enabled = true;
            
            else
                elkuldBT.Enabled = false;
            
        }

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

        private void regiJelszoTB_Leave(object sender, EventArgs e)
        {
            //getJelszo();
        }

        private void ujJelszoTB2_Leave(object sender, EventArgs e)
        {
            if (ujJelszoTB.Text != ujJelszoTB2.Text)
            {
                nemEggyezikLL.ForeColor = Color.Red;
                nemEggyezikLL.Text = "Az új jelszók nem eggyeznek egymással.";
                nemEggyezikLL.Visible = true;
            }
            else
            {
                nemEggyezikLL.Visible = false;
            }
        }

        private void regiJelszoTB_TextChanged(object sender, EventArgs e)
        {
            getJelszo();
        }
        public void fajlbolOlv()
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
                    username = ideig[0];
                    datum = ideig[1];
                }
            }
            olvas.Close();
        }

        private void ujJelszoTB_Leave(object sender, EventArgs e)
        {
            u1.setJelszo(ujJelszoTB.Text);
            if(ujJelszoTB.Text != "asd987654321")
            {
                ujJelszoOkLL.Text = "Megfelelő a jelszó";
                ujJelszoOkLL.ForeColor = Color.Green;
                ujJelszoOkLL.Visible = true;
            }
            else
            {
                ujJelszoOkLL.ForeColor = Color.Red;
                ujJelszoOkLL.Text = "Nem jó erősségű a jelszavad!";
                ujJelszoOkLL.Visible = true;
                ujJelszoTB.Clear();
            }

        }
    }
}
