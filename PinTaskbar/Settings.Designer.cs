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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.btnShowTaskBar.BackColor = System.Drawing.Color.DarkGray;
            this.btnShowTaskBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnShowTaskBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowTaskBar.Location = new System.Drawing.Point(146, 158);
            this.btnShowTaskBar.Name = "btnShowTaskBar";
            this.btnShowTaskBar.Size = new System.Drawing.Size(127, 38);
            this.btnShowTaskBar.TabIndex = 0;
            this.btnShowTaskBar.Text = "Göster";
            this.btnShowTaskBar.UseVisualStyleBackColor = false;
            this.btnShowTaskBar.Click += new System.EventHandler(this.btnShowTaskBar_Click);
            // 
            // btnHiddenTaskbar
            // 
            this.btnHiddenTaskbar.BackColor = System.Drawing.Color.DarkGray;
            this.btnHiddenTaskbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnHiddenTaskbar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHiddenTaskbar.Location = new System.Drawing.Point(146, 202);
            this.btnHiddenTaskbar.Name = "btnHiddenTaskbar";
            this.btnHiddenTaskbar.Size = new System.Drawing.Size(127, 38);
            this.btnHiddenTaskbar.TabIndex = 1;
            this.btnHiddenTaskbar.Text = "Gizle";
            this.btnHiddenTaskbar.UseVisualStyleBackColor = false;
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
            this.cbPinDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbPinDesktop.ForeColor = System.Drawing.SystemColors.Control;
            this.cbPinDesktop.Location = new System.Drawing.Point(12, 42);
            this.cbPinDesktop.Name = "cbPinDesktop";
            this.cbPinDesktop.Size = new System.Drawing.Size(214, 24);
            this.cbPinDesktop.TabIndex = 3;
            this.cbPinDesktop.Text = "Sadece Desktopta Sabitle";
            this.cbPinDesktop.UseVisualStyleBackColor = true;
            this.cbPinDesktop.CheckedChanged += new System.EventHandler(this.cbPinDesktop_CheckedChanged);
            // 
            // cbStartWithWindows
            // 
            this.cbStartWithWindows.AutoSize = true;
            this.cbStartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbStartWithWindows.ForeColor = System.Drawing.SystemColors.Control;
            this.cbStartWithWindows.Location = new System.Drawing.Point(12, 12);
            this.cbStartWithWindows.Name = "cbStartWithWindows";
            this.cbStartWithWindows.Size = new System.Drawing.Size(246, 24);
            this.cbStartWithWindows.TabIndex = 4;
            this.cbStartWithWindows.Text = "Windows Başlangıcında Çalıştır";
            this.cbStartWithWindows.UseVisualStyleBackColor = true;
            this.cbStartWithWindows.CheckedChanged += new System.EventHandler(this.cbStartWithWindows_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(146, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "Minimized";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 213);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 302);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 264);
            this.listBox1.TabIndex = 8;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(285, 579);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

