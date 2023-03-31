using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharManager_v0._01.TabContainer
{
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            Main_Window_Form m = new Main_Window_Form();
            if (m.WindowState == FormWindowState.Maximized)
            {
                m.WindowState = FormWindowState.Minimized;
            }
            else if (m.WindowState == FormWindowState.Minimized)
            {
                m.WindowState = FormWindowState.Maximized;
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crtbtn_Click(object sender, EventArgs e)
        {
            RegisterForm m = new RegisterForm();
            m.ShowDialog();
            this.Hide();
        }
    }
}
