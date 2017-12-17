using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace RemoteControl
{
    public partial class Form1 : MetroForm    {
        private readonly TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber;

        private static Image GrabDesktop()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics graphic = Graphics.FromImage(screenshot);
            graphic.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size, CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        private void SendDesktopImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            binFormatter.Serialize(mainStream, GrabDesktop());
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void mtConnect_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(tbPort.Text);
            try
            {
                client.Connect(tbIP.Text, portNumber);
                MetroMessageBox.Show(this, "OK", "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Information);                
            }catch (Exception)
            {
                MetroMessageBox.Show(this, "OK", "Failed to connect..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtShare_Click(object sender, EventArgs e)
        {
            if (mtShare.Text.StartsWith("Share"))
            {
                timer1.Start();
                mtShare.Text = "Stop Sharing";
            }
            else
            {
                timer1.Stop();
                mtShare.Text = "Share my Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //send an image from the screen every second
            SendDesktopImage();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //closing client connection and stopping the timer in case the user closes the form in order to avoid crash
            timer1.Stop();
            client.Close();
        }
    }
}
