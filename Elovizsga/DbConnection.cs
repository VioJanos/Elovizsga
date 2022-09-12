using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Elovizsga
{
    internal class DbConnection
    {
        MySqlConnection conn;
        string connstring;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public void Connection()
        {
            connstring = "SERVER = mysql.nethely.hu;PORT=3306; DATABASE=vizga;uid=vizga;PASSWORD=Janika208";
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                //getID();//Az adatbázisban következő ID-t adja az új felhasználónak
                //id++;

            }
            catch (MySqlException ex)
            {
                //MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void Close()
        {
            conn.Close();
        }
        string eredmeny;
        public string getQuery(string select,string key)
        {
            
            conn.Open();
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = select;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                eredmeny = dr[key].ToString();
            }
            conn.Close();
            return eredmeny;
        }
    }
}
