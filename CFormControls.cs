using System.Windows.Forms;

namespace TsManagement
{
    public static class CFormControls
    {
        public static void MenuChanged(Button btnMenuOption, Panel pnlMenuOption)
        {
            pnlMenuOption.Location = new System.Drawing.Point(pnlMenuOption.Location.X, btnMenuOption.Location.Y);
        }

        public static void ChangeMenu(Form form ,UserControl userControl)
        {
            userControl.Dock = DockStyle.Right;
            form.Controls.Add(userControl);
        }
    }
}
