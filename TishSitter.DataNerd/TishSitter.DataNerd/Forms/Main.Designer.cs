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
            this.stBar = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.tbLogFilePath = new System.Windows.Forms.TextBox();
            this.btnToggleTailThread = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBar)).BeginInit();
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
            // stBar
            // 
            this.stBar.BeforeTouchSize = new System.Drawing.Size(261, 26);
            this.stBar.Location = new System.Drawing.Point(12, 240);
            this.stBar.Margin = new System.Windows.Forms.Padding(0);
            this.stBar.Name = "stBar";
            this.stBar.Size = new System.Drawing.Size(261, 26);
            this.stBar.TabIndex = 6;
            this.stBar.Text = "Idle";
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
            this.btnToggleTailThread.Location = new System.Drawing.Point(276, 240);
            this.btnToggleTailThread.Name = "btnToggleTailThread";
            this.btnToggleTailThread.Size = new System.Drawing.Size(135, 26);
            this.btnToggleTailThread.TabIndex = 9;
            this.btnToggleTailThread.Text = "Start Tailing";
            this.btnToggleTailThread.UseVisualStyleBackColor = true;
            this.btnToggleTailThread.Click += new System.EventHandler(this.btnToggleTailThread_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 278);
            this.Controls.Add(this.btnToggleTailThread);
            this.Controls.Add(this.tbLogFilePath);
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.stBar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDropDown1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnToggleTailThread;

        private System.Windows.Forms.TextBox tbLogFilePath;

        private System.Windows.Forms.Button btnOpenLog;

        private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel stBar;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;

        #endregion
    }
}