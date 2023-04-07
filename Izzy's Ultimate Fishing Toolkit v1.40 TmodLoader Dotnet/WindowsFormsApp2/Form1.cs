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

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

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
                if (session.Process?.ProcessName == "dotnet")
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
                            groupBox5.Enabled = true;
                            groupBox6.Enabled = true;
                            groupBox7.Enabled = true;
                            groupBox9.Enabled = true;
                            groupBox10.Enabled = true;
                            Button4.Visible = false;
                            Button4.Text = "Press To Stop Bot";
                            Button5.Text = "Press To Start Bot";
                            button3.Text = "Press To Start Bot";
                            Button5.Visible = true;
                            Button1.Visible = true;
                            button3.Visible = true;
                            Button5.Enabled = true;
                            Button1.Enabled = true;
                            button3.Enabled = true;
                            checkBox6.Checked = false;
                            MessageBox.Show("Bot Has Finished!", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                Button4.Visible = false;
                Button4.Text = "Press To Stop Bot";
                Button5.Text = "Press To Start Bot";
                button3.Text = "Press To Start Bot";

                DummyScroll = 0;
                // RodHealth = 3;
                checkBox6.Checked = false;
                Button5.Visible = true;
                Button1.Visible = true;
                button3.Visible = true;
                Button5.Enabled = true;
                Button1.Enabled = true;
                button3.Enabled = true;
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
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                Button4.Visible = false;
                Button4.Text = "Press To Stop Bot";
                Button5.Text = "Press To Start Bot";
                button3.Text = "Press To Start Bot";
                Button5.Visible = true;
                Button1.Visible = true;
                button3.Visible = true;
                Button5.Enabled = true;
                Button1.Enabled = true;
                button3.Enabled = true;
                MessageBox.Show("The tmodloder.exe Process Was Stoped!", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            this.comboBox1.DataSource = dataSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";

            // make it readonly
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            // For FindKeyPress
            Thread TH = new Thread(Keyboardd);
            TH.SetApartmentState(ApartmentState.STA);
            CheckForIllegalCrossThreadCalls = false;
            TH.Start();

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
            toolTip1.SetToolTip(Button1, "Start the bot.");
            toolTip1.SetToolTip(numericUpDown7, "Set the speed of creating new lines.");
            toolTip1.SetToolTip(numericUpDown8, "Set a custom amount of throws. This will pull them in.");
            toolTip1.SetToolTip(numericUpDown10, "Set a custom delay before rod pull.");
            toolTip1.SetToolTip(TextBox4, "The current amount of rods thrown.");
            toolTip1.SetToolTip(textBox1, "The current mouse position.");
            toolTip1.SetToolTip(textBox2, "The coordinates to Terraria window.");
            toolTip1.SetToolTip(textBox3, "The coordinates to item Slot1.");
            toolTip1.SetToolTip(label17, "The amount of time converted from milliseconds.");

            // Bait Bot
            toolTip1.SetToolTip(radioButton1, "GoldenNet + Flowerboots bait method.");
            toolTip1.SetToolTip(radioButton2, "FlareGun + Flowerboots bait method. (Fastest)");
            toolTip1.SetToolTip(comboBox1, "Select a custom amount of flares to shoot");
            toolTip1.SetToolTip(button3, "Start the bot.");

            // Tab Control
            tabPage1.ToolTipText = "Slot1: Fishing Rod";
            tabPage2.ToolTipText = "Slot1: Stack , Slot2: Fishing Rod";
            tabPage3.ToolTipText = "Slot1: Flaregun , Slot2: Bug Net";

        }

        //  1  Interval Clock
        private void Timer2_Tick(object sender, EventArgs e)
        {

            //For Combobox
            if (radioButton2.Checked == true)
            {

                //  Check For Java Process
                if (Process.GetProcessesByName("dotnet").Length > 0)
                {

                    // Look for KillBox
                    if (checkBox3.Checked == false)
                    {

                        groupBox10.Enabled = true;

                    }

                }

            }
            else
            {

                groupBox10.Enabled = false;

            }

            // Stop Bot Timmer Line Bot
            if (checkBox1.Checked == true)
            {

                // Check Fpr Stop Bot, Else Run Code
                if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F2) & System.Windows.Input.KeyStates.Down) > 0)
                {

                    // Stop Timmer
                    timer15.Enabled = false;
                    timer16.Stop();
                    timer16.Enabled = false;
                    checkBox1.Checked = false;

                    // Edit Button
                    int newSize3 = (int)Math.Round(14.75);
                    Button1.Font = new Font(Button1.Font.FontFamily, newSize3, FontStyle.Bold | FontStyle.Italic);
                    Button1.Text = "Press To Start Bot";

                }

            }

            // Hide Pull Wait
            int PCount = Convert.ToInt32(numericUpDown8.Value);
            if (PCount > 0)
            {

                // Enable
                groupBox8.Enabled = true;

            }
            else
            {

                // Disable
                groupBox8.Enabled = false;

            }

            // Disable Text If Not On Correct Tab
            if (tabControl1.SelectedIndex == 0)
            {

                toolStripStatusLabel3.Visible = true;
                toolStripStatusLabel4.Visible = true;
                toolStripStatusLabel5.Visible = true;
                toolStripStatusLabel6.Visible = true;

            }
            else
            {

                toolStripStatusLabel3.Visible = false;
                toolStripStatusLabel4.Visible = false;
                toolStripStatusLabel5.Visible = false;
                toolStripStatusLabel6.Visible = false;

            }

            //  Handles For Lables
            string TL = TotalLines.ToString();
            Label6.Text = TL;

            string RH = RodHealth.ToString();
            Label14.Text = RH;

            string SR = ScrollReject.ToString();
            int SR1 = Int32.Parse(SR) + 1;
            string SR2 = SR1.ToString();

            //  Check For Java Process
            if (Process.GetProcessesByName("dotnet").Length > 0)
            {

                ToolStripStatusLabel1.ForeColor = Color.DarkGreen;
                ToolStripStatusLabel1.Text = "Found";
                checkBox8.Checked = true;
                if (CheckJava == 0)
                {
                    Button5.Enabled = true;
                    Button5.Text = "Press To Start Bot";
                    Button1.Text = "Press To Start Bot";
                    button3.Text = "Press To Start Bot";
                    CheckJava = 1;

                    // JavaFound Enable Client

                    GroupBox1.Enabled = true;
                    GroupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    GroupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = true;
                    groupBox7.Enabled = true;
                    groupBox9.Enabled = true;
                    groupBox10.Enabled = true;

                }

            }
            else
            {

                ToolStripStatusLabel1.ForeColor = Color.DarkRed;
                ToolStripStatusLabel1.Text = "Not Found";

                int newSize2 = 12;
                Button5.Font = new Font(Button5.Font.FontFamily, newSize2, FontStyle.Bold | FontStyle.Italic);
                Button5.Text = "Looking For Game...";

                int newSize3 = 12;
                button3.Font = new Font(button3.Font.FontFamily, newSize3, FontStyle.Bold | FontStyle.Italic);
                button3.Text = "Looking For Game...";

                int newSize1 = 12;
                Button1.Font = new Font(Button1.Font.FontFamily, newSize1, FontStyle.Bold | FontStyle.Italic);
                Button1.Text = "Looking For Game...";

                CheckJava = 0;
                checkBox8.Checked = false;
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;

            }

            //  X, Y coords bottom toolbar
            MyX_MyY.Text = (" X:" + (Cursor.Position.X + (", Y:" + Cursor.Position.Y)));

            //  Count Java Processes
            int count = 0;
            foreach (System.Diagnostics.Process myProc in System.Diagnostics.Process.GetProcesses())
            {
                if (myProc.ProcessName == "dotnet")
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
            decimal x1 = numericUpDown10.Value;
            double pi1 = (double)x1;
            TimeSpan t1 = TimeSpan.FromMilliseconds(pi1);
            string answer1 = string.Format("{0:D2}d:{1:D2}h:{2:D2}m:{3:D2}s",
                                    t1.Days,
                                    t1.Hours,
                                    t1.Minutes,
                                    t1.Seconds);
            label17.Text = "= " + answer1;

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
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                Button1.Enabled = false;
                button3.Enabled = false;
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
                MessageBox.Show("Please Start tmodloder.", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            if (Process.GetProcessesByName("dotnet").Length > 0)
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
                MessageBox.Show("Please Start tmodloder.", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
            if (Process.GetProcessesByName("dotnet").Length > 0)
            {
                // Capture Sound
                foreach (AudioSession session in AudioSession.EnumerateAll())
                {
                    if (session.Process?.ProcessName == "dotnet")
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
                MessageBox.Show("Please Start tmodloder.", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

        #region Unlimited Lines Bot
        //
        //
        //
        //
        //
        // === Unlimited Lines Bot ===

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        // 1 Tick Commands
        private void timer13_Tick(object sender, EventArgs e)
        {

            // X, Y coords bottom toolbar
            textBox1.Text = (" X:" + (Cursor.Position.X + (", Y:" + Cursor.Position.Y)));

            // Fill Coords Cursor
            string TopM0 = Cursor.Position.X.ToString();
            string LeftM0 = Cursor.Position.Y.ToString();

            textBox7.Text = TopM0;
            textBox8.Text = LeftM0;

            // Check If Process Exists
            Process[] pname = Process.GetProcessesByName("dotnet");
            if (pname.Length > 0)
            {

                // Get Window Location (Top Left)
                Process[] processes = Process.GetProcessesByName("dotnet");
                Process lol = processes[0];
                IntPtr ptr = lol.MainWindowHandle;
                Rect NotepadRect = new Rect();
                GetWindowRect(ptr, ref NotepadRect);

                string Left = NotepadRect.Left.ToString();
                string Top = NotepadRect.Top.ToString();

                textBox2.Text = " X:" + (Left + (", Y:" + Top));

                // Find Item Location
                int LeftM1 = Int32.Parse(Left);
                int TopM1 = Int32.Parse(Top);

                int LeftM2 = LeftM1 + 41;
                int TopM2 = TopM1 + 67;

                textBox3.Text = " X:" + (LeftM2 + (", Y:" + TopM2));

                // Fill Coords Modded
                string TopM3 = TopM2.ToString();
                string LeftM3 = LeftM2.ToString();

                textBox5.Text = LeftM3;
                textBox6.Text = TopM3;

            }
            else
            {

                textBox2.Text = "N/A";
                textBox3.Text = "N/A";

            }

        }

        // Main Function
        private void Button1_Click(object sender, EventArgs e)
        {

            if (Process.GetProcessesByName("dotnet").Length > 0)
            {
                // Edit Button
                int newSize1 = 10;
                Button1.Font = new Font(Button1.Font.FontFamily, newSize1, FontStyle.Bold | FontStyle.Italic);
                Button1.Text = "Saving Pointer Pos In 10s..";

                // Disable Class
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                Button1.Enabled = false;
                button3.Enabled = false;
                Button5.Enabled = false;

                // Start Timmer
                timer14.Enabled = true;
            }
            else
            {

                // MC Was Not Started
                MessageBox.Show("Please Start tmodloder.", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }


        // Set Position
        private void timer14_Tick(object sender, EventArgs e)
        {

            // Disable Clock
            timer14.Enabled = false;

            // Set Position
            textBox9.Text = Cursor.Position.X.ToString();
            textBox10.Text = Cursor.Position.Y.ToString();

            // Reset TextBox
            TextBox4.Text = 0.ToString();

            // Start Timmer Loop
            timer15.Enabled = true;

        }

        // Capture Key
        void Keyboardd()
        {

            if (timer15.Enabled == true)
            {

                while (isRunning)
                {

                    Thread.Sleep(40); //Min CPU Usage
                    if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F2) & System.Windows.Input.KeyStates.Down) > 0)
                    {

                        timer15.Enabled = false;

                        // Edit Button
                        int newSize4 = (int)Math.Round(14.75);
                        Button1.Font = new Font(Button1.Font.FontFamily, newSize4, FontStyle.Bold | FontStyle.Italic);
                        Button1.Text = "Stopping Bot..";

                    }

                }

            }

        }


        // Start Bot Commands
        private void timer15_Tick(object sender, EventArgs e)
        {

            // Edit Text
            int newSize2 = 15;
            Button1.Font = new Font(Button1.Font.FontFamily, newSize2, FontStyle.Bold | FontStyle.Italic);
            Button1.Text = "Press F2 To Stop Bot";

            ToolTip toolTip2 = new ToolTip();
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(Button1, "Stops the current bot session.");

            // Wait For Return
            if (checkBox1.Checked == true)
            {

            }
            else
            {
                // Check For Stop Bot, Else Run Code
                if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F2) & System.Windows.Input.KeyStates.Down) > 0)
                {

                    // Stop Timmer
                    timer15.Enabled = false;

                    // Enable Class
                    GroupBox1.Enabled = true;
                    GroupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    GroupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = true;
                    groupBox7.Enabled = true;
                    groupBox9.Enabled = true;
                    groupBox10.Enabled = true;
                    Button1.Enabled = true;
                    button3.Enabled = true;
                    Button5.Enabled = true;

                    // Enable Groupbox
                    if (radioButton2.Checked == true)
                    {

                        groupBox10.Enabled = true;

                    }

                    // Edit Button
                    int newSize3 = (int)Math.Round(14.75);
                    Button1.Font = new Font(Button1.Font.FontFamily, newSize3, FontStyle.Bold | FontStyle.Italic);
                    Button1.Text = "Press To Start Bot";

                    toolTip2.SetToolTip(Button1, "Start the bot.");

                }
                else
                {

                    // Check For Terraria
                    if (Process.GetProcessesByName("dotnet").Length > 0)
                    {

                        // Start Script
                        int CWait = Convert.ToInt32(numericUpDown7.Value);
                        int count = Convert.ToInt32(TextBox4.Text);

                        // Code Start
                        Thread.Sleep(CWait);
                        keybd_event(VK_ESCAPE, 0, KEYEVENTF_EXTENDEDKEY, 0);
                        Thread.Sleep(20);
                        keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0);

                        SetCursorPos(Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text)); // Item Location

                        Thread.Sleep(50);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), 0, 0); // RIGHTDOWN
                        Thread.Sleep(20);
                        mouse_event(MOUSEEVENTF_RIGHTUP, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), 0, 0); // RIGHTUP

                        Thread.Sleep(CWait);
                        SetCursorPos(Int32.Parse(textBox9.Text), Int32.Parse(textBox10.Text)); // Fish Location

                        Thread.Sleep(50);
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), 0, 0); // RIGHTDOWN
                        Thread.Sleep(20);
                        mouse_event(MOUSEEVENTF_RIGHTUP, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), 0, 0); // RIGHTUP

                        count = count + 2; // Counter

                        string SCount = count.ToString();
                        TextBox4.Text = SCount;

                        Thread.Sleep(CWait);
                        keybd_event(VK_ESCAPE, 0, KEYEVENTF_EXTENDEDKEY, 0);
                        Thread.Sleep(20);
                        keybd_event(VK_ESCAPE, 0, KEYEVENTF_KEYUP, 0);

                        // Check For Pull Lines
                        if (numericUpDown8.Value == 0)
                        {

                            // Do Nothing

                        }
                        else
                        {

                            // Check For Pull In Wait
                            if(numericUpDown10.Value > 0)
                            {

                                // Value Found
                                int LineV = Convert.ToInt32(numericUpDown8.Value);
                                int CCount = Convert.ToInt32(TextBox4.Text);
                                int PleaseWait = Convert.ToInt32(numericUpDown10.Value);
                                if (CCount >= LineV)
                                {

                                    // Reset TextBox
                                    TextBox4.Text = 0.ToString();

                                    // Wait Time
                                    timer16.Enabled = true;
                                    timer16.Interval = PleaseWait;

                                    checkBox1.Checked = true;

                                }

                            }
                            else
                            {

                                // Value Found
                                int LineV = Convert.ToInt32(numericUpDown8.Value);
                                int CCount = Convert.ToInt32(TextBox4.Text);
                                int PleaseWait = Convert.ToInt32(numericUpDown10.Value);
                                if (CCount >= LineV)
                                {

                                    // Reset TextBox
                                    TextBox4.Text = 0.ToString();

                                    // Pull Lines
                                    Thread.Sleep(50);
                                    mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox9.Text), Int32.Parse(textBox10.Text), 0, 0); // LEFTUP
                                    Thread.Sleep(20);
                                    mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox9.Text), Int32.Parse(textBox10.Text), 0, 0); // LEFTUP

                                }

                            }

                        }

                    }
                    else
                    {

                        // Terraria Not Found. Did It Crash?
                        // Stop Time-Out
                        timer15.Stop();
                        timer15.Enabled = false;
                        timer16.Stop();
                        timer16.Enabled = false;

                        GroupBox1.Enabled = false;
                        GroupBox2.Enabled = false;
                        groupBox3.Enabled = false;
                        GroupBox4.Enabled = false;
                        groupBox5.Enabled = false;
                        groupBox6.Enabled = false;
                        groupBox7.Enabled = false;
                        groupBox9.Enabled = false;
                        groupBox10.Enabled = false;
                        Button4.Visible = false;

                        Button5.Visible = true;
                        Button1.Visible = true;
                        button3.Visible = true;
                        Button5.Enabled = true;
                        Button1.Enabled = true;
                        button3.Enabled = true;
                        MessageBox.Show("The tmodloder.exe Process Was Stoped!", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }

        }

        // Pull Line In
        private void timer16_Tick(object sender, EventArgs e)
        {

            //Stop Timmer
            timer16.Enabled = false;

            // Pull Lines
            Thread.Sleep(50);
            mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox9.Text), Int32.Parse(textBox10.Text), 0, 0); // LEFTUP
            Thread.Sleep(20);
            mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox9.Text), Int32.Parse(textBox10.Text), 0, 0); // LEFTUP

            // Stop Loop
            checkBox1.Checked = false;

        }

        #endregion

        #region Bait Bot
        //
        //
        //
        //
        //
        // === Bait Bot ===


        // Start Bot
        private void button3_Click(object sender, EventArgs e)
        {

            // Check If Process Exists
            if (Process.GetProcessesByName("dotnet").Length > 0)
            {

                // Start Bait Bot

                // Check KillBox
                checkBox3.Checked = true;

                // Edit Text
                int newSize1 = 10;
                button3.Font = new Font(button3.Font.FontFamily, newSize1, FontStyle.Bold | FontStyle.Italic);
                button3.Text = "Saving Pointer Pos In 10s..";

                ToolTip toolTip5 = new ToolTip();
                toolTip5.ShowAlways = true;
                // toolTip5.SetToolTip(button3, "Start bot session.");

                // Disable Class
                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                Button1.Enabled = false;
                button3.Enabled = false;
                Button5.Enabled = false;

                // Start Timmer
                timer18.Enabled = true;

            }
            else
            {

                // MC Was Not Started
                MessageBox.Show("Please Start tmodloder.", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        // Check For Start
        private void timer18_Tick(object sender, EventArgs e)
        {

            // Run Command Started

            //Stop Search
            timer18.Enabled = false;

            // Save Coords
            // Set Position
            textBox11.Text = Cursor.Position.X.ToString();
            textBox12.Text = Cursor.Position.Y.ToString();

            //Flare Check
            if (radioButton2.Checked == true)
            {

                // Enable Timmer
                timer19.Enabled = true;

                // Throw Flares

                // Press 1
                Thread.Sleep(100);
                keybd_event(VK_ONE, 0, KEYEVENTF_EXTENDEDKEY, 0);
                Thread.Sleep(20);
                keybd_event(VK_ONE, 0, KEYEVENTF_KEYUP, 0);

                // Left Click

                for (int i = 0; i < Convert.ToInt32(comboBox1.SelectedValue); i++)
                {

                    SetCursorPos(Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text)); // Set Cursor Location

                    Thread.Sleep(1000);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP
                    Thread.Sleep(20);
                    mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP

                }

                // Press 2
                Thread.Sleep(100);
                keybd_event(VK_TWO, 0, KEYEVENTF_EXTENDEDKEY, 0);
                Thread.Sleep(20);
                keybd_event(VK_TWO, 0, KEYEVENTF_KEYUP, 0);

            }

            // Disable groupbox
            if (radioButton2.Checked == true)
            {

                groupBox10.Enabled = false;

            }

            // Edit Text
            int newSize2 = 14;
            button3.Font = new Font(button3.Font.FontFamily, newSize2, FontStyle.Bold | FontStyle.Italic);
            button3.Text = "Press F2 To Stop Bot";

            ToolTip toolTip3 = new ToolTip();
            toolTip3.ShowAlways = true;
            // toolTip3.SetToolTip(button3, "Stops the current bot session.");

            // Start Timmer
            timer17.Enabled = true;

        }

        // Bait Bot Actions
        private void timer17_Tick(object sender, EventArgs e)
        {

            // Check For Terraria
            if (Process.GetProcessesByName("dotnet").Length > 0)
            {

                // Check For Stop Bot, Else Run Code
                if ((System.Windows.Input.Keyboard.GetKeyStates(System.Windows.Input.Key.F2) & System.Windows.Input.KeyStates.Down) > 0)
                {

                    // Stop Timmer
                    timer17.Enabled = false;

                    // Disable KillBox
                    checkBox3.Checked = false;

                    // Enable Class
                    GroupBox1.Enabled = true;
                    GroupBox2.Enabled = true;
                    groupBox3.Enabled = true;
                    GroupBox4.Enabled = true;
                    groupBox5.Enabled = true;
                    groupBox6.Enabled = true;
                    groupBox7.Enabled = true;
                    groupBox9.Enabled = true;
                    groupBox10.Enabled = true;
                    Button1.Enabled = true;
                    button3.Enabled = true;
                    Button5.Enabled = true;

                    // Enable Groupbox
                    if (radioButton2.Checked == true)
                    {

                        groupBox10.Enabled = true;

                    }

                    // Kill Flare Check
                    timer19.Stop();
                    timer19.Enabled = false;

                    // Edit Button
                    int newSize3 = (int)Math.Round(14.75);
                    button3.Font = new Font(button3.Font.FontFamily, newSize3, FontStyle.Bold | FontStyle.Italic);
                    button3.Text = "Press To Start Bot";

                    ToolTip toolTip4 = new ToolTip();
                    toolTip4.ShowAlways = true;
                    // toolTip4.SetToolTip(button3, "Start the bot.");

                }
                else
                {

                    // Check Mode
                    if (radioButton1.Checked == true)
                    {

                        // Golen Net + Flowerboots

                        // Press 2
                        Thread.Sleep(100);
                        keybd_event(VK_TWO, 0, KEYEVENTF_EXTENDEDKEY, 0);
                        Thread.Sleep(20);
                        keybd_event(VK_TWO, 0, KEYEVENTF_KEYUP, 0);

                        // Spam Net
                        SetCursorPos(Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text)); // Set Cursor Location

                        Thread.Sleep(50);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP
                        Thread.Sleep(20);
                        mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP

                    }
                    else if (radioButton2.Checked == true)
                    {

                        // Flaregun + Flowerboots

                        // Check If Flare Despawned
                        if (checkBox2.Checked == true)
                        {

                            // Disable Checkbox
                            checkBox2.Checked = false;

                            // Throw Flares


                            // Press 1
                            Thread.Sleep(100);
                            keybd_event(VK_ONE, 0, KEYEVENTF_EXTENDEDKEY, 0);
                            Thread.Sleep(20);
                            keybd_event(VK_ONE, 0, KEYEVENTF_KEYUP, 0);

                            // Left Click
                            for (int i = 0; i < Convert.ToInt32(comboBox1.SelectedValue); i++)
                            {

                                SetCursorPos(Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text)); // Set Cursor Location

                                Thread.Sleep(1000);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP
                                Thread.Sleep(20);
                                mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP

                            }

                            // Press 2
                            Thread.Sleep(100);
                            keybd_event(VK_TWO, 0, KEYEVENTF_EXTENDEDKEY, 0);
                            Thread.Sleep(20);
                            keybd_event(VK_TWO, 0, KEYEVENTF_KEYUP, 0);

                            // Restart Timmer
                            timer19.Enabled = true;

                        }
                        else
                        {
                            // Spam Net
                            SetCursorPos(Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text)); // Net Location

                            Thread.Sleep(50);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP
                            Thread.Sleep(20);
                            mouse_event(MOUSEEVENTF_LEFTUP, Int32.Parse(textBox11.Text), Int32.Parse(textBox12.Text), 0, 0); // LEFTUP

                        }

                    }

                }

            }
            else
            {

                // Terraria Not Found. Did It Crash?
                // Stop Time-Out
                timer17.Stop();
                timer17.Enabled = false;
                timer19.Stop();
                timer19.Enabled = false;

                GroupBox1.Enabled = false;
                GroupBox2.Enabled = false;
                groupBox3.Enabled = false;
                GroupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                Button4.Visible = false;

                Button5.Visible = true;
                Button1.Visible = true;
                button3.Visible = true;
                Button5.Enabled = true;
                Button1.Enabled = true;
                button3.Enabled = true;
                MessageBox.Show("The tmodloder.exe Process Was Stoped!", "Izzy's Ultimate Fishing Toolkit v1.40", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        // Flare Despawn Check
        private void timer19_Tick(object sender, EventArgs e)
        {

            // Disable Timer
            timer19.Enabled = false;

            // Enable Checkbox
            checkBox2.Checked = true;

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