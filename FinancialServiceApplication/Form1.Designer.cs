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
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sIGNUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.label7 = new System.Windows.Forms.Label();
            this.goBackButton = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signUpPage = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.signUpForm = new System.Windows.Forms.Panel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.goBackButtonS = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.logInLink = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.vendorPage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.softwarePage = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.HeaderSearch.SuspendLayout();
            this.menuFunctions.SuspendLayout();
            this.homePage.SuspendLayout();
            this.footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logInPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.logInForm.SuspendLayout();
            this.signUpPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.signUpForm.SuspendLayout();
            this.vendorPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.header, "header");
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.Controls.Add(this.HeaderSearch);
            this.header.Controls.Add(this.menuFunctions);
            this.header.Name = "header";
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.searchText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.searchButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuFunctions
            // 
            this.menuFunctions.BackColor = System.Drawing.Color.White;
            this.menuFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.sIGNUPToolStripMenuItem,
            this.aBOUTUSToolStripMenuItem,
            this.lOGINToolStripMenuItem});
            resources.ApplyResources(this.menuFunctions, "menuFunctions");
            this.menuFunctions.Name = "menuFunctions";
            // 
            // hOMEToolStripMenuItem
            // 
            resources.ApplyResources(this.hOMEToolStripMenuItem, "hOMEToolStripMenuItem");
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // sIGNUPToolStripMenuItem
            // 
            this.sIGNUPToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sIGNUPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.sIGNUPToolStripMenuItem, "sIGNUPToolStripMenuItem");
            this.sIGNUPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sIGNUPToolStripMenuItem.Name = "sIGNUPToolStripMenuItem";
            this.sIGNUPToolStripMenuItem.Click += new System.EventHandler(this.sIGNUPToolStripMenuItem_Click);
            // 
            // aBOUTUSToolStripMenuItem
            // 
            this.aBOUTUSToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.aBOUTUSToolStripMenuItem, "aBOUTUSToolStripMenuItem");
            this.aBOUTUSToolStripMenuItem.Name = "aBOUTUSToolStripMenuItem";
            this.aBOUTUSToolStripMenuItem.Click += new System.EventHandler(this.aBOUTUSToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lOGINToolStripMenuItem.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lOGINToolStripMenuItem, "lOGINToolStripMenuItem");
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
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
            this.homePage.Paint += new System.Windows.Forms.PaintEventHandler(this.homePage_Paint);
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
            this.softwareButton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // vendorButton
            // 
            resources.ApplyResources(this.vendorButton, "vendorButton");
            this.vendorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vendorButton.ForeColor = System.Drawing.Color.White;
            this.vendorButton.Name = "vendorButton";
            this.vendorButton.UseVisualStyleBackColor = false;
            this.vendorButton.Click += new System.EventHandler(this.vendorButton_Click);
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
            this.SiteDescriptionText.Click += new System.EventHandler(this.SiteDescriptionText_Click);
            // 
            // aboutUs
            // 
            resources.ApplyResources(this.aboutUs, "aboutUs");
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Paint += new System.Windows.Forms.PaintEventHandler(this.aboutUs_Paint);
            // 
            // logInPage
            // 
            resources.ApplyResources(this.logInPage, "logInPage");
            this.logInPage.BackColor = System.Drawing.Color.White;
            this.logInPage.Controls.Add(this.pictureBox2);
            this.logInPage.Controls.Add(this.CitiSoft3);
            this.logInPage.Controls.Add(this.logInForm);
            this.logInPage.Name = "logInPage";
            this.logInPage.Paint += new System.Windows.Forms.PaintEventHandler(this.logInPage_Paint);
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
            this.logInForm.Controls.Add(this.label7);
            this.logInForm.Controls.Add(this.goBackButton);
            this.logInForm.Controls.Add(this.logInButton);
            this.logInForm.Controls.Add(this.textBox2);
            this.logInForm.Controls.Add(this.textBox1);
            this.logInForm.Controls.Add(this.signUpLink);
            this.logInForm.Controls.Add(this.label6);
            this.logInForm.Controls.Add(this.linkLabel1);
            this.logInForm.Controls.Add(this.label5);
            this.logInForm.Controls.Add(this.label2);
            this.logInForm.Name = "logInForm";
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
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.logInButton, "logInButton");
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Name = "logInButton";
            this.logInButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // signUpLink
            // 
            resources.ApplyResources(this.signUpLink, "signUpLink");
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.TabStop = true;
            this.signUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLink_LinkClicked);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // signUpPage
            // 
            resources.ApplyResources(this.signUpPage, "signUpPage");
            this.signUpPage.Controls.Add(this.label4);
            this.signUpPage.Controls.Add(this.pictureBox3);
            this.signUpPage.Controls.Add(this.signUpForm);
            this.signUpPage.Name = "signUpPage";
            this.signUpPage.Paint += new System.Windows.Forms.PaintEventHandler(this.signUpPage_Paint);
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
            this.signUpForm.Controls.Add(this.addressLabel);
            this.signUpForm.Controls.Add(this.contactLabel);
            this.signUpForm.Controls.Add(this.textBox8);
            this.signUpForm.Controls.Add(this.textBox7);
            this.signUpForm.Controls.Add(this.comboBox1);
            this.signUpForm.Controls.Add(this.genderLabel);
            this.signUpForm.Controls.Add(this.button2);
            this.signUpForm.Controls.Add(this.passwordLabel);
            this.signUpForm.Controls.Add(this.emailLabel);
            this.signUpForm.Controls.Add(this.textBox6);
            this.signUpForm.Controls.Add(this.textBox5);
            this.signUpForm.Controls.Add(this.label8);
            this.signUpForm.Controls.Add(this.goBackButtonS);
            this.signUpForm.Controls.Add(this.textBox3);
            this.signUpForm.Controls.Add(this.textBox4);
            this.signUpForm.Controls.Add(this.logInLink);
            this.signUpForm.Controls.Add(this.label9);
            this.signUpForm.Controls.Add(this.lastnameLabel);
            this.signUpForm.Controls.Add(this.firstnameLabel);
            this.signUpForm.Name = "signUpForm";
            // 
            // addressLabel
            // 
            resources.ApplyResources(this.addressLabel, "addressLabel");
            this.addressLabel.Name = "addressLabel";
            // 
            // contactLabel
            // 
            resources.ApplyResources(this.contactLabel, "contactLabel");
            this.contactLabel.Name = "contactLabel";
            // 
            // textBox8
            // 
            resources.ApplyResources(this.textBox8, "textBox8");
            this.textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(this.textBox7, "textBox7");
            this.textBox7.Name = "textBox7";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // genderLabel
            // 
            resources.ApplyResources(this.genderLabel, "genderLabel");
            this.genderLabel.Name = "genderLabel";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
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
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
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
            this.goBackButtonS.Click += new System.EventHandler(this.goBackButtonS_Click);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // logInLink
            // 
            resources.ApplyResources(this.logInLink, "logInLink");
            this.logInLink.Name = "logInLink";
            this.logInLink.TabStop = true;
            this.logInLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logInLink_LinkClicked);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
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
            // application
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.header);
            this.Controls.Add(this.signUpPage);
            this.Controls.Add(this.softwarePage);
            this.Controls.Add(this.logInPage);
            this.Controls.Add(this.homePage);
            this.Controls.Add(this.aboutUs);
            this.Controls.Add(this.vendorPage);
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
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sIGNUPToolStripMenuItem;
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
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private LinkLabel signUpLink;
        private Label label6;
        private LinkLabel linkLabel1;
        private Label label5;
        private Button goBackButton;
        private Button logInButton;
        private PictureBox pictureBox2;
        private Label label7;
        private Panel signUpForm;
        private Label label8;
        private Button goBackButtonS;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox4;
        private LinkLabel logInLink;
        private Label label9;
        private Label lastnameLabel;
        private Label firstnameLabel;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label passwordLabel;
        private Label emailLabel;
        private Label genderLabel;
        private ComboBox comboBox1;
        private Label addressLabel;
        private Label contactLabel;
        private TextBox textBox8;
        private TextBox textBox7;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label11;
        private Panel footer;
    }
}

