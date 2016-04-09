namespace Client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.serverList = new System.Windows.Forms.ListView();
            this.columnHeaderIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelServerList = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.timerPingServers = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 304);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(746, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(746, 304);
            this.splitContainer1.SplitterDistance = 487;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.serverList);
            this.splitContainer2.Panel1.Controls.Add(this.labelServerList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelConsole);
            this.splitContainer2.Panel2.Controls.Add(this.textBoxConsole);
            this.splitContainer2.Size = new System.Drawing.Size(255, 304);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.TabIndex = 0;
            // 
            // serverList
            // 
            this.serverList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderIP,
            this.columnHeaderPort,
            this.columnHeaderPing});
            this.serverList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverList.Location = new System.Drawing.Point(0, 17);
            this.serverList.Name = "serverList";
            this.serverList.Size = new System.Drawing.Size(255, 144);
            this.serverList.TabIndex = 1;
            this.serverList.UseCompatibleStateImageBehavior = false;
            this.serverList.View = System.Windows.Forms.View.Details;
            this.serverList.DoubleClick += new System.EventHandler(this.serverList_DoubleClick);
            // 
            // columnHeaderIP
            // 
            this.columnHeaderIP.Text = "Server IP";
            this.columnHeaderIP.Width = 121;
            // 
            // columnHeaderPort
            // 
            this.columnHeaderPort.Text = "Port";
            // 
            // columnHeaderPing
            // 
            this.columnHeaderPing.Text = "Ping";
            // 
            // labelServerList
            // 
            this.labelServerList.AutoSize = true;
            this.labelServerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelServerList.Location = new System.Drawing.Point(0, 0);
            this.labelServerList.Name = "labelServerList";
            this.labelServerList.Size = new System.Drawing.Size(76, 17);
            this.labelServerList.TabIndex = 0;
            this.labelServerList.Text = "Server List";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelConsole.Location = new System.Drawing.Point(0, 0);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(59, 17);
            this.labelConsole.TabIndex = 3;
            this.labelConsole.Text = "Console";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConsole.Location = new System.Drawing.Point(0, 0);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(255, 139);
            this.textBoxConsole.TabIndex = 2;
            // 
            // timerPingServers
            // 
            this.timerPingServers.Enabled = true;
            this.timerPingServers.Interval = 5000;
            this.timerPingServers.Tick += new System.EventHandler(this.timerPingServers_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 329);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Video Feed Client App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView serverList;
        private System.Windows.Forms.Label labelServerList;
        private System.Windows.Forms.Timer timerPingServers;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.ColumnHeader columnHeaderIP;
        private System.Windows.Forms.ColumnHeader columnHeaderPort;
        private System.Windows.Forms.ColumnHeader columnHeaderPing;
    }
}

