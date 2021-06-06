using System;
using System.Windows.Forms;
using TsManagement.UserControls;

namespace TsManagement
{
    public partial class CfrmMain : Form
    {
        public CfrmMain()
        {
            InitializeComponent();
            CFormControls.ChangeMenu(this, new userControlChickens());
            CFormControls.MenuChanged(btnChicken, pnlMenuOption);
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnChicken, pnlMenuOption);
            CFormControls.ChangeMenu(this, new userControlChickens());
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnLoans, pnlMenuOption);
            CFormControls.ChangeMenu(this, new userControlLoans());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnUsers, pnlMenuOption);
            CFormControls.ChangeMenu(this, new userControlsUsers());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnAbout, pnlMenuOption);
            CFormControls.ChangeMenu(this, new userControlAbout());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
