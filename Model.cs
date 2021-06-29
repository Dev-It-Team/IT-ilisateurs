
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_ilisateurs
{
    public class Model
    {
        public static void Authenticate(string User, string Password)
        {
            try
            {
               string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=127.0.0.1,1433;Database=BaseSQL;User ID=sa;Password=Password";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                //MessageBox.Show("Connection Open !");

                //Sql query to verify if user exists
                string querystring = "SELECT * FROM Users WHERE Email = '" + User + "' and Password = '" + Password + "'";
                string query = "insert into Users values ('"+"Ledru"+"','"+"Louis"+"','"+"ledrulouis1@gmail.com"+"','"+"Password"+"','"+"1999-10-20"+"','"+"adressse"+"','"+"2000-01-01 01:01:01"+"','"+"aa"+"','"+" 0"+"','"+"User"+"')";
                SqlCommand command = new SqlCommand(querystring, cnn);
                int rowsNb = 0 ;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowsNb = rowsNb + 1 ;
                    }
                }
                cnn.Close();
                MessageBox.Show("Connection successfull !, nav to menu");
            }
            catch
            {
                MessageBox.Show("Connection fail !");
            }
            
        }
    }
}