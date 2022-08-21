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
    public partial class UcLogin : UserControl
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public UcLogin()
        {
            InitializeComponent();
            connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                MessageBox.Show("DB hozzáférés checked!");
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        Users a = new Users();
        private void loginBT_Click(object sender, EventArgs e)
        {
            //bool talalat = false;
            //int index = 0;
            //for(int i = 0; i < a.Felhasznalok.Count;i++)
            //{
            //    if (a.Felhasznalok[i].FelhN == FelhnTB.Text && a.Felhasznalok[i].Jelszo == JelszoTB.Text)
            //    {
            //        talalat = true; 
            //        index = i;
            //    }
            //}
            //if(talalat)
            //{
            //    MessageBox.Show("Bejelentkezés sikeres!");
            //    string login = "log.txt";
            //    StreamWriter iras = new StreamWriter(login, false, Encoding.UTF8);
            //    iras.WriteLine(FelhnTB.Text + ";" + JelszoTB.Text + ";"+ a.Felhasznalok[index].Jogosultsag + ";" + DateTime.Now.ToLongDateString() +" "+  DateTime.Now.ToLongTimeString()); 
            //    iras.Close();
                
            //    UcMain main = new UcMain();
            //    main.Show();
            //    main.BringToFront();
            //}
            //else
            //{
            //    MessageBox.Show("Hiba!");
            //}

            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM vizga.User where Username='" + FelhnTB.Text + "' and Password='" + JelszoTB.Text + "';";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Sikeres bejelentkezés!");
                this.Visible = false;
                UcMain main = new UcMain();
                main.Show();
                main.BringToFront();
            }
            else
            {
                MessageBox.Show("Nem sikerült!");
            }
            conn.Close();
        }


        private void RegBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            
        }

        private void UcLogin_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void FelhnTB_MouseEnter(object sender, EventArgs e)
        {
            //string adat = "data.txt";
            //StreamReader olvas = new StreamReader(adat, Encoding.UTF8);
            //string sor = "";
            //while (!olvas.EndOfStream)
            //{
            //    sor = olvas.ReadLine();
            //    string[] ideig = sor.Split(';');
            //    if (!sor.Equals(""))
            //    {
            //        Users ss = new Users(ideig[0], ideig[1], ideig[2]);
            //        a.Felhasznalok.Add(ss);
            //    }
            //}
            //olvas.Close();
        }

        private void bejelentkezLL_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
