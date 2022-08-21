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
    public partial class LoginForm : Form
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public LoginForm()
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
        RegForm s = new RegForm();
        private void closeLL_MouseEnter(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Red;
        }

        private void closeLL_MouseLeave(object sender, EventArgs e)
        {
            closeLL.ForeColor= Color.Black;
        }

        private void closeLL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBT_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM vizga.User where Username='" + FelhnTB.Text + "' and Password='" + JelszoTB.Text + "';";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                string login = "log.txt";
                StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
                iras.WriteLine(FelhnTB.Text + ";" + DateTime.Now.ToLongDateString() +" "+  DateTime.Now.ToLongTimeString()); 
                iras.Close();
                ControlPanel a = new ControlPanel();
                a.Show();
                a.BringToFront();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nem sikerült!");
                FelhnTB.Text = "";
                JelszoTB.Text = "";
            }
            conn.Close();
        }

        private void toRegLL_Click(object sender, EventArgs e)
        {
            s.Show();
            s.BringToFront();
        }

        private void toRegLL_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toRegLL_MouseLeave(object sender, EventArgs e)
        {
            toRegLL.ForeColor= Color.Black;
        }

        private void toRegLL_MouseEnter(object sender, EventArgs e)
        {
            toRegLL.ForeColor = Color.BlueViolet;
        }
    }
}
