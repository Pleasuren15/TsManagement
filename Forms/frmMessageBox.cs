using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsManagement.Forms
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string Title,string Message)
        {
            InitializeComponent();
            setFields(Title, Message);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void setFields(string Title, string Message)
        {
            Text = Title;
            rtfMessage.Text = Message;
            rtfMessage.ReadOnly = true;
            btnOk.Focus();
        }

    }
}
