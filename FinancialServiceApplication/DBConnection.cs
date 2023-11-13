using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace FinancialServiceApplication
{
    internal class DBConnection {

        //attributes
        //private object of the class itself
        private static DBConnection _instance;

        //the connection string
        private string connectionString;

        //connnection to the database
        private SqlConnection connectToDB;

        public application Application { get; }

        //Constructor
        private DBConnection () {
            connectionString = Properties.Settings.Default.FCDConnectionString;

        }

        public DBConnection(application application)
        {
            Application = application;
        }

        //Methods
        //methods that create the unique object of the class itself
        public static DBConnection getInstanceOfDBConnection() { 
            if (_instance == null) {
                _instance = new DBConnection ();
            }
            return _instance;
        }

        public void saveToDatabase(string sqlQuery, ArrayList parameters) {

            using (SqlConnection connectToDB = new SqlConnection (connectionString)) 
            {

                //open connection
                connectToDB.Open();
                SqlCommand sqlCommand = new SqlCommand (sqlQuery, connectToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                foreach (SqlParameter parameter in parameters){
                    sqlCommand.Parameters.Add (parameter);
                }

                //execute the command
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("YOU HAVE SUCCESSFULLY JOINED THE COMMUNITY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the connection
                connectToDB.Close();

            }
        
        }

        // This code retrieves the hashed password specified to the inputed email fron the database
        // It returns the password as a string else it returns null
        public string RetrieveUserPassword(string sqlQuery, string email) 
        {                 
            // A connection to the database is established
            using (SqlConnection connectToDB = new SqlConnection(connectionString))
            {
                // Open connection to the database
                connectToDB.Open();

                // Create a sqlCommand object using the sqlQuery and connection to the database
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectToDB))
                {
                    // Add parameters to the sqlCommand
                    // This method prevents injection
                    sqlCommand.Parameters.AddWithValue("@email", email);

                    // Excute the sqlQuery and retrieve the count
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        string firstname = reader["firstname"].ToString();
                        string hashedPassword = reader["password"].ToString();
                        string role = reader["role"].ToString();
                        
                        //DisplayGreeting(firstname, role);

                        return hashedPassword;
                    }

                    // Return the password if the result is not null. Else return null
                    return null;

                }
            }
            
        }

        public bool ValidateUser(string email, string password)
        {
            string databaseHashedPassword = RetrieveUserPassword(SqlQueries.VALIDATE_LOGIN_DETAILS, email);

            if (databaseHashedPassword != null)
            {
                bool passwordMatched = PasswordHasher.VerifyPassword (password, databaseHashedPassword);

                return passwordMatched;
            }

            return false;
        }

    }
}
