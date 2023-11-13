using System.Windows.Forms;

namespace FinancialServiceApplication
{
    partial class application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(application));
            this.header = new System.Windows.Forms.Panel();
            this.HeaderSearch = new System.Windows.Forms.Panel();
            this.searchText = new System.Windows.Forms.TextBox();
            this.CitiSoft = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuFunctions = new System.Windows.Forms.MenuStrip();
            this.HomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePage = new System.Windows.Forms.Panel();
            this.footer = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.softwareButton = new System.Windows.Forms.Button();
            this.vendorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SiteDescriptionText = new System.Windows.Forms.Label();
            this.aboutUs = new System.Windows.Forms.Panel();
            this.logInPage = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CitiSoft3 = new System.Windows.Forms.Label();
            this.logInForm = new System.Windows.Forms.Panel();
            this.LogInPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.logInPasswordBox = new System.Windows.Forms.TextBox();
            this.logInEmailBox = new System.Windows.Forms.TextBox();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.signUpRedirectLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.passwordLogInLabel = new System.Windows.Forms.Label();
            this.emailLogInLabel = new System.Windows.Forms.Label();
            this.signUpPage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.signUpForm = new System.Windows.Forms.Panel();
            this.PasswordVisibility = new System.Windows.Forms.CheckBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postcodeLabel = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.postcodeBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.mobileBox = new System.Windows.Forms.TextBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goBackButtonS = new System.Windows.Forms.Button();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.logInLink = new System.Windows.Forms.LinkLabel();
            this.logInRedirectLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.vendorPage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.softwarePage = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.HeaderSearch.SuspendLayout();
            this.menuFunctions.SuspendLayout();
            this.homePage.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.aboutUs.SuspendLayout();
            this.logInPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logInForm.SuspendLayout();
            this.signUpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.signUpForm.SuspendLayout();
            this.vendorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.header, "header");
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.Controls.Add(this.greetingLabel);
            this.header.Controls.Add(this.HeaderSearch);
            this.header.Controls.Add(this.menuFunctions);
            this.header.Name = "header";
            // 
            // HeaderSearch
            // 
            resources.ApplyResources(this.HeaderSearch, "HeaderSearch");
            this.HeaderSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.HeaderSearch.Controls.Add(this.searchText);
            this.HeaderSearch.Controls.Add(this.CitiSoft);
            this.HeaderSearch.Controls.Add(this.searchButton);
            this.HeaderSearch.Name = "HeaderSearch";
            // 
            // searchText
            // 
            resources.ApplyResources(this.searchText, "searchText");
            this.searchText.BackColor = System.Drawing.SystemColors.Window;
            this.searchText.ForeColor = System.Drawing.Color.Black;
            this.searchText.HideSelection = false;
            this.searchText.Name = "searchText";
            // 
            // CitiSoft
            // 
            resources.ApplyResources(this.CitiSoft, "CitiSoft");
            this.CitiSoft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CitiSoft.ForeColor = System.Drawing.Color.White;
            this.CitiSoft.Name = "CitiSoft";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // menuFunctions
            // 
            this.menuFunctions.BackColor = System.Drawing.Color.White;
            this.menuFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeMenuItem,
            this.logoutMenuItem,
            this.signupMenuItem,
            this.aboutUsMenuItem,
            this.loginMenuItem});
            resources.ApplyResources(this.menuFunctions, "menuFunctions");
            this.menuFunctions.Name = "menuFunctions";
            // 
            // HomeMenuItem
            // 
            resources.ApplyResources(this.HomeMenuItem, "HomeMenuItem");
            this.HomeMenuItem.Name = "HomeMenuItem";
            this.HomeMenuItem.Click += new System.EventHandler(this.HomeMenuItem_Click);
            // 
            // logoutMenuItem
            // 
            this.logoutMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.logoutMenuItem, "logoutMenuItem");
            this.logoutMenuItem.Name = "logoutMenuItem";
            this.logoutMenuItem.Click += new System.EventHandler(this.LogOutMenuItem_Click);
            // 
            // signupMenuItem
            // 
            this.signupMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.signupMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.signupMenuItem, "signupMenuItem");
            this.signupMenuItem.ForeColor = System.Drawing.Color.White;
            this.signupMenuItem.Name = "signupMenuItem";
            this.signupMenuItem.Click += new System.EventHandler(this.SignUpMenuItem_Click);
            // 
            // aboutUsMenuItem
            // 
            this.aboutUsMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.aboutUsMenuItem, "aboutUsMenuItem");
            this.aboutUsMenuItem.Name = "aboutUsMenuItem";
            this.aboutUsMenuItem.Click += new System.EventHandler(this.AboutUsMenuItem_Click);
            // 
            // loginMenuItem
            // 
            this.loginMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.loginMenuItem.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.loginMenuItem, "loginMenuItem");
            this.loginMenuItem.Name = "loginMenuItem";
            this.loginMenuItem.Click += new System.EventHandler(this.LogInMenuItem_Click);
            // 
            // homePage
            // 
            resources.ApplyResources(this.homePage, "homePage");
            this.homePage.BackColor = System.Drawing.Color.White;
            this.homePage.Controls.Add(this.footer);
            this.homePage.Controls.Add(this.softwareButton);
            this.homePage.Controls.Add(this.vendorButton);
            this.homePage.Controls.Add(this.label1);
            this.homePage.Controls.Add(this.pictureBox1);
            this.homePage.Controls.Add(this.SiteDescriptionText);
            this.homePage.Name = "homePage";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.footer.Controls.Add(this.label11);
            resources.ApplyResources(this.footer, "footer");
            this.footer.Name = "footer";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Name = "label11";
            // 
            // softwareButton
            // 
            resources.ApplyResources(this.softwareButton, "softwareButton");
            this.softwareButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.softwareButton.ForeColor = System.Drawing.Color.White;
            this.softwareButton.Name = "softwareButton";
            this.softwareButton.UseVisualStyleBackColor = false;
            this.softwareButton.Click += new System.EventHandler(this.SoftwareButton_Click);
            // 
            // vendorButton
            // 
            resources.ApplyResources(this.vendorButton, "vendorButton");
            this.vendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vendorButton.ForeColor = System.Drawing.Color.White;
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.UseVisualStyleBackColor = false;
            this.vendorButton.Click += new System.EventHandler(this.CompanyButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // SiteDescriptionText
            // 
            resources.ApplyResources(this.SiteDescriptionText, "SiteDescriptionText");
            this.SiteDescriptionText.Name = "SiteDescriptionText";
            // 
            // aboutUs
            // 
            resources.ApplyResources(this.aboutUs, "aboutUs");
            this.aboutUs.Controls.Add(this.label6);
            this.aboutUs.Controls.Add(this.pictureBox4);
            this.aboutUs.Controls.Add(this.label5);
            this.aboutUs.Controls.Add(this.label2);
            this.aboutUs.Name = "aboutUs";
            // 
            // logInPage
            // 
            resources.ApplyResources(this.logInPage, "logInPage");
            this.logInPage.BackColor = System.Drawing.Color.White;
            this.logInPage.Controls.Add(this.pictureBox2);
            this.logInPage.Controls.Add(this.CitiSoft3);
            this.logInPage.Controls.Add(this.logInForm);
            this.logInPage.Name = "logInPage";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // CitiSoft3
            // 
            resources.ApplyResources(this.CitiSoft3, "CitiSoft3");
            this.CitiSoft3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CitiSoft3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CitiSoft3.Name = "CitiSoft3";
            // 
            // logInForm
            // 
            resources.ApplyResources(this.logInForm, "logInForm");
            this.logInForm.BackColor = System.Drawing.SystemColors.Menu;
            this.logInForm.Controls.Add(this.LogInPasswordVisibility);
            this.logInForm.Controls.Add(this.label7);
            this.logInForm.Controls.Add(this.goBackButton);
            this.logInForm.Controls.Add(this.logInButton);
            this.logInForm.Controls.Add(this.logInPasswordBox);
            this.logInForm.Controls.Add(this.logInEmailBox);
            this.logInForm.Controls.Add(this.signUpLink);
            this.logInForm.Controls.Add(this.signUpRedirectLabel);
            this.logInForm.Controls.Add(this.forgotPasswordLinkLabel);
            this.logInForm.Controls.Add(this.passwordLogInLabel);
            this.logInForm.Controls.Add(this.emailLogInLabel);
            this.logInForm.Name = "logInForm";
            // 
            // LogInPasswordVisibility
            // 
            resources.ApplyResources(this.LogInPasswordVisibility, "LogInPasswordVisibility");
            this.LogInPasswordVisibility.Name = "LogInPasswordVisibility";
            this.LogInPasswordVisibility.UseVisualStyleBackColor = true;
            this.LogInPasswordVisibility.CheckedChanged += new System.EventHandler(this.LogInPasswordVisibility_CheckedChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // goBackButton
            // 
            this.goBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.goBackButton, "goBackButton");
            this.goBackButton.ForeColor = System.Drawing.Color.White;
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.UseVisualStyleBackColor = false;
            this.goBackButton.Click += new System.EventHandler(this.LogInPageGoBackButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // logInPasswordBox
            // 
            resources.ApplyResources(this.logInPasswordBox, "logInPasswordBox");
            this.logInPasswordBox.Name = "logInPasswordBox";
            this.logInPasswordBox.TextChanged += new System.EventHandler(this.LogInPasswordBox_TextChanged);
            // 
            // logInEmailBox
            // 
            resources.ApplyResources(this.logInEmailBox, "logInEmailBox");
            this.logInEmailBox.Name = "logInEmailBox";
            this.logInEmailBox.TextChanged += new System.EventHandler(this.LogInEmailBox_TextChanged);
            // 
            // signUpLink
            // 
            resources.ApplyResources(this.signUpLink, "signUpLink");
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.TabStop = true;
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // signUpRedirectLabel
            // 
            resources.ApplyResources(this.signUpRedirectLabel, "signUpRedirectLabel");
            this.signUpRedirectLabel.Name = "signUpRedirectLabel";
            // 
            // forgotPasswordLinkLabel
            // 
            resources.ApplyResources(this.forgotPasswordLinkLabel, "forgotPasswordLinkLabel");
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.TabStop = true;
            // 
            // passwordLogInLabel
            // 
            resources.ApplyResources(this.passwordLogInLabel, "passwordLogInLabel");
            this.passwordLogInLabel.Name = "passwordLogInLabel";
            // 
            // emailLogInLabel
            // 
            resources.ApplyResources(this.emailLogInLabel, "emailLogInLabel");
            this.emailLogInLabel.Name = "emailLogInLabel";
            // 
            // signUpPage
            // 
            resources.ApplyResources(this.signUpPage, "signUpPage");
            this.signUpPage.Controls.Add(this.label4);
            this.signUpPage.Controls.Add(this.pictureBox3);
            this.signUpPage.Controls.Add(this.signUpForm);
            this.signUpPage.Name = "signUpPage";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Name = "label4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // signUpForm
            // 
            resources.ApplyResources(this.signUpForm, "signUpForm");
            this.signUpForm.BackColor = System.Drawing.Color.SeaShell;
            this.signUpForm.Controls.Add(this.PasswordVisibility);
            this.signUpForm.Controls.Add(this.countryLabel);
            this.signUpForm.Controls.Add(this.postcodeLabel);
            this.signUpForm.Controls.Add(this.countryBox);
            this.signUpForm.Controls.Add(this.postcodeBox);
            this.signUpForm.Controls.Add(this.addressLabel);
            this.signUpForm.Controls.Add(this.mobileLabel);
            this.signUpForm.Controls.Add(this.addressBox);
            this.signUpForm.Controls.Add(this.mobileBox);
            this.signUpForm.Controls.Add(this.genderBox);
            this.signUpForm.Controls.Add(this.genderLabel);
            this.signUpForm.Controls.Add(this.signUpButton);
            this.signUpForm.Controls.Add(this.passwordLabel);
            this.signUpForm.Controls.Add(this.emailLabel);
            this.signUpForm.Controls.Add(this.passwordBox);
            this.signUpForm.Controls.Add(this.emailBox);
            this.signUpForm.Controls.Add(this.label8);
            this.signUpForm.Controls.Add(this.goBackButtonS);
            this.signUpForm.Controls.Add(this.lastnameBox);
            this.signUpForm.Controls.Add(this.firstnameBox);
            this.signUpForm.Controls.Add(this.logInLink);
            this.signUpForm.Controls.Add(this.logInRedirectLabel);
            this.signUpForm.Controls.Add(this.lastnameLabel);
            this.signUpForm.Controls.Add(this.firstnameLabel);
            this.signUpForm.Name = "signUpForm";
            // 
            // PasswordVisibility
            // 
            resources.ApplyResources(this.PasswordVisibility, "PasswordVisibility");
            this.PasswordVisibility.Name = "PasswordVisibility";
            this.PasswordVisibility.UseVisualStyleBackColor = true;
            this.PasswordVisibility.CheckedChanged += new System.EventHandler(this.PasswordVisibility_CheckedChanged);
            // 
            // countryLabel
            // 
            resources.ApplyResources(this.countryLabel, "countryLabel");
            this.countryLabel.Name = "countryLabel";
            // 
            // postcodeLabel
            // 
            resources.ApplyResources(this.postcodeLabel, "postcodeLabel");
            this.postcodeLabel.Name = "postcodeLabel";
            // 
            // countryBox
            // 
            resources.ApplyResources(this.countryBox, "countryBox");
            this.countryBox.Name = "countryBox";
            this.countryBox.TextChanged += new System.EventHandler(this.SignUpCountryBox_TextChanged);
            // 
            // postcodeBox
            // 
            resources.ApplyResources(this.postcodeBox, "postcodeBox");
            this.postcodeBox.Name = "postcodeBox";
            this.postcodeBox.TextChanged += new System.EventHandler(this.SignUpPostcodeBox_TextChanged);
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // mobileLabel
            // 
            resources.ApplyResources(this.mobileLabel, "mobileLabel");
            this.mobileLabel.Name = "mobileLabel";
            // 
            // addressBox
            // 
            resources.ApplyResources(this.addressBox, "addressBox");
            this.addressBox.Name = "addressBox";
            this.addressBox.TextChanged += new System.EventHandler(this.SignUpAddressBox_TextChanged);
            // 
            // mobileBox
            // 
            resources.ApplyResources(this.mobileBox, "mobileBox");
            this.mobileBox.Name = "mobileBox";
            this.mobileBox.TextChanged += new System.EventHandler(this.SignUpMobileBox_TextChanged);
            this.mobileBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpMobileBox_KeyPress);
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.genderBox, "genderBox");
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            resources.GetString("genderBox.Items"),
            resources.GetString("genderBox.Items1")});
            this.genderBox.Name = "genderBox";
            this.genderBox.SelectedIndexChanged += new System.EventHandler(this.SignUpGenderBox_SelectedIndexChanged);
            // 
            // genderLabel
            // 
            resources.ApplyResources(this.genderLabel, "genderLabel");
            this.genderLabel.Name = "genderLabel";
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.signUpButton, "signUpButton");
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.Name = "emailLabel";
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.TextChanged += new System.EventHandler(this.SignUpPasswordBox_TextChanged);
            // 
            // emailBox
            // 
            resources.ApplyResources(this.emailBox, "emailBox");
            this.emailBox.Name = "emailBox";
            this.emailBox.TextChanged += new System.EventHandler(this.SignUpEmailBox_TextChanged);
            this.emailBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignUpEmailBox_KeyPress);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // goBackButtonS
            // 
            this.goBackButtonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.goBackButtonS, "goBackButtonS");
            this.goBackButtonS.ForeColor = System.Drawing.Color.White;
            this.goBackButtonS.Name = "goBackButtonS";
            this.goBackButtonS.UseVisualStyleBackColor = false;
            this.goBackButtonS.Click += new System.EventHandler(this.SignUpPageGoBackButton_Click);
            // 
            // lastnameBox
            // 
            resources.ApplyResources(this.lastnameBox, "lastnameBox");
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.TextChanged += new System.EventHandler(this.SignUpLastnameBox_TextChanged);
            // 
            // firstnameBox
            // 
            resources.ApplyResources(this.firstnameBox, "firstnameBox");
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.TextChanged += new System.EventHandler(this.SignUpFirstnameBox_TextChanged);
            // 
            // logInLink
            // 
            resources.ApplyResources(this.logInLink, "logInLink");
            this.logInLink.Name = "logInLink";
            this.logInLink.TabStop = true;
            this.logInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogInLink_LinkClicked);
            // 
            // logInRedirectLabel
            // 
            resources.ApplyResources(this.logInRedirectLabel, "logInRedirectLabel");
            this.logInRedirectLabel.Name = "logInRedirectLabel";
            // 
            // lastnameLabel
            // 
            resources.ApplyResources(this.lastnameLabel, "lastnameLabel");
            this.lastnameLabel.Name = "lastnameLabel";
            // 
            // firstnameLabel
            // 
            resources.ApplyResources(this.firstnameLabel, "firstnameLabel");
            this.firstnameLabel.Name = "firstnameLabel";
            // 
            // vendorPage
            // 
            resources.ApplyResources(this.vendorPage, "vendorPage");
            this.vendorPage.BackColor = System.Drawing.Color.Black;
            this.vendorPage.Controls.Add(this.label3);
            this.vendorPage.Name = "vendorPage";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // softwarePage
            // 
            resources.ApplyResources(this.softwarePage, "softwarePage");
            this.softwarePage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.softwarePage.Name = "softwarePage";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // greetingLabel
            // 
            resources.ApplyResources(this.greetingLabel, "greetingLabel");
            this.greetingLabel.Name = "greetingLabel";
            // 
            // application
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.aboutUs);
            this.Controls.Add(this.vendorPage);
            this.Controls.Add(this.signUpPage);
            this.Controls.Add(this.softwarePage);
            this.Controls.Add(this.logInPage);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Name = "application";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.HeaderSearch.ResumeLayout(false);
            this.HeaderSearch.PerformLayout();
            this.menuFunctions.ResumeLayout(false);
            this.menuFunctions.PerformLayout();
            this.homePage.ResumeLayout(false);
            this.homePage.PerformLayout();
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.aboutUs.ResumeLayout(false);
            this.aboutUs.PerformLayout();
            this.logInPage.ResumeLayout(false);
            this.logInPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.logInForm.ResumeLayout(false);
            this.logInForm.PerformLayout();
            this.signUpPage.ResumeLayout(false);
            this.signUpPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.signUpForm.ResumeLayout(false);
            this.signUpForm.PerformLayout();
            this.vendorPage.ResumeLayout(false);
            this.vendorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel HeaderSearch;
        private System.Windows.Forms.Label CitiSoft;
        private System.Windows.Forms.MenuStrip menuFunctions;
        private System.Windows.Forms.ToolStripMenuItem HomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signupMenuItem;
        private System.Windows.Forms.Panel homePage;
        private Panel aboutUs;
        private Label SiteDescriptionText;
        private Panel logInPage;
        private Panel signUpPage;
        private PictureBox pictureBox1;
        private Label label1;
        private Button softwareButton;
        private Button vendorButton;
        private Panel vendorPage;
        private Label label3;
        private Panel softwarePage;
        private Label CitiSoft3;
        private Panel logInForm;
        private Label emailLogInLabel;
        private TextBox logInPasswordBox;
        private TextBox logInEmailBox;
        private LinkLabel signUpLink;
        private Label signUpRedirectLabel;
        private LinkLabel forgotPasswordLinkLabel;
        private Label passwordLogInLabel;
        private Button goBackButton;
        private Button logInButton;
        private PictureBox pictureBox2;
        private Label label7;
        private Panel signUpForm;
        private Label label8;
        private Button goBackButtonS;
        private Button signUpButton;
        private TextBox lastnameBox;
        private TextBox firstnameBox;
        private LinkLabel logInLink;
        private Label logInRedirectLabel;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private TextBox passwordBox;
        private TextBox emailBox;
        private Label passwordLabel;
        private Label emailLabel;
        private Label genderLabel;
        private ComboBox genderBox;
        private Label addressLabel;
        private Label mobileLabel;
        private TextBox addressBox;
        private TextBox mobileBox;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label11;
        private Panel footer;
        private Label countryLabel;
        private Label postcodeLabel;
        private TextBox countryBox;
        private TextBox postcodeBox;
        private ToolStripMenuItem logoutMenuItem;
        private CheckBox PasswordVisibility;
        private CheckBox LogInPasswordVisibility;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label greetingLabel;
    }
}

