﻿using System;
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
        }
        PassWDCryp uj = new PassWDCryp();
        string username;
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
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Munka1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Teljes személyi állomány";

            for(int i = 1; i < FelhasznalokDGV.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = FelhasznalokDGV.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < FelhasznalokDGV.Rows.Count -1; i++)
            {
                for(int j = 0; j < FelhasznalokDGV.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = FelhasznalokDGV.Rows[i].Cells[j].Value.ToString();
                }
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
                FelhasznalokDGV.DataSource = null;
                FelhasznalokDGV.DataSource = GetUsersList();
            }
        }
        //Vizsgálja hogy milyen joggal van bent a felhasználó és úgy engedélyezi a gombokat
        private void getJog()
        {
            
            //if ()
            //{
            //    newBT.Enabled = true;
            //    editBT.Enabled = true;
            //    deleteBT.Enabled = true;
            //}
            //else
            //{
            //    newBT.Enabled = false;
            //    editBT.Enabled = false;
            //    deleteBT.Enabled = false;
            //}
        }
    }
}
