using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialServiceApplication
{
    public partial class application : Form
    {
        List<Panel> listPanel = new List<Panel>();
        public application()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(menuFunctions);
            listPanel.Add(homePage);
            listPanel.Add(aboutUs);
            listPanel.Add(logInPage);
            listPanel.Add(signUpPage);
            listPanel.Add(header);
            listPanel.Add(footer);
            listPanel.Add(vendorPage);
            listPanel.Add(softwarePage);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = false;
            PanelVisibility(logInPage);
        }

        private void aBOUTUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelVisibility(aboutUs);
        }

        private void aboutUs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelVisibility(header, footer, homePage);
        }

        private void homePage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void sIGNUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = false;
            PanelVisibility(signUpPage);
        }

        private void logInPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelVisibility(params Control[] panelsToDisplay)
        {
            foreach (Control panel in listPanel)
            {
                panel.Visible = panelsToDisplay.Contains(panel);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            PanelVisibility(header, footer, softwarePage);
        }

        private void vendorButton_Click(object sender, EventArgs e)
        {
            PanelVisibility(header, footer, vendorPage);
        }

        private void SiteDescriptionText_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = true;
            PanelVisibility(header, footer, homePage);
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelVisibility(signUpPage);
        }

        private void signUpPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logInLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menuFunctions.Visible = false;
            PanelVisibility(logInPage);
        }

        private void goBackButtonS_Click(object sender, EventArgs e)
        {
            menuFunctions.Visible = true;
            PanelVisibility(header, footer, homePage);
        }

        private void footer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}