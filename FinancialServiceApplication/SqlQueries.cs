using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialServiceApplication
{
    internal class SqlQueries {
        //SqlQuery to send user details to the database
        public static string SAVE_USER_TO_DATABASE = "INSERT INTO [USER] (firstName, lastName, email, password, gender, mobile, address, postcode, country, role)" +
            " VALUES (@firstName, @lastName, @email, @password, @gender, @mobile, @address, @postcode, @country, @role)";

        public static string VALIDATE_LOGIN_DETAILS = "SELECT firstname, password, role FROM [USER] WHERE email = @email";
 
    }
}
