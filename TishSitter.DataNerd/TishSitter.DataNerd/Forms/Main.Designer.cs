namespace TishSitter.DataNerd.Forms
{
    partial class Main
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
            this.comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stBarTail = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.tbLogFilePath = new System.Windows.Forms.TextBox();
            this.btnToggleTailThread = new System.Windows.Forms.Button();
            this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
            this.btnToggleDbService = new System.Windows.Forms.Button();
            this.stBarDb = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBarTail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
            this.statusBarAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stBarDb)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDropDown1
            // 
            this.comboDropDown1.BeforeTouchSize = new System.Drawing.Size(121, 21);
            this.comboDropDown1.Location = new System.Drawing.Point(118, 127);
            this.comboDropDown1.Name = "comboDropDown1";
            this.comboDropDown1.Size = new System.Drawing.Size(121, 21);
            this.comboDropDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Spot";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "World";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingame Time";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thanks for using DataNerd!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stBarTail
            // 
            this.stBarTail.BeforeTouchSize = new System.Drawing.Size(149, 34);
            this.stBarTail.Location = new System.Drawing.Point(249, 2);
            this.stBarTail.Margin = new System.Windows.Forms.Padding(0);
            this.stBarTail.Name = "stBarTail";
            this.stBarTail.Size = new System.Drawing.Size(149, 34);
            this.stBarTail.TabIndex = 6;
            this.stBarTail.Text = "Idle";
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Location = new System.Drawing.Point(335, 205);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(76, 29);
            this.btnOpenLog.TabIndex = 7;
            this.btnOpenLog.Text = "Open Log";
            this.btnOpenLog.UseVisualStyleBackColor = true;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // tbLogFilePath
            // 
            this.tbLogFilePath.Location = new System.Drawing.Point(12, 210);
            this.tbLogFilePath.Name = "tbLogFilePath";
            this.tbLogFilePath.ReadOnly = true;
            this.tbLogFilePath.Size = new System.Drawing.Size(317, 20);
            this.tbLogFilePath.TabIndex = 8;
            // 
            // btnToggleTailThread
            // 
            this.btnToggleTailThread.Enabled = false;
            this.btnToggleTailThread.Location = new System.Drawing.Point(200, 2);
            this.btnToggleTailThread.Name = "btnToggleTailThread";
            this.btnToggleTailThread.Size = new System.Drawing.Size(47, 34);
            this.btnToggleTailThread.TabIndex = 9;
            this.btnToggleTailThread.Text = "Start Tail";
            this.btnToggleTailThread.UseVisualStyleBackColor = true;
            this.btnToggleTailThread.Click += new System.EventHandler(this.btnToggleTailThread_Click);
            // 
            // statusBarAdv1
            // 
            this.statusBarAdv1.BeforeTouchSize = new System.Drawing.Size(423, 42);
            this.statusBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.statusBarAdv1.Controls.Add(this.btnToggleDbService);
            this.statusBarAdv1.Controls.Add(this.stBarDb);
            this.statusBarAdv1.Controls.Add(this.btnToggleTailThread);
            this.statusBarAdv1.Controls.Add(this.stBarTail);
            this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBarAdv1.Location = new System.Drawing.Point(0, 236);
            this.statusBarAdv1.Name = "statusBarAdv1";
            this.statusBarAdv1.Padding = new System.Windows.Forms.Padding(3);
            this.statusBarAdv1.Size = new System.Drawing.Size(423, 42);
            this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
            this.statusBarAdv1.TabIndex = 10;
            // 
            // btnToggleDbService
            // 
            this.btnToggleDbService.Location = new System.Drawing.Point(0, 2);
            this.btnToggleDbService.Name = "btnToggleDbService";
            this.btnToggleDbService.Size = new System.Drawing.Size(47, 34);
            this.btnToggleDbService.TabIndex = 10;
            this.btnToggleDbService.Text = "Start DB";
            this.btnToggleDbService.UseVisualStyleBackColor = true;
            this.btnToggleDbService.Click += new System.EventHandler(this.btnToggleDbService_Click);
            // 
            // stBarDb
            // 
            this.stBarDb.BeforeTouchSize = new System.Drawing.Size(149, 34);
            this.stBarDb.Location = new System.Drawing.Point(49, 2);
            this.stBarDb.Margin = new System.Windows.Forms.Padding(0);
            this.stBarDb.Name = "stBarDb";
            this.stBarDb.Size = new System.Drawing.Size(149, 34);
            this.stBarDb.TabIndex = 7;
            this.stBarDb.Text = "Idle";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 278);
            this.Controls.Add(this.statusBarAdv1);
            this.Controls.Add(this.tbLogFilePath);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDropDown1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBarTail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
            this.statusBarAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stBarDb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnToggleDbService;
        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel stBarDb;

        private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;

        private System.Windows.Forms.Button btnToggleTailThread;

        private System.Windows.Forms.TextBox tbLogFilePath;

        private System.Windows.Forms.Button btnOpenLog;

        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel stBarTail;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;

        #endregion
    }
}