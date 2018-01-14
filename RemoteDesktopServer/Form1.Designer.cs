namespace RemoteDesktopServer
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbPort = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(80, 103);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(155, 52);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Open Connection";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(46, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Port:";
            // 
            // tbPort
            // 
            // 
            // 
            // 
            this.tbPort.CustomButton.Image = null;
            this.tbPort.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tbPort.CustomButton.Name = "";
            this.tbPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPort.CustomButton.TabIndex = 1;
            this.tbPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPort.CustomButton.UseSelectable = true;
            this.tbPort.CustomButton.Visible = false;
            this.tbPort.Lines = new string[0];
            this.tbPort.Location = new System.Drawing.Point(99, 63);
            this.tbPort.MaxLength = 32767;
            this.tbPort.Name = "tbPort";
            this.tbPort.PasswordChar = '\0';
            this.tbPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPort.SelectedText = "";
            this.tbPort.SelectionLength = 0;
            this.tbPort.SelectionStart = 0;
            this.tbPort.ShortcutsEnabled = true;
            this.tbPort.Size = new System.Drawing.Size(159, 23);
            this.tbPort.TabIndex = 2;
            this.tbPort.UseSelectable = true;
            this.tbPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 178);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Text = "Remote Desktop Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbPort;
    }
}

