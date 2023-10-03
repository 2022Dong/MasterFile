using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.Logging;
using Microsoft.VisualBasic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System;
using System.Linq;

// Name: Dongyun Huang
// ID: 30042104
// Date: 2/10/2023 - 27/11/2023
namespace MasterFile
{
    public partial class GeneralForm : Form
    {
        public GeneralForm()
        {
            InitializeComponent();
            // Load data
            LoadExcelFile();
        }

        //Q4.1.Create a Dictionary data structure with a TKey of type integer
        //and a TValue of type string, name the new data structure “MasterFile”.
        public static Dictionary<int, string> MasterFile = new Dictionary<int, string>();

        //Q4.2.Create a method that will read the data from the.csv file into the Dictionary data structure when the GUI loads.
        private void LoadExcelFile()
        {
            //MasterFile.Clear();
            using (var reader = new StreamReader("MalinStaffNamesV2.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] keyValue = line.Split(',');
                    MasterFile.Add(int.Parse(keyValue[0]), keyValue[1]);
                }
            }
            DiaplaylbAllStaff();
        }

        //Q4.3.Create a method to display the Dictionary data into a non-selectable display only list box (ie read only).
        private void DiaplaylbAllStaff()
        {
            lbAllStaff.Items.Clear();

            foreach (var staff in MasterFile)
            {
                lbAllStaff.Items.Add(staff);
            }
        }

        //Q4.4.Create a method to filter the Staff Name data from the Dictionary into a second filtered and selectable list box.
        //This method must use a text box input and update as each character is entered.The list box must reflect the filtered data in real time.
        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
            lbFilteredData.Items.Clear();

            string filterText = txtStaffName.Text.ToLower(); // Convert filter text to lowercase

            foreach (var staff in MasterFile)
            {
                int id = staff.Key;
                string name = staff.Value;

                if (name.ToLower().Contains(filterText))
                {
                    lbFilteredData.Items.Add($"[{id}, {name}]");
                }
            }
        }

        //Q4.5.Create a method to filter the Staff ID data from the Dictionary into the second filtered and selectable list box.
        //This method must use a text box input and update as each number is entered.The list box must reflect the filtered data in real time.
        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {
            lbFilteredData.Items.Clear();

            foreach (var staff in MasterFile)
            {
                int id = staff.Key;
                string name = staff.Value;

                if (id.ToString().Contains(txtStaffID.Text))
                {
                    lbFilteredData.Items.Add($"[{id}, {name}]");
                }
            }
        }
        // If it's not a digit & control key, supress the key press.
        private void txtStaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Q4.6.Create a method for the Staff Name text box which will clear the contents and place the focus into the Staff Name text box. Utilise a keyboard shortcut.
        private void txtStaffName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                txtStaffName.Clear();
                txtStaffName.Focus();
            }
        }

        //Q4.7.Create a method for the Staff ID text box which will clear the contents and place the focus into the text box. Utilise a keyboard shortcut.
        private void txtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Control)
            {
                txtStaffID.Clear();
                txtStaffID.Focus();
            }
        }

        //Q4.8.Create a method for the filtered and selectable list box which will populate the two text boxes when a staff record is selected.Utilise the Tab and keyboard keys.


        //Q4.9.Create a method that will open the Admin GUI when the Alt + A keys are pressed.
        //Ensure the General GUI sends the currently selected Staff ID and Staff Name to the Admin GUI for Update and Delete purposes and is opened as modal.
        //Create modified logic to open the Admin GUI to Create a new user when the Staff ID 77 and the Staff Name is empty.
        //Read the appropriate criteria in the Admin GUI for further information.


        //Q4.10.Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //Make all methods private and ensure the Dictionary is static and public.

        //Q4.11.Ensure all code is adequately commented.Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        //Ensure your code is compliant with the CITEMS coding standards (refer http://www.citems.com.au/).

    }
}