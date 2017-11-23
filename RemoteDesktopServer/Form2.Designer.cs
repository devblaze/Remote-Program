namespace RemoteDesktopServer
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTag = new MetroFramework.Drawing.Html.HtmlLabel();
            this.lbFrames = new MetroFramework.Drawing.Html.HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTag
            // 
            this.lbTag.AutoScroll = true;
            this.lbTag.AutoScrollMinSize = new System.Drawing.Size(34, 23);
            this.lbTag.AutoSize = false;
            this.lbTag.BackColor = System.Drawing.SystemColors.Window;
            this.lbTag.Location = new System.Drawing.Point(496, 31);
            this.lbTag.Name = "lbTag";
            this.lbTag.Size = new System.Drawing.Size(38, 29);
            this.lbTag.TabIndex = 1;
            this.lbTag.Text = "FPS:";
            // 
            // lbFrames
            // 
            this.lbFrames.AutoScroll = true;
            this.lbFrames.AutoScrollMinSize = new System.Drawing.Size(17, 23);
            this.lbFrames.AutoSize = false;
            this.lbFrames.BackColor = System.Drawing.SystemColors.Window;
            this.lbFrames.Location = new System.Drawing.Point(540, 31);
            this.lbFrames.Name = "lbFrames";
            this.lbFrames.Size = new System.Drawing.Size(69, 23);
            this.lbFrames.TabIndex = 2;
            this.lbFrames.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 341);
            this.Controls.Add(this.lbFrames);
            this.Controls.Add(this.lbTag);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Remote Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Drawing.Html.HtmlLabel lbTag;
        private MetroFramework.Drawing.Html.HtmlLabel lbFrames;
    }
}