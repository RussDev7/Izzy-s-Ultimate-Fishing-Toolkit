using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Say Hello To Decompilers
        string HelloThere = "Hello there fellow Decompiler, This Program Was Made By D.RU$$ (xXCrypticNightXx).";

        #region Components

        private int RodHealth = 0;

        private int TotalLines = 0;

        private int ScrollReject = 0;

        private int CheckJava = 0;

        private int DummyScroll = 0;

        private const int MOUSEEVENTF_WHEEL = 2048;

        // The amount of movement is specified in mouseData.
        private const int MOUSEEVENTF_HWHEEL = 4096;

        // Not available for 2000 or XP
        private void MouseScroll(bool up, int clicks)
        {
            if (up)
            {
                Form1.mouse_event(MOUSEEVENTF_WHEEL, 0, 0, (clicks * 120), 0);
            }
            else
            {
                Form1.mouse_event(MOUSEEVENTF_WHEEL, 0, 0, ((clicks * 120) * -1), 0);
            }

        }

        public delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

        [DllImport("user32.dll", EntryPoint = "mouse_event")]
        static extern void mouse_event(Int32 dwFlags, Int32 dx, Int32 dy, Int32 cButtons, Int32 dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr handle, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        internal static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern bool RegisterHotKey(IntPtr windowHandle, int hotkeyId, uint modifierKeys, uint virtualKey);

            [DllImport("user32.dll")]
            public static extern bool UnregisterHotKey(IntPtr windowHandle, int hotkeyId);
        }

        private const int VK_ESCAPE = 27;
        private const int VK_ONE = 0x31;
        private const int VK_TWO = 0x32;
        private const int KEYEVENTF_EXTENDEDKEY = 1;
        private const int KEYEVENTF_KEYDOWN = 0;
        private const int KEYEVENTF_KEYUP = 2;
        private const int MOUSEEVENTF_LEFTDOWN = 2;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_RIGHTDOWN = 0x008;
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;

        public enum MouseEventFlags : System.UInt32
        {

            MOUSEEVENTF_ABSOLUTE = 32768,

            MOUSEEVENTF_LEFTDOWN = 2,

            MOUSEEVENTF_LEFTUP = 4,

            MOUSEEVENTF_MIDDLEDOWN = 32,

            MOUSEEVENTF_MIDDLEUP = 64,

            MOUSEEVENTF_MOVE = 1,

            MOUSEEVENTF_RIGHTDOWN = 8,

            MOUSEEVENTF_RIGHTUP = 16,

            MOUSEEVENTF_XDOWN = 128,

            MOUSEEVENTF_XUP = 256,

            MOUSEEVENTF_WHEEL = 2048,

            MOUSEEVENTF_HWHEEL = 4096,
        }

        // For Combobox
        public class Language
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }

        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        // Components For ProcessGet
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Fishing Bot
        // === Fishing Bot ===

        private void Timer1_Tick(object sender, EventArgs e)
        {

            // Here, I'm just monitoring chrome, one of the possible sessions.
            // If you want the whole speakers peak values, use the AudioSession.GetSpeakersChannelsPeakValues() method
            foreach (AudioSession session in AudioSession.EnumerateAll())
            {
                if (session.Process?.ProcessName == "Terraria")
                {
                    float[] values = session.GetChannelsPeakValues();
                    if (values.Length == 0) continue;

                    // Type Values To Console
                    //Console.WriteLine(string.Join(" ", values.Select(v => v.ToString("00%"))));

                    // Send Values To GUI
                    var Label100String = string.Join(" ", values.Select(v => v.ToString("00%")));
                    string firstTwoChars = Label100String.Length <= 2 ? Label100String : Label100String.Substring(0, 2);

                    string VPInput = numericUpDown6.Text;
                    string s1 = firstTwoChars;
                    int s1int = Int32.Parse(s1);
                    int s2int = Int32.Parse(VPInput);

                    // toolStripStatusLabel5.Text = s1;

                    // this will give result false as  
                    // both s1 and s2 are different 

                    // this will give result false as  
                    // both s1 and s2 are different 
                    if (s1int <= s2int)
                    {
                    }
                    else
                    {

                        //  Sound Spike Was Found, Run Code
                        Timer1.Stop();
                        Timer1.Enabled = false;


                        //  Finished Last Scroll
                        //  Check To Close APP
                        //  Unlimited Throws Enabled
                        if (checkBox6.Checked == true)
                        {

                            //  Pull In Line Before Throw
                            Thread.Sleep(100);
                            Form1.mouse_event(2, 0, 0, 0, 1);
                            //  RIGHTDOWN
                            Thread.Sleep(100);
                            Form1.mouse_event(4, 0, 0, 0, 1);
                            //  RIGHTUP
                            //  STOP BOT
                            //  Stop Time-Out
                            Timer7.Stop();
                            Timer7.Enabled = false;
                            TotalLines = (TotalLines + 1);
                            //  Enable

                            //  Stop Timmer
                            Timer5.Stop();
                            Timer5.Enabled = false;
                            GroupBox1.Enabled = true;
                            groupBox3.Enabled = true;
                            GroupBox2.Enabled = true;
                            GroupBox4.Enabled = true;
                            Button4.Visible = false;
                            Button4.Text = "Press To Stop Bot";
                            Button5.Text = "Press To Start Bot";
                            Button5.Visible = true;
                            Button5.Enabled = true;
                            checkBox6.Checked = false;
                            MessageBox.Show("Bot Has Finished!", "Izzy's Fishing Bot v2.00", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {

                            //  Run Macros
                            this.RedirrectYes();

                        }

                    }

                }

            }
                                   

            //  Look For KillSwitch
            if (checkBox6.Checked == true)
            {
                //  Stop Time-Out
                Timer7.Stop();
                Timer7.Enabled = false;
                Timer1.Stop();
                Timer1.Enabled = false;
                Timer5.Stop();
                Timer5.Enabled = false;
                GroupBox1.Enabled = true;
                GroupBox2.Enabled = true;
                groupBox3.Enabled = true;
                GroupBox4.Enabled = true;
                Button4.Visible = false;
                Button4.Text = "Press To Stop Bot";
                Button5.Text = "Press To Start Bot";

                DummyScroll = 0;
                // RodHealth = 3;
                checkBox6.Checked = false;
                Button5.Visible = true;
                Button5.Enabled = true;
            }

            //  Look For terraria.exe
            if (checkBox8.Checked == false)
            {
                //  Stop Time-Out
                Timer7.Stop();
                Timer7.Enabled = false;
                Timer1.Stop();
                Timer1.Enabled = false;
                Timer5.Stop();
                Timer5.Enabled = false;
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                Button4.Visible = false;
                Button4.Text = "Press To Stop Bot";
                Button5.Text = "Press To Start Bot";
                Button5.Visible = true;
                Button5.Enabled = true;
                MessageBox.Show("The terraria.exe Process Was Stoped!", "Izzy's Fishing Bot v2.00", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        //  Found Fish
        private void RedirrectYes()
        {
            //  Stop Time-Out
            Timer7.Stop();
            Timer7.Enabled = false;
            TotalLines = (TotalLines + 1);
            RodHealth = (RodHealth + 1);
            //  Do Macro
            //  Do Not Do if No Pole In INV
            if (DummyScroll == 0)
            {
                int Num3 = Convert.ToInt32(NumericUpDown3.Value);
                Thread.Sleep(Num3);
                //  Wait Line-In Seconds
                Thread.Sleep(100);
                Form1.mouse_event(2, 0, 0, 0, 1);
                //  RIGHTDOWN
                Thread.Sleep(100);
                Form1.mouse_event(4, 0, 0, 0, 1);
                //  RIGHTUP
            }
            else
            {
                //  Reset DummyScroll
                DummyScroll = 0;
            }

            int Num4 = Convert.ToInt32(NumericUpDown4.Value);
            Thread.Sleep(Num4);
            //  Wait Line-Out Seconds
            Thread.Sleep(100);
            Form1.mouse_event(2, 0, 0, 0, 1);
            //  RIGHTDOWN
            Thread.Sleep(100);
            Form1.mouse_event(4, 0, 0, 0, 1);
            //  RIGHTUP
            int Num5 = Convert.ToInt32(NumericUpDown5.Value);
            Thread.Sleep(Num5);
            //  Wait Kill-Noise Seconds
            //  Start Time-Out
            Timer7.Enabled = true;
            Timer7.Start();
            //  Re-Enable Search
            Timer1.Enabled = true;
            Timer1.Start();
        }

        // Check For Key Press
        bool isRunning = true;

        //  Form Load Commands
        private void Form1_Load(object sender, EventArgs e)
        {
            // Do not show a drop-down arrow.
            //toolStripDropDownButton1.ShowDropDownArrow = false;

            // For Combobox

            //Build a list
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { Name = "One", Value = "1" });
            dataSource.Add(new Language() { Name = "Two", Value = "2" });
            dataSource.Add(new Language() { Name = "Three", Value = "3" });
            dataSource.Add(new Language() { Name = "Four", Value = "4" });
            dataSource.Add(new Language() { Name = "Five", Value = "5" });
            dataSource.Add(new Language() { Name = "Six", Value = "6" });
            dataSource.Add(new Language() { Name = "Seven", Value = "7" });
            dataSource.Add(new Language() { Name = "Eight", Value = "8" });
            dataSource.Add(new Language() { Name = "Nine", Value = "9" });
            dataSource.Add(new Language() { Name = "Ten", Value = "10" });

            //Setup data binding

            // make it readonly

            // For FindKeyPress

            // Adjust Timer1
            // Timer1.Interval = 250;

            this.KeyPreview = true;
            Tmr.Start();
            //  Tool Tips
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;

            // Fishing Bot
            toolTip1.SetToolTip(Button4, "Stops the current bot session.");
            toolTip1.SetToolTip(Button5, "Start the bot.");
            toolTip1.SetToolTip(NumericUpDown2, "Set a custom delay before running bot.");
            toolTip1.SetToolTip(NumericUpDown3, "Set a custom delay before pulling in line.");
            toolTip1.SetToolTip(NumericUpDown4, "Set a custom delay before casting new line.");
            toolTip1.SetToolTip(NumericUpDown5, "Set a custom delay before continuing loop.");
            toolTip1.SetToolTip(numericUpDown6, "Set the level of sound needed to trigger the bot.");
            toolTip1.SetToolTip(numericUpDown1, "Set the amount of time before stopping the bot.");
            toolTip1.SetToolTip(label3, "The amount of time converted from milliseconds.");

            // Unlimited Lines Bot

            // Bait Bot

            // Tab Control

        }

        //  1  Interval Clock
        private void Timer2_Tick(object sender, EventArgs e)
        {

            // Disable Text If Not On Correct Tab
                toolStripStatusLabel3.Visible = true;
                toolStripStatusLabel4.Visible = true;
                toolStripStatusLabel5.Visible = true;
                toolStripStatusLabel6.Visible = true;

            //  Handles For Lables
            string TL = TotalLines.ToString();
            Label6.Text = TL;

            string RH = RodHealth.ToString();
            Label14.Text = RH;

            string SR = ScrollReject.ToString();
            int SR1 = Int32.Parse(SR) + 1;
            string SR2 = SR1.ToString();

            //  Check For Java Process
            if (Process.GetProcessesByName("Terraria").Length > 0)
            {

                ToolStripStatusLabel1.ForeColor = Color.DarkGreen;
                ToolStripStatusLabel1.Text = "Found";
                checkBox8.Checked = true;
                if (CheckJava == 0)
                {
                    Button5.Enabled = true;
                    Button5.Text = "Press To Start Bot";
                    CheckJava = 1;

                    // JavaFound Enable Client

                    GroupBox1.Enabled = true;
                    GroupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    GroupBox4.Enabled = true;

                }

            }
            else
            {

                ToolStripStatusLabel1.ForeColor = Color.DarkRed;
                ToolStripStatusLabel1.Text = "Not Found";

                int newSize2 = 12;
                Button5.Font = new Font(Button5.Font.FontFamily, newSize2, FontStyle.Bold | FontStyle.Italic);
                Button5.Text = "Looking For Game...";

                CheckJava = 0;
                checkBox8.Checked = false;
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;

            }

            //  X, Y coords bottom toolbar
            MyX_MyY.Text = (" X:" + (Cursor.Position.X + (", Y:" + Cursor.Position.Y)));

            //  Count Java Processes
            int count = 0;
            foreach (System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
            {
                if (myProc.ProcessName == "Terraria")
                {
                    count = count + 1;
                }
            }

            // Fishing Duration To SMHD
            decimal x = numericUpDown1.Value;
            double pi = (double)x;
            TimeSpan t = TimeSpan.FromMilliseconds(pi);
            string answer = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s",
                                    t.Days,
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds);
            label3.Text = "= " + answer;

            // Fishing Duration To SMHD #2

        }

        //  Start Bot
        private void Button5_Click(object sender, EventArgs e)
        {

            if (checkBox8.Checked)
            {

                // Start Bot

                //  
                Button5.Text = "Starting Bot...";
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                Button4.Enabled = true;
                Button4.Visible = true;
                Button5.Visible = false;
                RodHealth = 1;
                ScrollReject = 0;
                TotalLines = 0;
                Label6.Text = "0";
                int Num2 = Convert.ToInt32(NumericUpDown2.Value);
                System.Threading.Thread.Sleep(Num2);
                //  Wait Start-Delay Seconds
                //  Throw Line
                System.Threading.Thread.Sleep(100);
                mouse_event(2, 0, 0, 0, 1);
                //  RIGHTDOWN
                System.Threading.Thread.Sleep(100);
                mouse_event(4, 0, 0, 0, 1);
                //  RIGHTUP
                int Num5 = Convert.ToInt32(NumericUpDown5.Value);
                System.Threading.Thread.Sleep(Num5);
                //  Wait Noise Reduction Time
                //  Start Anti-AFK

                //  Start Time-Out
                Timer7.Enabled = true;
                Timer7.Start();
                //  Start Bot
                Timer1.Enabled = true;
                Timer1.Start();

                // Start Timmer-Off
                if (numericUpDown1.Value > 0)
                {

                    decimal value = numericUpDown1.Value;
                    int n = Convert.ToInt32(value);

                    timer12.Interval = n;
                    timer12.Enabled = true;

                }

            }
            else
            {

                // MC Was Not Started
                MessageBox.Show("Please Start Terraria.", "Izzy's Fishing Bot v2.00", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        //  Form Closing
        private void Form1_Closing(object sender, EventArgs e)
        {
            //  Terminate SndVol

        }

        //  Stop Bot
        private void Button4_Click(object sender, EventArgs e)
        {

            //  Send Stop State
            Button4.Enabled = false;
            checkBox6.Checked = true;
            Button4.Text = "Stoping Bot...";

        }

        // Get Sound Level For 1 Minuite
        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

            //  Check For Java Process
            if (Process.GetProcessesByName("Terraria").Length > 0)
            {

                toolStripStatusLabel6.Text = "- [Working]";

                // Disable Timer
                timer9.Enabled = true;

                // Action Timer
                timer10.Enabled = true;

            }
            else
            {

                // MC Was Not Started
                MessageBox.Show("Please Start Terraria.", "Izzy's Fishing Bot v2.00", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        // Disable Timmer
        private void timer9_Tick(object sender, EventArgs e)
        {

            timer9.Enabled = false;
            timer10.Enabled = false;
            toolStripStatusLabel5.Text = "N/A";
            toolStripStatusLabel6.Text = "- [Scan]";

        }

        // Find Sound
        private void timer10_Tick(object sender, EventArgs e)
        {
            //  Check For Java Process
            if (Process.GetProcessesByName("Terraria").Length > 0)
            {
                // Capture Sound
                foreach (AudioSession session in AudioSession.EnumerateAll())
                {
                    if (session.Process?.ProcessName == "Terraria")
                    {
                        float[] values = session.GetChannelsPeakValues();
                        if (values.Length == 0) continue;

                        // Type Values To Console
                        //Console.WriteLine(string.Join(" ", values.Select(v => v.ToString("00%"))));

                        // Send Values To GUI
                        var Label100String = string.Join(" ", values.Select(v => v.ToString("00%")));
                        string firstTwoChars = Label100String.Length <= 2 ? Label100String : Label100String.Substring(0, 2);

                        string VPInput = numericUpDown6.Text;
                        string s1 = firstTwoChars;
                        int s1int = Int32.Parse(s1);
                        int s2int = Int32.Parse(VPInput);

                        toolStripStatusLabel5.Text = s1;

                    }

                }

            }
            else
            {

                // MC Was Not Started
                MessageBox.Show("Please Start Terraria.", "Izzy's Fishing Bot v2.00", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        // For Bot Shutdown
        private void timer12_Tick(object sender, EventArgs e)
        {

            // Timmer Activated, Kill Bot
            timer12.Enabled = false;
            checkBox6.Checked = true;

            //Debug Test
            MessageBox.Show("Bot Has Stoped! Time Is Up!");

        }

        #endregion

        //
        //
        //
        //
        //
        // END OF CODE

        // Run Events On Form Closing
        private void Inicio(object sender, FormClosingEventArgs e)
        {

            isRunning = false;

        }

    }

}