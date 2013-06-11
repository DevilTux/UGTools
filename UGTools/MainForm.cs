using System;
using System.Windows.Forms;

using UGTools.Controls;

namespace UGTools
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        #region -- Private Methods --
        private void ExitApp()
        {
            Application.Exit();
        }
        #endregion
        

        private void HideAppToolStripMenuItemClick(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
            Hide();
        }
        private void ExitAppToolStripMenuItemClick(object sender, EventArgs e)
        {
            ExitApp();
        }
        private void ShowToolStripMenuItemClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            ExitApp();
        }
        private void NotifyIconDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void CheckAEToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ae = new CheckAE();
            ae.MdiParent = this;
            ae.WindowState = FormWindowState.Maximized;
            ae.Show();
        }

        private void RoboFormToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ae = new RoboForm();
            ae.MdiParent = this;
            ae.WindowState = FormWindowState.Maximized;
            ae.Show();
        }

    }
}
