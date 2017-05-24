namespace Nullify
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this._tabDownload = new System.Windows.Forms.TabPage();
            this._resultDataGrid = new MetroFramework.Controls.MetroGrid();
            this._ContextMenuStrip = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._searchButton = new MetroFramework.Controls.MetroButton();
            this._searchTextBox = new MetroFramework.Controls.MetroTextBox();
            this._vlcWrapper = new AxWMPLib.AxWindowsMediaPlayer();
            this._tabPlayer = new System.Windows.Forms.TabPage();
            this._dataGridPlayer = new MetroFramework.Controls.MetroGrid();
            this._libraryContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.updateLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tab = new MetroFramework.Controls.MetroTabControl();
            this._tabSetting = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this._checkBoxDirDef = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this._saveSettingButton = new MetroFramework.Controls.MetroButton();
            this._browseSettingButton = new MetroFramework.Controls.MetroButton();
            this._libSettingDirectory = new MetroFramework.Controls.MetroTextBox();
            this._tabDMCA = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this._cttynulLabel = new MetroFramework.Controls.MetroLink();
            this._licenseLinkLabel = new MetroFramework.Controls.MetroLink();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._songName = new MetroFramework.Controls.MetroLabel();
            this._minuteLabel = new MetroFramework.Controls.MetroLabel();
            this._progressBar = new MetroFramework.Controls.MetroProgressBar();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this._downloadButton = new MetroFramework.Controls.MetroLink();
            this._lyricsButton = new MetroFramework.Controls.MetroLink();
            this._metroVolUp = new MetroFramework.Controls.MetroLink();
            this._metroVolDown = new MetroFramework.Controls.MetroLink();
            this._metroStopButton = new MetroFramework.Controls.MetroLink();
            this._metroPlayButton = new MetroFramework.Controls.MetroLink();
            this._albumPic = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumPicDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.yearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._tabDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGrid)).BeginInit();
            this._ContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._vlcWrapper)).BeginInit();
            this._tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPlayer)).BeginInit();
            this._libraryContextMenu.SuspendLayout();
            this._tab.SuspendLayout();
            this._tabSetting.SuspendLayout();
            this._tabDMCA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // _tabDownload
            // 
            this._tabDownload.Controls.Add(this._resultDataGrid);
            this._tabDownload.Controls.Add(this._searchButton);
            this._tabDownload.Controls.Add(this._searchTextBox);
            this._tabDownload.Controls.Add(this._vlcWrapper);
            this._tabDownload.Location = new System.Drawing.Point(4, 38);
            this._tabDownload.Name = "_tabDownload";
            this._tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this._tabDownload.Size = new System.Drawing.Size(825, 338);
            this._tabDownload.TabIndex = 0;
            this._tabDownload.Text = "Download";
            this._tabDownload.UseVisualStyleBackColor = true;
            // 
            // _resultDataGrid
            // 
            this._resultDataGrid.AllowUserToAddRows = false;
            this._resultDataGrid.AllowUserToDeleteRows = false;
            this._resultDataGrid.AllowUserToResizeRows = false;
            this._resultDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._resultDataGrid.AutoGenerateColumns = false;
            this._resultDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._resultDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._resultDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._resultDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._resultDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._resultDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn2,
            this.durationDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn1,
            this.albumPicDataGridViewImageColumn1,
            this.yearDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn1,
            this.albumDataGridViewTextBoxColumn1});
            this._resultDataGrid.ContextMenuStrip = this._ContextMenuStrip;
            this._resultDataGrid.DataSource = this.songBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._resultDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this._resultDataGrid.EnableHeadersVisualStyles = false;
            this._resultDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._resultDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._resultDataGrid.Location = new System.Drawing.Point(6, 42);
            this._resultDataGrid.MultiSelect = false;
            this._resultDataGrid.Name = "_resultDataGrid";
            this._resultDataGrid.ReadOnly = true;
            this._resultDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._resultDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._resultDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._resultDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._resultDataGrid.Size = new System.Drawing.Size(813, 296);
            this._resultDataGrid.Style = MetroFramework.MetroColorStyle.Teal;
            this._resultDataGrid.TabIndex = 7;
            this._resultDataGrid.DoubleClick += new System.EventHandler(this._toolStripPlayButton_Click);
            // 
            // _ContextMenuStrip
            // 
            this._ContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this._ContextMenuStrip.Name = "_ContextMenuStrip";
            this._ContextMenuStrip.Size = new System.Drawing.Size(129, 48);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // downloadToolStripMenuItem
            // 
            this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
            this.downloadToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.downloadToolStripMenuItem.Text = "Download";
            this.downloadToolStripMenuItem.Click += new System.EventHandler(this.downloadToolStripMenuItem_Click);
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Location = new System.Drawing.Point(736, 10);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(83, 23);
            this._searchButton.TabIndex = 6;
            this._searchButton.Text = "Search";
            this._searchButton.UseSelectable = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _searchTextBox
            // 
            // 
            // 
            // 
            this._searchTextBox.CustomButton.Image = null;
            this._searchTextBox.CustomButton.Location = new System.Drawing.Point(702, 1);
            this._searchTextBox.CustomButton.Name = "";
            this._searchTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._searchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._searchTextBox.CustomButton.TabIndex = 1;
            this._searchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._searchTextBox.CustomButton.UseSelectable = true;
            this._searchTextBox.CustomButton.Visible = false;
            this._searchTextBox.Lines = new string[] {
        "Search a song..."};
            this._searchTextBox.Location = new System.Drawing.Point(6, 10);
            this._searchTextBox.MaxLength = 32767;
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.PasswordChar = '\0';
            this._searchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._searchTextBox.SelectedText = "";
            this._searchTextBox.SelectionLength = 0;
            this._searchTextBox.SelectionStart = 0;
            this._searchTextBox.ShortcutsEnabled = true;
            this._searchTextBox.Size = new System.Drawing.Size(724, 23);
            this._searchTextBox.TabIndex = 5;
            this._searchTextBox.Text = "Search a song...";
            this._searchTextBox.UseSelectable = true;
            this._searchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._searchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this._searchTextBox.Click += new System.EventHandler(this._searchTextBox_Click);
            // 
            // _vlcWrapper
            // 
            this._vlcWrapper.Enabled = true;
            this._vlcWrapper.Location = new System.Drawing.Point(225, 132);
            this._vlcWrapper.Name = "_vlcWrapper";
            this._vlcWrapper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("_vlcWrapper.OcxState")));
            this._vlcWrapper.Size = new System.Drawing.Size(165, 66);
            this._vlcWrapper.TabIndex = 4;
            this._vlcWrapper.Visible = false;
            // 
            // _tabPlayer
            // 
            this._tabPlayer.Controls.Add(this._dataGridPlayer);
            this._tabPlayer.Location = new System.Drawing.Point(4, 38);
            this._tabPlayer.Name = "_tabPlayer";
            this._tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this._tabPlayer.Size = new System.Drawing.Size(825, 338);
            this._tabPlayer.TabIndex = 1;
            this._tabPlayer.Text = "Player";
            this._tabPlayer.UseVisualStyleBackColor = true;
            // 
            // _dataGridPlayer
            // 
            this._dataGridPlayer.AllowUserToAddRows = false;
            this._dataGridPlayer.AllowUserToDeleteRows = false;
            this._dataGridPlayer.AllowUserToResizeRows = false;
            this._dataGridPlayer.AutoGenerateColumns = false;
            this._dataGridPlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._dataGridPlayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridPlayer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._dataGridPlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.albumPicDataGridViewImageColumn,
            this.urlDataGridViewTextBoxColumn});
            this._dataGridPlayer.ContextMenuStrip = this._libraryContextMenu;
            this._dataGridPlayer.DataSource = this.libraryBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridPlayer.DefaultCellStyle = dataGridViewCellStyle5;
            this._dataGridPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridPlayer.EnableHeadersVisualStyles = false;
            this._dataGridPlayer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._dataGridPlayer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this._dataGridPlayer.Location = new System.Drawing.Point(3, 3);
            this._dataGridPlayer.MultiSelect = false;
            this._dataGridPlayer.Name = "_dataGridPlayer";
            this._dataGridPlayer.ReadOnly = true;
            this._dataGridPlayer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridPlayer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this._dataGridPlayer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._dataGridPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridPlayer.Size = new System.Drawing.Size(819, 332);
            this._dataGridPlayer.Style = MetroFramework.MetroColorStyle.Teal;
            this._dataGridPlayer.TabIndex = 0;
            this._dataGridPlayer.Theme = MetroFramework.MetroThemeStyle.Light;
            this._dataGridPlayer.DoubleClick += new System.EventHandler(this.PlayDoubleClickLibrary);
            // 
            // _libraryContextMenu
            // 
            this._libraryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateLibraryToolStripMenuItem});
            this._libraryContextMenu.Name = "_libraryContextMenu";
            this._libraryContextMenu.Size = new System.Drawing.Size(149, 26);
            // 
            // updateLibraryToolStripMenuItem
            // 
            this.updateLibraryToolStripMenuItem.Name = "updateLibraryToolStripMenuItem";
            this.updateLibraryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateLibraryToolStripMenuItem.Text = "Update library";
            this.updateLibraryToolStripMenuItem.Click += new System.EventHandler(this.updateLibraryToolStripMenuItem_Click);
            // 
            // _tab
            // 
            this._tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tab.Controls.Add(this._tabPlayer);
            this._tab.Controls.Add(this._tabDownload);
            this._tab.Controls.Add(this._tabSetting);
            this._tab.Controls.Add(this._tabDMCA);
            this._tab.Controls.Add(this.metroTabPage3);
            this._tab.Location = new System.Drawing.Point(20, 63);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(833, 380);
            this._tab.Style = MetroFramework.MetroColorStyle.Teal;
            this._tab.TabIndex = 17;
            this._tab.UseSelectable = true;
            // 
            // _tabSetting
            // 
            this._tabSetting.Controls.Add(this.metroLabel6);
            this._tabSetting.Controls.Add(this.metroLabel5);
            this._tabSetting.Controls.Add(this.metroLabel4);
            this._tabSetting.Controls.Add(this._checkBoxDirDef);
            this._tabSetting.Controls.Add(this.metroLabel1);
            this._tabSetting.Controls.Add(this._saveSettingButton);
            this._tabSetting.Controls.Add(this._browseSettingButton);
            this._tabSetting.Controls.Add(this._libSettingDirectory);
            this._tabSetting.HorizontalScrollbarBarColor = true;
            this._tabSetting.HorizontalScrollbarHighlightOnWheel = false;
            this._tabSetting.HorizontalScrollbarSize = 10;
            this._tabSetting.Location = new System.Drawing.Point(4, 38);
            this._tabSetting.Name = "_tabSetting";
            this._tabSetting.Size = new System.Drawing.Size(825, 338);
            this._tabSetting.TabIndex = 2;
            this._tabSetting.Text = "Setting";
            this._tabSetting.VerticalScrollbarBarColor = true;
            this._tabSetting.VerticalScrollbarHighlightOnWheel = false;
            this._tabSetting.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.Location = new System.Drawing.Point(5, 157);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(561, 15);
            this.metroLabel6.TabIndex = 30;
            this.metroLabel6.Text = "If unchecked Nullify will asks you where download your file everytime, and theser" +
    "e won\'t be added to your library";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(5, 107);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(146, 25);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Download Setting";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(5, 20);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 25);
            this.metroLabel4.TabIndex = 28;
            this.metroLabel4.Text = "Library Setting";
            // 
            // _checkBoxDirDef
            // 
            this._checkBoxDirDef.AutoSize = true;
            this._checkBoxDirDef.Checked = true;
            this._checkBoxDirDef.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxDirDef.Location = new System.Drawing.Point(12, 135);
            this._checkBoxDirDef.Name = "_checkBoxDirDef";
            this._checkBoxDirDef.Size = new System.Drawing.Size(176, 15);
            this._checkBoxDirDef.Style = MetroFramework.MetroColorStyle.Teal;
            this._checkBoxDirDef.TabIndex = 27;
            this._checkBoxDirDef.Text = "Download in library directory";
            this._checkBoxDirDef.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(5, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(216, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Select your default library directory";
            // 
            // _saveSettingButton
            // 
            this._saveSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._saveSettingButton.Location = new System.Drawing.Point(693, 96);
            this._saveSettingButton.Name = "_saveSettingButton";
            this._saveSettingButton.Size = new System.Drawing.Size(113, 23);
            this._saveSettingButton.TabIndex = 4;
            this._saveSettingButton.Text = "Save Setting";
            this._saveSettingButton.UseSelectable = true;
            this._saveSettingButton.Click += new System.EventHandler(this._saveSettingButton_Click);
            // 
            // _browseSettingButton
            // 
            this._browseSettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._browseSettingButton.Location = new System.Drawing.Point(765, 67);
            this._browseSettingButton.Name = "_browseSettingButton";
            this._browseSettingButton.Size = new System.Drawing.Size(41, 23);
            this._browseSettingButton.TabIndex = 3;
            this._browseSettingButton.Text = "...";
            this._browseSettingButton.UseSelectable = true;
            this._browseSettingButton.Click += new System.EventHandler(this._browseSettingButton_Click);
            // 
            // _libSettingDirectory
            // 
            this._libSettingDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this._libSettingDirectory.CustomButton.Image = null;
            this._libSettingDirectory.CustomButton.Location = new System.Drawing.Point(725, 1);
            this._libSettingDirectory.CustomButton.Name = "";
            this._libSettingDirectory.CustomButton.Size = new System.Drawing.Size(21, 21);
            this._libSettingDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._libSettingDirectory.CustomButton.TabIndex = 1;
            this._libSettingDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._libSettingDirectory.CustomButton.UseSelectable = true;
            this._libSettingDirectory.CustomButton.Visible = false;
            this._libSettingDirectory.Lines = new string[] {
        "metroTextBox1"};
            this._libSettingDirectory.Location = new System.Drawing.Point(12, 67);
            this._libSettingDirectory.MaxLength = 32767;
            this._libSettingDirectory.Name = "_libSettingDirectory";
            this._libSettingDirectory.PasswordChar = '\0';
            this._libSettingDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._libSettingDirectory.SelectedText = "";
            this._libSettingDirectory.SelectionLength = 0;
            this._libSettingDirectory.SelectionStart = 0;
            this._libSettingDirectory.ShortcutsEnabled = true;
            this._libSettingDirectory.Size = new System.Drawing.Size(747, 23);
            this._libSettingDirectory.TabIndex = 2;
            this._libSettingDirectory.Text = "metroTextBox1";
            this._libSettingDirectory.UseSelectable = true;
            this._libSettingDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._libSettingDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // _tabDMCA
            // 
            this._tabDMCA.Controls.Add(this.metroLabel2);
            this._tabDMCA.Controls.Add(this.pictureBox3);
            this._tabDMCA.HorizontalScrollbarBarColor = true;
            this._tabDMCA.HorizontalScrollbarHighlightOnWheel = false;
            this._tabDMCA.HorizontalScrollbarSize = 10;
            this._tabDMCA.Location = new System.Drawing.Point(4, 38);
            this._tabDMCA.Name = "_tabDMCA";
            this._tabDMCA.Size = new System.Drawing.Size(825, 338);
            this._tabDMCA.TabIndex = 3;
            this._tabDMCA.Text = "Disclaimer";
            this._tabDMCA.VerticalScrollbarBarColor = true;
            this._tabDMCA.VerticalScrollbarHighlightOnWheel = false;
            this._tabDMCA.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(379, 23);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(443, 249);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = resources.GetString("metroLabel2.Text");
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox3.Image = global::Nullify.Properties.Resources.MainLogo;
            this.pictureBox3.Location = new System.Drawing.Point(36, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 178);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.pictureBox2);
            this.metroTabPage3.Controls.Add(this._cttynulLabel);
            this.metroTabPage3.Controls.Add(this._licenseLinkLabel);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.pictureBox1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(825, 338);
            this.metroTabPage3.TabIndex = 4;
            this.metroTabPage3.Text = "About";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // _cttynulLabel
            // 
            this._cttynulLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cttynulLabel.Location = new System.Drawing.Point(598, 312);
            this._cttynulLabel.Name = "_cttynulLabel";
            this._cttynulLabel.Size = new System.Drawing.Size(224, 23);
            this._cttynulLabel.TabIndex = 8;
            this._cttynulLabel.Text = "Brought to you by cttynul with love <3";
            this._cttynulLabel.UseSelectable = true;
            this._cttynulLabel.Click += new System.EventHandler(this._cttynulLabel_Click);
            // 
            // _licenseLinkLabel
            // 
            this._licenseLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._licenseLinkLabel.Location = new System.Drawing.Point(615, 294);
            this._licenseLinkLabel.Name = "_licenseLinkLabel";
            this._licenseLinkLabel.Size = new System.Drawing.Size(207, 23);
            this._licenseLinkLabel.TabIndex = 7;
            this._licenseLinkLabel.Text = "Published under Apache License 2.0";
            this._licenseLinkLabel.UseSelectable = true;
            this._licenseLinkLabel.Click += new System.EventHandler(this._licenseLinkLabel_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(161, 95);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(509, 137);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = resources.GetString("metroLabel3.Text");
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Nullify.Properties.Resources.DonatePaypal;
            this.pictureBox1.Location = new System.Drawing.Point(334, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 60);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _songName
            // 
            this._songName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._songName.AutoSize = true;
            this._songName.Location = new System.Drawing.Point(130, 449);
            this._songName.Name = "_songName";
            this._songName.Size = new System.Drawing.Size(136, 19);
            this._songName.TabIndex = 18;
            this._songName.Text = "Now Playing: Nothing";
            // 
            // _minuteLabel
            // 
            this._minuteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._minuteLabel.AutoSize = true;
            this._minuteLabel.Location = new System.Drawing.Point(130, 468);
            this._minuteLabel.Name = "_minuteLabel";
            this._minuteLabel.Size = new System.Drawing.Size(117, 19);
            this._minuteLabel.TabIndex = 19;
            this._minuteLabel.Text = "                           ";
            // 
            // _progressBar
            // 
            this._progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._progressBar.FontSize = MetroFramework.MetroProgressBarSize.Small;
            this._progressBar.Location = new System.Drawing.Point(185, 548);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(532, 10);
            this._progressBar.Style = MetroFramework.MetroColorStyle.Silver;
            this._progressBar.TabIndex = 24;
            // 
            // _timer
            // 
            this._timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _downloadButton
            // 
            this._downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._downloadButton.Image = global::Nullify.Properties.Resources.cloud_computing;
            this._downloadButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._downloadButton.ImageSize = 32;
            this._downloadButton.Location = new System.Drawing.Point(740, 497);
            this._downloadButton.Name = "_downloadButton";
            this._downloadButton.Size = new System.Drawing.Size(135, 37);
            this._downloadButton.TabIndex = 26;
            this._downloadButton.Text = "Download";
            this._downloadButton.UseSelectable = true;
            this._downloadButton.Click += new System.EventHandler(this._downloadButton_Click);
            // 
            // _lyricsButton
            // 
            this._lyricsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lyricsButton.Image = global::Nullify.Properties.Resources.lyrics;
            this._lyricsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lyricsButton.ImageSize = 32;
            this._lyricsButton.Location = new System.Drawing.Point(765, 497);
            this._lyricsButton.Name = "_lyricsButton";
            this._lyricsButton.Size = new System.Drawing.Size(110, 37);
            this._lyricsButton.TabIndex = 25;
            this._lyricsButton.Text = "Lyrics";
            this._lyricsButton.UseSelectable = true;
            this._lyricsButton.Click += new System.EventHandler(this._lyricsButton_Click);
            // 
            // _metroVolUp
            // 
            this._metroVolUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._metroVolUp.Image = global::Nullify.Properties.Resources.speakerpiu;
            this._metroVolUp.ImageSize = 32;
            this._metroVolUp.Location = new System.Drawing.Point(500, 497);
            this._metroVolUp.Name = "_metroVolUp";
            this._metroVolUp.Size = new System.Drawing.Size(45, 45);
            this._metroVolUp.TabIndex = 23;
            this._metroVolUp.UseSelectable = true;
            this._metroVolUp.Click += new System.EventHandler(this._volumeUP_Click);
            // 
            // _metroVolDown
            // 
            this._metroVolDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._metroVolDown.Image = global::Nullify.Properties.Resources.speakermeno;
            this._metroVolDown.ImageSize = 32;
            this._metroVolDown.Location = new System.Drawing.Point(347, 497);
            this._metroVolDown.Name = "_metroVolDown";
            this._metroVolDown.Size = new System.Drawing.Size(45, 45);
            this._metroVolDown.TabIndex = 22;
            this._metroVolDown.UseSelectable = true;
            this._metroVolDown.Click += new System.EventHandler(this._volumeDown_Click);
            // 
            // _metroStopButton
            // 
            this._metroStopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._metroStopButton.Image = global::Nullify.Properties.Resources.stop;
            this._metroStopButton.ImageSize = 42;
            this._metroStopButton.Location = new System.Drawing.Point(449, 497);
            this._metroStopButton.Name = "_metroStopButton";
            this._metroStopButton.Size = new System.Drawing.Size(45, 45);
            this._metroStopButton.TabIndex = 21;
            this._metroStopButton.UseSelectable = true;
            this._metroStopButton.Click += new System.EventHandler(this._toolStripStopButton_Click);
            // 
            // _metroPlayButton
            // 
            this._metroPlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._metroPlayButton.Image = ((System.Drawing.Image)(resources.GetObject("_metroPlayButton.Image")));
            this._metroPlayButton.ImageSize = 42;
            this._metroPlayButton.Location = new System.Drawing.Point(398, 497);
            this._metroPlayButton.Name = "_metroPlayButton";
            this._metroPlayButton.Size = new System.Drawing.Size(45, 45);
            this._metroPlayButton.TabIndex = 20;
            this._metroPlayButton.UseSelectable = true;
            this._metroPlayButton.Click += new System.EventHandler(this._toolStripPlayButton_Click);
            // 
            // _albumPic
            // 
            this._albumPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._albumPic.Image = global::Nullify.Properties.Resources.no_album_art;
            this._albumPic.Location = new System.Drawing.Point(24, 449);
            this._albumPic.Name = "_albumPic";
            this._albumPic.Size = new System.Drawing.Size(100, 100);
            this._albumPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._albumPic.TabIndex = 5;
            this._albumPic.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Image = global::Nullify.Properties.Resources.cttynullogo;
            this.pictureBox2.Location = new System.Drawing.Point(250, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 78);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            this.albumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // albumPicDataGridViewImageColumn
            // 
            this.albumPicDataGridViewImageColumn.DataPropertyName = "AlbumPic";
            this.albumPicDataGridViewImageColumn.FillWeight = 200F;
            this.albumPicDataGridViewImageColumn.HeaderText = "AlbumPic";
            this.albumPicDataGridViewImageColumn.Name = "albumPicDataGridViewImageColumn";
            this.albumPicDataGridViewImageColumn.ReadOnly = true;
            this.albumPicDataGridViewImageColumn.Visible = false;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Visible = false;
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataSource = typeof(Nullify.LibraryItem);
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn1
            // 
            this.urlDataGridViewTextBoxColumn1.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn1.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn1.Name = "urlDataGridViewTextBoxColumn1";
            this.urlDataGridViewTextBoxColumn1.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn1.Visible = false;
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            this.authorDataGridViewTextBoxColumn1.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn1.Visible = false;
            // 
            // albumPicDataGridViewImageColumn1
            // 
            this.albumPicDataGridViewImageColumn1.DataPropertyName = "AlbumPic";
            this.albumPicDataGridViewImageColumn1.HeaderText = "AlbumPic";
            this.albumPicDataGridViewImageColumn1.Name = "albumPicDataGridViewImageColumn1";
            this.albumPicDataGridViewImageColumn1.ReadOnly = true;
            this.albumPicDataGridViewImageColumn1.Visible = false;
            // 
            // yearDataGridViewTextBoxColumn1
            // 
            this.yearDataGridViewTextBoxColumn1.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn1.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn1.Name = "yearDataGridViewTextBoxColumn1";
            this.yearDataGridViewTextBoxColumn1.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn1.Visible = false;
            // 
            // genreDataGridViewTextBoxColumn1
            // 
            this.genreDataGridViewTextBoxColumn1.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn1.Name = "genreDataGridViewTextBoxColumn1";
            this.genreDataGridViewTextBoxColumn1.ReadOnly = true;
            this.genreDataGridViewTextBoxColumn1.Visible = false;
            // 
            // albumDataGridViewTextBoxColumn1
            // 
            this.albumDataGridViewTextBoxColumn1.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn1.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn1.Name = "albumDataGridViewTextBoxColumn1";
            this.albumDataGridViewTextBoxColumn1.ReadOnly = true;
            this.albumDataGridViewTextBoxColumn1.Visible = false;
            // 
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(Nullify.Song);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 572);
            this.Controls.Add(this._downloadButton);
            this.Controls.Add(this._lyricsButton);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this._metroVolUp);
            this.Controls.Add(this._metroVolDown);
            this.Controls.Add(this._metroStopButton);
            this.Controls.Add(this._metroPlayButton);
            this.Controls.Add(this._minuteLabel);
            this.Controls.Add(this._songName);
            this.Controls.Add(this._tab);
            this.Controls.Add(this._albumPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(876, 572);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Nullify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this._tabDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGrid)).EndInit();
            this._ContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._vlcWrapper)).EndInit();
            this._tabPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPlayer)).EndInit();
            this._libraryContextMenu.ResumeLayout(false);
            this._tab.ResumeLayout(false);
            this._tabSetting.ResumeLayout(false);
            this._tabSetting.PerformLayout();
            this._tabDMCA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource songBindingSource;
        private AxWMPLib.AxWindowsMediaPlayer _vlcWrapper;
        private System.Windows.Forms.PictureBox _albumPic;
        private System.Windows.Forms.TabPage _tabDownload;
        private System.Windows.Forms.TabPage _tabPlayer;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private MetroFramework.Controls.MetroTabControl _tab;
        private MetroFramework.Controls.MetroTextBox _searchTextBox;
        private MetroFramework.Controls.MetroGrid _resultDataGrid;
        private MetroFramework.Controls.MetroButton _searchButton;
        private MetroFramework.Controls.MetroContextMenu _ContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn albumPicDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroGrid _dataGridPlayer;
        private MetroFramework.Controls.MetroContextMenu _libraryContextMenu;
        private System.Windows.Forms.ToolStripMenuItem updateLibraryToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage _tabSetting;
        private MetroFramework.Controls.MetroTabPage _tabDMCA;
        private MetroFramework.Controls.MetroButton _saveSettingButton;
        private MetroFramework.Controls.MetroButton _browseSettingButton;
        private MetroFramework.Controls.MetroTextBox _libSettingDirectory;
        private MetroFramework.Controls.MetroLabel _songName;
        private MetroFramework.Controls.MetroLabel _minuteLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink _metroPlayButton;
        private MetroFramework.Controls.MetroLink _metroStopButton;
        private MetroFramework.Controls.MetroLink _metroVolDown;
        private MetroFramework.Controls.MetroLink _metroVolUp;
        private MetroFramework.Controls.MetroProgressBar _progressBar;
        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLink _lyricsButton;
        private MetroFramework.Controls.MetroLink _downloadButton;
        private MetroFramework.Controls.MetroCheckBox _checkBoxDirDef;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLink _licenseLinkLabel;
        private MetroFramework.Controls.MetroLink _cttynulLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn albumPicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

