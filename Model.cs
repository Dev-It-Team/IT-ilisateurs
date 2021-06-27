
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
        public static void OpenSQLConnexion(string User, string Password)
        {
            try
            {
               string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=127.0.0.1,1433;Initial Catalog=BaseSQL;User ID=sa;Password=Password";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                MessageBox.Show("Connection Open !");
                cnn.Close(); 
            }
            catch
            {
                MessageBox.Show("Connection fail !");
            }
            
        }
    }
}