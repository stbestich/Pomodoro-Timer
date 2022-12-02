namespace PomodoroTimer
{
    partial class TimeIsUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeIsUpForm));
            this.ShortBreakPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TimeIsUpLable = new System.Windows.Forms.Label();
            this.OKButton = new Guna.UI2.WinForms.Guna2Button();
            this.OKButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ShortBreakPanel
            // 
            this.ShortBreakPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortBreakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ShortBreakPanel.Location = new System.Drawing.Point(299, 318);
            this.ShortBreakPanel.Name = "ShortBreakPanel";
            this.ShortBreakPanel.Size = new System.Drawing.Size(0, 13);
            this.ShortBreakPanel.TabIndex = 18;
            this.ShortBreakPanel.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.OKButtonPanel;
            // 
            // TimeIsUpLable
            // 
            this.TimeIsUpLable.AutoSize = true;
            this.TimeIsUpLable.BackColor = System.Drawing.Color.Transparent;
            this.TimeIsUpLable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIsUpLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(159)))), ((int)(((byte)(122)))));
            this.TimeIsUpLable.Location = new System.Drawing.Point(126, 39);
            this.TimeIsUpLable.Name = "TimeIsUpLable";
            this.TimeIsUpLable.Size = new System.Drawing.Size(174, 32);
            this.TimeIsUpLable.TabIndex = 22;
            this.TimeIsUpLable.Text = "TIME IS UP!";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.BackColor = System.Drawing.Color.Transparent;
            this.OKButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.OKButton.BorderRadius = 4;
            this.OKButton.BorderThickness = 3;
            this.OKButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OKButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OKButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OKButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OKButton.FillColor = System.Drawing.Color.Transparent;
            this.OKButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.OKButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.OKButton.Location = new System.Drawing.Point(147, 90);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(132, 69);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "OK ^_^";
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            this.OKButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseDown);
            this.OKButton.MouseEnter += new System.EventHandler(this.OKButton_MouseEnter);
            this.OKButton.MouseLeave += new System.EventHandler(this.OKButton_MouseLeave);
            this.OKButton.MouseHover += new System.EventHandler(this.OKButton_MouseHover);
            this.OKButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OKButton_MouseUp);
            // 
            // OKButtonPanel
            // 
            this.OKButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.OKButtonPanel.Location = new System.Drawing.Point(148, 146);
            this.OKButtonPanel.Name = "OKButtonPanel";
            this.OKButtonPanel.Size = new System.Drawing.Size(130, 16);
            this.OKButtonPanel.TabIndex = 23;
            this.OKButtonPanel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimeIsUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 200);
            this.Controls.Add(this.TimeIsUpLable);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.OKButtonPanel);
            this.Controls.Add(this.ShortBreakPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeIsUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMODORO! *NEW MESSAGE!";
            this.Load += new System.EventHandler(this.TimeIsUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel ShortBreakPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label TimeIsUpLable;
        private Guna.UI2.WinForms.Guna2Button OKButton;
        private Guna.UI2.WinForms.Guna2Panel OKButtonPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}