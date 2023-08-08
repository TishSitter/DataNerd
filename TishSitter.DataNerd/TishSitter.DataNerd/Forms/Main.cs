using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using TishSitter.DataNerd.Database;
using TishSitter.DataNerd.Properties;
using TishSitter.DataNerd.Services;

namespace TishSitter.DataNerd.Forms
{
    public partial class Main : Form
    {
        private readonly ResourceManager _resx = Resources.ResourceManager;
        private readonly LogTailer _logTailer = new LogTailer();
        private readonly DbService _dbService = new DbService();
        
        private BlockingCollection<DbQueueObj> _crossThreadQueue = new BlockingCollection<DbQueueObj>();
        
        public Main()
        {
            CheckAndInitialiseFiles();
            InitializeComponent();
        }

        private void CheckAndInitialiseFiles()
        {
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "TishSitter", "DataNerd"));
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            _logTailer.StopThread();
            _dbService.StopThread();
        }

        private void btnToggleTailThread_Click(object sender, EventArgs e)
        {
            if (!_logTailer.ThreadRunning)
            {
                try
                {
                    btnToggleTailThread.Enabled = false;
                    btnOpenLog.Enabled = false;
                    _logTailer.StartThread(tbLogFilePath.Text, _crossThreadQueue);
                    stBarTail.BackColor = Color.Green;
                    stBarTail.ForeColor = Color.White;
                    stBarTail.Text = "Tailing LogFile";
                    btnToggleTailThread.Text = "Stop Tailing";
                    btnToggleTailThread.Enabled = true;
                }
                catch (Exception ex)
                {
                    btnOpenLog.Enabled = true;
                    btnToggleTailThread.Enabled = true;
                    stBarTail.BackColor = Color.Red;
                    stBarTail.ForeColor = Color.White;
                    stBarTail.Text = "Error initialising LogTailer";
                    _logTailer.StopThread();
                    MessageBox.Show($@"Failed to start LogTailer: {Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                }
                
            }
            else
            {
                btnToggleTailThread.Enabled = false;
                _logTailer.StopThread();
                stBarTail.BackColor = Color.White;
                stBarTail.ForeColor = Color.Black;
                stBarTail.Text = "Idle";
                btnToggleTailThread.Text = "Start Tailing";
                btnToggleTailThread.Enabled = true;
                btnOpenLog.Enabled = true;
            }
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Palia", "Saved", "Logs");
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = "Palia Log Files (Palia*.log)|Palia*.log";
            openFileDialog.Title = "Select your Palia.log file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbLogFilePath.Text = openFileDialog.FileName;
                btnToggleTailThread.Enabled = true;
            }
        }

        private void btnToggleDbService_Click(object sender, EventArgs e)
        {
            if (!_dbService.ThreadRunning)
            {
                try
                {
                    btnToggleDbService.Enabled = false;
                    _dbService.StartThread(_crossThreadQueue);
                    stBarDb.BackColor = Color.Green;
                    stBarDb.ForeColor = Color.White;
                    stBarDb.Text = "Connected to Database";
                    btnToggleDbService.Text = "Stop DB";
                    btnToggleDbService.Enabled = true;
                }
                catch (Exception ex)
                {
                    btnToggleDbService.Enabled = true;
                    stBarDb.BackColor = Color.Red;
                    stBarDb.ForeColor = Color.White;
                    stBarDb.Text = "Error connecting to Database";
                    _dbService.StopThread();
                    MessageBox.Show($@"Failed to connect to Database: {Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                }
                
            }
            else
            {
                btnToggleDbService.Enabled = false;
                _dbService.StopThread();
                stBarDb.BackColor = Color.White;
                stBarDb.ForeColor = Color.Black;
                stBarDb.Text = "Idle";
                btnToggleDbService.Text = "Start Tailing";
                btnToggleDbService.Enabled = true;
            }
        }
    }
}