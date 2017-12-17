namespace RemoteControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbIP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbPort = new MetroFramework.Controls.MetroTextBox();
            this.mtShare = new MetroFramework.Controls.MetroTile();
            this.mtConnect = new MetroFramework.Controls.MetroTile();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbIP
            // 
            // 
            // 
            // 
            this.tbIP.CustomButton.Image = null;
            this.tbIP.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.tbIP.CustomButton.Name = "";
            this.tbIP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbIP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbIP.CustomButton.TabIndex = 1;
            this.tbIP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbIP.CustomButton.UseSelectable = true;
            this.tbIP.CustomButton.Visible = false;
            this.tbIP.Lines = new string[0];
            this.tbIP.Location = new System.Drawing.Point(120, 167);
            this.tbIP.MaxLength = 32767;
            this.tbIP.Name = "tbIP";
            this.tbIP.PasswordChar = '\0';
            this.tbIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbIP.SelectedText = "";
            this.tbIP.SelectionLength = 0;
            this.tbIP.SelectionStart = 0;
            this.tbIP.ShortcutsEnabled = true;
            this.tbIP.Size = new System.Drawing.Size(143, 23);
            this.tbIP.TabIndex = 0;
            this.tbIP.UseSelectable = true;
            this.tbIP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbIP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 171);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Server IP:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 210);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Port Number:";
            // 
            // tbPort
            // 
            // 
            // 
            // 
            this.tbPort.CustomButton.Image = null;
            this.tbPort.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.tbPort.CustomButton.Name = "";
            this.tbPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPort.CustomButton.TabIndex = 1;
            this.tbPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPort.CustomButton.UseSelectable = true;
            this.tbPort.CustomButton.Visible = false;
            this.tbPort.Lines = new string[0];
            this.tbPort.Location = new System.Drawing.Point(120, 206);
            this.tbPort.MaxLength = 32767;
            this.tbPort.Name = "tbPort";
            this.tbPort.PasswordChar = '\0';
            this.tbPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPort.SelectedText = "";
            this.tbPort.SelectionLength = 0;
            this.tbPort.SelectionStart = 0;
            this.tbPort.ShortcutsEnabled = true;
            this.tbPort.Size = new System.Drawing.Size(143, 23);
            this.tbPort.TabIndex = 4;
            this.tbPort.UseSelectable = true;
            this.tbPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtShare
            // 
            this.mtShare.ActiveControl = null;
            this.mtShare.Location = new System.Drawing.Point(141, 63);
            this.mtShare.Name = "mtShare";
            this.mtShare.Size = new System.Drawing.Size(122, 73);
            this.mtShare.TabIndex = 9;
            this.mtShare.Text = "Share my Screen";
            this.mtShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtShare.TileImage = ((System.Drawing.Image)(resources.GetObject("mtShare.TileImage")));
            this.mtShare.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtShare.UseSelectable = true;
            this.mtShare.Click += new System.EventHandler(this.mtShare_Click);
            // 
            // mtConnect
            // 
            this.mtConnect.ActiveControl = null;
            this.mtConnect.Location = new System.Drawing.Point(23, 63);
            this.mtConnect.Name = "mtConnect";
            this.mtConnect.Size = new System.Drawing.Size(112, 73);
            this.mtConnect.TabIndex = 8;
            this.mtConnect.Text = "Connect";
            this.mtConnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtConnect.TileImage = global::RemoteControl.Properties.Resources.connect;
            this.mtConnect.UseSelectable = true;
            this.mtConnect.Click += new System.EventHandler(this.mtConnect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 272);
            this.Controls.Add(this.mtShare);
            this.Controls.Add(this.mtConnect);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tbIP);
            this.Name = "Form1";
            this.Text = "Remote Desktop Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbIP;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbPort;
        private MetroFramework.Controls.MetroTile mtConnect;
        private MetroFramework.Controls.MetroTile mtShare;
        private System.Windows.Forms.Timer timer1;
    }
}

