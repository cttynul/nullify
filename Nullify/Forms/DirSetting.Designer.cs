namespace Nullify
{
    partial class DirSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirSetting));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this._browseForSetting = new MetroFramework.Controls.MetroLink();
            this._saveButton = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 25);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Library Setting";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(216, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Select your default library directory";
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(325, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[] {
        "textBox1"};
            this.textBox1.Location = new System.Drawing.Point(42, 107);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(347, 23);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "textBox1";
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _browseForSetting
            // 
            this._browseForSetting.Image = global::Nullify.Properties.Resources.folder;
            this._browseForSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._browseForSetting.ImageSize = 24;
            this._browseForSetting.Location = new System.Drawing.Point(395, 85);
            this._browseForSetting.Name = "_browseForSetting";
            this._browseForSetting.Size = new System.Drawing.Size(112, 62);
            this._browseForSetting.TabIndex = 8;
            this._browseForSetting.Text = "Select Dir";
            this._browseForSetting.UseSelectable = true;
            this._browseForSetting.Click += new System.EventHandler(this.button2_Click);
            // 
            // _saveButton
            // 
            this._saveButton.Image = global::Nullify.Properties.Resources.save;
            this._saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._saveButton.ImageSize = 24;
            this._saveButton.Location = new System.Drawing.Point(194, 136);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(137, 42);
            this._saveButton.TabIndex = 9;
            this._saveButton.Text = "Save Settings";
            this._saveButton.UseSelectable = true;
            // 
            // DirSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 199);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._browseForSetting);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 199);
            this.MinimumSize = new System.Drawing.Size(498, 199);
            this.Name = "DirSetting";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Nullify Settings";
            this.Load += new System.EventHandler(this.DirSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroLink _browseForSetting;
        private MetroFramework.Controls.MetroLink _saveButton;
    }
}