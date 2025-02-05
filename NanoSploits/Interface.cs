using System;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using NanoPages;
using System.Threading;
using System.Threading.Tasks;

namespace NanoForm
{
    public partial class Interface : Form
    {
        private mainPage mainPageInstance;
        private homePage homePageInstance;
        private Mutex multiBloxMutex;
        private System.Windows.Forms.Timer checkStateTimer;

        public Interface()
        {
            InitializeComponent();

            DialogResult updateBox = MessageBox.Show("This version of NanoSploit is no longer supported!\nPlease, download lasest version", "NanoSploit Recode", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (updateBox == DialogResult.OK) {
                System.Diagnostics.Process.Start("https://getnano.online");
                System.Diagnostics.Process.Start("https://nano4free.t.me");
            }

            checkStateTimer = new System.Windows.Forms.Timer
            {
                Interval = 1500 
            };
            checkStateTimer.Tick += CheckState_Tick;
            checkStateTimer.Start();

            homePageInstance = new homePage();
            ChangeControl(homePageInstance);

            multiBloxMutex = new Mutex(false, "ROBLOX_singletonMutex");
        }
        private void ChangeControl(UserControl userControl)
        {
            if (userControl == null) return;

            userControl.Dock = DockStyle.Fill;
            userControl.BackColor = Color.Transparent;
            placeholder.Controls.Clear();
            placeholder.Controls.Add(userControl);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckState_Tick(object sender, EventArgs e)
        {
            try
            {
                bool isXenoInjected = NanoAPI.MainFunctions.IsInjected();
                bool IsRobloxOpen = NanoAPI.MainFunctions.IsRobloxOpen();
                if (IsRobloxOpen)
                {
                    Task.Delay(5000);
                    if (!isXenoInjected)
                    {
                        NanoAPI.MainFunctions.AttachAPI();
                    }
                    else
                    {
                        UpdateStatusLabel(isXenoInjected ? Color.LightGreen : Color.Firebrick, "⚫");
                        SwitchToMainPage();
                    }
                }
                else
                {
                    UpdateStatusLabel(Color.Firebrick, "⚫");
                    SwitchToHomePage();
                }
            }
            catch (Exception ex)
            {
                // Log or handle exceptions gracefully
                MessageBox.Show($"An error occurred while checking Roblox state: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatusLabel(Color color, string text)
        {
            statusLabel.Text = text;
            statusLabel.ForeColor = color;
        }

        private void SwitchToMainPage()
        {
            if (mainPageInstance == null)
            {
                mainPageInstance = new mainPage();
            }

            if (!placeholder.Controls.Contains(mainPageInstance))
            {
                ChangeControl(mainPageInstance);
            }
        }

        private void SwitchToHomePage()
        {
            if (homePageInstance != null && !placeholder.Controls.Contains(homePageInstance))
            {
                ChangeControl(homePageInstance);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            TopMost = siticoneButton2.Checked;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (siticoneButton3.Checked)
                {
                    // Attempt to acquire the mutex
                    if (multiBloxMutex.WaitOne(0))
                    {
                        MessageBox.Show("MultiRoblox is started! [WARNING: CAN INCLUDE BUGS]", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Close Roblox before enabling MultiRoblox!", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        siticoneButton3.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Shutting down MultiRoblox...", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    if (multiBloxMutex.WaitOne(0))
                    {
                        NanoAPI.MainFunctions.KillRoblox();
                        multiBloxMutex.ReleaseMutex();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}