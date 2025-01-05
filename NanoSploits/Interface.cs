using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using NanoPages;
using Zorara;

namespace NanoForm
{
    public partial class Interface : Form
    {
        private mainPage mainPageInstance;
        private homePage homePageInstance;

        public Interface()
        {
            InitializeComponent();
            checkState = new Timer();
            checkState.Interval = 1000;
            checkState.Tick += checkState_Tick;
            checkState.Start();
            homePageInstance = new homePage();
            ChangeControl(homePageInstance);
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
            bool isInjected = CoreFunctions.IsInjected();
            bool isRobloxOpen = CoreFunctions.IsRobloxOpen();

            if (isRobloxOpen && !isInjected)
            {
                CoreFunctions.Inject();
            }

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
            MessageBox.Show("In development!");
            //if (siticoneButton3.Checked) { 
            //    placeholder.BackColor = Color.FromArgb(50,50,50);
            //    dragPanel.BackColor = Color.FromArgb(45, 45, 45);
            //    siticoneButton1.FillColor = Color.FromArgb(50,50,50);
            //    siticoneButton2.FillColor = Color.FromArgb(50, 50, 50);
            //    siticoneButton3.FillColor = Color.FromArgb(50, 50, 50);
            //}
            //else { 
            //    TopMost = false;
            //}
        }
    }

}
