using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;

namespace Nullify
{
    public partial class DirSetting : Form
    {
        public DirSetting()
        {
                    
            InitializeComponent();
            this.AcceptButton = _saveButton;
            
        }

        private void DirSetting_Load(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default._settingDownloadDir == "")
            {
                string _defaultDir = Environment.GetFolderPath(SpecialFolder.CommonMusic) + "\\Nullify\\";
                textBox1.Text = _defaultDir;
            }
            else
            {
                textBox1.Text = Properties.Settings.Default._settingDownloadDir;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default._settingDownloadDir = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            string directoryPath = "";
            if (dir.ShowDialog() == DialogResult.OK)
            {
                directoryPath = dir.SelectedPath;
            }


            string downloadDir = directoryPath + "\\Nullify\\";
            Properties.Settings.Default._settingDownloadDir = downloadDir;
            textBox1.Text = Properties.Settings.Default._settingDownloadDir;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // do nothing
        }

        
    }
}
