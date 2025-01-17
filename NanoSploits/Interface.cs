﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using NanoPages;
using Zorara;
using System.Threading;

namespace NanoForm
{
    public partial class Interface : Form
    {
        private mainPage mainPageInstance;
        private homePage homePageInstance;
        private Mutex MultiBLOX;
        public Interface()
        {
            InitializeComponent();
            checkState = new System.Windows.Forms.Timer();
            checkState.Interval = 1000;
            checkState.Tick += checkState_Tick;
            checkState.Start();
            homePageInstance = new homePage();
            ChangeControl(homePageInstance);
            MultiBLOX = new Mutex(false, "ROBLOX_singletonMutex");
        }
        private void ChangeControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.BackColor = Color.Transparent;
            userControl.BringToFront();
            placeholder.Controls.Clear();
            placeholder.Controls.Add(userControl);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            CoreFunctions.SetAutoInject(false);
            CoreFunctions.KillRoblox();
            Application.Exit();
        }

        private void checkState_Tick(object sender, EventArgs e)
        {
            CoreFunctions.SetAutoInject(true);
            bool isInjected = CoreFunctions.IsInjected();
            bool isRobloxOpen = CoreFunctions.IsRobloxOpen();
            if (isInjected)
            {
                statusLabel.Text = "online";
                statusLabel.ForeColor = Color.LightGreen;
                SwitchToMainPage();
            }
            else
            {
                statusLabel.Text = "offline";
                statusLabel.ForeColor = Color.Firebrick;
                SwitchToHomePage();
            }
        }

        private void SwitchToMainPage()
        {
            if (mainPageInstance == null || !placeholder.Controls.Contains(mainPageInstance))
            {
                if (mainPageInstance == null)
                {
                    mainPageInstance = new mainPage();
                }
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
            if (siticoneButton2.Checked) { TopMost = true; }
            else { TopMost = false; }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) {
                if (MultiBLOX.WaitOne(0))
                {
                    MessageBox.Show("MultiRoblox is started! [WARNING: CAN INCLUDE A BUGS]", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Close roblox before enable!", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    siticoneButton3.Checked = false;
                }
            }
            else {
                MessageBox.Show("Shutting down...", "NanoMultiRoblox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (MultiBLOX.WaitOne(0))
                {
                    CoreFunctions.KillRoblox();
                    MultiBLOX.ReleaseMutex();
                }
            }
        }
    }

}
