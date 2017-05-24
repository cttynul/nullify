using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Nullify.Forms
{
    public partial class DisclaimerForm : MetroForm
    {
        public DisclaimerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DirSetting _dirForm = new DirSetting();
            
            _dirForm.ShowDialog();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DisclaimerForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._settingDownloadDir != "")
            {
                button1.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;
            }
        }
    }
}
