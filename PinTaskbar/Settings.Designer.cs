namespace PinTaskbar
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShowTaskBar = new System.Windows.Forms.Button();
            this.btnHiddenTaskbar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbPinDesktop = new System.Windows.Forms.CheckBox();
            this.cbStartWithWindows = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnShowTaskBar
            // 
            this.btnShowTaskBar.Location = new System.Drawing.Point(12, 244);
            this.btnShowTaskBar.Name = "btnShowTaskBar";
            this.btnShowTaskBar.Size = new System.Drawing.Size(75, 23);
            this.btnShowTaskBar.TabIndex = 0;
            this.btnShowTaskBar.Text = "Göster";
            this.btnShowTaskBar.UseVisualStyleBackColor = true;
            this.btnShowTaskBar.Click += new System.EventHandler(this.btnShowTaskBar_Click);
            // 
            // btnHiddenTaskbar
            // 
            this.btnHiddenTaskbar.Location = new System.Drawing.Point(93, 244);
            this.btnHiddenTaskbar.Name = "btnHiddenTaskbar";
            this.btnHiddenTaskbar.Size = new System.Drawing.Size(75, 23);
            this.btnHiddenTaskbar.TabIndex = 1;
            this.btnHiddenTaskbar.Text = "Gizle";
            this.btnHiddenTaskbar.UseVisualStyleBackColor = true;
            this.btnHiddenTaskbar.Click += new System.EventHandler(this.btnHiddenTaskbar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbPinDesktop
            // 
            this.cbPinDesktop.AutoSize = true;
            this.cbPinDesktop.Location = new System.Drawing.Point(12, 35);
            this.cbPinDesktop.Name = "cbPinDesktop";
            this.cbPinDesktop.Size = new System.Drawing.Size(150, 17);
            this.cbPinDesktop.TabIndex = 3;
            this.cbPinDesktop.Text = "Sadece Desktopta Sabitle";
            this.cbPinDesktop.UseVisualStyleBackColor = true;
            this.cbPinDesktop.CheckedChanged += new System.EventHandler(this.cbPinDesktop_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Location = new System.Drawing.Point(12, 12);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(172, 17);
            this.cbStartWithWindows.TabIndex = 4;
            this.cbStartWithWindows.Text = "Windows Başlangıcında Çalıştır";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbStartWithWindows);
            this.Controls.Add(this.cbPinDesktop);
            this.Controls.Add(this.btnHiddenTaskbar);
            this.Controls.Add(this.btnShowTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Resize += new System.EventHandler(this.Settings_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnShowTaskBar;
        private System.Windows.Forms.Button btnHiddenTaskbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbPinDesktop;
        private System.Windows.Forms.CheckBox cbStartWithWindows;
        private System.Windows.Forms.Button button1;
    }
}

