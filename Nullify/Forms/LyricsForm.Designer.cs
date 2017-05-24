namespace Nullify
{
    partial class LyricsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyricsForm));
            this._richTextBox = new System.Windows.Forms.RichTextBox();
            this._saveButton = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // _richTextBox
            // 
            this._richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._richTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._richTextBox.Location = new System.Drawing.Point(11, 63);
            this._richTextBox.Name = "_richTextBox";
            this._richTextBox.Size = new System.Drawing.Size(388, 336);
            this._richTextBox.TabIndex = 0;
            this._richTextBox.Text = "";
            // 
            // _saveButton
            // 
            this._saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._saveButton.Image = global::Nullify.Properties.Resources.save;
            this._saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._saveButton.ImageSize = 32;
            this._saveButton.Location = new System.Drawing.Point(293, 405);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(143, 38);
            this._saveButton.TabIndex = 3;
            this._saveButton.Text = "Save Lyrics";
            this._saveButton.UseSelectable = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // LyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 456);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._richTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LyricsForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Lyrics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox _richTextBox;
        private MetroFramework.Controls.MetroLink _saveButton;
    }
}