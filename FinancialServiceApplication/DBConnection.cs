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
    internal class DBConnection
    {
        private DataGridView dataGridView1 = new DataGridView();
        private DataGridView dataGridView2 = new DataGridView();

        //attributes
        //private object of the class itself
        private static DBConnection _instance;

        //the connection string
        private string connectionString;

        //connnection to the database
        private SqlConnection connectToDB;

        public application Application { get; }

        //Constructor
        private DBConnection()
        {
            connectionString = Properties.Settings.Default.FCDConnectionString;

        }


        public DBConnection(application application)
        {
            Application = application;
        }

        //Methods
        //methods that create the unique object of the class itself
        public static DBConnection getInstanceOfDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        //
        //
        //
        //
        // SIGN UP AND LOG IN
        //
        //
        //
        //

        public void saveToDatabase(string sqlQuery, ArrayList parameters)
        {

            using (SqlConnection connectToDB = new SqlConnection(connectionString))
            {

                //open connection
                connectToDB.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectToDB);

                //set the sqlCommand's properties
                sqlCommand.CommandType = CommandType.Text;

                foreach (SqlParameter parameter in parameters)
                {
                    sqlCommand.Parameters.Add(parameter);
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

                        // Application.DisplayGreeting(firstname, role);

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
                bool passwordMatched = PasswordHasher.VerifyPassword(password, databaseHashedPassword);

                return passwordMatched;
            }

            return false;
        }

        //
        //
        //
        //
        //
        //
        //
        //
        //

        public void AddVendorToDatabase(string sqlQuery, string company_name = null, string company_website = null, string established_date = null, string no_of_employees = null)
        {

            using (SqlConnection connectToDB = new SqlConnection(connectionString))
            {

                //open connection
                connectToDB.Open();
                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectToDB))
                {
                    if (company_name != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@company_name", company_name);
                    }
                    if (company_website != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@company_website", company_website);

                    }
                    if (established_date != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@company_established", established_date);
                    }
                    if (no_of_employees != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@no_of_employees", no_of_employees);
                    }
                    //execute the command
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                // Close the connection
                connectToDB.Close();
            }
        }
           
        public void AddSoftwareToDatabase(string sqlQuery, string software_name = null, string description = null, string document_to_attach = null)
        {
            using (SqlConnection connectToDB = new SqlConnection(connectionString))
            {
                // Open connection
                connectToDB.Open();

                using (SqlCommand sqlCommand = new SqlCommand(sqlQuery, connectToDB))
                {
                    // Set the sqlCommand's properties

                    if (software_name != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@software_name", software_name);
                    }

                    if (description != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@description", description);
                    }

                    if (document_to_attach != null)
                    {
                        sqlCommand.Parameters.AddWithValue("@document_to_attach", document_to_attach);
                    }

                    // sqlCommand.Parameters.AddWithValue("@ref_no", ref_no);

                    // Execute the command
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Close the connection
                connectToDB.Close();
            }
        }



        public DataSet LoadVendors(string sqlQuery)
        {
            try
            {
                DataSet dataTable = new DataSet();
                using (SqlConnection connectToDB = new SqlConnection(connectionString))
                {
                    connectToDB.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectToDB))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
            catch (Exception)
            {
                // Log the exception or handle it in a way appropriate for your application.
                // For now, let's rethrow the exception:
                throw;
            }
        }

        public DataSet LoadSoftware(string sqlQuery)
        {
            try
            {
                DataSet dataTable = new DataSet();
                using (SqlConnection connectToDB = new SqlConnection(connectionString))
                {
                    connectToDB.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectToDB))
                    {
                        adapter.Fill(dataTable);
                    }
                }

                return dataTable;
            }
            catch (Exception)
            {
                // Log the exception or handle it in a way appropriate for your application.
                // For now, let's rethrow the exception:
                throw;
            }
        }

      
          



        /* public static byte[] RetrieveFileDataFromDatabase(int softwareId)
         {
             byte[] fileData = null;

             using (SqlConnection connection = new SqlConnection("your_connection_string"))
             {
                 connection.Open();

                 // Adjust the SQL query to match your schema
                 string query = "SELECT document_to_attach FROM YourTable WHERE software_id = @softwareId";

                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     command.Parameters.AddWithValue("@softwareId", softwareId);

                     using (SqlDataReader reader = command.ExecuteReader())
                     {
                         if (reader.Read())
                         {
                             // Assuming the file data is stored as a byte array
                             fileData = (byte[])reader["document_to_attach"];
                         }
                     }
                 }
             }

             return fileData;
         }
        */




        /*public DataSet LoadSoftware(string sqlQuery)
        {
            try
            {
                DataSet dataTable = new DataSet();
                using (SqlConnection connectToDB = new SqlConnection(connectionString))
                {
                    connectToDB.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectToDB);
                    adapter.Fill(dataTable);
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                // Handle the exception or rethrow it, depending on your application's logic.
                // For now, let's rethrow the exception:
                throw;
            }
        }*/

    }
}