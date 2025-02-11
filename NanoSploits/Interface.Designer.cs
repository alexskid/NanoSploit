﻿namespace NanoForm
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.dragPanel = new Siticone.UI.WinForms.SiticonePanel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.siticoneButton3 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton2 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.headLabel = new System.Windows.Forms.Label();
            this.siticoneDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.placeholder = new Siticone.UI.WinForms.SiticonePanel();
            this.siticoneElipse = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.dragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dragPanel.Controls.Add(this.statusLabel);
            this.dragPanel.Controls.Add(this.siticoneButton3);
            this.dragPanel.Controls.Add(this.siticoneButton2);
            this.dragPanel.Controls.Add(this.siticoneButton1);
            this.dragPanel.Controls.Add(this.headLabel);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.ShadowDecoration.BorderRadius = 7;
            this.dragPanel.ShadowDecoration.Depth = 50;
            this.dragPanel.ShadowDecoration.Enabled = true;
            this.dragPanel.ShadowDecoration.Parent = this.dragPanel;
            this.dragPanel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.dragPanel.Size = new System.Drawing.Size(737, 47);
            this.dragPanel.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.statusLabel.Location = new System.Drawing.Point(13, 14);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(30, 20);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "⚫";
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneButton3.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.siticoneButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton3.ForeColor = System.Drawing.Color.White;
            this.siticoneButton3.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Location = new System.Drawing.Point(449, 0);
            this.siticoneButton3.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(118, 47);
            this.siticoneButton3.TabIndex = 3;
            this.siticoneButton3.Text = "MultiRoblox";
            this.siticoneButton3.Click += new System.EventHandler(this.siticoneButton3_Click);
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.siticoneButton2.ButtonMode = Siticone.UI.WinForms.Enums.ButtonMode.ToogleButton;
            this.siticoneButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.siticoneButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Location = new System.Drawing.Point(567, 0);
            this.siticoneButton2.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(119, 47);
            this.siticoneButton2.TabIndex = 2;
            this.siticoneButton2.Text = "TopMost";
            this.siticoneButton2.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(687, 0);
            this.siticoneButton1.Margin = new System.Windows.Forms.Padding(2);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(50, 47);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "✖️";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.headLabel.Location = new System.Drawing.Point(47, 13);
            this.headLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(103, 22);
            this.headLabel.TabIndex = 0;
            this.headLabel.Text = "NanoSploit";
            // 
            // siticoneDragControl
            // 
            this.siticoneDragControl.TargetControl = this.dragPanel;
            // 
            // placeholder
            // 
            this.placeholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeholder.Location = new System.Drawing.Point(0, 47);
            this.placeholder.Margin = new System.Windows.Forms.Padding(2);
            this.placeholder.Name = "placeholder";
            this.placeholder.ShadowDecoration.Parent = this.placeholder;
            this.placeholder.Size = new System.Drawing.Size(737, 398);
            this.placeholder.TabIndex = 1;
            // 
            // siticoneElipse
            // 
            this.siticoneElipse.BorderRadius = 10;
            this.siticoneElipse.TargetControl = this;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(737, 445);
            this.Controls.Add(this.placeholder);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NanoSploit";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel dragPanel;
        private System.Windows.Forms.Label headLabel;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton2;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl;
        private Siticone.UI.WinForms.SiticonePanel placeholder;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton3;
        private System.Windows.Forms.Label statusLabel;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse;
    }
}

