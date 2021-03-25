using System;
using System.Windows.Forms;
namespace TsManagement
{
    public partial class CfrmMain : Form
    {
        public CfrmMain()
        {
            InitializeComponent();
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnChicken, pnlMenuOption);
        }

        private void btnLoans_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnLoans, pnlMenuOption);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            CFormControls.MenuChanged(btnUsers,pnlMenuOption);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
