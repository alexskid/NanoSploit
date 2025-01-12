using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Zorara;

namespace NanoPages
{
    public partial class mainPage : UserControl
    {
        public mainPage()
        {
            InitializeComponent();
            showScriptsPanel();

            codeEditor1.Theme = "twilight";
            codeEditor1.HighlighterMode = "lua";
            codeEditor1.Text = "print(\"Nano got updated again\")\n-- Now on yougame.biz!";
            codeEditor1.Load();
        }
        private void showExecutorPanel()
        {
            executorPanel.Dock = DockStyle.Fill;
            executorPanel.BringToFront();
            scriptPanel.Visible = false;
            scriptPanel.AutoScroll = false;
            executorPanel.Visible = true;
        }
        private void showScriptsPanel()
        {
            scriptPanel.Dock = DockStyle.Fill;
            scriptPanel.BringToFront();
            scriptPanel.Visible = true;
            scriptPanel.AutoScroll = true;
            executorPanel.Visible = false;
        }
        private void showChatPanel()
        {
            // coming soon
        }
        private void applyWalkSpeed_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your walkspeed will be : {wSpeedBox.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CoreFunctions.ExecuteScript($"game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = {wSpeedBox.Text}");
        }

        private void applyJumpPower_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your jumppower will be = {jPowerBox.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CoreFunctions.ExecuteScript($"game.Players.LocalPlayer.Character.Humanoid.JumpPower = {jPowerBox.Text}");
        }

        private void siticoneButton8_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your gravitation will be = {gravityBox.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CoreFunctions.ExecuteScript($"game.Workspace.Gravity = {gravityBox.Text}");
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet('https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source'))()");
        }

        private void siticoneButton6_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt\"))()");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Infinite%20Jump.txt\"))()");
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Fly.txt\"))()");
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/WRD%20ESP.txt\"))()");
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/BTools.txt\"))()");
        }

        private void siticoneButton7_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Click%20Teleport.txt\"))()");
        }

        private void executeBtnPage_Click(object sender, EventArgs e)
        {
            showExecutorPanel();
        }

        private void scriptBtnPage_Click(object sender, EventArgs e)
        {
            showScriptsPanel();
        }

        private void siticoneButton9_Click(object sender, EventArgs e)
        {
            try
            {
                CoreFunctions.ExecuteScript(codeEditor1.Text);
            }
            catch (Exception ex) {
                MessageBox.Show($"Got a error while doing this action, make sure your av is disabled : \n{ex.Message}", "NanoSploit", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void siticoneButton10_Click(object sender, EventArgs e)
        {
            codeEditor1.Text = string.Empty;
        }

        private void siticoneButton11_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files (.txt)|.txt|Lua Files (.lua)|.lua|Other Files (*)|*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string script = File.ReadAllText(dialog.FileName);
                codeEditor1.Text = script;
            }
        }

        private void siticoneButton12_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Text Files (.txt)|.txt|Lua Files (.lua)|.lua|Other Files (*)|*",
                DefaultExt = "lua",
                Title = "Save Lua or Text File"
            };
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://github.com/ltseverydayyou/uuuuuuu/blob/main/UNC%20test?raw=true\"))()");
        }

        private void creditsBtnPage_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Dear {Environment.UserName}, our chat is not ready. But we have telegram channel!", "Did developer is stupid?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Process.Start("https://t.me/nano4free");
        }

        private void siticoneButton14_Click(object sender, EventArgs e)
        {
            CoreFunctions.ExecuteScript("loadstring(game:HttpGet(\"https://pastefy.app/wa3v2Vgm/raw\"))() ");
        }
    }
}
