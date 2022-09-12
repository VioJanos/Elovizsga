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
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        DbConnection con = new DbConnection();
        RegForm s = new RegForm();
        PassWDCryp uj = new PassWDCryp();

        //x re húzva a színe változik és katt-ra bezárul
        private void closeBT_MouseEnter(object sender, EventArgs e)
        {
           closeBT.BackColor = Color.Red;
        }

        private void closeBT_MouseLeave(object sender, EventArgs e)
        {
            closeBT.BackColor = panel2.BackColor;
        }
        private void closeBT_Click(object sender, EventArgs e)
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
            con.Connection();
            con.Close();
            string a = "SELECT PASSWORD FROM vizga.User where Username='" + FelhnTB.Text + "' ;";
            ;
            string jelszo = uj.DecodePassWD(con.getQuery(a, "password"));
            if (jelszo == JelszoTB.Text)
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                string login = "log.txt";
                StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
                iras.WriteLine(FelhnTB.Text + ";" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                iras.Close();
                ControlPanel CP1 = new ControlPanel();
                CP1.Show();
                CP1.BringToFront();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hibás jelszó!");
                JelszoTB.Clear();
                JelszoTB.Focus();
            }


            //conn.Open();
            //cmd = new MySqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "SELECT PASSWORD FROM vizga.User where Username='" + FelhnTB.Text + "' ;";
            //dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    string jelszo = dr["PASSWORD"].ToString();
            //    jelszo = uj.DecodePassWD(jelszo);
            //    if(jelszo == JelszoTB.Text)
            //    {
            //        MessageBox.Show("Sikeres bejelentkezés!");
            //        string login = "log.txt";
            //        StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
            //        iras.WriteLine(FelhnTB.Text + ";" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
            //        iras.Close();
            //        ControlPanel a = new ControlPanel();
            //        a.Show();
            //        a.BringToFront();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Hibás jelszó!");
            //        JelszoTB.Clear();
            //        JelszoTB.Focus();
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Nem sikerült!");
            //    FelhnTB.Text = "";
            //    JelszoTB.Text = "";
            //}
            //conn.Close();
        }
    }
}
