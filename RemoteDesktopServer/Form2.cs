using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace RemoteDesktopServer
{
    public partial class Form2 : MetroForm
    {
        public int port;
        private TcpClient client = new TcpClient();
        private TcpListener server;
        private NetworkStream mainStream;
        private double frames = 0;

        private readonly Thread Listening;
        private readonly Thread GetImage;

        public Form2(int v)
        {
            port = v;
            //client - new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);
            InitializeComponent();
        }

        private void StartListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }
            GetImage.Start();
        }

        private void StopListening()
        {
            server.Stop();
            client = null;
            if (Listening.IsAlive)
            {
                Listening.Abort();
            }
            if (GetImage.IsAlive)
            {
                GetImage.Abort();
            }
        }

        private void ReceiveImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                mainStream = client.GetStream();
                pictureBox1.Image = (Image)binFormatter.Deserialize(mainStream);
                
                frames++;
                lbFrames.Text = frames.ToString();
                /*
                while ((Image)binFormatter.Deserialize(mainStream) != null)
                {
                    frames++;
                    lbFrames.Text = frames.ToString();
                }
                */
            }
        }

        /*protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }
        */

        protected void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Close();
            StopListening();
        }

        protected void Form2_Load(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Any, port);
            StartListening();
        }
    }
}
