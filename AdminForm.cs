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
using System.Diagnostics;

namespace MasterFile
{
    public partial class AdminForm : Form
    {
        private GeneralForm formInstance; // need an instance to call the methods.
        public AdminForm(GeneralForm form, string id, string name)
        {
            InitializeComponent();

            formInstance = form;
            PopulateSelectedData(id, name);
        }

        #region Form KeyDown Events
        private void AdminForm_KeyDown(object sender, KeyEventArgs e)
        {
            //// Create
            //if (e.KeyCode == Keys.C && e.Alt)
            //{
            //    Create();
            //}

            // update
            if (e.KeyCode == Keys.U && e.Alt)
            {
                //Trace.Listeners.Add(myTraceListener);
                stsMsg.Text = "";

                var watch = Stopwatch.StartNew();
                Update();
                watch.Stop();
                var elapseTicks = watch.ElapsedTicks;

                Trace.WriteLine($"Update(): {elapseTicks} ticks;");
            }

            // remove
            else if (e.KeyCode == Keys.D && e.Alt)
            {
                //Trace.Listeners.Add(myTraceListener);
                stsMsg.Text = "";

                var watch = Stopwatch.StartNew();
                Delete();
                watch.Stop();
                var elapseTicks = watch.ElapsedTicks;

                Trace.WriteLine($"Delete(): {elapseTicks} ticks;");
            }

            // close
            else if (e.KeyCode == Keys.L && e.Alt)
            {
                var watch = Stopwatch.StartNew();
                CloseAdminForm();
                watch.Stop();
                var elapseTicks = watch.ElapsedTicks;

                Trace.WriteLine($"SaveExcelFile(): {elapseTicks} ticks;");
            }
        }
        #endregion

        //Q5.1.Create the Admin GUI with the following settings: GUI is model, all Control Box features are removed/hidden,
        //then add two text boxes.The text box for the Staff ID should be read-only for Add, Update and Delete purposes.


        //Q5.2.Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 
        private void PopulateSelectedData(string id, string name)
        {
            txtStaffID.Text = id;
            txtStaffName.Text = name;

            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                //Trace.Listeners.Add(myTraceListener);

                var watch = Stopwatch.StartNew();
                Create();
                watch.Stop();
                var elapseTicks = watch.ElapsedTicks;

                Trace.WriteLine($"Create(): {elapseTicks} ticks;");
            }
        }

        //Q5.3.Create a method that will create a new Staff ID and input the staff name from the related text box.
        //The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        //The new staff member must be added to the Dictionary data structure.
        private void Create()
        {
            // Generate 7 random digits. 
            Random random = new Random();
            int rand = 0;
            for (int i = 0; i < 7; i++)
            {
                rand = rand * 10 + random.Next(10); // 0 ~ 9
            }
            // Generate unique id starting w/ 77
            int staffId = 770000000 + rand;

            if (!GeneralForm.MasterFile.ContainsKey(staffId))
            {
                txtStaffID.Text = staffId.ToString();
                txtStaffName.Text = "";
                txtStaffName.Focus();


                if (!string.IsNullOrEmpty(txtStaffName.Text))
                {
                    GeneralForm.MasterFile.Add(staffId, txtStaffName.Text);
                }
            }
            else
            {
                stsMsg.Text = "Duplicate ID, Please reopen admin form try again.";
            }
        }
        private void txtStaffID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Alt)
            {
                Create();
            }
        }

        //Q5.4.Create a method that will Update the name of the current Staff ID.
        private void Update()
        {
            int currentId = int.Parse(txtStaffID.Text);
            string newName = txtStaffName.Text;

            if (!string.IsNullOrEmpty(newName))
            {
                // Update the name of the current Staff ID.
                GeneralForm.MasterFile[currentId] = newName; // add new
                ClearTexbox();
            }
            else
            {
                stsMsg.Text = "Need a name.";
            }
        }

        //Q5.5.Create a method that will Remove the current Staff ID and clear the text boxes.
        private void Delete()
        {
            if (!string.IsNullOrEmpty(txtStaffID.Text))
            {
                int currentId = int.Parse(txtStaffID.Text);
                GeneralForm.MasterFile.Remove(currentId);
                ClearTexbox();
            }
            else
            {
                stsMsg.Text = "Need a selected record from the General form...";
            }
        }

        //Q5.6.Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.
        private void SaveToCSV()
        {
            string csvFilePath = "MalinStaffNamesV2.csv";

            // Create a CSV file with the updated data.
            File.WriteAllLines(csvFilePath, GeneralForm.MasterFile.Select(kvp => $"{kvp.Key},{kvp.Value}"));

            ClearTexbox();
        }

        //Q5.7.Create a method that will close the Admin GUI when the Alt + L keys are pressed.
        private void CloseAdminForm()
        {
            SaveToCSV();

            // GeneralForm - after closing.
            formInstance.LoadExcelFile(); // formInstance.DiaplaylbAllStaff();
            formInstance.ClearTextBoxes();

            Close();
        }

        //Q5.8.Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //Make all methods private and ensure the Dictionary is updated.
        private void ClearTexbox()
        {
            txtStaffID.Clear();
            txtStaffName.Clear();
            stsMsg.Text = "Task done (^_^)";
        }

        //Q5.9.Ensure all code is adequately commented.Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        //Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).
    }
}
