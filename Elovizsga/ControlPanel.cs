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
                //MessageBox.Show("DB hozzáférés checked!");

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

            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT First_name, Last_name FROM vizga.User where Username= @Username;";
            cmd.Parameters.AddWithValue("@Username",username);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                label2.Text = dr["First_name"].ToString() + " " + dr["Last_name"].ToString();
                label4.Text = datum;
            }

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

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeLL_MouseEnter(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Red;
        }

        private void closeLL_MouseLeave(object sender, EventArgs e)
        {
            closeLL.ForeColor = Color.Black;
        }
    }
}
