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
    public partial class ControlPanel : Form
    {
        //Csatlakozás az adatbázishoz
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public ControlPanel()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        string datum;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainBT_Click(object sender, EventArgs e)
        {
        }
         
        private void ControlPanel_Load(object sender, EventArgs e)
        {
            //Amikor betölt a program beolvassa a log.txt és kinyeri belőle az adatokat.
            fajlbolOlv();
            //Utána lekérdezi annak a felhasználónak a nevét amelyiknek a username attributuma megegyezik a log.txt-ben eltároltal.És kiírja a nevet és a bejelentkezés dátumát.
            getAdat();

            //Jogosultsághoz kötött bejelentkezés:
            getJogA(username);
            getJogL(username);
            getJogO(username);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ucReg1_Load(object sender, EventArgs e)
        {

        }

        private void ucLogin1_Load(object sender, EventArgs e)
        {

        }
        //Alkalmazás bezárása x re kattintva
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //x re húzva a színe változik
        private void closeLL_MouseEnter(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Red;
        }
        //x ről elhúzva a színe változik
        private void closeLL_MouseLeave(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Black;
        }
        //Alkalmazás újraindítása
        private void kijelentkezBT_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

        public void getAdat()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT First_name, Last_name FROM vizga.User where Username= @Username;";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr["First_name"].ToString() + " " + dr["Last_name"].ToString();
                label4.Text = datum;
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }

        public void getJogA(string user)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Username, Admin, Leader, Operator FROM vizga.User where Admin = '1' and Username = @Username;";
            cmd.Parameters.AddWithValue("@Username", user);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminLL.Text = "Adminnal jelentkeztél be!";
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }
        public void getJogL(string user)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Username, Admin, Leader, Operator FROM vizga.User where Leader = '1' and Username = @Username;";
            cmd.Parameters.AddWithValue("@Username", user);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminLL.Text = "Vezetővel jelentkeztél be!";
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }
        public void getJogO(string user)
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Username, Admin, Leader, Operator FROM vizga.User where Operator = '1' and Username = @Username;";
            cmd.Parameters.AddWithValue("@Username", user);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adminLL.Text = "Felhasználóval jelentkeztél be!";
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }

        private void userProfilBT_Click(object sender, EventArgs e)
        {
            PasswChangeForm p1 = new PasswChangeForm();
            p1.Show();
            p1.BringToFront();
        }
    }
}
