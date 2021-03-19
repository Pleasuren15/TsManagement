using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TsManagement.Models;

namespace TsManagement.Forms
{
    public partial class frmCreditor : Form
    {
        frmMessageBox frmMessageBox;
        public frmCreditor()
        {
            InitializeComponent();
            SetFields();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal mPrice = 0;
            if (isValidDecimal(txtAmountToBePaid.Text,ref mPrice))
            {
                string Message = $"{txtCreditorId.Text}, {txtCreditorName.Text} was saved successfully with a balance of ${mPrice:c} on " +
                    $"{txtDateIssued.Text}";
                CdbTsManagement.ControlCreditor(new CreditedStockDetails(txtCreditorId.Text, cmbStockId.Text, txtCreditorName.Text,
                    mPrice, Convert.ToDateTime(txtDateIssued.Text)), Message);
            }
        }
        private void cmbStockId_SelectedIndexChanged(object sender, EventArgs e)
        {
            existsCreditorDetails();
        }
        private void txtCreditorId_Leave(object sender, EventArgs e)
        {
            existsCreditorDetails();
        }

        #region helper methods
        public void SetFieldsToUpdate(CreditedStockDetails creditedStockDetails)
        {
            cmbStockId.Text = creditedStockDetails.StockId;
            txtCreditorId.Text = creditedStockDetails.CellphoneNumber;
            txtCreditorName.Text = creditedStockDetails.Name;
            txtAmountToBePaid.Text = creditedStockDetails.Amount.ToString();
            txtDateIssued.Text = creditedStockDetails.Date.ToShortDateString();

            cmbStockId.Enabled = txtCreditorId.Enabled = txtCreditorName.Enabled = false;

        }
        private void SetFields()
        {
            txtDateIssued.Text = DateTime.Now.ToShortDateString();

            IList<string> lstDates = CdbTsManagement.GetStockDates();
            cmbStockId.DataSource = lstDates.Reverse().ToList();
        }
        private void existsCreditorDetails()
        {
            IList<CreditedStockDetails> lstCreditorDetails = CdbTsManagement.GetCreditedStockDetails(cmbStockId.SelectedItem.ToString());
            if (lstCreditorDetails.Where(c => c.CellphoneNumber == txtCreditorId.Text && c.StockId == cmbStockId.Text).Count() > 0)
            {
                lblError.Text = $"{txtCreditorId.Text} for {cmbStockId.Text} exists already.";
                btnConfirm.Text = "Update";
            }
            else
            {
                lblError.Text = "";
                btnConfirm.Text = "Confirm";
            }
        }
        private bool isValidDecimal(string sPrice, ref decimal mPrice)
        {
            sPrice = sPrice.Replace('.', ',');
            if (decimal.TryParse(sPrice, out decimal m))
            {
                if (m > 0)
                {
                    mPrice = m;
                    return true;
                }
            }

            frmMessageBox = new frmMessageBox("Invalid number", $"{sPrice} is an invalid number, input must be a valid money value");
            frmMessageBox.Show();
            return false;
        }
        #endregion


    }
}
