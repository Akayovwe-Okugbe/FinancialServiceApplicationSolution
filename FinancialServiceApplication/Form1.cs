using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace FinancialServiceApplication
{
    public partial class application : Form
    {
        //
        private readonly List<Panel> listPanel = new List<Panel>();

        //
        private readonly ArrayList parameterList = new ArrayList();
        private ErrorProvider errorProvider = new ErrorProvider();
        //
        DBConnection dbconnection = DBConnection.getInstanceOfDBConnection();
        SqlQueries sqlQueries = new SqlQueries();
        


        public application()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            this.Controls.Add(menuFunctions);
            listPanel.Add(homePage);
            listPanel.Add(aboutUs);
            listPanel.Add(logInPage);
            listPanel.Add(signUpPage);
            listPanel.Add(header);
            listPanel.Add(footer);

            listPanel.Add(vendorPage);
            listPanel.Add(vendorDisplay);
            listPanel.Add(addVendorPanel);
            listPanel.Add(updateVendorPanel);

            listPanel.Add(softwarePage);
            listPanel.Add(displaySoftwarePanel);
            listPanel.Add(addSoftwarePanel);
            listPanel.Add(softwareUpdatePanel);

            listPanel.Add(adminDataGridViewPanel);
            listPanel.Add(updateUserRolePanel);
            listPanel.Add(deleteUserPanel);

            listPanel.Add(extraPanel);
        }

        //
        //
        //
        //
        // METHODS
        //
        //
        //
        //

        private void CheckSignUpTextBoxes()
        {
            /* This code checks all the text boxes in the sign up page if it is not null or empty.
            * This ensures the user enter details in all the required fields before displaying the signup button
            */
            if (!string.IsNullOrEmpty(firstnameBox.Text) && !string.IsNullOrEmpty(lastnameBox.Text) &&
                !string.IsNullOrEmpty(emailBox.Text) && !string.IsNullOrEmpty(passwordBox.Text) &&
                !string.IsNullOrEmpty(genderBox.Text) && !string.IsNullOrEmpty(mobileBox.Text) &&
                !string.IsNullOrEmpty(addressBox.Text) && !string.IsNullOrEmpty(postcodeBox.Text) &&
                !string.IsNullOrEmpty(countryBox.Text))
            {
                // The signup button is displayed if the required fields are not null
                signUpButton.Visible = true;
            }
            else
            {
                // Else the button stays invisible
                signUpButton.Visible = false;
            }
        }

        private void CheckLogInTextBoxes()
        {
            /* This code checks all the text boxes in the log in page if it is not null or empty.
            * This ensures the user enter details in all the required fields before displaying the login button
            */
            if (!string.IsNullOrEmpty(logInEmailBox.Text) && !string.IsNullOrEmpty(logInPasswordBox.Text))
            {
                // The login button is displayed if the required fields are not null
                logInButton.Visible = true;
            }
            else
            {
                // Else the button stays hidden
                logInButton.Visible = false;
            }
        }

        private void TextBoxLength(object sender, EventArgs e, int maximumLength)
        {
            // cast the sender as a textBox to access its properties
            TextBox textBox = (TextBox)sender;

            /* This code checks if the length of the text is greater than the maximum specified length,
             * truncate the text to the characters specified and move the cursor to the end */
            if (textBox.Text.Length > maximumLength)
            {
                textBox.Text = textBox.Text.Substring(0, maximumLength);
                textBox.Select(textBox.Text.Length, 0);

            }
        }

        private void PanelVisibility(params Control[] panelsToDisplay)
        {
            foreach (Control panel in listPanel)
            {
                panel.Visible = panelsToDisplay.Contains(panel);
            }
        }

        private void DisplayGreeting(string firstname, string role)
        {
            greetingLabel.Visible = true;
            greetingLabel.Text = $"Hello, {firstname}!  [ {role} ]";
        }

        private void DisplayHomepage()
        {           
            menuFunctions.Visible = true;
            PanelVisibility(header, footer, homePage);
        }

        private void DisplayAdminPage()
        {
            PanelVisibility(adminDataGridViewPanel);
            deleteUser.Visible = true;
            updateUser.Visible = true;
            createUser.Visible = true;
        }



        //
        //
        //
        //
        // HOME PAGE AND MENU FUNCTIONS
        //
        //
        //
        //

        private void HomeMenuItem_Click(object sender, EventArgs e)
        {
            DisplayHomepage();
        }

        private void LogInMenuItem_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = false;
            PanelVisibility(logInPage);
        }

        private void AboutUsMenuItem_Click(object sender, EventArgs e)
        {
            PanelVisibility(aboutUs);
        }

        private void SignUpMenuItem_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = false;
            joinCommunityLabel.Text = "JOIN THE COMMUNITY";
            goBackButtonS.Visible = true;
            backToAdminPage.Visible = false;
            logInRedirectLabel.Visible = true;
            logInLink.Visible = true;
            signUpButton.Text = "SIGN UP";
            PanelVisibility(signUpPage);
        }

        private void LogOutMenuItem_Click(object sender, EventArgs e)
        {
            // After successful logout
            MessageBox.Show("LOG OUT SUCCESSFULLY!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            greetingLabel.Visible = false;
            PanelVisibility(header, footer, homePage);
            vendorButton.Visible = false;
            softwareButton.Visible = false;
            searchText.Visible = false;
            searchButton.Visible = false;
            menuFunctions.Visible = true;
            logoutMenuItem.Visible = false;
            loginMenuItem.Visible = true;
            signupMenuItem.Visible = true;
            adminDataGridViewPanel.Visible = false;
            adminAccessButton.Visible = true;
        }

        private void CompanyButton_Click(object sender, EventArgs e)
        {
            PanelVisibility(header, vendorPage, vendorDisplay);
        }

        private void SoftwareButton_Click(object sender, EventArgs e)
        {
            PanelVisibility(header, softwarePage, displaySoftwarePanel);
                          
        }

        private void ePanelButton_Click(object sender, EventArgs e)
        {
            PanelVisibility(extraPanel);
        }

        private void adminAccessButton_Click(object sender, EventArgs e)
        {
            adminAccessPanel.Visible = !adminAccessPanel.Visible;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            string accessCode = "#45ab";
            string enteredCode = adminAccessTextBox.Text;


            if (enteredCode == accessCode)
            {
                menuFunctions.Visible = true;
                HomeMenuItem.Visible = true;               
                loginMenuItem.Visible = true;
                signupMenuItem.Visible = true;
                aboutUsMenuItem.Visible = false;
                logoutMenuItem.Visible = false;
                PanelVisibility(adminDataGridViewPanel);
                deleteUser.Visible = true;
                updateUser.Visible = true;
                createUser.Visible = true;
            }
            else
            {
                MessageBox.Show("INVALID!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                adminAccessPanel.Visible = false;
            }
            
        }

        //
        //
        //
        //
        // LOG IN
        //
        //
        //
        //

        private void LogInEmailBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(logInEmailBox, EventArgs.Empty, 100);

            // Check if all text boxes in the log in page have input and display the log in button
            CheckLogInTextBoxes();
        }

        private void LogInPasswordBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(logInPasswordBox, EventArgs.Empty, 20);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckLogInTextBoxes();
        }

        private void LogInPasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            // This code if the checkBox(PanelVisibiliy) is checked
            // It sets the PasswordChar of the checkBox to null(\0) if it is checked, thus displaying the password as plain text
            // If not checked, it masked the password by setting the PasswordChar to '*'
            logInPasswordBox.PasswordChar = LogInPasswordVisibility.Checked ? '\0' : '*';
        }

        private void LogInPageGoBackButton_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            foreach (Control control in logInForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }

            DisplayHomepage();
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelVisibility(signUpPage);
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Get the user's entered email and password
            string email = logInEmailBox.Text;
            string password = logInPasswordBox.Text;

            // Validate the user, retrieve the firstname and role
            bool userValidated = DBConnection.getInstanceOfDBConnection().ValidateUser(email, password, out string firstname, out string role);           

            if (userValidated)
            {
                MessageBox.Show("LOGIN SUCCESSFUL!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayGreeting(firstname, role);

                if (role == "CONSULTANT")
                {
                    // After successful login, display a complete home screen
                    PanelVisibility(header, footer, homePage);
                    vendorButton.Visible = true;
                    softwareButton.Visible = true;
                    searchText.Visible = true;
                    searchButton.Visible = true;
                    menuFunctions.Visible = true;
                    logoutMenuItem.Visible = true;
                    aboutUsMenuItem.Visible = true;
                    loginMenuItem.Visible = false;
                    signupMenuItem.Visible = false;
                    adminAccessButton.Visible = false;
                    adminAccessPanel.Visible = false;
                    VendorToSoftwareLinkButton.Visible = true;
                }
                else if (role == "ADMINISTRATOR")
                {
                    PanelVisibility(adminDataGridViewPanel);
                    deleteUser.Visible = true;
                    updateUser.Visible = true;
                    createUser.Visible = true;
                    menuFunctions.Visible = true;
                    logoutMenuItem.Visible = true;
                    HomeMenuItem.Visible = false;
                    aboutUsMenuItem.Visible = false;
                    loginMenuItem.Visible = false;
                    signupMenuItem.Visible = false;
                    adminAccessButton.Visible = false;
                    adminAccessPanel.Visible = false;
                }
                else
                {
                    PanelVisibility(header, footer, homePage);
                    vendorButton.Visible = true;
                    softwareButton.Visible = true;
                    searchText.Visible = true;
                    searchButton.Visible = true;
                    menuFunctions.Visible = true;
                    logoutMenuItem.Visible = true;
                    aboutUsMenuItem.Visible = true;
                    loginMenuItem.Visible = false;
                    signupMenuItem.Visible = false;
                    BtnShowVendorPage.Visible = false;
                    btnAddSoft.Visible = false;
                    adminAccessButton.Visible = false;
                    adminAccessPanel.Visible = false;
                    VendorToSoftwareLinkButton.Visible = false;
                }
                
                
            }
            else
            {
                MessageBox.Show("INVALID CREDENTIALS. PLEASE CHECK LOGIN DETAILS!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*

            // Validate the user, retrieve the firstname and role
            if (DBConnection.getInstanceOfDBConnection().ValidateUser(email, password, out string firstname, out string role))
            {
                // Successful login
                MessageBox.Show($"Login successful! User role: {userRole}");

                // Now you can use the userRole information to determine actions or features available to the user
                if (userRole == "Admin")
                {
                    // Do something specific for Admin
                    PanelVisibility(header, footer, homePage);
                    logoutMenuItem.Visible = true;
                    loginMenuItem.Visible = false;
                    //signupMenuItem.Visible = true;
                    searchText.Visible = true;
                    searchButton.Visible = true;
                    menuFunctions.Visible = true;
                    adminDataGridViewPanel.Visible = true;

                }
                else if (userRole == "Consultant")
                {
                    // Do something specific for Consultant
                    PanelVisibility(header, footer, homePage);
                    vendorButton.Visible = true;
                    softwareButton.Visible = true;
                    searchText.Visible = true;
                    searchButton.Visible = true;
                    menuFunctions.Visible = true;
                    logoutMenuItem.Visible = true;
                    loginMenuItem.Visible = false;
                    signupMenuItem.Visible = false;
                    adminDataGridViewPanel.Visible = false;
                }

                // ... (other actions after successful login)
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid email or password. Please try again.");
            }

            */
        }

        //
        //
        //
        //
        // SIGN UP
        //
        //
        //
        //

        private void SignUpFirstnameBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(firstnameBox, EventArgs.Empty, 50);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();

        }

        private void SignUpLastnameBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(lastnameBox, EventArgs.Empty, 50);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();

        }

        private void SignUpEmailBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(emailBox, EventArgs.Empty, 100);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();

        }

        private void SignUpEmailBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This code check if '@' is the current character and the textbox does not already contain '@'
            if ((e.KeyChar == '@' && !emailBox.Text.Contains('@')) || e.KeyChar == '_' || e.KeyChar == '.')
            {
                // Allow the character to be entered
                e.Handled = false;
            }
            else if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '_' && e.KeyChar != '.')
            {
                // Ignore the input if it's not a letter, digit, or '@', '_', or '.' character
                e.Handled = true;
            }
        }

        private void SignUpPasswordBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(passwordBox, EventArgs.Empty, 20);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();
        }

        private void PasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            // This code if the checkBox(PanelVisibiliy) is checked
            // It sets the PasswordChar of the checkBox to null(\0) if it is checked, thus displaying the password as plain text
            // If not checked, it masked the password by setting the PasswordChar to '*'
            passwordBox.PasswordChar = PasswordVisibility.Checked ? '\0' : '*';
        }

        private void SignUpGenderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();

        }

        private void SignUpMobileBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(mobileBox, EventArgs.Empty, 15);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();
        }

        private void SignUpMobileBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // This code checks if the curent character entered is a digit or the '+' character
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '+')
            {
                // Allow the character to be entered into the box
                e.Handled = false;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                // Ignore the character
                e.Handled = true;
            }

        }

        private void SignUpAddressBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(addressBox, EventArgs.Empty, 100);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();
        }

        private void SignUpPostcodeBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(postcodeBox, EventArgs.Empty, 7);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();
        }

        private void SignUpCountryBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed into the text box
            TextBoxLength(countryBox, EventArgs.Empty, 100);

            // Check if all text boxes in the signup page have input and display the signup button
            CheckSignUpTextBoxes();
        }

        private void SignUpPageGoBackButton_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            foreach (Control control in signUpForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
            DisplayHomepage();
        }

        private void LogInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menuFunctions.Visible = false;
            PanelVisibility(logInPage);
        }
        
        private void SignUpButton_Click(object sender, EventArgs e)
        {
             /* This method saves a new user.
             It is used when a new user signs up and when the Administrator creates a new user.
             The method uses the 'joinCommunityLabel' to determine where it is called from
             and further redirect to the neceessary page after a successful sign up process */

            // Assign parameters to the text boxes
            string firstname = firstnameBox.Text;
            string lastname = lastnameBox.Text;
            string email = emailBox.Text;

            string enteredPassword = passwordBox.Text;
            string hashPassword = PasswordHasher.HashPassword(enteredPassword); // This process hash the password for security
            string password = hashPassword;

            string gender = genderBox.Text;
            string mobile = mobileBox.Text;
            string address = addressBox.Text;
            string postcode = postcodeBox.Text;
            string country = countryBox.Text;
            string role = "NON-CONSULTANT";

            //Add parameters to the Arraylist
            parameterList.Add(new SqlParameter("firstName", firstname));
            parameterList.Add(new SqlParameter("lastName", lastname));
            parameterList.Add(new SqlParameter("email", email));
            parameterList.Add(new SqlParameter("password", password));
            parameterList.Add(new SqlParameter("gender", gender));
            parameterList.Add(new SqlParameter("mobile", mobile));
            parameterList.Add(new SqlParameter("address", address));
            parameterList.Add(new SqlParameter("postcode", postcode));
            parameterList.Add(new SqlParameter("country", country));
            parameterList.Add(new SqlParameter("role", role));

            // Check if email already exist in the database
            if (DBConnection.getInstanceOfDBConnection().IsEmailExists(SqlQueries.VALIDATE_EMAIL, email))
            {
                MessageBox.Show("EMAIL ALREADY EXISTS! PLEASE ENTER ANOTHER EMAIL.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //Save to the Database
                DBConnection.getInstanceOfDBConnection().saveToDatabase(SqlQueries.SAVE_USER_TO_DATABASE, parameterList);

                // Display the Administrator page
                if (joinCommunityLabel.Text == "ADD A NEW USER")
                {
                    DisplayAdminPage();
                }
                else
                {
                    // After successful signup, display a complete home screen
                    DisplayHomepage();
                    vendorButton.Visible = true;
                    softwareButton.Visible = true;
                    searchText.Visible = true;
                    searchButton.Visible = true;
                    menuFunctions.Visible = true;
                    logoutMenuItem.Visible = true;
                    loginMenuItem.Visible = false;
                    signupMenuItem.Visible = false;
                    BtnShowVendorPage.Visible = false;
                    btnAddSoft.Visible = false;
                    VendorToSoftwareLinkButton.Visible = false;

                    DisplayGreeting(firstname, role);
                }
            }

        }

        //
        //
        //
        //
        // VENDOR
        //
        //
        //
        //

        private void BtnShowVendorPage_Click(object sender, EventArgs e)
        {
            // Set the visibility of the panels
            vendorDisplay.Visible = false;        // Hide vendorDisplay panel
            addVendorPanel.Visible = true;        // Show addVendorPanel
            updateVendorPanel.Visible = false;    // Hide updateVendorPanel
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            // Validate each TextBox
            List<string> emptyFields = new List<string>();

            // checks if textboxes are empty
            if (string.IsNullOrWhiteSpace(companyNameTextBox.Text))
            {
                emptyFields.Add("Company Name");
            }

            if (string.IsNullOrWhiteSpace(websiteTextBox.Text))
            {
                emptyFields.Add("Company Website");
            }

            if (string.IsNullOrWhiteSpace(establishedDateTextBox.Text))
            {
                emptyFields.Add("Established Date");
            }

            if (string.IsNullOrWhiteSpace(numemptextbox.Text))
            {
                emptyFields.Add("Number of Employees");
            }

            if (emptyFields.Count > 0)
            {
                //displays error message with list of empty textboxes
                string errorMessage = "Please enter a value in ";
                errorMessage += string.Join(", ", emptyFields);
                errorMessage += ".";
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Get values from TextBoxes
                string company_name = companyNameTextBox.Text;
                string company_website = websiteTextBox.Text;
                string company_established = establishedDateTextBox.Text;
                string no_of_employees = numemptextbox.Text;
                //attempt for adding a vendor
                DBConnection.getInstanceOfDBConnection().AddVendorToDatabase(SqlQueries.ADD_NEW_VENDOR, company_name, company_website, company_established, no_of_employees);
                MessageBox.Show("VENDOR ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear TextBoxes after successful addition
                companyNameTextBox.Text = "";
                websiteTextBox.Text = "";
                establishedDateTextBox.Text = "";
                numemptextbox.Text = "";
                //navigate to vendor display page
                vendorDisplay.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR ADDING VENDOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            List<string> emptyFields = new List<string>();
            //checks if the textboxes are empty or not
            if (string.IsNullOrWhiteSpace(comTextBox.Text))
            {
                emptyFields.Add("Company Name");
            }
            if (string.IsNullOrWhiteSpace(webTextBox.Text))
            {
                emptyFields.Add("Website");
            }
            if (string.IsNullOrWhiteSpace(estTextBox.Text))
            {
                emptyFields.Add("Established Date");
            }
            if (string.IsNullOrWhiteSpace(empTextBox.Text))
            {
                emptyFields.Add("Number Of Employees");
            }
            if (emptyFields.Count > 0)
            {
                //displays error message with list of empty textboxes
                string errorMessage = "Please enter a value in ";
                errorMessage += string.Join(", ", emptyFields);
                errorMessage += ".";
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                VENDOR.changeVendor(dbconnection, sqlQueries, Convert.ToInt16(updateRefNoTextBox.Text), comTextBox.Text, webTextBox.Text, estTextBox.Text, empTextBox.Text);

                // Display success message
                MessageBox.Show("VENDOR UPDATE SUCCESSFUL", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Show the vendor display panel
                vendorDisplay.Visible = true;
                comTextBox.Text = "";
                webTextBox.Text = "";
                estTextBox.Text = "";
                empTextBox.Text = "";

            }
            catch (Exception ex)
            {
                //displays the error message
                MessageBox.Show($"ERROR OCCURRED: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDeleteVendor_Click(object sender, EventArgs e)
        {
            //call method from vendor class to delete vendor
            VENDOR.eraseVendor(dbconnection, sqlQueries, Convert.ToInt16(updateRefNoTextBox.Text), comTextBox.Text, webTextBox.Text, estTextBox.Text, empTextBox.Text);
            MessageBox.Show("VENDOR DELETE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //clear textboxes
            companyNameTextBox.Text = "";
            websiteTextBox.Text = "";
            establishedDateTextBox.Text = "";
            numEployeesTextBox.Text = "";
            //show vendor display panel
            vendorDisplay.Visible = true;
        }


        // Switches to the vendors page and displays the vendor information panel
        private void BtnShowVendors_Click(object sender, EventArgs e)
        {
            PanelVisibility(vendorPage, vendorDisplay);
        }

        private void displayVendorInGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //makes the textbox readonly
            updateRefNoTextBox.ReadOnly = true;
            //check if valid cell is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && displayVendorInGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //selects entire row when a row is clicked
                displayVendorInGridView.CurrentRow.Selected = true;
                //retrieve details of clicked row and populate textboxes with associated info
                updateRefNoTextBox.Text = displayVendorInGridView.Rows[e.RowIndex].Cells["ref_no"].FormattedValue.ToString();
                comTextBox.Text = displayVendorInGridView.Rows[e.RowIndex].Cells["company_name"].FormattedValue.ToString();
                webTextBox.Text = displayVendorInGridView.Rows[e.RowIndex].Cells["company_website"].FormattedValue.ToString();
                estTextBox.Text = displayVendorInGridView.Rows[e.RowIndex].Cells["company_established"].FormattedValue.ToString();
                empTextBox.Text = displayVendorInGridView.Rows[e.RowIndex].Cells["no_of_employees"].FormattedValue.ToString();
                //displays the vendor update panel
                updateVendorPanel.Visible = true;
            }

        }

        // Displays the homepage
        private void BtnShowHomePage_Click(object sender, EventArgs e)
        {
            DisplayHomepage();
        }

        private void btnGoBackToAddingVendor_Click(object sender, EventArgs e)
        {

            PanelVisibility(vendorPage, vendorDisplay);
            //vendorDisplay.Visible = true;
            //addVendorPanel.Visible = false;
            //updateVendorPanel.Visible = false;
        }

        private void vendorDisplay_Paint(object sender, PaintEventArgs e)
        {
            // Use the DBConnection to load vendor data using the displayVendor SQL query
            DataSet getVendor = dbconnection.LoadUsers(sqlQueries.displayVendor());

            // Set the DataSource of the displayVendorInGridView DataGridView to the loaded data
            displayVendorInGridView.DataSource = getVendor.Tables[0];
        }


        //
        //
        //
        //
        // SOFTWARE
        //
        //
        //
        //

        private void btnDeleteSoftwareFromDatabase_Click(object sender, EventArgs e)
        {

            //delete software from database
            SOFTWARE.eraseSoftware(dbconnection, sqlQueries, Convert.ToInt32(softIDTextBox.Text), updateSoftNameTextBox.Text, updateSoftDescTextBox.Text, filePath.Text);
            MessageBox.Show("SOFTWARE DELETE SUCCESSFUL", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Clear the text boxes after successful delete
            softIDTextBox.Text = "";
            updateSoftNameTextBox.Text = "";
            updateSoftDescTextBox.Text = "";
            filePath.Text = "";

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // makes the softIDTextBox readonly
            softIDTextBox.ReadOnly = true;
            //check if valid cell is clicked
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                //makes the entire row selected if row is clicked
                dataGridView2.CurrentRow.Selected = true;
                //retrieve details of clicked row and populate textboxes with associated info
                softIDTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells["software_id"].FormattedValue.ToString();
                updateSoftNameTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells["software_name"].FormattedValue.ToString();
                updateSoftDescTextBox.Text = dataGridView2.Rows[e.RowIndex].Cells["description"].FormattedValue.ToString();
                filePath.Text = dataGridView2.Rows[e.RowIndex].Cells["document_to_attach"].FormattedValue.ToString();
                //show the software update page
                softwareUpdatePanel.Visible = true;
                filePath.Enabled = true;
                //filePath.ReadOnly = false;

            }
        }




        private void btnBacToAddingSoftware_Click(object sender, EventArgs e)
        {
            //shows the software display page 
            displaySoftwarePanel.Visible = true;
            //hide the stated panels
            addSoftwarePanel.Visible = false;
            softwareUpdatePanel.Visible = false;
        }

        // Method to handle the Paint event of the displaySoftwarePanel
        private void displaySoftwarePanel_Paint(object sender, PaintEventArgs e)
        {
            // Retrieve software data from the database using the displaySoftware SQL query
            DataSet getSoftware = dbconnection.LoadUsers(sqlQueries.displaySoftware());

            // Bind the retrieved software data to a DataGridView (dataGridView2) for display
            dataGridView2.DataSource = getSoftware.Tables[0];
        }


        private void btnBrowseFile_Click_1(object sender, EventArgs e)
        {
            //calling the pdfattach method from SOFTWARE class
            pathFile.Text = SOFTWARE.pdfAttach();
        }

        private void updateBrowse_Click(object sender, EventArgs e)
        {
            //calling the pdfattach method from SOFTWARE class
            filePath.Text = SOFTWARE.pdfAttach();
        }

        private void btnGoBackToDisplaySoftwarePanel_Click(object sender, EventArgs e)
        {
            //show software display page
            displaySoftwarePanel.Visible = true;
            //hide the stated panels
            addSoftwarePanel.Visible = false;
            softwareUpdatePanel.Visible = false;
        }

        private void btnAddSoft_Click(object sender, EventArgs e)
        {
            //hide the stated panels
            softwareUpdatePanel.Visible = false;
            displaySoftwarePanel.Visible = false;
            //show the add software page
            addSoftwarePanel.Visible = true;
        }

        //navigate to Homepage
        private void BtnGoBackToHomePage_Click(object sender, EventArgs e)
        {
            DisplayHomepage();
        }

        private void btnAddSoftwareToDatabase_Click(object sender, EventArgs e)
        {
            //validate each textbox
            List<string> emptyFields = new List<string>();

            // checks if textboxes are empty
            if (string.IsNullOrWhiteSpace(softwareNameTextBox.Text))
            {
                emptyFields.Add("Software Name");
            }

            if (string.IsNullOrWhiteSpace(desctextbox.Text))
            {
                emptyFields.Add("Software Description");
            }

            if (string.IsNullOrWhiteSpace(pathFile.Text))
            {
                emptyFields.Add("File Path");
            }

            if (emptyFields.Count == 0)
            {
                try
                {
                    // Read the PDF file into a byte array
                    byte[] pdf = File.ReadAllBytes(pathFile.Text);

                    // Get values from TextBoxes
                    string softwareName = softwareNameTextBox.Text;
                    string description = softwareDescriptionTextBox.Text;
                    string documentToAttach = pathFile.Text;

                    // If all TextBoxes are valid, add software to the database
                    DBConnection.getInstanceOfDBConnection().AddSoftwareToDatabase(SqlQueries.ADD_NEW_SOFTWARE, softwareName, description, documentToAttach);
                    MessageBox.Show("SOFTWARE ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Clear TextBoxes after successful addition
                    softwareNameTextBox.Text = "";
                    softwareDescriptionTextBox.Text = "";
                    pathFile.Text = "";

                    // Display the software panel
                    displaySoftwarePanel.Visible = true;
                }
                catch (Exception ex)
                {
                    //displays the error message
                    MessageBox.Show($"PLEASE ATTACH PDF FILE");
                }

            }
            else
            {
                //displays error message
                string errorMessage = "Please enter a value in ";
                errorMessage += string.Join(", ", emptyFields);
                errorMessage += ".";
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateSoftware_Click(object sender, EventArgs e)
        {
            // Validate each TextBox
            List<string> emptyFields = new List<string>();

            //check is software name is empty or not
            if (string.IsNullOrWhiteSpace(updateSoftNameTextBox.Text))
            {
                emptyFields.Add("Software Name");
            }
            //check if software description is empty or not
            if (string.IsNullOrWhiteSpace(updateSoftDesc.Text))
            {
                emptyFields.Add(" Description");
            }
            //show error message if field is empty
            if (emptyFields.Count > 0)
            {
                string errorMessage = "Please enter a value in ";
                errorMessage += string.Join(", ", emptyFields);
                errorMessage += ".";
                MessageBox.Show(errorMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //prevenT clearing the software id
            softIDTextBox.ReadOnly = true;
            try
            {
                //change software info in database
                SOFTWARE.changeSoftware(dbconnection, sqlQueries, Convert.ToInt32(softIDTextBox.Text), updateSoftNameTextBox.Text, updateSoftDesc.Text, filePath.Text);

                MessageBox.Show("SOFTWARE UPDATE SUCCESSFUL", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear TextBoxes and show the software panel after successful update
                softIDTextBox.Text = "";
                updateSoftNameTextBox.Text = "";
                updateSoftDesc.Text = "";
                filePath.Text = "";
                displaySoftwarePanel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PLEASE ATTACH PDF FILE");
            }
            displaySoftwarePanel.Visible = true;
        }

        //
        //
        //
        //
        // ADMINISTRATOR
        //
        //
        //
        //

        private void createUser_Click(object sender, EventArgs e)
        {
            joinCommunityLabel.Text = "ADD A NEW USER";
            goBackButtonS.Visible = false;
            backToAdminPage.Visible = true;
            logInRedirectLabel.Visible = false;
            logInLink.Visible = false;
            signUpButton.Text = "ADD USER";
            PanelVisibility(signUpPage);

        }

        private void backToAdminPage_Click(object sender, EventArgs e)
        {
            DisplayAdminPage();
        }

        private void deleteUserFromDatabase_Click(object sender, EventArgs e)
        {
            admin.DeleteUser(dbconnection, sqlQueries, Convert.ToInt16(userIDTextBox.Text));

            userIDTextBox.Text = "";
            PanelVisibility(adminDataGridViewPanel);
            
        }

        private void adminDataGridViewPanel_Paint(object sender, PaintEventArgs e)
        {
            DataSet getUser = dbconnection.LoadUsers(sqlQueries.displayUser());
            usersList.DataSource = getUser.Tables[0];
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            PanelVisibility(adminDataGridViewPanel, deleteUserPanel);
            deleteUser.Visible = false;
            updateUser.Visible = false;
            createUser.Visible = false;

        }

        private void BtnBackToAdminDashboard_Click(object sender, EventArgs e)
        {
            DisplayAdminPage();

        }

        private void BtnBackToAdminDash_Click(object sender, EventArgs e)
        {
            DisplayAdminPage();

        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            PanelVisibility(adminDataGridViewPanel, updateUserRolePanel);
            deleteUser.Visible = false;
            updateUser.Visible = false;
            createUser.Visible = false;

        }

        private void UpdateUserRoleButton_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(userIDUpdateTextBox.Text);
            string newRole = selectUserRoleBox.Text;

            DBConnection.getInstanceOfDBConnection().UpdateUserRole(SqlQueries.UPDATE_USER_ROLE, userId, newRole);

            DisplayAdminPage();
        }

        // Method to toggle the visibility of the vendor/software link panel
        private void VendorToSoftwareLinkButton_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the vendor/software link panel
            vendorToSoftwareLinkPanel.Visible = !vendorToSoftwareLinkPanel.Visible;
        }

        // Method triggered when initiating the vendor-software linking process
        private void InitiateVenSofLinkButton_Click(object sender, EventArgs e)
        {
            // Retrieve the vendor reference number and software ID from TextBoxes
            int ref_no = int.Parse(companyRefTextBox.Text);
            int software_id = int.Parse(softwareIdTextBox.Text);

            // Call the method to link the vendor to the software in the database
            DBConnection.getInstanceOfDBConnection().LinkVendorToSoftware(SqlQueries.LINK_QUERY, ref_no, software_id);
        }

        private void comTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(comTextBox, EventArgs.Empty, 50);
        }

        private void webTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(webTextBox, EventArgs.Empty, 50);
        }

        private void empTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void estTextBox_Validating(object sender, CancelEventArgs e)
        {
            // Cast the sender to TextBox
            TextBox estTextBox = (TextBox)sender;

            // Validate the entered text using the ValidDate method
            if (!VENDOR.ValidDate(estTextBox.Text))
            {
                // Validation failed: prevent focus change and display an error message
                e.Cancel = true;
                errorProvider.SetError(estTextBox, "Please enter a valid date (YYYY-MM-DD)");
            }
            else
            {
                // Validation passed: allow focus change and clear the error message
                e.Cancel = false;
                errorProvider.SetError(estTextBox, null);
            }
        }

        private void companyNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(companyNameTextBox, EventArgs.Empty, 50);
        }

        private void websiteTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(websiteTextBox, EventArgs.Empty, 50);
        }

        private void numEployeesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow integers and and '-'
            TextBox numEployeesTextBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-' || numEployeesTextBox.Text.Contains('-') || numEployeesTextBox.SelectionStart == 0))
            {
                //hanle the event
                e.Handled = true;

            }
        }

        private void establishedDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox establishedDate = (TextBox)sender;
            //validate entred text
            if (!VENDOR.ValidDate(establishedDate.Text))
            {
                //cancel event
                e.Cancel = true;
                errorProvider.SetError(establishedDate, "Please enter a valid date (YYYY-MM-DD)");
            }
            else
            {
                //Allow focus change
                e.Cancel = false;
                //clear error message
                errorProvider.SetError(establishedDate, null);
            }
        }

        private void softIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateSoftNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(updateSoftNameTextBox, EventArgs.Empty, 20);
        }

        private void updateSoftDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limit the length of the text to 200 characters
            TextBoxLength(updateSoftDescTextBox, EventArgs.Empty, 200);

            // Allow only letters, commas, apostrophes, full stops, and backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '\'' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Prevent the input of disallowed characters
                e.Handled = true;
            }
        }

        private void filePath_Click(object sender, EventArgs e)
        {
            // Get the file path from the 'label' control
            string documentPath = filePath.Text;

            // Check if the file path is not empty or null
            if (!string.IsNullOrEmpty(documentPath))
            {
                try
                {
                    // Attempt to start a process to open the file
                    Process.Start(documentPath);
                }
                catch (Exception ex)
                {
                    // Display an error message if there's an exception
                    MessageBox.Show($"ERROR OPENING THE FILE: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void softwareNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Set a maximum lentgth for the number of character allowed in the textbox
            TextBoxLength(softwareNameTextBox, EventArgs.Empty, 20);
        }

      

        private void desctextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limit the length of the text to 200 characters
            TextBoxLength(softwareDescriptionTextBox, EventArgs.Empty, 200);

            // Allow only letters, commas, apostrophes, full stops, and backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '\'' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Prevent the input of disallowed characters
                e.Handled = true;
            }
        }

        private void updateSoftDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Limit the length of the text to 200 characters
            TextBoxLength(updateSoftDescTextBox, EventArgs.Empty, 200);

            // Allow only letters, commas, apostrophes, full stops, and backspace key
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '\'' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                // Prevent the input of disallowed characters
                e.Handled = true;
            }
        }
        public static void names()
        {
            // Array of 16 names
            string[] names = {
            "Alice", "Bob", "Charlie", "David",
            "Eva", "Frank", "Grace", "Henry",
            "Ivy", "Jack", "Katie", "Liam",
            "Mia", "Noah", "Olivia", "Penny",

        // Loop through the array and print each name
        foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        
    }

         
        

        //
        //
        //
        // 
        //
        //
        //
        //
    }
}