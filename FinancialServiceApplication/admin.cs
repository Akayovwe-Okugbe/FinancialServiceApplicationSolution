using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace FinancialServiceApplication
{
    internal class admin
    {
        private List<string> selectedRoles = new List<string>();

        /* public static void UpdateUserRole(DBConnection dBConnection, SqlQueries query, int user_id, string role)
         {
             string updateRoleQuery = query.updateUserRole(user_id);

             ArrayList parameters = new ArrayList();
             parameters.Add(new SqlParameter("user_id", user_id));
             parameters.Add(new SqlParameter("role", role));

             // Call the appropriate method to update the user role in the database
             dBConnection.saveToDatabase(updateRoleQuery, parameters, role);
         }*/

        public class UserManagement
        {
            private string connectionString = "your_connection_string_here";

            public void UpdateUserRole(int userId, string newRole)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlUpdateQuery = "UPDATE [User] SET Role = @NewRole WHERE UserId = @UserId";
                    SqlCommand updateCommand = new SqlCommand(sqlUpdateQuery, connection);
                    updateCommand.Parameters.AddWithValue("@NewRole", newRole);
                    updateCommand.Parameters.AddWithValue("@UserId", userId);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        // Usage in your form class
        private UserManagement userManagement = new UserManagement();


        // Event handler for update button click



        public static void DeleteUser(DBConnection dBConnection, SqlQueries query, int user_id)
        {
            try
            {
                string deleteUserQuery = query.deleteUser(user_id);

                // Use parameters for better security
                ArrayList parameters = new ArrayList();
                parameters.Add(new SqlParameter("user_id", user_id));

                // Call the appropriate method to delete the user from the database
                dBConnection.saveToDatabase(deleteUserQuery, parameters, ""); // Add an empty string or provide an appropriate value for the 'role' parameter
                Console.WriteLine("User deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting user: {ex.Message}");
            }
        }



    }
}
