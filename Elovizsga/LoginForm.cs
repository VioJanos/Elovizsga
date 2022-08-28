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
        //Csatlakozás az adatbázishoz
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

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        RegForm s = new RegForm();

        //x re húzva a színe változik
        private void closeLL_MouseEnter(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Red;
        }
        //x ről elhúzva a színe változik
        private void closeLL_MouseLeave(object sender, EventArgs e)
        {
            closeLL.ForeColor= Color.Black;
        }
        //Alkalmazás bezárása x re kattintva
        private void closeLL_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Bejelentkezés adatbázisban meglévő felhasználóval, és egy log.txt fájl készítése Username és aktuális dátum óra perc adatokkal. Főprogram előjön.
        private void loginBT_Click(object sender, EventArgs e)
        {
            getBejelentkezes();
        }
        //Átirányít a regisztrációs formra
        private void toRegLL_Click(object sender, EventArgs e)
        {
            s.Show();
            s.BringToFront();
        }

        private void toRegLL_MouseHover(object sender, EventArgs e)
        {
            
        }
        // szövegszínének megváltoztatása
        private void toRegLL_MouseLeave(object sender, EventArgs e)
        {
            toRegLL.ForeColor= Color.Black;
        }
        // szövegszínének megváltoztatása
        private void toRegLL_MouseEnter(object sender, EventArgs e)
        {
            toRegLL.ForeColor = Color.BlueViolet;
        }

        public void getBejelentkezes()
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
                iras.WriteLine(FelhnTB.Text + ";" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
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
    }
}
