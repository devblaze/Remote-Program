using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MSTSCLib;

namespace RemoteControl
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mtConnect_Click(object sender, EventArgs e)
        {
            try
            {
                screen.Server = tlServer.Text;
                screen.UserName = tlUsername.Text;

                IMsTscNonScriptable secured = (IMsTscNonScriptable)screen.GetOcx();
                //screen.ClearTextPassword = tlPassword.Text;
                screen.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Connecting", "Error Connecting to the server" + tlServer.Text + " Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (screen.Connected.ToString() == "1")
                {
                    screen.Disconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Disconnecting", "Error @ Disconnecting from the server " + tlServer.Text + " Error: " + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
