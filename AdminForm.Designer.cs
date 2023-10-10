namespace MasterFile
{
    partial class AdminForm
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
            label5 = new Label();
            label3 = new Label();
            txtStaffName = new TextBox();
            label2 = new Label();
            txtStaffID = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            statusStrip1 = new StatusStrip();
            stsMsg = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(257, 253);
            label5.Name = "label5";
            label5.Size = new Size(87, 21);
            label5.TabIndex = 15;
            label5.Text = "Alt + L: Exit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 295);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 13;
            label3.Text = "Tab: Locating cursor";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(41, 176);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(175, 29);
            txtStaffName.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 11;
            label2.Text = "Staff Name :";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(41, 74);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(175, 29);
            txtStaffID.TabIndex = 10;
            txtStaffID.KeyDown += txtStaffID_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 9;
            label1.Text = "Staff ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(257, 77);
            label6.Name = "label6";
            label6.Size = new Size(137, 21);
            label6.TabIndex = 18;
            label6.Text = "Alt + O : Login out";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(257, 46);
            label7.Name = "label7";
            label7.Size = new Size(119, 21);
            label7.TabIndex = 17;
            label7.Text = "Alt + I : Login in";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(257, 15);
            label8.Name = "label8";
            label8.Size = new Size(50, 21);
            label8.TabIndex = 16;
            label8.Text = "USER";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(257, 190);
            label9.Name = "label9";
            label9.Size = new Size(116, 21);
            label9.TabIndex = 21;
            label9.Text = "Alt + U: Update";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(257, 159);
            label10.Name = "label10";
            label10.Size = new Size(190, 21);
            label10.TabIndex = 20;
            label10.Text = "Alt + C: Create  --> Alt +U";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(257, 128);
            label11.Name = "label11";
            label11.Size = new Size(171, 21);
            label11.TabIndex = 19;
            label11.Text = "DATA MODIFICATION";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(257, 222);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 22;
            label12.Text = "Alt + D: Delete";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stsMsg });
            statusStrip1.Location = new Point(0, 335);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(504, 22);
            statusStrip1.TabIndex = 25;
            statusStrip1.Text = "statusStrip1";
            // 
            // stsMsg
            // 
            stsMsg.Name = "stsMsg";
            stsMsg.Size = new Size(84, 17);
            stsMsg.Text = "Feedback info:";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 357);
            Controls.Add(statusStrip1);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtStaffName);
            Controls.Add(label2);
            Controls.Add(txtStaffID);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            KeyDown += AdminForm_KeyDown;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private TextBox txtStaffName;
        private Label label2;
        private TextBox txtStaffID;
        private Label label1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel stsMsg;
    }
}