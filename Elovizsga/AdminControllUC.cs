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
    public partial class AdminControllUC : UserControl
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public AdminControllUC()
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
            rF1.getID();
        }
        PassWDCryp uj = new PassWDCryp();
        RegForm rF1 = new RegForm();
        string username;
        int id;
        string jelszo;
        private void AdminControllUC_Load(object sender, EventArgs e)
        {
            FelhasznalokDGV.DataSource = GetUsersList();
            txtBoxEdit();
            getJog();
        }
        //Lekérdezem az összes elemet a User táblából
        private DataTable GetUsersList()
        {
            DataTable dtUsers = new DataTable();
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM vizga.User order by Employee_id;";
            dr = cmd.ExecuteReader();
            dtUsers.Load(dr);
            conn.Close();
            return dtUsers;
            
        }
        private void txtBoxEdit()
        {
            if(idTB.Enabled == true)
            {
                idTB.Enabled = false;
                usernameTB.Enabled = false;
                passwdTB.Enabled = false;
                firstnameTB.Enabled = false;
                lastnameTB.Enabled = false;
                mailTB.Enabled = false;
                dateTimePicker1.Enabled = false;
                comboBox1.Enabled = false;
            }
            else
            {
                idTB.Enabled = true;
                usernameTB.Enabled = true;
                passwdTB.Enabled = true;
                firstnameTB.Enabled = true;
                lastnameTB.Enabled = true;
                mailTB.Enabled = true;
                dateTimePicker1.Enabled = true;
                comboBox1.Enabled = true;
            }

           
        }
        //Excelbe kiírom a DataGridView tartalmát
        private void saveBT_Click(object sender, EventArgs e)
        {
            if(saveBT.Text == "Exportálás")
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

                app.Visible = true;
                worksheet = workbook.Sheets["Munka1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Teljes személyi állomány";

                for (int i = 1; i < FelhasznalokDGV.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = FelhasznalokDGV.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < FelhasznalokDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < FelhasznalokDGV.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = FelhasznalokDGV.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            
            //Ha az "Új hozzáadása" gombra kattint akkor más lesz a gomb szövege és megcsinálja a felhasználót(nem működik rendesen még!)
            if(saveBT.Text == "Mentés")
            {
                                
                setUjFelhasznalo();
                rF1.setJogos(comboBox1.Text);
                rF1.setSzulido();
            }
        }
        //Az adott sorra kattintva kitölti a TB -kat, szerkeztés még nincs meg.
        private void FelhasznalokDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = "";
            if(FelhasznalokDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                FelhasznalokDGV.CurrentRow.Selected = true;
                idTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Employee_id"].FormattedValue.ToString();
                usernameTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Username"].FormattedValue.ToString();
                passwdTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                string pw = uj.DecodePassWD(passwdTB.Text);
                passwdTB.Text = pw;
                firstnameTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["First_name"].FormattedValue.ToString();
                lastnameTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["Last_name"].FormattedValue.ToString();
                mailTB.Text = FelhasznalokDGV.Rows[e.RowIndex].Cells["E-mail"].FormattedValue.ToString();
                string datum = FelhasznalokDGV.Rows[e.RowIndex].Cells["Birth"].FormattedValue.ToString();
                dateTimePicker1.Value = DateTime.Parse(datum);
                if(FelhasznalokDGV.Rows[e.RowIndex].Cells["Admin"].Value is true)
                {
                    comboBox1.SelectedIndex = 1;
                }
                else if(FelhasznalokDGV.Rows[e.RowIndex].Cells["Leader"].Value is true)
                {
                    comboBox1.SelectedIndex = 3;
                }
                else
                {
                    comboBox1.SelectedIndex= 2;
                }
                
            }
        }
        //Szerkezthetőek lesznek a textBoxok
        private void editBT_Click(object sender, EventArgs e)
        {
            txtBoxEdit();
        }
        //Törli az adott sort, és frissíti a nézetet.
        private void deleteBT_Click(object sender, EventArgs e)
        {
            DialogResult torli;
            torli = MessageBox.Show("Biztos törli az adott elemet?", "Törlés",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(torli == DialogResult.Yes)
            {
                conn.Open();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Delete FROM vizga.User WHERE Username = @Username;";
                cmd.Parameters.AddWithValue("@Username", usernameTB.Text);
                dr = cmd.ExecuteReader();
                conn.Close();
                reLoad();
            }
        }
        //DataGridView újratöltése
        private void reLoad()
        {
            FelhasznalokDGV.DataSource = null;
            FelhasznalokDGV.DataSource = GetUsersList();
        }
        //Vizsgálja hogy milyen joggal van bent a felhasználó és úgy engedélyezi a gombokat
        private void getJog()
        {
            bool vizsgal =false;
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
                }
            }
            olvas.Close();


            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection= conn;
            cmd.CommandText = "Select Username FROM vizga.User where Admin = 1 and Username = @Username";
            cmd.Parameters.AddWithValue("@Username", username);
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                dr["Username"].ToString();
                vizsgal = dr["Username"].ToString() == username;
            
            }
            if (vizsgal)
            {
                newBT.Enabled = true;
                editBT.Enabled = true;
                deleteBT.Enabled = true;
            }
            else
            {
                newBT.Enabled = false;
                editBT.Enabled = false;
                deleteBT.Enabled = false;
            }
            conn.Close();
        }
        private void setUjFelhasznalo()
        {
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO vizga.User (`Employee_id`, `Password`, `First_name`, `Last_name`, `E-mail`) VALUES('" + uj.setID(id) + "', '" + jelszo + "', '" + lastnameTB.Text + "', '" + firstnameTB.Text + "', '" + mailTB.Text + "');";
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("Felhasználó létrehozva!");
                id++;
                conn.Close();
                reLoad();
            }
            else
            {
                MessageBox.Show("Hiba!");
            }
            conn.Close();
        }
        //Kiüríti a textBoxokat
        public void textBoxEmpty()
        {
            idTB.Clear();
            usernameTB.Clear();
            passwdTB.Clear();
            firstnameTB.Clear();
            lastnameTB.Clear();
            mailTB.Clear();


        }
        private void newBT_Click(object sender, EventArgs e)
        {
            textBoxEmpty();
            txtBoxEdit();
            idTB.Enabled = false ;
            usernameTB.Enabled = false ;
            saveBT.Text = "Mentés";
        }
        // Jelszó titkosítás
        private void passwdTB_Leave(object sender, EventArgs e)
        {
            jelszo = passwdTB.Text.ToString();
            uj.setJelszo(jelszo);
            passwdTB.Text = uj.Jelszo;
            jelszo = uj.EncodePassWD(passwdTB.Text);
        }
    }
}
