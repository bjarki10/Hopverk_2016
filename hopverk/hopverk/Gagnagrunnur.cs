using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace hopverk
{
    class Gagnagrunnur
    {
       
    
        private string server;
        private string database;
        private string uid;
        private string password;
        string tengistrengur;
        string fyrirspurn;

        MySqlConnection sqltenging;
        MySqlCommand nySQLskipun;
        MySqlDataReader sqllesari = null;

        public void TengingVidGagnagrunn()
        {
            server = "10.200.10.24";
            database = "2201992909_hopverk_2016";
            uid = "2201992909";
            password = "mypassword";

            tengistrengur = "server=" + server + ";userid=" + uid + ";password=" + password + ";database=" + database;
            sqltenging = new MySqlConnection(tengistrengur);
        }
        private bool OpenConnection()
        {
            try
            {
                sqltenging.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                sqltenging.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
        public List<string> LesautSQLToflu()
        {
            List<string> Faerslur = new List<string>();
            string lina = null;
            if (OpenConnection() == true)
            {
                fyrirspurn = "SELECT Nafn,Voruflokkur,Verd,ALager FROM vorur";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                sqllesari = nySQLskipun.ExecuteReader();
                while (sqllesari.Read())
                {
                    for (int i = 0; i < sqllesari.FieldCount; i++)
                    {
                        lina += (sqllesari.GetValue(i).ToString()) + ":";
                    }
                    Faerslur.Add(lina);
                    lina = null;
                }
                CloseConnection();
                return Faerslur;
            }
            return Faerslur;
        }
        public void addtotable(string nafn, string skuld)
        {
            if (OpenConnection() == true) 
            {
                fyrirspurn = "INSERT INTO skuld (nafn, Skuld) VALUES ('" + nafn + "','" + skuld + "')";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void removefromtable(string nafn, string skuld)
        {
            if (OpenConnection() == true)
            {
                fyrirspurn = "DELETE FROM skuld WHERE nafn='" + nafn + "' AND Skuld ='" + skuld + "'";
                nySQLskipun = new MySqlCommand(fyrirspurn, sqltenging);
                nySQLskipun.ExecuteNonQuery();
                CloseConnection();
                }
            }


        
    }
}

