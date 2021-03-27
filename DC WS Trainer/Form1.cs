using Memory;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace DC_Trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        public string codeFile = Application.StartupPath + @"\codes.ini";
        public Mem MemLib = new Mem();
        private int currentGameId;
        private bool isGameLoaded;

        private void OpenGame()
        {
            var gameName = MemLib.LoadCode("gameName", codeFile);
            int gameProcId = MemLib.GetProcIdFromName(gameName); //use task manager to find game name. For CoD MW2 it is iw4sp. Do not add .exe extension

            if (!isGameLoaded || currentGameId != gameProcId)
            {
                ProcessID.Invoke(new MethodInvoker(delegate { ProcessID.Text = gameProcId.ToString(); }));
                MemLib.OpenProcess(gameProcId);
                currentGameId = gameProcId;
                isGameLoaded = true;
            }
            if (isGameLoaded && currentGameId != gameProcId)
            {
                isGameLoaded = false;
                ProcessID.Invoke(new MethodInvoker(delegate { ProcessID.Text = "Not Found"; }));
                activateTrainer_checkbox.Invoke(new MethodInvoker(delegate { activateTrainer_checkbox.Checked = false; }));
            }
        }

        protected override void WndProc(ref Message m) //hotbuttons
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (isGameLoaded && id == 1)
                {
                    activateTrainer_checkbox.Checked = !activateTrainer_checkbox.Checked;
                }
                else if (id == 2)
                {
                    godMode_Checkbox.Checked = !godMode_Checkbox.Checked;
                }
                else if (id == 3)
                {
                    AddCells();
                }
                else if (id == 4)
                {
                    AddMoney();
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegisterHotKey(this.Handle, 1, 0, (int)Keys.F1);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.F2);
            RegisterHotKey(this.Handle, 3, 0, (int)Keys.F3);
            RegisterHotKey(this.Handle, 4, 0, (int)Keys.F4);

            //start our backgroundworker. (similar to a timer, but works on a seperate thread)
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true) //infinite loop
            {
                OpenGame();
                //because we are working on a seperate thread from the UI, we need to use invoke on our UI elements.
                //start reading our values
                if (activateTrainer_checkbox.Checked)
                {
                    if (godMode_Checkbox.Checked)
                    {
                        var currentHealth = MemLib.ReadInt("currentHealth", codeFile);

                        if (currentHealth > 0)
                        {
                            var totalHealth = MemLib.ReadInt("totalHealth", codeFile);
                            if (totalHealth < 20000)
                            {
                                MemLib.WriteMemory(MemLib.LoadCode("totalHealth", codeFile), "int", "20000");
                            }
                            if (currentHealth < totalHealth)
                            {
                                MemLib.WriteMemory(MemLib.LoadCode("currentHealth", codeFile), "int", "20000");
                            }
                        }
                    }
                }
                Thread.Sleep(700);
            }
        }

        private void activateTrainer_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            status_Label.Text = activateTrainer_checkbox.Checked ? "Status: Active" : "Status: Not Active";
            if (!activateTrainer_checkbox.Checked)
            {
                godMode_Checkbox.Checked = false;
            }
        }

        private void AddCells()
        {
            if (activateTrainer_checkbox.Checked)
            {
                var cells = MemLib.ReadInt("cells", codeFile);
                cells += 10;
                MemLib.WriteMemory(MemLib.LoadCode("cells", codeFile), "int", cells.ToString());
            }
        }

        private void AddMoney()
        {
            if (activateTrainer_checkbox.Checked)
            {
                var money = MemLib.ReadInt("money", codeFile);
                money += 10000;
                MemLib.WriteMemory(MemLib.LoadCode("money", codeFile), "int", money.ToString());
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var formGraphics = e.Graphics;
            string drawString1 = "Windows Store Edition";
            System.Drawing.Font drawFont1 = new System.Drawing.Font("Microsoft Sans Serif", 22, System.Drawing.FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush1 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            float x1 = 34.0F;
            float y1 = 148.0F;
            System.Drawing.StringFormat drawFormat1 = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString1, drawFont1, drawBrush1, x1, y1, drawFormat1);

            //377; 171
            string drawString2 = "V22 21-01-2021";
            System.Drawing.Font drawFont2 = new System.Drawing.Font("Microsoft Sans Serif", 8, System.Drawing.FontStyle.Bold);
            System.Drawing.SolidBrush drawBrush2 = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            float x2 = 358.0F;
            float y2 = 164.0F;
            System.Drawing.StringFormat drawFormat2 = new System.Drawing.StringFormat();
            formGraphics.DrawString(drawString2, drawFont2, drawBrush2, x2, y2, drawFormat2);
            drawFont1.Dispose();
            drawBrush1.Dispose();
            drawFont2.Dispose();
            drawBrush2.Dispose();
            formGraphics.Dispose();
        }

        private void creator_Label_Click(object sender, EventArgs e)
        {
            Process.Start("https://shababco.blogspot.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.deviantart.com/sirleviatan/art/Dead-Cells-Icon-HD-868510231");
        }
    }
}
