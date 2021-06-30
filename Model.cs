
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
        public static bool Authenticate(string User, string Password)
        {
            try
            {
                //Open SQL connexion
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=127.0.0.1,1433;Database=BaseSQL;User ID=sa;Password=Password";
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                //MessageBox.Show("Connection Open !");

                //Sql query to verify if user exists
                string querystring = "SELECT * FROM Users WHERE Email = '" + User + "' and Password = '" + Password + "' and UserFlag in ('Comm', 'Tech')";
                //string query = "insert into Users values ('"+"Ledru"+"','"+"Louis"+"','"+"ledrulouis1@gmail.com"+"','"+"Password"+"','"+"1999-10-20"+"','"+"adressse"+"','"+"2000-01-01 01:01:01"+"','"+"aa"+"','"+" 0"+"','"+"User"+"')";
                SqlCommand command = new SqlCommand(querystring, cnn);
                int rowsNb = 0 ;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rowsNb = rowsNb + 1 ;
                    }
                    //MessageBox.Show("Connection successfull !, nav to menu");
                    cnn.Close();
                    return true;
                }
                else
                {
                    MessageBox.Show("Connection refusée !");
                    cnn.Close();
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Connection fail !");
                return false;
            }
            
        }

        public static void DeleteUser(string Email)
        {
            try
            {
                //Open SQL connexion
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=127.0.0.1,1433;Database=BaseSQL;User ID=sa;Password=Password";
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                //Query to check if user exists
                string CheckUserExists = "SELECT IdUser FROM Users WHERE Email = '" + Email + "'";
                SqlCommand command = new SqlCommand(CheckUserExists, cnn);
                var IdUserToDelete = command.ExecuteScalar();
                cnn.Close();

                if(IdUserToDelete != null)
                {
                    string DeleteUserRest = "Delete from Restaurants where IdUser = '" + IdUserToDelete + "'";
                    string DeleteUserDeDr = "Delete from DeliveryDrivers where IdUser = '" + IdUserToDelete + "'";
                    string DeleteUserUsers = "Delete from Users where IdUser = '" + IdUserToDelete + "'";

                    cnn.Open();
                    SqlCommand commandDel1 = new SqlCommand(DeleteUserRest, cnn);
                    commandDel1.ExecuteNonQuery();
                    SqlCommand commandDel2 = new SqlCommand(DeleteUserDeDr, cnn);
                    commandDel2.ExecuteNonQuery();
                    SqlCommand commandDel3 = new SqlCommand(DeleteUserUsers, cnn);
                    commandDel3.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("User deleted successfully");
                }
                else
                {
                    MessageBox.Show("User not found in database");
                }
            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite, veuillez réessayer.");
            }
        }

        public static void CreateUser(string Name, string FirstName, string Email, string Password, string Birthdate, string Address, string UserFlag)
        {
            try
            {
                //Open SQL connexion
                string connectionString;
                SqlConnection cnn;
                connectionString = @"Data Source=127.0.0.1,1433;Database=BaseSQL;User ID=sa;Password=Password";
                cnn = new SqlConnection(connectionString);
                cnn.Open();

                //Query to check if user exists
                string CheckUserExists = "SELECT IdUser FROM Users WHERE Email = '" + Email + "'";
                SqlCommand command = new SqlCommand(CheckUserExists, cnn);
                var IdUserExists = command.ExecuteScalar();
                cnn.Close();
                if(IdUserExists != null)
                {
                    MessageBox.Show("Cette adresse email est déjà utilisée.");
                }
                else
                {
                    string InsertUser = "insert into Users values ('"+Name+"','"+FirstName+"','"+Email+"','"+Password+"','"+Birthdate+"','"+Address+"','"+DateTime.Now.ToString("MM'-'dd'-'yyyy HH:mm:ss")+"','"+"aa"+"','"+" 0"+"','"+UserFlag+"')";
                    SqlCommand commandInsertUser = new SqlCommand(InsertUser, cnn);
                    cnn.Open();
                    commandInsertUser.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Création réussie");
                }

            }
            catch
            {
                MessageBox.Show("Une erreur s'est produite, veuillez réessayer.");
            }
        }
    }
}