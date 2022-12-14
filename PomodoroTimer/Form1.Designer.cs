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
            this.PauseButon = new Guna.UI2.WinForms.Guna2Button();
            this.StopButton = new Guna.UI2.WinForms.Guna2Button();
            this.UnpausePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PlayPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.StopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Minutes = new System.Windows.Forms.Label();
            this.Seconds = new System.Windows.Forms.Label();
            this.LogoBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timerCtrl = new System.Windows.Forms.Timer(this.components);
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.LongBreakPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShortBreakPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.CHiloutLabel = new System.Windows.Forms.Label();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
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
            this.StartButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.StartButton.Location = new System.Drawing.Point(43, 276);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(207, 82);
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
            this.ButtonPanel.Location = new System.Drawing.Point(45, 348);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(203, 13);
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
            this.UnpauseButon.Location = new System.Drawing.Point(248, 289);
            this.UnpauseButon.Name = "UnpauseButon";
            this.UnpauseButon.Size = new System.Drawing.Size(98, 69);
            this.UnpauseButon.TabIndex = 2;
            this.UnpauseButon.Visible = false;
            this.UnpauseButon.Click += new System.EventHandler(this.UnpauseButon_Click);
            this.UnpauseButon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UnpauseButon_MouseDown);
            this.UnpauseButon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UnpauseButon_MouseUp);
            // 
            // PauseButon
            // 
            this.PauseButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseButon.BackColor = System.Drawing.Color.Transparent;
            this.PauseButon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PauseButon.BorderRadius = 4;
            this.PauseButon.BorderThickness = 3;
            this.PauseButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.PauseButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.PauseButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.PauseButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.PauseButon.FillColor = System.Drawing.Color.Transparent;
            this.PauseButon.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.PauseButon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.PauseButon.Location = new System.Drawing.Point(144, 289);
            this.PauseButon.Name = "PauseButon";
            this.PauseButon.Size = new System.Drawing.Size(98, 69);
            this.PauseButon.TabIndex = 3;
            this.PauseButon.Visible = false;
            this.PauseButon.Click += new System.EventHandler(this.PauseButon_Click);
            this.PauseButon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PauseButon_MouseDown);
            this.PauseButon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PauseButon_MouseUp);
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
            this.StopButton.Size = new System.Drawing.Size(98, 69);
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
            this.PlayPanel.Location = new System.Drawing.Point(250, 348);
            this.PlayPanel.Name = "PlayPanel";
            this.PlayPanel.Size = new System.Drawing.Size(94, 13);
            this.PlayPanel.TabIndex = 6;
            this.PlayPanel.Visible = false;
            // 
            // StopPanel
            // 
            this.StopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.StopPanel.Location = new System.Drawing.Point(43, 348);
            this.StopPanel.Name = "StopPanel";
            this.StopPanel.Size = new System.Drawing.Size(94, 13);
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
            this.Minutes.Location = new System.Drawing.Point(23, 163);
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
            this.Seconds.Font = new System.Drawing.Font("Arial Rounded MT Bold", 37.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.Seconds.Location = new System.Drawing.Point(150, 182);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(106, 73);
            this.Seconds.TabIndex = 10;
            this.Seconds.Text = "00";
            this.Seconds.Visible = false;
            this.Seconds.Click += new System.EventHandler(this.Seconds_Click);
            // 
            // LogoBox
            // 
            this.LogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoBox.Image")));
            this.LogoBox.ImageRotate = 0F;
            this.LogoBox.Location = new System.Drawing.Point(12, 12);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(358, 258);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 11;
            this.LogoBox.TabStop = false;
            this.LogoBox.UseTransparentBackground = true;
            // 
            // timerCtrl
            // 
            this.timerCtrl.Interval = 1000;
            this.timerCtrl.Tick += new System.EventHandler(this.timerCtrl_Tick);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button2.BorderRadius = 4;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.guna2Button2.Location = new System.Drawing.Point(200, 436);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(118, 69);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Text = "15 MIN!";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click_1);
            this.guna2Button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Button2_MouseDown);
            this.guna2Button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Button2_MouseUp);
            // 
            // LongBreakPanel
            // 
            this.LongBreakPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LongBreakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.LongBreakPanel.Location = new System.Drawing.Point(203, 495);
            this.LongBreakPanel.Name = "LongBreakPanel";
            this.LongBreakPanel.Size = new System.Drawing.Size(114, 13);
            this.LongBreakPanel.TabIndex = 15;
            this.LongBreakPanel.Visible = false;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 10;
            this.guna2Elipse4.TargetControl = this.ShortBreakPanel;
            // 
            // ShortBreakPanel
            // 
            this.ShortBreakPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortBreakPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.ShortBreakPanel.Location = new System.Drawing.Point(69, 495);
            this.ShortBreakPanel.Name = "ShortBreakPanel";
            this.ShortBreakPanel.Size = new System.Drawing.Size(114, 13);
            this.ShortBreakPanel.TabIndex = 13;
            this.ShortBreakPanel.Visible = false;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 10;
            this.guna2Elipse5.TargetControl = this.LongBreakPanel;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.guna2Button1.Location = new System.Drawing.Point(66, 436);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 69);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "5 MIN!";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            this.guna2Button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Button1_MouseDown);
            this.guna2Button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Button1_MouseUp);
            // 
            // CHiloutLabel
            // 
            this.CHiloutLabel.AutoSize = true;
            this.CHiloutLabel.BackColor = System.Drawing.Color.Transparent;
            this.CHiloutLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHiloutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(159)))), ((int)(((byte)(122)))));
            this.CHiloutLabel.Location = new System.Drawing.Point(115, 401);
            this.CHiloutLabel.Name = "CHiloutLabel";
            this.CHiloutLabel.Size = new System.Drawing.Size(160, 32);
            this.CHiloutLabel.TabIndex = 16;
            this.CHiloutLabel.Text = "CHILLOUT";
            // 
            // guna2Button3
            // 
            this.guna2Button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button3.BackgroundImage")));
            this.guna2Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.guna2Button3.BorderRadius = 4;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(157)))), ((int)(((byte)(120)))));
            this.guna2Button3.Location = new System.Drawing.Point(250, 276);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(94, 82);
            this.guna2Button3.TabIndex = 17;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            this.guna2Button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Button3_MouseDown);
            this.guna2Button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Button3_MouseUp);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.guna2Panel1.Location = new System.Drawing.Point(252, 348);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(92, 13);
            this.guna2Panel1.TabIndex = 18;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 10;
            this.guna2Elipse6.TargetControl = this.guna2Panel1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(382, 553);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.CHiloutLabel);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.LongBreakPanel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ShortBreakPanel);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.Seconds);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButon);
            this.Controls.Add(this.UnpauseButon);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.StopPanel);
            this.Controls.Add(this.UnpausePanel);
            this.Controls.Add(this.PlayPanel);
            this.Controls.Add(this.LogoBox);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POMODORO!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button StartButton;
        private Guna.UI2.WinForms.Guna2Panel ButtonPanel;
        private Guna.UI2.WinForms.Guna2Elipse ButtonPanelElipse;
        private Guna.UI2.WinForms.Guna2Button UnpauseButon;
        private Guna.UI2.WinForms.Guna2Button PauseButon;
        private Guna.UI2.WinForms.Guna2Button StopButton;
        private Guna.UI2.WinForms.Guna2Panel UnpausePanel;
        private Guna.UI2.WinForms.Guna2Panel PlayPanel;
        private Guna.UI2.WinForms.Guna2Panel StopPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label Seconds;
        private Guna.UI2.WinForms.Guna2PictureBox LogoBox;
        private System.Windows.Forms.Timer timerCtrl;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Panel LongBreakPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Panel ShortBreakPanel;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label CHiloutLabel;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
    }
}

