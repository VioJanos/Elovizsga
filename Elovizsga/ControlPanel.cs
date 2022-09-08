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
            this.AutoSizeMode = AutoSizeMode.GrowOnly ;
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
            pwChange1.Visible = false;
            adminControllUC1.Visible = false;
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
        //Alkalmazás bezárása és ablak méretezések és szinváltoztatás
        private void closeBT_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Bezárja a programot?","Mini ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void closeBT_MouseEnter(object sender, EventArgs e)
        {
            closeBT.BackColor = Color.Red;
        }
        private void closeBT_MouseLeave(object sender, EventArgs e)
        {
            closeBT.BackColor = panel4.BackColor;
        }

        private void maxBT_Click(object sender, EventArgs e)
        {
            if (WindowState is FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }
        }
        private void maxBT_MouseEnter(object sender, EventArgs e)
        {
            maxBT.BackColor = Color.Gray;
        }
        private void maxBT_MouseLeave(object sender, EventArgs e)
        {
            maxBT.BackColor = panel4.BackColor;
        }
        private void minBT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void minBT_MouseEnter(object sender, EventArgs e)
        {
            minBT.BackColor = Color.Gray;
        }

        private void minBT_MouseLeave(object sender, EventArgs e)
        {
            minBT.BackColor = panel4.BackColor;
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
                adminLL.Text = "Admin";
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
                adminLL.Text = "Vezető";
                adminBT.Enabled = false;
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
                adminLL.Text = "Felhasználó";
                adminBT.Enabled=false;
                conn.Close();
            }
            else
            {
                conn.Close();
            }
        }

        private void userProfilBT_Click(object sender, EventArgs e)
        {
            adminControllUC1.Visible = false;
            pwChange1.Visible = true;   
        }

        private void adminBT_Click(object sender, EventArgs e)
        {
            pwChange1.Visible=false;
            adminControllUC1.Visible = true;
        }
    }
}
