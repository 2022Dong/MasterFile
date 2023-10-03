namespace MasterFile
{
    partial class GeneralForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtStaffName = new TextBox();
            label2 = new Label();
            txtStaffID = new TextBox();
            label1 = new Label();
            lbAllStaff = new ListBox();
            lbFilteredData = new ListBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(303, 383);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 27;
            label5.Text = "Alt + L: Exit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(303, 347);
            label4.Name = "label4";
            label4.Size = new Size(175, 21);
            label4.TabIndex = 26;
            label4.Text = "Ctrl + F: Switching form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(303, 311);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 25;
            label3.Text = "Tab: Locating cursor";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(303, 213);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(162, 29);
            txtStaffName.TabIndex = 24;
            txtStaffName.TextChanged += txtStaffName_TextChanged;
            txtStaffName.KeyDown += txtStaffName_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(303, 173);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 23;
            label2.Text = "Staff Name :";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(303, 111);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new Size(162, 29);
            txtStaffID.TabIndex = 22;
            txtStaffID.TextChanged += txtStaffID_TextChanged;
            txtStaffID.KeyDown += txtStaffID_KeyDown;
            txtStaffID.KeyPress += txtStaffID_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(303, 71);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 21;
            label1.Text = "Staff ID :";
            // 
            // lbAllStaff
            // 
            lbAllStaff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAllStaff.FormattingEnabled = true;
            lbAllStaff.ItemHeight = 21;
            lbAllStaff.Location = new Point(12, 34);
            lbAllStaff.Name = "lbAllStaff";
            lbAllStaff.Size = new Size(270, 382);
            lbAllStaff.TabIndex = 20;
            // 
            // lbFilteredData
            // 
            lbFilteredData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFilteredData.FormattingEnabled = true;
            lbFilteredData.ItemHeight = 21;
            lbFilteredData.Location = new Point(484, 34);
            lbFilteredData.Name = "lbFilteredData";
            lbFilteredData.Size = new Size(304, 382);
            lbFilteredData.TabIndex = 20;
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStaffName);
            Controls.Add(label2);
            Controls.Add(txtStaffID);
            Controls.Add(label1);
            Controls.Add(lbFilteredData);
            Controls.Add(lbAllStaff);
            Name = "GeneralForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtStaffName;
        private Label label2;
        private TextBox txtStaffID;
        private Label label1;
        private ListBox lbAllStaff;
        private ListBox lbFilteredData;
    }
}