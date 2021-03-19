using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TsManagement.Forms;
using TsManagement.Models;

namespace TsManagement
{
    public partial class CfrmMain : Form
    {
        frmCreditor frmCreditor;
        frmMessageBox frmMessageBox;

        IList<CreditedStockDetails> lstCreditorDetails;
        public CfrmMain()
        {
            InitializeComponent();
            SetcmbItems();
            UpdateFields();
        }
        private void btnStockOut_Click(object sender, EventArgs e)
        {
            if (isValidInt(txtStockOut.Text))
            {
                CdbTsManagement.UpdateStock(cmbStockFor.SelectedItem.ToString(), -Convert.ToInt32(txtStockOut.Text));
                UpdateFields();
            }
        }
        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (isValidInt(txtStockIn.Text))
            {
                CdbTsManagement.UpdateStock(cmbStockFor.SelectedItem.ToString(), Convert.ToInt32(txtStockIn.Text));
                UpdateFields();
            }
        }
        private void cmbStockFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }
        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFields();
        }
        private void btnAddCreditor_Click(object sender, EventArgs e)
        {
            frmCreditor = new frmCreditor();
            frmCreditor.ShowDialog();
            setlstCreditedStock();
        }
        private void btnUpdateCreditor_Click(object sender, EventArgs e)
        {
            if(lstbxCreditedStockDetails.SelectedIndex == -1)
            {
                frmMessageBox = new frmMessageBox("No selection", "No details were selected to be updated, select and try again.");
                frmMessageBox.ShowDialog();
            }
            else
            {
                frmCreditor = new frmCreditor();
                int idx = lstbxCreditedStockDetails.SelectedIndex;
                frmCreditor.SetFieldsToUpdate(lstCreditorDetails[idx]);
                frmCreditor.ShowDialog();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #region Helper Methods
        private void UpdateFields()
        {
            //Set Labels
            Stock stock = CdbTsManagement.getStock(cmbStockFor.SelectedItem.ToString());
            lblStockQuantity.Text = $"{stock.StockQuantity}";
            lblStockValue.Text = $"{stock.StockValue.ToString("c")}";
            setlstCreditedStock();

        }
        private void SetcmbItems()
        {
            //Set Available Dates
            IList<string> lstDates = CdbTsManagement.GetStockDates();
            cmbStockFor.DataSource = lstDates.Reverse().ToList();

        }
        private void setlstCreditedStock()
        {
            //Set Listbox For Creditors
           lstCreditorDetails = CdbTsManagement.GetCreditedStockDetails(cmbStockFor.SelectedItem.ToString());

            string sortBy = cmbSortBy.SelectedItem == null ? "Amount" : cmbSortBy.SelectedItem.ToString();
            if (sortBy == SorType.Amount.ToString())
            {
                lstCreditorDetails = lstCreditorDetails.OrderBy(e => e.Amount).ToList();
            }
            else if (sortBy == SorType.Date.ToString())
            {
                lstCreditorDetails = lstCreditorDetails.OrderBy(e => e.Date).ToList();
            }
            else if (sortBy == SorType.Name.ToString())
            {
                lstCreditorDetails = lstCreditorDetails.OrderBy(e => e.Name).ToList();
            }

            lstbxCreditedStockDetails.Items.Clear();

            if (lstCreditorDetails.Count > 0)
            {
                lstbxCreditedStockDetails.Enabled = true;
                foreach (CreditedStockDetails csd in lstCreditorDetails)
                {
                    lstbxCreditedStockDetails.Items.Add(csd.Name.PadRight(20) + csd.CellphoneNumber.PadLeft(30) +
                        csd.Amount.ToString("c").PadLeft(35) + csd.Date.ToShortDateString().PadLeft(30));
                }
            }
            else
            {
                lstbxCreditedStockDetails.Enabled = false;
                lstbxCreditedStockDetails.Items.Add("No creditors available".PadLeft(70));
            }

        }
        private bool isValidInt(string sNumber)
        {
            if (int.TryParse(sNumber, out int i))
            {
                if (i > 0)
                {
                    return true;
                }
            }

            frmMessageBox = new frmMessageBox("Invalid Number", $"{sNumber} is invalid input number, try using a number greater than 0(e.g 0,1,5,23...)");
            frmMessageBox.Show();
            return false;
        }
        #endregion
    }
    enum SorType
    {
        Amount, Date, Name
    }
}
