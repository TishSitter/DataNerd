using System;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;
using TishSitter.DataNerd.Properties;
using TishSitter.DataNerd.Services;

namespace TishSitter.DataNerd.Forms
{
    public partial class Main : Form
    {
        private readonly ResourceManager _resx = Resources.ResourceManager;
        private readonly LogTailer _logTailer = new LogTailer();
        
        public Main()
        {
            InitializeComponent();
        }

        private void btnToggleTailThread_Click(object sender, EventArgs e)
        {
            if (!_logTailer.ThreadRunning)
            {
                try
                {
                    btnToggleTailThread.Enabled = false;
                    btnOpenLog.Enabled = false;
                    _logTailer.StartThread(tbLogFilePath.Text);
                    stBar.BackColor = Color.Green;
                    stBar.ForeColor = Color.White;
                    stBar.Text = "Tailing LogFile";
                    btnToggleTailThread.Text = _resx.GetString("Main_btnToggleTailThread_Click_Stop_Tailing");
                    btnToggleTailThread.Enabled = true;
                }
                catch (Exception ex)
                {
                    btnOpenLog.Enabled = true;
                    btnToggleTailThread.Enabled = true;
                    stBar.BackColor = Color.Red;
                    stBar.ForeColor = Color.White;
                    stBar.Text = "Error initialising LogTailer";
                    _logTailer.StopThread();
                    MessageBox.Show($@"{_resx.GetString("Main_btnToggleTailThread_Click_ErrorStartingThread")}: {Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}");
                }
                
            }
            else
            {
                btnToggleTailThread.Enabled = false;
                _logTailer.StopThread();
                stBar.BackColor = Color.White;
                stBar.ForeColor = Color.Black;
                stBar.Text = "Idle";
                btnToggleTailThread.Text = _resx.GetString("StartTailing");
                btnToggleTailThread.Enabled = true;
                btnOpenLog.Enabled = true;
            }
        }

        private void btnOpenLog_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Palia", "Saved", "Logs");
            openFileDialog.FilterIndex = 1;
            openFileDialog.Filter = _resx.GetString("Main_btnOpenLog_Filter");
            openFileDialog.Title = _resx.GetString("Main_btnOpenLog_Title");
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbLogFilePath.Text = openFileDialog.FileName;
                btnToggleTailThread.Enabled = true;
            }
        }
    }
}