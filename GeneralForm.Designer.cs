﻿namespace MasterFile
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            statusStrip1 = new StatusStrip();
            stsMsg = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(279, 371);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 27;
            label5.Text = "Alt + Q: Exit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(279, 346);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 26;
            label4.Text = "Alt + A: Admin Form";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 397);
            label3.Name = "label3";
            label3.Size = new Size(212, 21);
            label3.TabIndex = 25;
            label3.Text = "Space: Populate selected data";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(296, 213);
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
            label2.Location = new Point(296, 173);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 23;
            label2.Text = "Staff Name :";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(296, 111);
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
            label1.Location = new Point(296, 71);
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
            lbAllStaff.Size = new Size(258, 382);
            lbAllStaff.TabIndex = 20;
            lbAllStaff.TabStop = false;
            // 
            // lbFilteredData
            // 
            lbFilteredData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbFilteredData.FormattingEnabled = true;
            lbFilteredData.ItemHeight = 21;
            lbFilteredData.Location = new Point(521, 34);
            lbFilteredData.Name = "lbFilteredData";
            lbFilteredData.Size = new Size(267, 382);
            lbFilteredData.TabIndex = 20;
            lbFilteredData.KeyPress += lbFilteredData_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(279, 291);
            label6.Name = "label6";
            label6.Size = new Size(149, 21);
            label6.TabIndex = 28;
            label6.Text = "Alt + I: Clear Staff ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(279, 319);
            label7.Name = "label7";
            label7.Size = new Size(184, 21);
            label7.TabIndex = 29;
            label7.Text = "Alt + N: Clear Staff Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(279, 267);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 30;
            label8.Text = "Tab: Relocate cursor";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { stsMsg });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 31;
            statusStrip1.Text = "statusStrip1";
            // 
            // stsMsg
            // 
            stsMsg.Name = "stsMsg";
            stsMsg.Size = new Size(34, 17);
            stsMsg.Text = "Info: ";
            // 
            // GeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(statusStrip1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStaffName);
            Controls.Add(label2);
            Controls.Add(txtStaffID);
            Controls.Add(label1);
            Controls.Add(lbFilteredData);
            Controls.Add(lbAllStaff);
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GeneralForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "General Dictionary";
            KeyDown += GeneralForm_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
        private Label label6;
        private Label label7;
        private Label label8;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stsMsg;
    }
}