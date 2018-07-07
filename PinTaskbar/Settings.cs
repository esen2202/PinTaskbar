using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PinTaskbar
{
    public partial class Settings : Form
    {
        private ContextMenuStrip TrayIconContextMenu;
        private ToolStripMenuItem CloseMenuItem;
        private ToolStripMenuItem OpenSettingsMenuItem;

        #region Taskbar

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("shell32.dll")]
        public static extern UInt32 SHAppBarMessage(UInt32 dwMessage, ref APPBARDATA pData);

        public enum AppBarMessages
        {
            New = 0x00,
            Remove = 0x01,
            QueryPos = 0x02,
            SetPos = 0x03,
            GetState = 0x04,
            GetTaskBarPos = 0x05,
            Activate = 0x06,
            GetAutoHideBar = 0x07,
            SetAutoHideBar = 0x08,
            WindowPosChanged = 0x09,
            SetState = 0x0a
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct APPBARDATA
        {
            public UInt32 cbSize;
            public IntPtr hWnd;
            public UInt32 uCallbackMessage;
            public UInt32 uEdge;
            public Rectangle rc;
            public Int32 lParam;
        }

        public enum AppBarStates
        {
            AutoHide = 0x01,
            AlwaysOnTop = 0x00
        }

        /// <summary>
        /// Set the Taskbar State option
        /// </summary>
        /// <param name="option">AppBarState to activate</param>
        public void SetTaskbarState(AppBarStates option)
        {
            APPBARDATA msgData = new APPBARDATA();
            msgData.cbSize = (UInt32)Marshal.SizeOf(msgData);
            msgData.hWnd = FindWindow("System_TrayWnd", null);
            msgData.lParam = (Int32)(option);
            SHAppBarMessage((UInt32)AppBarMessages.SetState, ref msgData);
        }

        /// <summary>
        /// Gets the current Taskbar state
        /// </summary>
        /// <returns>current Taskbar state</returns>
        public AppBarStates GetTaskbarState()
        {
            APPBARDATA msgData = new APPBARDATA();
            msgData.cbSize = (UInt32)Marshal.SizeOf(msgData);
            msgData.hWnd = FindWindow("System_TrayWnd", null);
            return (AppBarStates)SHAppBarMessage((UInt32)AppBarMessages.GetState, ref msgData);
        }
        #endregion

        public Settings()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        private void Settings_Load(object sender, EventArgs e)
        {


            this.ShowInTaskbar = false;

            taskBarStatusIcon();

            //Optional - Add a context menu to the TrayIcon:
            TrayIconContextMenu = new ContextMenuStrip();
            CloseMenuItem = new ToolStripMenuItem();
            OpenSettingsMenuItem = new ToolStripMenuItem();

            TrayIconContextMenu.SuspendLayout();

            // 
            // TrayIconContextMenu
            // 
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] { this.OpenSettingsMenuItem });
            this.TrayIconContextMenu.Items.AddRange(new ToolStripItem[] { this.CloseMenuItem });

            this.TrayIconContextMenu.Name = "TrayIconContextMenu";
            this.TrayIconContextMenu.Size = new Size(153, 70);

            // 
            // OpenSettingsMenuItem
            // 
            this.OpenSettingsMenuItem.Name = "OpenSettingsMenuItem";
            this.OpenSettingsMenuItem.Size = new Size(152, 22);
            this.OpenSettingsMenuItem.Text = "Show Settings";
            this.OpenSettingsMenuItem.Click += new EventHandler(this.OpenSettingsMenuItem_Click);

            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new Size(152, 22);
            this.CloseMenuItem.Text = "Exit PinTaskbar";
            this.CloseMenuItem.Click += new EventHandler(this.CloseMenuItem_Click);



            TrayIconContextMenu.ResumeLayout(false);
            notifyIcon1.ContextMenuStrip = TrayIconContextMenu;

        }

        private void OpenSettingsMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();

        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void taskBarStatusIcon()
        {
            if (GetTaskbarState() == AppBarStates.AlwaysOnTop)
                notifyIcon1.Icon = Properties.Resources.pinClose;
            else
                notifyIcon1.Icon = Properties.Resources.pinOpen;
        }

        private void btnShowTaskBar_Click(object sender, EventArgs e)
        {
            SetTaskbarState(AppBarStates.AlwaysOnTop);
            taskBarStatusIcon();
        }

        private void btnHiddenTaskbar_Click(object sender, EventArgs e)
        {
            SetTaskbarState(AppBarStates.AutoHide);
            taskBarStatusIcon();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;

            this.Activate();
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (GetTaskbarState() == AppBarStates.AlwaysOnTop)
                    SetTaskbarState(AppBarStates.AutoHide);
                else
                    SetTaskbarState(AppBarStates.AlwaysOnTop);

                taskBarStatusIcon();
            }
        }

        private void Settings_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                //notifyIcon1.Visible = true;
                this.Hide();
            }

            else if (FormWindowState.Normal == this.WindowState)
            {
                //notifyIcon1.Visible = false;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbPinDesktop.Checked == true)
            {
                if (!isThereMaximizeWindow())
                {
                    SetTaskbarState(AppBarStates.AlwaysOnTop);
                }
                else
                {
                    SetTaskbarState(AppBarStates.AutoHide);
                }
            }

        }


        /// <summary>
        /// Masaüstündemi 
        /// </summary>
        /// <returns></returns>
        bool IsOnDesktop()
        {
            // Get all the processes.
            Process[] proc = Process.GetProcesses();
            // Get current window handle.
            IntPtr cWin = GetForegroundWindow();
            foreach (Process x in proc)
            {

                if (x.MainWindowHandle == cWin)
                {
                    return false;
                }
            }

            return true;
        }

        private void cbPinDesktop_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPinDesktop.Checked)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        //Startup registry key and value
        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "PinTaskbar";

        private static void SetStartup()
        {
            //Set the application to run at startup
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.SetValue(StartupValue, Application.ExecutablePath.ToString());
        }

        private static void DeleteStartup()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            key.DeleteValue(StartupValue);
        }

        private void cbStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStartWithWindows.Checked)
            {
                SetStartup();
            }
            else
            {
                DeleteStartup();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Tüm Açık Window ların Status una erişmek
        #region minimized all window 

        private static WINDOWPLACEMENT GetPlacement(IntPtr hwnd)
        {
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            placement.length = Marshal.SizeOf(placement);
            GetWindowPlacement(hwnd, ref placement);
            return placement;
        }

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        internal struct WINDOWPLACEMENT
        {
            public int length;
            public int flags;
            public ShowWindowCommands showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        internal enum ShowWindowCommands : int
        {
            Hide = 0,
            Normal = 1,
            Minimized = 2,
            Maximized = 3,
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //  listBox1.Items.Clear();
            Process[] procs = Process.GetProcesses();
            List<string> islemler = new List<string>();

            foreach (Process proc in procs)
            {
                var placement = GetPlacement(proc.MainWindowHandle);
                if (placement.showCmd != ShowWindowCommands.Hide)
                {
                    islemler.Add(placement.showCmd.ToString() + " | " + proc.ProcessName); //proc.MainWindowTitle
                }
            }

            islemler.Sort();
            listBox1.DataSource = islemler;
        }

        bool isThereMaximizeWindow()
        {
            bool result = false;

            Process[] procs = Process.GetProcesses();
            foreach (Process proc in procs)
            {
                var placement = GetPlacement(proc.MainWindowHandle);
                if (placement.showCmd == ShowWindowCommands.Maximized)
                {
                    result = true;
                }
            }

            #region Explorer için Max Kontrolü
            SHDocVw.ShellWindows shellWindows = new SHDocVw.ShellWindows();

            string filename;
            ArrayList windows = new ArrayList();

            foreach (SHDocVw.InternetExplorer ie in shellWindows)
            {
                filename = Path.GetFileNameWithoutExtension(ie.FullName).ToLower();
                if (filename.Equals("explorer"))
                {
                    //do something with the handle here
                    MessageBox.Show(ie.HWND.ToString());
                    
                }
            }

            #endregion
            return result;

        }
        #endregion


    }
}