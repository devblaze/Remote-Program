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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tlUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tlPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtDisconnect = new MetroFramework.Controls.MetroTile();
            this.mtConnect = new MetroFramework.Controls.MetroTile();
            this.screen = new AxMSTSCLib.AxMsTscAxNotSafeForScripting();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            this.SuspendLayout();
            // 
            // tlServer
            // 
            // 
            // 
            // 
            this.tlServer.CustomButton.Image = null;
            this.tlServer.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.tlServer.CustomButton.Name = "";
            this.tlServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tlServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tlServer.CustomButton.TabIndex = 1;
            this.tlServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tlServer.CustomButton.UseSelectable = true;
            this.tlServer.CustomButton.Visible = false;
            this.tlServer.Lines = new string[0];
            this.tlServer.Location = new System.Drawing.Point(80, 82);
            this.tlServer.MaxLength = 32767;
            this.tlServer.Name = "tlServer";
            this.tlServer.PasswordChar = '\0';
            this.tlServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tlServer.SelectedText = "";
            this.tlServer.SelectionLength = 0;
            this.tlServer.SelectionStart = 0;
            this.tlServer.ShortcutsEnabled = true;
            this.tlServer.Size = new System.Drawing.Size(98, 23);
            this.tlServer.TabIndex = 0;
            this.tlServer.UseSelectable = true;
            this.tlServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tlServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Server:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(184, 86);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Username:";
            // 
            // tlUsername
            // 
            // 
            // 
            // 
            this.tlUsername.CustomButton.Image = null;
            this.tlUsername.CustomButton.Location = new System.Drawing.Point(91, 1);
            this.tlUsername.CustomButton.Name = "";
            this.tlUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tlUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tlUsername.CustomButton.TabIndex = 1;
            this.tlUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tlUsername.CustomButton.UseSelectable = true;
            this.tlUsername.CustomButton.Visible = false;
            this.tlUsername.Lines = new string[0];
            this.tlUsername.Location = new System.Drawing.Point(261, 82);
            this.tlUsername.MaxLength = 32767;
            this.tlUsername.Name = "tlUsername";
            this.tlUsername.PasswordChar = '\0';
            this.tlUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tlUsername.SelectedText = "";
            this.tlUsername.SelectionLength = 0;
            this.tlUsername.SelectionStart = 0;
            this.tlUsername.ShortcutsEnabled = true;
            this.tlUsername.Size = new System.Drawing.Size(113, 23);
            this.tlUsername.TabIndex = 4;
            this.tlUsername.UseSelectable = true;
            this.tlUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tlUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(380, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Password:";
            // 
            // tlPassword
            // 
            // 
            // 
            // 
            this.tlPassword.CustomButton.Image = null;
            this.tlPassword.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.tlPassword.CustomButton.Name = "";
            this.tlPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tlPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tlPassword.CustomButton.TabIndex = 1;
            this.tlPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tlPassword.CustomButton.UseSelectable = true;
            this.tlPassword.CustomButton.Visible = false;
            this.tlPassword.Lines = new string[0];
            this.tlPassword.Location = new System.Drawing.Point(452, 82);
            this.tlPassword.MaxLength = 32767;
            this.tlPassword.Name = "tlPassword";
            this.tlPassword.PasswordChar = '*';
            this.tlPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tlPassword.SelectedText = "";
            this.tlPassword.SelectionLength = 0;
            this.tlPassword.SelectionStart = 0;
            this.tlPassword.ShortcutsEnabled = true;
            this.tlPassword.Size = new System.Drawing.Size(112, 23);
            this.tlPassword.TabIndex = 6;
            this.tlPassword.UseSelectable = true;
            this.tlPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tlPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtDisconnect
            // 
            this.mtDisconnect.ActiveControl = null;
            this.mtDisconnect.Location = new System.Drawing.Point(694, 39);
            this.mtDisconnect.Name = "mtDisconnect";
            this.mtDisconnect.Size = new System.Drawing.Size(99, 73);
            this.mtDisconnect.TabIndex = 9;
            this.mtDisconnect.Text = "Disconnect";
            this.mtDisconnect.TileImage = ((System.Drawing.Image)(resources.GetObject("mtDisconnect.TileImage")));
            this.mtDisconnect.TileImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtDisconnect.UseSelectable = true;
            this.mtDisconnect.Click += new System.EventHandler(this.mtDisconnect_Click);
            // 
            // mtConnect
            // 
            this.mtConnect.ActiveControl = null;
            this.mtConnect.Location = new System.Drawing.Point(576, 39);
            this.mtConnect.Name = "mtConnect";
            this.mtConnect.Size = new System.Drawing.Size(112, 73);
            this.mtConnect.TabIndex = 8;
            this.mtConnect.Text = "Connect";
            this.mtConnect.TileImage = global::RemoteControl.Properties.Resources.connect;
            this.mtConnect.UseSelectable = true;
            this.mtConnect.Click += new System.EventHandler(this.mtConnect_Click);
            // 
            // screen
            // 
            this.screen.Enabled = true;
            this.screen.Location = new System.Drawing.Point(23, 118);
            this.screen.Name = "screen";
            this.screen.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("screen.OcxState")));
            this.screen.Size = new System.Drawing.Size(781, 371);
            this.screen.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.mtDisconnect);
            this.Controls.Add(this.mtConnect);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tlPassword);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tlUsername);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tlServer);
            this.Name = "Form1";
            this.Text = "Remote Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tlServer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tlUsername;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tlPassword;
        private MetroFramework.Controls.MetroTile mtConnect;
        private MetroFramework.Controls.MetroTile mtDisconnect;
        private AxMSTSCLib.AxMsTscAxNotSafeForScripting screen;
    }
}

