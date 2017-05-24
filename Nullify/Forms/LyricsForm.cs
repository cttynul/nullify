using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace Nullify
{
    public partial class LyricsForm : MetroForm
    {

        private string _lyricsPath;
        public string LyricsPath
        {
            get
            {
                return this._lyricsPath;
            }
            set
            {
                this._lyricsPath = value;
            }
        }

        public LyricsForm(string lyricsPath)
        {
            LyricsPath = lyricsPath;
            
            InitializeComponent();
            if (File.Exists(LyricsPath))
            {
                _saveButton.Enabled = false;
                string _lyricsText = File.ReadAllText(LyricsPath);
                _richTextBox.Text = _lyricsText;
            }
            else
            {
                _saveButton.Enabled = true;
            }
            _richTextBox.TextChanged += EnableSave;
        }

        private void EnableSave(object sender, EventArgs e)
        {
            _saveButton.Enabled = true;
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveFile()
        {
            try
            {
                StreamWriter sw = File.CreateText(LyricsPath);
                foreach(String s in _richTextBox.Lines)
                {
                    sw.WriteLine(s);
                }
                sw.Flush();
                sw.Close();
                MetroMessageBox.Show(this, "Your lyrics has just been saved, enjoy :3", "Lyrics saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                // Impossibile salvare ops
            }
        }
    }
}
