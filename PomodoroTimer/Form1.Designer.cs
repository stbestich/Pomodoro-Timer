namespace PomodoroTimer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UnpauseButon = new Guna.UI2.WinForms.Guna2Button();
            this.StopButton = new Guna.UI2.WinForms.Guna2Button();
            this.UnpausePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PlayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.StopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.BorderRadius = 4;
            this.StartButton.BorderThickness = 3;
            this.StartButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StartButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StartButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StartButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.StartButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.StartButton.Location = new System.Drawing.Point(66, 276);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(252, 82);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "POMODORO!";
            this.StartButton.UseTransparentBackground = true;
            this.StartButton.Click += new System.EventHandler(this.guna2Button1_Click);
            this.StartButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseDown);
            this.StartButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartButton_MouseUp);
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ButtonPanel.Location = new System.Drawing.Point(68, 348);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(248, 13);
            this.ButtonPanel.TabIndex = 1;
            // 
            // ButtonPanelElipse
            // 
            this.ButtonPanelElipse.BorderRadius = 10;
            this.ButtonPanelElipse.TargetControl = this.ButtonPanel;
            // 
            // UnpauseButon
            // 
            this.UnpauseButon.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UnpauseButon.BackColor = System.Drawing.Color.Transparent;
            this.UnpauseButon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnpauseButon.BackgroundImage")));
            this.UnpauseButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.UnpauseButon.BorderRadius = 4;
            this.UnpauseButon.BorderThickness = 3;
            this.UnpauseButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UnpauseButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UnpauseButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UnpauseButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UnpauseButon.FillColor = System.Drawing.Color.Transparent;
            this.UnpauseButon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.UnpauseButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.UnpauseButon.Location = new System.Drawing.Point(203, 289);
            this.UnpauseButon.Name = "UnpauseButon";
            this.UnpauseButon.Size = new System.Drawing.Size(141, 69);
            this.UnpauseButon.TabIndex = 2;
            this.UnpauseButon.Visible = false;
            this.UnpauseButon.Click += new System.EventHandler(this.UnpauseButon_Click);
            this.UnpauseButon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnpauseButon_MouseDown);
            this.UnpauseButon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UnpauseButon_MouseUp);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopButton.BackgroundImage")));
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.StopButton.BorderRadius = 4;
            this.StopButton.BorderThickness = 3;
            this.StopButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StopButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StopButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StopButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StopButton.FillColor = System.Drawing.Color.Transparent;
            this.StopButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.StopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.StopButton.Location = new System.Drawing.Point(40, 289);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(141, 69);
            this.StopButton.TabIndex = 4;
            this.StopButton.Visible = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            this.StopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopButton_MouseDown);
            this.StopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopButton_MouseUp);
            // 
            // UnpausePanel
            // 
            this.UnpausePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UnpausePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.UnpausePanel.Location = new System.Drawing.Point(146, 348);
            this.UnpausePanel.Name = "UnpausePanel";
            this.UnpausePanel.Size = new System.Drawing.Size(94, 13);
            this.UnpausePanel.TabIndex = 5;
            this.UnpausePanel.Visible = false;
            // 
            // PlayPanel
            // 
            this.PlayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.PlayPanel.Location = new System.Drawing.Point(205, 348);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(137, 13);
            this.PlayPanel.TabIndex = 6;
            this.PlayPanel.Visible = false;
            // 
            // StopPanel
            // 
            this.StopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.StopPanel.Location = new System.Drawing.Point(43, 348);
            this.StopPanel.Name = "StopPanel";
            this.StopPanel.Size = new System.Drawing.Size(137, 13);
            this.StopPanel.TabIndex = 7;
            this.StopPanel.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.StopPanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.PlayPanel;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 10;
            this.guna2Elipse3.TargetControl = this.UnpausePanel;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.BackColor = System.Drawing.Color.Transparent;
            this.Minutes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.Minutes.Location = new System.Drawing.Point(26, 163);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(140, 97);
            this.Minutes.TabIndex = 8;
            this.Minutes.Text = "00";
            this.Minutes.Visible = false;
            // 
            // Seconds
            // 
            this.Seconds.AutoSize = true;
            this.Seconds.BackColor = System.Drawing.Color.Transparent;
            this.Seconds.Font = new System.Drawing.Font("Arial Rounded MT Bold", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.Seconds.Location = new System.Drawing.Point(149, 176);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(119, 81);
            this.Seconds.TabIndex = 10;
            this.Seconds.Text = "00";
            this.Seconds.Visible = false;
            this.Seconds.Click += new System.EventHandler(this.Seconds_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.UnpauseButon);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.StopPanel);
            this.Controls.Add(this.UnpausePanel);
            this.Controls.Add(this.PlayPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2Panel ButtonPanel;
        private Guna.UI2.WinForms.Guna2Elipse ButtonPanelElipse;
        private Guna.UI2.WinForms.Guna2Button UnpauseButon;
        private Guna.UI2.WinForms.Guna2Button StopButton;
        private Guna.UI2.WinForms.Guna2Panel UnpausePanel;
        private Guna.UI2.WinForms.Guna2Panel PlayPanel;
        private Guna.UI2.WinForms.Guna2Panel StopPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Seconds;
    }
}

