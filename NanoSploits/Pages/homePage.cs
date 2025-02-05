using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NanoPages
{
    public partial class homePage : UserControl
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://site248760110.fo.team/");
        }

        private void siticoneButton13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Own API in development, because fluxx api is buggy asf", "NanoSploit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //DialogResult warning = MessageBox.Show("Hey! If you do this, AutoInject will be disabled. You are sure about that?", "NanoSploit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //if (warning == DialogResult.Yes)
            //{
            //    CoreFunctions.SetAutoInject(false);
            //    attachManual.Text = "Attach";
            //    CoreFunctions.Inject();
            //}
            //else
            //{
            //    MessageBox.Show("Action aborted", "NanoSploit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }
    }
}
