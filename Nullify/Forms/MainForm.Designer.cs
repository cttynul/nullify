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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._resultDataGrid = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this._searchButton = new System.Windows.Forms.Button();
            this._songName = new System.Windows.Forms.Label();
            this._minuteLabel = new System.Windows.Forms.Label();
            this._downloadButton = new System.Windows.Forms.Button();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._toolStripButtonDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._toolStripVolUpButton = new System.Windows.Forms.ToolStripButton();
            this._toolStripVolDownButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._toolStripPlayButton = new System.Windows.Forms.ToolStripButton();
            this._toolStripStopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tab = new System.Windows.Forms.TabControl();
            this._tabDownload = new System.Windows.Forms.TabPage();
            this._vlcWrapper = new AxWMPLib.AxWindowsMediaPlayer();
            this._tabPlayer = new System.Windows.Forms.TabPage();
            this._dataGridPlayer = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._checkBoxDirDef = new System.Windows.Forms.CheckBox();
            this._lyricsButton = new System.Windows.Forms.Button();
            this._albumPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGrid)).BeginInit();
            this._contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).BeginInit();
            this._toolStrip.SuspendLayout();
            this._tab.SuspendLayout();
            this._tabDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._vlcWrapper)).BeginInit();
            this._tabPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumPic)).BeginInit();
            this.SuspendLayout();
            // 
            // _resultDataGrid
            // 
            this._resultDataGrid.AllowUserToAddRows = false;
            this._resultDataGrid.AllowUserToDeleteRows = false;
            this._resultDataGrid.AllowUserToOrderColumns = true;
            this._resultDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._resultDataGrid.AutoGenerateColumns = false;
            this._resultDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._resultDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._resultDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._resultDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.Duration,
            this.Url});
            this._resultDataGrid.ContextMenuStrip = this._contextMenuStrip;
            this._resultDataGrid.DataSource = this.songBindingSource;
            this._resultDataGrid.GridColor = System.Drawing.SystemColors.ControlLight;
            this._resultDataGrid.Location = new System.Drawing.Point(3, 36);
            this._resultDataGrid.MultiSelect = false;
            this._resultDataGrid.Name = "_resultDataGrid";
            this._resultDataGrid.ShowEditingIcon = false;
            this._resultDataGrid.Size = new System.Drawing.Size(643, 322);
            this._resultDataGrid.TabIndex = 3;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Duration.DataPropertyName = "Duration";
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.Visible = false;
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.downloadToolStripMenuItem});
            this._contextMenuStrip.Name = "_contextMenuStrip";
            this._contextMenuStrip.Size = new System.Drawing.Size(129, 48);
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
            // songBindingSource
            // 
            this.songBindingSource.DataSource = typeof(Nullify.Song);
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchTextBox.Location = new System.Drawing.Point(6, 10);
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(556, 21);
            this._searchTextBox.TabIndex = 1;
            // 
            // _searchButton
            // 
            this._searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._searchButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._searchButton.Location = new System.Drawing.Point(568, 8);
            this._searchButton.Name = "_searchButton";
            this._searchButton.Size = new System.Drawing.Size(75, 23);
            this._searchButton.TabIndex = 2;
            this._searchButton.Text = "Search";
            this._searchButton.UseVisualStyleBackColor = true;
            this._searchButton.Click += new System.EventHandler(this._searchButton_Click);
            // 
            // _songName
            // 
            this._songName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._songName.AutoSize = true;
            this._songName.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._songName.Location = new System.Drawing.Point(109, 406);
            this._songName.Name = "_songName";
            this._songName.Size = new System.Drawing.Size(128, 15);
            this._songName.TabIndex = 7;
            this._songName.Text = "Now Playing: Nothing";
            // 
            // _minuteLabel
            // 
            this._minuteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._minuteLabel.AutoSize = true;
            this._minuteLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._minuteLabel.Location = new System.Drawing.Point(109, 421);
            this._minuteLabel.Name = "_minuteLabel";
            this._minuteLabel.Size = new System.Drawing.Size(0, 15);
            this._minuteLabel.TabIndex = 8;
            // 
            // _downloadButton
            // 
            this._downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._downloadButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._downloadButton.Location = new System.Drawing.Point(594, 431);
            this._downloadButton.Name = "_downloadButton";
            this._downloadButton.Size = new System.Drawing.Size(75, 23);
            this._downloadButton.TabIndex = 10;
            this._downloadButton.Text = "Download";
            this._downloadButton.UseVisualStyleBackColor = true;
            this._downloadButton.Click += new System.EventHandler(this._downloadButton_Click);
            // 
            // _toolStrip
            // 
            this._toolStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this._toolStrip.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripButtonDownload,
            this.toolStripProgressBar1,
            this.toolStripSeparator3,
            this._toolStripVolUpButton,
            this._toolStripVolDownButton,
            this.toolStripSeparator2,
            this._toolStripPlayButton,
            this._toolStripStopButton,
            this.toolStripDropDownButton1,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripDropDownButton2});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(681, 25);
            this._toolStrip.TabIndex = 14;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _toolStripButtonDownload
            // 
            this._toolStripButtonDownload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripButtonDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._toolStripButtonDownload.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._toolStripButtonDownload.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripButtonDownload.Image")));
            this._toolStripButtonDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripButtonDownload.Name = "_toolStripButtonDownload";
            this._toolStripButtonDownload.Size = new System.Drawing.Size(67, 22);
            this._toolStripButtonDownload.Text = "&Download";
            this._toolStripButtonDownload.Click += new System.EventHandler(this._toolStripButtonDownload_Click);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // _toolStripVolUpButton
            // 
            this._toolStripVolUpButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripVolUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripVolUpButton.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripVolUpButton.Image")));
            this._toolStripVolUpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripVolUpButton.Name = "_toolStripVolUpButton";
            this._toolStripVolUpButton.Size = new System.Drawing.Size(23, 22);
            this._toolStripVolUpButton.Text = "Volume Up";
            this._toolStripVolUpButton.Click += new System.EventHandler(this._toolStripVolUpButton_Click);
            // 
            // _toolStripVolDownButton
            // 
            this._toolStripVolDownButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripVolDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripVolDownButton.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripVolDownButton.Image")));
            this._toolStripVolDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripVolDownButton.Name = "_toolStripVolDownButton";
            this._toolStripVolDownButton.Size = new System.Drawing.Size(23, 22);
            this._toolStripVolDownButton.Text = "Volume Down";
            this._toolStripVolDownButton.Click += new System.EventHandler(this._toolStripVolDownButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // _toolStripPlayButton
            // 
            this._toolStripPlayButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripPlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripPlayButton.Image = global::Nullify.Properties.Resources.play_pause24x24;
            this._toolStripPlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripPlayButton.Name = "_toolStripPlayButton";
            this._toolStripPlayButton.Size = new System.Drawing.Size(23, 22);
            this._toolStripPlayButton.Text = "Play/Pause";
            this._toolStripPlayButton.Click += new System.EventHandler(this._toolStripPlayButton_Click);
            // 
            // _toolStripStopButton
            // 
            this._toolStripStopButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._toolStripStopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolStripStopButton.Image = global::Nullify.Properties.Resources.stop_24x24;
            this._toolStripStopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolStripStopButton.Name = "_toolStripStopButton";
            this._toolStripStopButton.Size = new System.Drawing.Size(23, 22);
            this._toolStripStopButton.Text = "Stop";
            this._toolStripStopButton.Click += new System.EventHandler(this._toolStripStopButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripDropDownButton1.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton1.Text = "Library &Settings";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(71, 22);
            this.toolStripButton2.Text = "&Disclaimer";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem,
            this.aboutDeveloperToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton2.Text = "&About";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // aboutDeveloperToolStripMenuItem
            // 
            this.aboutDeveloperToolStripMenuItem.Name = "aboutDeveloperToolStripMenuItem";
            this.aboutDeveloperToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutDeveloperToolStripMenuItem.Text = "About Developer";
            this.aboutDeveloperToolStripMenuItem.Click += new System.EventHandler(this.aboutDeveloperToolStripMenuItem_Click);
            // 
            // _tab
            // 
            this._tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tab.Controls.Add(this._tabDownload);
            this._tab.Controls.Add(this._tabPlayer);
            this._tab.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tab.Location = new System.Drawing.Point(12, 29);
            this._tab.Multiline = true;
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(657, 362);
            this._tab.TabIndex = 15;
            // 
            // _tabDownload
            // 
            this._tabDownload.Controls.Add(this._resultDataGrid);
            this._tabDownload.Controls.Add(this._vlcWrapper);
            this._tabDownload.Controls.Add(this._searchButton);
            this._tabDownload.Controls.Add(this._searchTextBox);
            this._tabDownload.Location = new System.Drawing.Point(4, 24);
            this._tabDownload.Name = "_tabDownload";
            this._tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this._tabDownload.Size = new System.Drawing.Size(649, 334);
            this._tabDownload.TabIndex = 0;
            this._tabDownload.Text = "Download";
            this._tabDownload.UseVisualStyleBackColor = true;
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
            this._tabPlayer.Location = new System.Drawing.Point(4, 24);
            this._tabPlayer.Name = "_tabPlayer";
            this._tabPlayer.Padding = new System.Windows.Forms.Padding(3);
            this._tabPlayer.Size = new System.Drawing.Size(649, 334);
            this._tabPlayer.TabIndex = 1;
            this._tabPlayer.Text = "Player";
            this._tabPlayer.UseVisualStyleBackColor = true;
            // 
            // _dataGridPlayer
            // 
            this._dataGridPlayer.AllowUserToAddRows = false;
            this._dataGridPlayer.AllowUserToDeleteRows = false;
            this._dataGridPlayer.AllowUserToOrderColumns = true;
            this._dataGridPlayer.AutoGenerateColumns = false;
            this._dataGridPlayer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this._dataGridPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.authorDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.albumPicDataGridViewImageColumn,
            this.urlDataGridViewTextBoxColumn});
            this._dataGridPlayer.DataSource = this.libraryBindingSource;
            this._dataGridPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridPlayer.Location = new System.Drawing.Point(3, 3);
            this._dataGridPlayer.Name = "_dataGridPlayer";
            this._dataGridPlayer.ReadOnly = true;
            this._dataGridPlayer.Size = new System.Drawing.Size(643, 328);
            this._dataGridPlayer.TabIndex = 0;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.albumPicDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.albumPicDataGridViewImageColumn.DataPropertyName = "AlbumPic";
            this.albumPicDataGridViewImageColumn.HeaderText = "AlbumPic";
            this.albumPicDataGridViewImageColumn.Name = "albumPicDataGridViewImageColumn";
            this.albumPicDataGridViewImageColumn.ReadOnly = true;
            this.albumPicDataGridViewImageColumn.Visible = false;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // _checkBoxDirDef
            // 
            this._checkBoxDirDef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._checkBoxDirDef.AutoSize = true;
            this._checkBoxDirDef.Checked = true;
            this._checkBoxDirDef.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkBoxDirDef.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._checkBoxDirDef.Location = new System.Drawing.Point(477, 460);
            this._checkBoxDirDef.Name = "_checkBoxDirDef";
            this._checkBoxDirDef.Size = new System.Drawing.Size(192, 19);
            this._checkBoxDirDef.TabIndex = 16;
            this._checkBoxDirDef.Text = "Download in library directory";
            this._checkBoxDirDef.UseVisualStyleBackColor = true;
            // 
            // _lyricsButton
            // 
            this._lyricsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lyricsButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lyricsButton.Location = new System.Drawing.Point(594, 456);
            this._lyricsButton.Name = "_lyricsButton";
            this._lyricsButton.Size = new System.Drawing.Size(75, 23);
            this._lyricsButton.TabIndex = 5;
            this._lyricsButton.Text = "Lyrics";
            this._lyricsButton.UseVisualStyleBackColor = true;
            this._lyricsButton.Visible = false;
            this._lyricsButton.Click += new System.EventHandler(this._lyricsButton_Click);
            // 
            // _albumPic
            // 
            this._albumPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._albumPic.Image = global::Nullify.Properties.Resources.no_album_art;
            this._albumPic.Location = new System.Drawing.Point(23, 406);
            this._albumPic.Name = "_albumPic";
            this._albumPic.Size = new System.Drawing.Size(80, 80);
            this._albumPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._albumPic.TabIndex = 5;
            this._albumPic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(681, 496);
            this.Controls.Add(this._lyricsButton);
            this.Controls.Add(this._checkBoxDirDef);
            this.Controls.Add(this._tab);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._downloadButton);
            this.Controls.Add(this._minuteLabel);
            this.Controls.Add(this._songName);
            this.Controls.Add(this._albumPic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Nullify Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._resultDataGrid)).EndInit();
            this._contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songBindingSource)).EndInit();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._tab.ResumeLayout(false);
            this._tabDownload.ResumeLayout(false);
            this._tabDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._vlcWrapper)).EndInit();
            this._tabPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._albumPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _resultDataGrid;
        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.Button _searchButton;
        private System.Windows.Forms.BindingSource songBindingSource;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private AxWMPLib.AxWindowsMediaPlayer _vlcWrapper;
        private System.Windows.Forms.PictureBox _albumPic;
        private System.Windows.Forms.Label _songName;
        private System.Windows.Forms.Label _minuteLabel;
        private System.Windows.Forms.Button _downloadButton;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _toolStripButtonDownload;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton _toolStripVolUpButton;
        private System.Windows.Forms.ToolStripButton _toolStripVolDownButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton _toolStripPlayButton;
        private System.Windows.Forms.ToolStripButton _toolStripStopButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage _tabDownload;
        private System.Windows.Forms.TabPage _tabPlayer;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.CheckBox _checkBoxDirDef;
        private System.Windows.Forms.DataGridView _dataGridPlayer;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private System.Windows.Forms.Button _lyricsButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn albumPicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}

