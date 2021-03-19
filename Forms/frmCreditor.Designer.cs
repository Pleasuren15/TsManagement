namespace TsManagement.Forms
{
    partial class frmCreditor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCreditorId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAmountToBePaid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDateIssued = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCreditorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStockId = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 60);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "chicken management";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(-3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thabisma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stock Id";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 63);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(37, 15);
            this.lblError.TabIndex = 1;
            this.lblError.Text = "Errors";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(138, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 1);
            this.panel3.TabIndex = 13;
            // 
            // txtCreditorId
            // 
            this.txtCreditorId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCreditorId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditorId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCreditorId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCreditorId.Location = new System.Drawing.Point(138, 127);
            this.txtCreditorId.Name = "txtCreditorId";
            this.txtCreditorId.Size = new System.Drawing.Size(130, 20);
            this.txtCreditorId.TabIndex = 1;
            this.txtCreditorId.Text = "0";
            this.txtCreditorId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCreditorId.Leave += new System.EventHandler(this.txtCreditorId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cre. Cellphone";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel4.Location = new System.Drawing.Point(138, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(129, 1);
            this.panel4.TabIndex = 16;
            // 
            // txtAmountToBePaid
            // 
            this.txtAmountToBePaid.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAmountToBePaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAmountToBePaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtAmountToBePaid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToBePaid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAmountToBePaid.Location = new System.Drawing.Point(138, 183);
            this.txtAmountToBePaid.Name = "txtAmountToBePaid";
            this.txtAmountToBePaid.Size = new System.Drawing.Size(130, 20);
            this.txtAmountToBePaid.TabIndex = 3;
            this.txtAmountToBePaid.Text = "0";
            this.txtAmountToBePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amount";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel5.Location = new System.Drawing.Point(138, 232);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 1);
            this.panel5.TabIndex = 19;
            // 
            // txtDateIssued
            // 
            this.txtDateIssued.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDateIssued.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateIssued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDateIssued.Enabled = false;
            this.txtDateIssued.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateIssued.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDateIssued.Location = new System.Drawing.Point(138, 211);
            this.txtDateIssued.Name = "txtDateIssued";
            this.txtDateIssued.Size = new System.Drawing.Size(130, 20);
            this.txtDateIssued.TabIndex = 4;
            this.txtDateIssued.Text = "0";
            this.txtDateIssued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date Issued";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Location = new System.Drawing.Point(9, 248);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(92, 26);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel6.Location = new System.Drawing.Point(138, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 1);
            this.panel6.TabIndex = 23;
            // 
            // txtCreditorName
            // 
            this.txtCreditorName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCreditorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCreditorName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCreditorName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCreditorName.Location = new System.Drawing.Point(138, 155);
            this.txtCreditorName.Name = "txtCreditorName";
            this.txtCreditorName.Size = new System.Drawing.Size(130, 20);
            this.txtCreditorName.TabIndex = 2;
            this.txtCreditorName.Text = "0";
            this.txtCreditorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cre. Name";
            // 
            // cmbStockId
            // 
            this.cmbStockId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStockId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStockId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStockId.FormattingEnabled = true;
            this.cmbStockId.Items.AddRange(new object[] {
            "Amount",
            "Date",
            "Name"});
            this.cmbStockId.Location = new System.Drawing.Point(138, 85);
            this.cmbStockId.Name = "cmbStockId";
            this.cmbStockId.Size = new System.Drawing.Size(130, 23);
            this.cmbStockId.TabIndex = 0;
            this.cmbStockId.SelectedIndexChanged += new System.EventHandler(this.cmbStockId_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(9, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(164, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "•(yyyy/mm)•";
            // 
            // frmCreditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(276, 279);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbStockId);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtCreditorName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtDateIssued);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtAmountToBePaid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtCreditorId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCreditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Creditor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCreditorId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAmountToBePaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDateIssued;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCreditorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStockId;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
    }
}