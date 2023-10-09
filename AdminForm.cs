using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Xml;

namespace MasterFile
{
    public partial class AdminForm : Form
    {
        private Dictionary<int, string> MasterFile;
        public AdminForm(string id, string name, Dictionary<int, string> masterFile)
        {
            InitializeComponent();

            MasterFile = masterFile; // 2 forms share same dictionary.

            PopulateSelectedData(id, name);
        }

        // Events
        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Create
            if (e.KeyCode == Keys.C && e.Alt)
            {
                //Create();
            }
            // update
            if (e.KeyCode == Keys.U && e.Alt)
            {
                Update();
            }

            // remove
            else if (e.KeyCode == Keys.D && e.Alt)
            {
                int currentId = int.Parse(txtStaffID.Text);
                MasterFile.Remove(currentId);
            }

            // save
            else if (e.KeyCode == Keys.S && e.Alt)
            {
                SaveToCSV();
            }

            // close
            else if (e.KeyCode == Keys.L && e.Alt)
            {
                CloseAdminForm();
            }
        }

        //Q5.1.Create the Admin GUI with the following settings: GUI is model, all Control Box features are removed/hidden,
        //then add two text boxes.The text box for the Staff ID should be read-only for Add, Update and Delete purposes.


        //Q5.2.Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateSelectedData(string id, string name)
        {
            txtStaffID.Text = id;
            txtStaffName.Text = name;
        }

        //Q5.3.Create a method that will create a new Staff ID and input the staff name from the related text box.
        //The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        //The new staff member must be added to the Dictionary data structure.


        //Q5.4.Create a method that will Update the name of the current Staff ID.
        private void Update()
        {
            int currentId = int.Parse(txtStaffID.Text);
            string newName = txtStaffName.Text;

            if (!string.IsNullOrEmpty(newName))
            {
                // Update the name of the current Staff ID.
                MasterFile[currentId] = newName;
            }
        }

        //Q5.5.Create a method that will Remove the current Staff ID and clear the text boxes.


        //Q5.6.Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveToCSV()
        {
            string csvFilePath = "MalinStaffNamesV2.csv";

            try
            {
                // Create a CSV file with the updated data.
                File.WriteAllLines(csvFilePath, MasterFile.Select(kvp => $"{kvp.Key},{kvp.Value}"));

                stsMsg.Text = "Data updated successfully!";
            }
            catch (Exception ex)
            {
                stsMsg.Text = $"Error updating data: {ex.Message}";
            }
        }


        //Q5.7.Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseAdminForm()
        {
            Close();
        }

        //Q5.8.Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //Make all methods private and ensure the Dictionary is updated.


        //Q5.9.Ensure all code is adequately commented.Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        //Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).

    }
}
