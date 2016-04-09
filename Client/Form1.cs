using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private ListViewGroup lanServers = new ListViewGroup("LAN Servers");
        private ListViewGroup addedServers = new ListViewGroup("LAN Servers");

        //private TcpClient curpeer, connpeer;
        private TcpClient curpeer;

        private Thread listenThread;

        private const int VIDEO_W = 1280;
        private const int VIDEO_H = 720;
        private Bitmap newBitmap = new Bitmap(VIDEO_W, VIDEO_H, PixelFormat.Format24bppRgb);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = newBitmap;
            toolStripStatusLabel1.Text = "Welcome!";

            serverList.Groups.Add(lanServers);
            serverList.Groups.Add(addedServers);

            listenThread = new Thread(ReadInput);
            listenThread.Start();

            // debugging
            ListViewItem localServ = new ListViewItem(new string[] { "127.0.0.1", "1337", "???" });
            localServ.Group = lanServers;
            serverList.Items.Add(localServ);
        }

        private void consoleAdd(string line)
        {
            textBoxConsole.AppendText(line);
            textBoxConsole.AppendText(Environment.NewLine);
        }

        private void timerPingServers_Tick(object sender, EventArgs e)
        {
            //consoleAdd("TODO: ping servers");
        }

        private void serverList_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = serverList.SelectedItems;
            if (selected.Count == 0) return;

            // debugging
            Console.WriteLine(selected[0].SubItems[0].Text);
            Console.WriteLine(selected[0].SubItems[1].Text);
            curpeer = new TcpClient("127.0.0.1", 1337);
        }

        private void UpdateImage(byte[] buf)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<byte[]>(UpdateImage), buf);
                return;
            }

            BitmapData bitmapData = newBitmap.LockBits(new Rectangle(0, 0, VIDEO_W, VIDEO_H), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
            Marshal.Copy(buf, 0, bitmapData.Scan0, buf.Length);
            newBitmap.UnlockBits(bitmapData);
            pictureBox1.Invalidate();
        }

        private void ReadInput()
        {
            byte[] videoBuf = new byte[VIDEO_W * VIDEO_H * 3];
            for (;;)
            {
                if (curpeer == null)
                {
                    Thread.Sleep(500);
                    continue;
                }

                try
                {
                    if (curpeer.GetStream().Read(videoBuf, 0, videoBuf.Length) == videoBuf.Length)
                    {
                        UpdateImage(videoBuf);
                    }
                }
                catch { }
            }
        }
    }
}
