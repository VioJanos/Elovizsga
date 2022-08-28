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
    
    public partial class RegForm : Form
    {
        //Csatlakozás az adatbázishoz
        MySqlConnection conn;
        string connstring;
        int id;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public RegForm()
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
                getID();//Az adatbázisban következő ID-t adja az új felhasználónak
                id++;
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
        // Új példány létrehozása az osztályból, változók
        Users uj = new Users();
        string vezeteknev = "";
        string keresztnev = "";
        string jelszo = "";
        string jogosultsag = "";
        string username = "";
        string szuletesido = "";

        //Alkalmazás bezárása x re kattintva
        private void closeLL_Click(object sender, EventArgs e)
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

        private void vezetekNevTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            
        }
        //Új felhasználó felvétele az adatbázisba
        private void RegBT_Click(object sender, EventArgs e)
        {
            setUjFelhasznalo();
        }

        //Vezetéknév ellenőrzése és beállítása
        private void vezetekNevTB_Leave(object sender, EventArgs e)
        {
            vezeteknev = vezetekNevTB.Text;
            uj.setVezet(vezeteknev);
            vezetekNevTB.Text = uj.VezetekNev;
            keresztNevTB.Focus();
        }

        private void keresztNevTB_TextChanged(object sender, EventArgs e)
        {

        }
        //Keresztnév ellenőrzése és beállítása
        private void keresztNevTB_Leave(object sender, EventArgs e)
        {
            keresztnev = keresztNevTB.Text;
            uj.setKereszt(keresztnev);
            keresztNevTB.Text = uj.KeresztNev;
            JelszoTB.Focus();
        }
        //Jelszó ellenőrzése és beállítása
        private void JelszoTB_Leave(object sender, EventArgs e)
        {
            jelszo = JelszoTB.Text;
            uj.setJelszo(JelszoTB.Text);
            JelszoTB.Text = uj.Jelszo;
            emailTB.Focus();
            
        }
        //Átírányít a login formra
        private void toLoginLL_Click(object sender, EventArgs e)
        {
            LoginForm b = new LoginForm();
            b.Show();
            b.BringToFront();
        }
        // szövegszínének megváltoztatása
        private void toLoginLL_MouseEnter(object sender, EventArgs e)
        {
            toLoginLL.ForeColor = Color.BlueViolet;
        }
        // szövegszínének megváltoztatása
        private void toLoginLL_MouseLeave(object sender, EventArgs e)
        {
            toLoginLL.ForeColor = Color.Black;
        }
        //Jogosultság beállítása osztályban
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null || comboBox1.SelectedIndex == 0)
            {
                rosszJogosultsagLL.ForeColor = Color.Red;
                rosszJogosultsagLL.Text = "Kötelező megadni jogosultságot!";
                RegBT.Enabled = false;
                rosszJogosultsagLL.Visible = true;
                comboBox1.Focus();
            }
            else
            {
                rosszDatumLL.Visible = false;
                RegBT.Enabled = true;
                jogosultsag = comboBox1.SelectedItem.ToString();
                uj.setJogosultsag(jogosultsag);
            }
            
            
        }
        public void setUjFelhasznalo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO vizga.User (`Employee_id`, `Password`, `First_name`, `Last_name`, `E-mail`) VALUES('" + uj.setID(id) + "', '" + JelszoTB.Text + "', '" + vezetekNevTB.Text + "', '" + keresztNevTB.Text + "', '" + emailTB.Text + "');";
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("Felhasználó létrehozva, bejelentkezhetsz!");
                id++;
                torol();

            }
            else
            {
                MessageBox.Show("Hiba!");
            }
            conn.Close();
            setJogos(jogosultsag);
            setSzulido();
            rosszJogosultsagLL.Visible = false;
            rosszEmailLL.Visible = false;
        }
        //Jogosultság beállítása adatbázisban osztályban lévő adat alapján
        private void setJogos(string jog)
        {
            username = vezeteknev.Substring(0,3) + keresztnev.Substring(0,3) + uj.Id;
            jog = jogosultsag;
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            if (jog == "Admin")
            {
                cmd.CommandText = "UPDATE vizga.User SET Admin = '1' WHERE USERNAME = @Username";
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
            else if (jog == "Vezető")
            {
                cmd.CommandText = "UPDATE vizga.User SET Leader = '1' WHERE USERNAME = @Username";
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
            else if(jog == "Felhasználó")
            {
                cmd.CommandText = "UPDATE vizga.User SET Operator = '1' WHERE USERNAME = @Username";
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
        }
        //Email ellenőrzése és beállítása
        private void emailTB_Leave(object sender, EventArgs e)
        {
            if (!emailTB.Text.Contains("@"))
            {
                rosszEmailLL.ForeColor = Color.Red;
                rosszEmailLL.Text = "Nem megfelelő email formátum! Írja be újra!";
                rosszEmailLL.Visible = true;
                emailTB.Clear();
            }
            else
            {
                rosszEmailLL.Visible = false; 
                uj.setEmail(emailTB.Text);
            }
        }

        //Születési idő ellenőrzése és beállítása
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value <= DateTime.MinValue)
            {
                rosszDatumLL.ForeColor = Color.Red;
                rosszDatumLL.Visible = true;
                rosszDatumLL.Text = "Túl régi dátum, add meg a valós születési dátumod.";
                dateTimePicker1.Refresh();
            }
            else if(dateTimePicker1.Value >= DateTime.Now)
            {
                rosszDatumLL.ForeColor = Color.Red;
                rosszDatumLL.Visible = true;
                rosszDatumLL.Text = "Még meg sem születtél, add meg a valós születési dátumod.";
                dateTimePicker1.Refresh();
            }
            else
            {
                rosszDatumLL.Visible = false;
                szuletesido = Convert.ToString(dateTimePicker1.Text);
                uj.setSzulDate(szuletesido);
            }
            

        }

        public void setSzulido()
        {
            username = vezeteknev.Substring(0, 3) + keresztnev.Substring(0, 3) + uj.Id;
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            DateTime szulido = dateTimePicker1.Value;
            string format = "yyyy-MM-dd";
            string insert = @"UPDATE `vizga`.`User` set `Birth` = '"+szulido.ToString(format)+"' WHERE USERNAME = @Username";
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.CommandText = insert;

            dr = cmd.ExecuteReader();
            if(!dr.Read())
            {
                conn.Close();

            }
            else
            {
                conn.Close();
                MessageBox.Show("Hiba!");
            }
        }

        //textboxok törlése
        public void torol()
        {
            vezetekNevTB.Clear();
            keresztNevTB.Clear();
            JelszoTB.Clear();
            emailTB.Clear();
            rosszEmailLL.Visible = false;
            rosszJogosultsagLL.Visible = false;
            comboBox1.SelectedIndex = 0;
            
        }

        public void getID()
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Employee_id FROM vizga.User order by Employee_id desc ";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string ideig = dr["Employee_id"].ToString();
                id = int.Parse(ideig);  
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is null || comboBox1.SelectedIndex == 0)
            {
                rosszJogosultsagLL.ForeColor = Color.Red;
                rosszJogosultsagLL.Text = "Kötelező megadni jogosultságot!";
                RegBT.Enabled = false;
                rosszJogosultsagLL.Visible = true;
            }
            else
            {
                RegBT.Enabled = true;
                rosszJogosultsagLL.Visible =false;
            }
        }
    }
}
