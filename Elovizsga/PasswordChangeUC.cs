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
    public partial class PasswordChangeUC : UserControl
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        ControlPanel p1 = new ControlPanel();
        public PasswordChangeUC()
        {
            InitializeComponent();
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
        private void ujJelszoBT_Click(object sender, EventArgs e)
        {
            ujJelszoGB.Visible = true;
            ujJelszoTB.Enabled = false;
            ujJelszoTB2.Enabled = false;
        }

        private void ujJelszoGB_Enter(object sender, EventArgs e)
        {
            p1.fajlbolOlv();
            getJelszo();
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

                }
                else
                {
                    rosszJelszoLL.ForeColor = Color.Red;
                    rosszJelszoLL.Text = "Nem eggyezik a régi jelszavaddal!";
                    rosszJelszoLL.Visible = true;
                }

            }
        }
        public void setUjJelszo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE vizga.User SET PASSWORD = '" + ujJelszoTB2.Text + "' Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
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
        }

        private void ujJelszoTB2_TextChanged(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = elkuldBT.Enabled = true;
        }
    }
}
