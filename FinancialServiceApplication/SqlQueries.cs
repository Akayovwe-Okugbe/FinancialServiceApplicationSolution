using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialServiceApplication
{
    public class SqlQueries
    {
        //SqlQuery to send user details to the database
        public static string SAVE_USER_TO_DATABASE = "INSERT INTO [USER] (firstName, lastName, email, password, gender, mobile, address, postcode, country, role)" +
            " VALUES (@firstName, @lastName, @email, @password, @gender, @mobile, @address, @postcode, @country, @role)";

        public static string VALIDATE_LOGIN_DETAILS = "SELECT firstname, password, role FROM [USER] WHERE email = @email";

        public static string ADD_NEW_VENDOR = "INSERT INTO COMPANY([company_name], [company_website], [company_established], [no_of_employees] ) VALUES(@company_name, @company_website, @company_established, @no_of_employees)";
        public static string ADD_NEW_SOFTWARE = " INSERT INTO SOFTWARE ([software_name], [description]) VALUES (@software_name, @description)";

        public string displayVendor()
        {
            string DISPLAY_VENDORS = "SELECT * FROM COMPANY";
            return DISPLAY_VENDORS;
        }
        public string displaySoftware()
        {
            string DISPLAY_SOFTWARE = "SELECT * FROM SOFTWARE";
            return DISPLAY_SOFTWARE;
        }
    }

}

