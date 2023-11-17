using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Windows.Forms;

namespace FinancialServiceApplication
{
    internal class SOFTWARE

    {
        public static void changeSoftware(DBConnection dBConnection, SqlQueries query, int software_id, string software_name, string description, string document_to_attach)
        {
              dBConnection.AddSoftwareToDatabase(query.updateSoftware(software_id), software_name, description, document_to_attach);
                 
        }
        
        public static void eraseSoftware(DBConnection dBConnection, SqlQueries query, int software_id)
        {
            dBConnection.AddSoftwareToDatabase(query.deleteSoftware(software_id));
            //MessageBox.Show("DELETE SUCCESSFUL");
        }
       
        private static bool SoftwareIdExists(DBConnection dBConnection, SqlQueries query, int software_id, string software_name, string description, string document_to_attach)
        {
            return false;
        }
        public static string pdfAttach()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files |*.pdf";
                openFileDialog.Title = "SELECT PDF TO ATTACH";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    String filePath = openFileDialog.FileName;
                    return filePath;
                }
                else
                {
                    return null;
                }
            }
        }

        





            /* public static void changeSoftware(DBConnection dBConnection, SqlQueries query, int software_id, string software_name, string description, string document_to_attach)
             {
                 dBConnection.AddSoftwareToDatabase(query.updateVendor(software_id), software_name, description, document_to_attach);
                 //MessageBox.Show("SUCCESS");

             }

             private void updateBtn_Click(object sender, EventArgs e)
             {
                 VENDOR.changeVendor(dbconnection, sqlQueries, Convert.ToInt16(updateRefNoTextBox.Text), comTextBox.Text, webTextBox.Text, estTextBox.Text, empTextBox.Text);




             }*/
            /* public static string pdfAttach()
             {
                 using (OpenFileDialog openFileDialog = new OpenFileDialog())
                 {
                     openFileDialog.Filter = "PDF Files |*.pdf";
                     openFileDialog.Title = "SELECT PDF TO ATTACH";
                     if (openFileDialog.ShowDialog() == DialogResult.OK)
                     {
                         String filePath = openFileDialog.FileName;
                         return filePath;
                     }
                     else
                     {
                         return null;
                     }
                 }
             }*/
        }
    }

