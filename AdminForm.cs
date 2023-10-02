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
        public AdminForm()
        {
            InitializeComponent();
        }
        //Q5.1.Create the Admin GUI with the following settings: GUI is model, all Control Box features are removed/hidden,
        //then add two text boxes.The text box for the Staff ID should be read-only for Add, Update and Delete purposes.


        //Q5.2.Create a method that will receive the Staff ID from the General GUI and then populate text boxes with the related data. 


        //Q5.3.Create a method that will create a new Staff ID and input the staff name from the related text box.
        //The Staff ID must be unique starting with 77xxxxxxx while the staff name may be duplicated.
        //The new staff member must be added to the Dictionary data structure.


        //Q5.4.Create a method that will Update the name of the current Staff ID.


        //Q5.5.Create a method that will Remove the current Staff ID and clear the text boxes.


        //Q5.6.Create a method that will save changes to the csv file, this method should be called as the Admin GUI closes.


        //Q5.7.Create a method that will close the Admin GUI when the Alt + L keys are pressed.


        //Q5.8.Add suitable error trapping and user feedback via a status strip or similar to ensure a fully functional User Experience.
        //Make all methods private and ensure the Dictionary is updated.


        //Q5.9.Ensure all code is adequately commented.Map the programming criteria and features to your code/methods by adding comments above the method signatures.
        //Ensure your code is compliant with the CITEMS and MS coding standards (refer http://www.citems.com.au/).

    }
}
