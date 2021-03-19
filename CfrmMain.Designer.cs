namespace TsManagement
{
    partial class CfrmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblStockValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStockQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStockFor = new System.Windows.Forms.ComboBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbxCreditedStockDetails = new System.Windows.Forms.ListBox();
            this.txtStockIn = new System.Windows.Forms.TextBox();
            this.txtStockOut = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStockOut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.btnAddCreditor = new System.Windows.Forms.Button();
            this.btnUpdateCreditor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Teal;
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(738, 70);
            this.pnlMenu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "chicken management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(7, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thabisma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Showing stock for";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.OrangeRed;
            this.panel7.Controls.Add(this.lblStockValue);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(143, 123);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(133, 57);
            this.panel7.TabIndex = 18;
            // 
            // lblStockValue
            // 
            this.lblStockValue.AutoSize = true;
            this.lblStockValue.BackColor = System.Drawing.Color.OrangeRed;
            this.lblStockValue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockValue.ForeColor = System.Drawing.Color.Black;
            this.lblStockValue.Location = new System.Drawing.Point(3, 23);
            this.lblStockValue.Name = "lblStockValue";
            this.lblStockValue.Size = new System.Drawing.Size(90, 25);
            this.lblStockValue.TabIndex = 1;
            this.lblStockValue.Text = "R123.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Monetary value";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.OrangeRed;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.lblStockQuantity);
            this.panel6.Location = new System.Drawing.Point(14, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(126, 57);
            this.panel6.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chicken Count";
            // 
            // lblStockQuantity
            // 
            this.lblStockQuantity.AutoSize = true;
            this.lblStockQuantity.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockQuantity.Location = new System.Drawing.Point(9, 23);
            this.lblStockQuantity.Name = "lblStockQuantity";
            this.lblStockQuantity.Size = new System.Drawing.Size(48, 25);
            this.lblStockQuantity.TabIndex = 3;
            this.lblStockQuantity.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(180, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "•(yyyy/mm)•";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(556, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Copyright2020, All rights reserved";
            // 
            // cmbStockFor
            // 
            this.cmbStockFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStockFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockFor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStockFor.FormattingEnabled = true;
            this.cmbStockFor.Items.AddRange(new object[] {
            "Amount",
            "Date",
            "Name"});
            this.cmbStockFor.Location = new System.Drawing.Point(157, 81);
            this.cmbStockFor.Name = "cmbStockFor";
            this.cmbStockFor.Size = new System.Drawing.Size(119, 23);
            this.cmbStockFor.TabIndex = 15;
            this.cmbStockFor.SelectedIndexChanged += new System.EventHandler(this.cmbStockFor_SelectedIndexChanged);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortBy.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Amount",
            "Date",
            "Name"});
            this.cmbSortBy.Location = new System.Drawing.Point(611, 182);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(121, 23);
            this.cmbSortBy.TabIndex = 15;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(531, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sort by(Asc.)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Credited chickens";
            // 
            // lstbxCreditedStockDetails
            // 
            this.lstbxCreditedStockDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstbxCreditedStockDetails.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxCreditedStockDetails.FormattingEnabled = true;
            this.lstbxCreditedStockDetails.Location = new System.Drawing.Point(11, 211);
            this.lstbxCreditedStockDetails.Name = "lstbxCreditedStockDetails";
            this.lstbxCreditedStockDetails.Size = new System.Drawing.Size(721, 199);
            this.lstbxCreditedStockDetails.TabIndex = 10;
            // 
            // txtStockIn
            // 
            this.txtStockIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtStockIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStockIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStockIn.Location = new System.Drawing.Point(506, 152);
            this.txtStockIn.Name = "txtStockIn";
            this.txtStockIn.Size = new System.Drawing.Size(99, 20);
            this.txtStockIn.TabIndex = 9;
            this.txtStockIn.Text = "0";
            this.txtStockIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStockOut
            // 
            this.txtStockOut.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtStockOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtStockOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtStockOut.Location = new System.Drawing.Point(506, 124);
            this.txtStockOut.Name = "txtStockOut";
            this.txtStockOut.Size = new System.Drawing.Size(99, 20);
            this.txtStockOut.TabIndex = 9;
            this.txtStockOut.Text = "0";
            this.txtStockOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Location = new System.Drawing.Point(506, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(506, 145);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 1);
            this.panel3.TabIndex = 6;
            // 
            // btnStockOut
            // 
            this.btnStockOut.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStockOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockOut.FlatAppearance.BorderSize = 0;
            this.btnStockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOut.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOut.ForeColor = System.Drawing.Color.Black;
            this.btnStockOut.Location = new System.Drawing.Point(611, 120);
            this.btnStockOut.Name = "btnStockOut";
            this.btnStockOut.Size = new System.Drawing.Size(121, 26);
            this.btnStockOut.TabIndex = 5;
            this.btnStockOut.Text = "Stock out";
            this.btnStockOut.UseVisualStyleBackColor = false;
            this.btnStockOut.Click += new System.EventHandler(this.btnStockOut_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(610, 416);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 27);
            this.button5.TabIndex = 5;
            this.button5.Text = "Stock tracker";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockIn.FlatAppearance.BorderSize = 0;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.Black;
            this.btnStockIn.Location = new System.Drawing.Point(611, 148);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(121, 27);
            this.btnStockIn.TabIndex = 5;
            this.btnStockIn.Text = "Stock in";
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // btnAddCreditor
            // 
            this.btnAddCreditor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCreditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCreditor.FlatAppearance.BorderSize = 0;
            this.btnAddCreditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCreditor.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCreditor.ForeColor = System.Drawing.Color.Black;
            this.btnAddCreditor.Location = new System.Drawing.Point(11, 416);
            this.btnAddCreditor.Name = "btnAddCreditor";
            this.btnAddCreditor.Size = new System.Drawing.Size(122, 27);
            this.btnAddCreditor.TabIndex = 5;
            this.btnAddCreditor.Text = "Add creditor";
            this.btnAddCreditor.UseVisualStyleBackColor = false;
            this.btnAddCreditor.Click += new System.EventHandler(this.btnAddCreditor_Click);
            // 
            // btnUpdateCreditor
            // 
            this.btnUpdateCreditor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateCreditor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCreditor.FlatAppearance.BorderSize = 0;
            this.btnUpdateCreditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCreditor.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCreditor.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCreditor.Location = new System.Drawing.Point(134, 416);
            this.btnUpdateCreditor.Name = "btnUpdateCreditor";
            this.btnUpdateCreditor.Size = new System.Drawing.Size(122, 27);
            this.btnUpdateCreditor.TabIndex = 5;
            this.btnUpdateCreditor.Text = "Update creditor";
            this.btnUpdateCreditor.UseVisualStyleBackColor = false;
            this.btnUpdateCreditor.Click += new System.EventHandler(this.btnUpdateCreditor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(8, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "developed by, Pleasure Ndhlovu";
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(738, 464);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSortBy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.btnStockOut);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.btnUpdateCreditor);
            this.Controls.Add(this.btnAddCreditor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnStockIn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStockOut);
            this.Controls.Add(this.txtStockIn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.lstbxCreditedStockDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbStockFor);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thabisma Chicken Management";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockQuantity;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStockOut;
        private System.Windows.Forms.TextBox txtStockOut;
        private System.Windows.Forms.Label lblStockValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbxCreditedStockDetails;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStockFor;
        private System.Windows.Forms.Button btnAddCreditor;
        private System.Windows.Forms.Button btnUpdateCreditor;
        private System.Windows.Forms.Label label10;
    }
}

