using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;
using YoutubeExtractor;
using MediaToolkit;
using MediaToolkit.Model;
using Id3;
using TagLib;
using Nullify.Forms;

// Copyright 2017 (C) cttynul
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Nullify
{
    public partial class MainForm : Form
    {
        private string directoryPath = "";

        public MainForm()
        {
            // datagrid.rows.clear to clean datagrid
            InitializeComponent();
            this.AcceptButton = _searchButton;
            _tab.SelectedIndexChanged += new EventHandler(_tab_SelectedIndexChanged);

    }

        private void _tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_tab.SelectedTab == _tab.TabPages["_tabPlayer"])
            {
                _checkBoxDirDef.Visible = false;
                _downloadButton.Visible = false;
                _toolStripButtonDownload.Enabled = false;
                _lyricsButton.Visible = true;
            }
            else
            {
                _checkBoxDirDef.Visible = true;
                _downloadButton.Visible = true;
                _toolStripButtonDownload.Enabled = true;
                _lyricsButton.Visible = false;
            }
        }

        private void _searchButton_Click(object sender, EventArgs e)
        {
            VideoSearch _items = new VideoSearch();
            List<Song> _songList = new List<Song>();
            try
            {
                foreach (var item in _items.SearchQuery(_searchTextBox.Text, 2))
                {
                    Song _song = new Song();
                    _song.Title = item.Title;
                    _song.Author = item.Author;
                    _song.Duration = item.Duration;
                    _song.Url = item.Url;
                    // Thumb not used anymore
                    //byte[] _imagesBytes = new WebClient().DownloadData(item.Thumbnail);
                    //using (MemoryStream ms = new MemoryStream(_imagesBytes))
                    //{
                    //    _song.Thumb = Image.FromStream(ms);
                    //}
                    _songList.Add(_song);
                }
                songBindingSource.DataSource = _songList;
            }
            catch (Exception NoConnection)
            {
                MessageBox.Show("You're not connected to THE INTERNET, or Youtube stopped working, maybe the answer is the first one!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_resultDataGrid.SelectedCells.Count > 0)
            {
                if (_vlcWrapper.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    _vlcWrapper.Ctlcontrols.stop();
                    _vlcWrapper.URL = "";

                }
                int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                // Cells 2 = URL
                string _toPlay = Convert.ToString(selectedRow.Cells[2].Value);
                WebClient _webWrapper = new WebClient();
                // Debug
                //MessageBox.Show(_toPlay, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toPlay);
                string downloadDir = "C:\\Temp\\TempMp3.mp3";
                if (System.IO.File.Exists(downloadDir))
                {
                    System.IO.File.Delete(downloadDir);

                }
                else
                {
                    //do nothing

                }

                _webWrapper.DownloadFileAsync(url, downloadDir);
                _webWrapper.DownloadFileCompleted += StreamSong;

            }
        }

        private void downloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_resultDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                // Cells 2 = URL
                string _toDownload = Convert.ToString(selectedRow.Cells[2].Value);
                // Debug
                //MessageBox.Show(_toDownload, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FolderBrowserDialog dir = new FolderBrowserDialog();
                WebClient _webWrapper = new WebClient();
                string _title = Convert.ToString(selectedRow.Cells[0].Value);

                if (_checkBoxDirDef.Checked)
                {
                    directoryPath = Properties.Settings.Default._settingDownloadDir;
                }
                else
                {
                    if (dir.ShowDialog() == DialogResult.OK)
                    {
                        directoryPath = dir.SelectedPath + "//";
                    }
                }


                string downloadDir = directoryPath;

                if (!Directory.Exists(downloadDir))
                    Directory.CreateDirectory(downloadDir);
                Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toDownload);
                _webWrapper.DownloadFileAsync(url, downloadDir + _title + ".mp3");

                _webWrapper.DownloadFileCompleted += DownloadedYeah;

                //Mp3File file = new Mp3File(toedit);
                //Id3Tag idbit = new Id3Tag();
                //idbit = file.GetTag(Id3TagFamily.FileStartTag);
                //idbit.BeatsPerMinute.AsInt = 320;
                //file.WriteTag(idbit, Id3.WriteConflictAction.Replace);

                // QUI CI SONO LE COSE PER I TAG BELLI
                //System.Threading.Thread.Sleep(8000);
                //string toedit = downloadDir + _title + ".mp3";
                //TagLib.File taggedfile = TagLib.File.Create(toedit);
                //taggedfile.Tag.Album = "VincoIo";
                //taggedfile.Save();

            }

        }

        private void DownloadedYeah(object sender, AsyncCompletedEventArgs e)
        {
            if (_checkBoxDirDef.Checked)
            {
                MessageBox.Show("Your Mp3 has been downloaded in your library directory " + Properties.Settings.Default._settingDownloadDir, "Oh yeah!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _dataGridPlayer.Rows.Clear();
                PopulatePlayer();
            }
            else
            {
                MessageBox.Show("Your Mp3 has been downloaded!", "Oh yeah!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void StreamSong(object sender, AsyncCompletedEventArgs e)
        {
            _vlcWrapper.URL = "C:\\Temp\\TempMp3.mp3";
            _vlcWrapper.Ctlcontrols.play();

            try
            {
                TagLib.File taggedfile = TagLib.File.Create("C:\\Temp\\TempMp3.mp3");
                _songName.Text = "Now Playing:" + " " + taggedfile.Tag.JoinedPerformers.ToString() + " - " + taggedfile.Tag.Title.ToString() + " From: " + taggedfile.Tag.Album.ToString();

                try
                {
                    var bin = (byte[])taggedfile.Tag.Pictures[0].Data.Data;
                    _albumPic.Image = ByteToImage(bin);
                }
                catch
                {
                    _albumPic.Image = Nullify.Properties.Resources.no_album_art;
                }

                try
                {
                    _minuteLabel.Text = "Genre(s): " + taggedfile.Tag.JoinedGenres.ToString() + "; Year: " + taggedfile.Tag.Year.ToString();
                }
                catch
                {
                    _minuteLabel.Text = "";
                }

            }
            catch
            {
                _songName.Text = "Now Playing: No Info";
            }
            //taggedfile.Save();
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private void _playButton_Click(object sender, EventArgs e)
        {
            if (_vlcWrapper.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                _vlcWrapper.Ctlcontrols.pause();
            }
            else
            {
                if (_resultDataGrid.SelectedCells.Count > 0)
                {
                    if (_vlcWrapper.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        _vlcWrapper.Ctlcontrols.stop();
                        _vlcWrapper.URL = "";

                    }
                    int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                    // Cells 2 = URL
                    string _toPlay = Convert.ToString(selectedRow.Cells[2].Value);
                    WebClient _webWrapper = new WebClient();
                    // Debug
                    //MessageBox.Show(_toPlay, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toPlay);
                    string downloadDir = "C:\\Temp\\TempMp3.mp3";
                    if (System.IO.File.Exists(downloadDir))
                    {
                        System.IO.File.Delete(downloadDir);

                    }
                    else
                    {
                        //do nothing

                    }

                    _webWrapper.DownloadFileAsync(url, downloadDir);
                    _webWrapper.DownloadFileCompleted += StreamSong;
                }
                else
                {
                    try
                    {
                        _vlcWrapper.Ctlcontrols.play();

                    }
                    catch
                    {
                        // do nothing
                    }
                }

            }
        }

        private void _stopButton_Click(object sender, EventArgs e)
        {
            _vlcWrapper.Ctlcontrols.stop();
        }

        private void _toolStripPlayButton_Click(object sender, EventArgs e)
        {
            if (_tab.SelectedTab == _tab.TabPages["_tabDownload"])
            {
                if (_vlcWrapper.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    _vlcWrapper.Ctlcontrols.pause();
                }
                else
                {
                    if (_resultDataGrid.SelectedCells.Count > 0)
                    {
                        if (_vlcWrapper.playState == WMPLib.WMPPlayState.wmppsPlaying)
                        {
                            _vlcWrapper.Ctlcontrols.stop();
                            _vlcWrapper.URL = "";

                        }
                        int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                        DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                        // Cells 2 = URL
                        string _toPlay = Convert.ToString(selectedRow.Cells[2].Value);
                        WebClient _webWrapper = new WebClient();
                        // Debug
                        //MessageBox.Show(_toPlay, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toPlay);
                        string downloadDir = "C:\\Temp\\TempMp3.mp3";
                        if (System.IO.File.Exists(downloadDir))
                        {
                            System.IO.File.Delete(downloadDir);

                        }
                        else
                        {
                            //do nothing

                        }

                        _webWrapper.DownloadFileAsync(url, downloadDir);
                        _webWrapper.DownloadFileCompleted += StreamSong;
                    }
                    else
                    {
                        try
                        {
                            _vlcWrapper.Ctlcontrols.play();

                        }
                        catch
                        {
                            // do nothing
                        }
                    }

                }
            }
            else
            {
                // Play da libreria
                PlaySong();
            }

        }

        private void _toolStripStopButton_Click(object sender, EventArgs e)
        {
            _vlcWrapper.Ctlcontrols.stop();
            _songName.Text = "Now Playing: Nothing";
            _albumPic.Image = Nullify.Properties.Resources.no_album_art;
            _minuteLabel.Text = "";
        }

        private void _toolStripButtonDownload_Click(object sender, EventArgs e)
        {
            if (_resultDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                // Cells 2 = URL
                string _toDownload = Convert.ToString(selectedRow.Cells[2].Value);
                // Debug
                //MessageBox.Show(_toDownload, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FolderBrowserDialog dir = new FolderBrowserDialog();
                WebClient _webWrapper = new WebClient();
                string _title = Convert.ToString(selectedRow.Cells[0].Value);

                if (_checkBoxDirDef.Checked)
                {
                    directoryPath = Properties.Settings.Default._settingDownloadDir;
                }
                else
                {
                    if (dir.ShowDialog() == DialogResult.OK)
                    {
                        directoryPath = dir.SelectedPath + "//";
                    }
                }

                string downloadDir = directoryPath;
                if (!Directory.Exists(downloadDir))
                    Directory.CreateDirectory(downloadDir);
                Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toDownload);
                _webWrapper.DownloadFileAsync(url, downloadDir + _title + ".mp3");

                _webWrapper.DownloadFileCompleted += DownloadedYeah;

                //Mp3File file = new Mp3File(toedit);
                //Id3Tag idbit = new Id3Tag();
                //idbit = file.GetTag(Id3TagFamily.FileStartTag);
                //idbit.BeatsPerMinute.AsInt = 320;
                //file.WriteTag(idbit, Id3.WriteConflictAction.Replace);

                // QUI CI SONO LE COSE PER I TAG BELLI
                //System.Threading.Thread.Sleep(8000);
                //string toedit = downloadDir + _title + ".mp3";
                //TagLib.File taggedfile = TagLib.File.Create(toedit);
                //taggedfile.Tag.Album = "VincoIo";
                //taggedfile.Save();

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DirSetting dirForm = new DirSetting();
            dirForm.ShowDialog();
        }

        public void PopulatePlayer()
        {
            string _librarydir = Properties.Settings.Default._settingDownloadDir;
            //_dataGridPlayer.DataSource = new System.IO.DirectoryInfo(_librarydir);
            string[] _libraryFiles = Directory.GetFiles(_librarydir);


            List<LibraryItem> _librarySongs = new List<LibraryItem>();

            foreach (var item in _libraryFiles)
            {
                if (item.EndsWith(".mp3"))
                {
                    LibraryItem _librarySong = new LibraryItem();
                    TagLib.File taggedfile = TagLib.File.Create(item);

                    _librarySong.Author = taggedfile.Tag.JoinedPerformers.ToString();
                    if (_librarySong.Author == "")
                    {
                        _librarySong.Author = "Unknown";
                    }

                    _librarySong.Title = taggedfile.Tag.Title.ToString();
                    if (_librarySong.Title == "")
                    {
                        _librarySong.Title = "Unknown";
                    }

                    _librarySong.Album = taggedfile.Tag.Album.ToString();
                    if (_librarySong.Album.Contains("youtube.com"))
                    {
                        _librarySong.Album = "Unknown";
                    }

                    try
                    {
                        var bin = (byte[])taggedfile.Tag.Pictures[0].Data.Data;
                        _librarySong.AlbumPic = ByteToImage(bin);
                    }
                    catch
                    {
                        _librarySong.AlbumPic = Nullify.Properties.Resources.no_album_art;
                    }
                    if (taggedfile.Tag.Year.ToString() != "0")
                    {
                        _librarySong.Year = taggedfile.Tag.Year.ToString();
                    }
                    else
                    {
                        _librarySong.Year = "Unknown";
                    }

                    _librarySong.Genre = taggedfile.Tag.JoinedGenres.ToString();

                    if (_librarySong.Genre == "")
                    {
                        _librarySong.Genre = "Unknown";
                    }

                    _librarySong.Url = item;
                    _librarySongs.Add(_librarySong);
                }
                else
                {
                    // jump item
                }
            }


            libraryBindingSource.DataSource = _librarySongs;
        }

        private void PlaySong()
        {
            if (_dataGridPlayer.SelectedCells.Count > 0)
            {
                int selectedrowindex = _dataGridPlayer.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _dataGridPlayer.Rows[selectedrowindex];

                // Cells 2 = URL
                string _toPlay = Convert.ToString(selectedRow.Cells[6].Value);
                _vlcWrapper.URL = _toPlay;
                _vlcWrapper.Ctlcontrols.play();

                try
                {
                    TagLib.File taggedfile = TagLib.File.Create(_toPlay);
                    _songName.Text = "Now Playing:" + " " + taggedfile.Tag.JoinedPerformers.ToString() + " - " + taggedfile.Tag.Title.ToString() + " From: " + taggedfile.Tag.Album.ToString();

                    try
                    {
                        var bin = (byte[])taggedfile.Tag.Pictures[0].Data.Data;
                        _albumPic.Image = ByteToImage(bin);
                    }
                    catch
                    {
                        _albumPic.Image = Nullify.Properties.Resources.no_album_art;
                    }

                    try
                    {
                        _minuteLabel.Text = "Genre(s): " + taggedfile.Tag.JoinedGenres.ToString() + "; Year: " + taggedfile.Tag.Year.ToString();
                    }
                    catch
                    {
                        _minuteLabel.Text = "";
                    }

                }
                catch
                {
                    _songName.Text = "Now Playing: No Info";
                }
                //taggedfile.Save();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default._settingDownloadDir == "")
            {
                
                DisclaimerForm _disForm = new DisclaimerForm();
                _disForm.ShowDialog();
                
            }
            else
            {
                // check for aggiornamentis
                checkForUpdates();

                //populate player
                try
                {
                    PopulatePlayer();
                }
                catch
                {
                    // cant open items
                }


            }
        }

        private void _downloadButton_Click(object sender, EventArgs e)
        {
            if (_resultDataGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = _resultDataGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _resultDataGrid.Rows[selectedrowindex];

                // Cells 2 = URL
                string _toDownload = Convert.ToString(selectedRow.Cells[2].Value);
                // Debug
                //MessageBox.Show(_toDownload, "Name Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                FolderBrowserDialog dir = new FolderBrowserDialog();
                WebClient _webWrapper = new WebClient();
                string _title = Convert.ToString(selectedRow.Cells[0].Value);

                if (_checkBoxDirDef.Checked)
                {
                    directoryPath = Properties.Settings.Default._settingDownloadDir;
                }
                else
                {
                    if (dir.ShowDialog() == DialogResult.OK)
                    {
                        directoryPath = dir.SelectedPath + "//";
                    }
                }

                string downloadDir = directoryPath;
                if (!Directory.Exists(downloadDir))
                    Directory.CreateDirectory(downloadDir);
                Uri url = new Uri("http://www.youtubeinmp3.com/fetch/?video=" + _toDownload);
                _webWrapper.DownloadFileAsync(url, downloadDir + _title + ".mp3");

                _webWrapper.DownloadFileCompleted += DownloadedYeah;

            }
        }

        private void _lyricsButton_Click(object sender, EventArgs e)
        {
            if (_dataGridPlayer.SelectedCells.Count > 0)
            {
                int selectedrowindex = _dataGridPlayer.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = _dataGridPlayer.Rows[selectedrowindex];

                string _songPath = Convert.ToString(selectedRow.Cells[6].Value);
                string _tempString = _songPath.Remove(_songPath.Length - 3);
                string _lyricsPath = _tempString + "txt";

                Form _lyricsForm = new LyricsForm(_lyricsPath);
                _lyricsForm.Show();
                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            License licenseForm = new License();
            licenseForm.ShowDialog();
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDeveloperForm devForm = new AboutDeveloperForm();
            devForm.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DisclaimerForm disForm = new DisclaimerForm();
            disForm.Show();
        }

        private void _toolStripVolUpButton_Click(object sender, EventArgs e)
        {
            if(_vlcWrapper.settings.volume < 90)
            {
                _vlcWrapper.settings.volume = (_vlcWrapper.settings.volume + 10);
            }
        }

        private void _toolStripVolDownButton_Click(object sender, EventArgs e)
        {
            if (_vlcWrapper.settings.volume > 1)
            {
                _vlcWrapper.settings.volume = (_vlcWrapper.settings.volume - (_vlcWrapper.settings.volume / 2));
            }
        }

        private void checkForUpdates()
        {

            try
            {
                int localVersion = 1;
                WebClient _webVersionCheck = new WebClient();
                string remoteVersion = _webVersionCheck.DownloadString("https://raw.githubusercontent.com/cttynul/nullify/master/Nullify/version.txt");

                if (Convert.ToInt32(remoteVersion) > localVersion)
                {
                    DialogResult _wannaUpdate = MessageBox.Show("Seems you're still using version an old Nullify version.\nThe new version has just been released\nDo you wanna update right now?", "There's a new version for you", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (_wannaUpdate == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start("https://sourceforge.net/projects/nullify");
                    }
                }
                else
                {
                    //nothing
                }
            }
            catch
            {
                MessageBox.Show("Cant check for updates :S", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}


