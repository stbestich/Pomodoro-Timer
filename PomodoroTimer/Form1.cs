/*
 ██████╗████████╗   ██████╗ ███████╗ ██████╗████████╗██╗ █████╗ ██╗  ██╗██╗  ██╗██╗  ██╗
██╔════╝╚══██╔══╝   ██╔══██╗██╔════╝██╔════╝╚══██╔══╝██║██╔══██╗██║  ██║██║  ██║██║  ██║
╚█████╗    ██║      ██████╦╝█████   ╚█████╗    ██║   ██║██║  ╚═╝███████║███████║███████║
 ╚═══██╗   ██║      ██╔══██╗██╔══╝   ╚═══██╗   ██║   ██║██║  ██╗██╔══██║██╔══██║██╔══██║
██████╔╝   ██║   ██╗██████╦╝███████╗██████╔╝   ██║   ██║╚█████╔╝██║  ██║██║  ██║██║  ██║
╚═════╝    ╚═╝   ╚═╝╚═════╝ ╚══════╝╚═════╝    ╚═╝   ╚═╝ ╚════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝                              
*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        #region --Ненужные методы--
        private void Seconds_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        #endregion

        #region --Управление кнопками--
        void TimerStarted()
        {
            StartButton.Hide();
            ButtonPanel.Hide();
            LogoBox.Hide();
            guna2Button1.Hide();
            guna2Button2.Hide();

            ShortBreakPanel.Hide();
            LongBreakPanel.Hide();

            UnpauseButon.Show();
            PauseButon.Show();
            StopButton.Show();

            UnpausePanel.Show();
            StopPanel.Show();
            PlayPanel.Show();

            CHiloutLabel.Hide();

            Minutes.Show();
            Seconds.Show();
        }

        void TimerStoped()
        {
            StartButton.Show();
            ButtonPanel.Show();
            LogoBox.Show();
            guna2Button1.Show();
            guna2Button2.Show();

            ShortBreakPanel.Show();
            LongBreakPanel.Show();

            UnpauseButon.Hide();
            PauseButon.Hide();
            StopButton.Hide();

            UnpausePanel.Hide();
            StopPanel.Hide();
            PlayPanel.Hide();

            CHiloutLabel.Show();

            Minutes.Hide();
            Seconds.Hide();
        }

        void ButtonSoundEffect()
        {
            //s Звук при нажатии кнопки
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"PomodoroTimer.pressedButtonSound.wav");
            SoundPlayer buttonSound = new SoundPlayer(resourceStream);
            buttonSound.Play();
            //e Звук при нажатии кнопки
        }

        void TimerStoppedSoundEffect()
        {
            System.Reflection.Assembly assembly1 = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream1 = assembly1.GetManifestResourceStream(@"PomodoroTimer.TimerStoppedSoundEffect.wav");
            SoundPlayer TimerStoppedSoundEffect = new SoundPlayer(resourceStream1);
            TimerStoppedSoundEffect.Play(); 
        }
        #endregion

        #region --Управление Таймером--
        private int timeLeft;

        void TimerControl()
        {
            this.timeLeft = 25 * 60;
            Minutes.Text = (this.timeLeft / 60).ToString("00");
            Seconds.Text = (this.timeLeft % 60).ToString("00");
            timerCtrl.Start();
        }

        //s 5 minutes Break
        void shortBreak()
        {
            this.timeLeft = 5 * 60;
            Minutes.Text = (this.timeLeft / 60).ToString("00");
            Seconds.Text = (this.timeLeft % 60).ToString("00");
            timerCtrl.Start();
        }
        //e 5 minutes break

        //s 15 minutes break
        void longBreak()
        {
            this.timeLeft = 15 * 60;
            Minutes.Text = (this.timeLeft / 60).ToString("00");
            Seconds.Text = (this.timeLeft % 60).ToString("00");
            timerCtrl.Start();
        }
        //e 15 minutes break

        private void timerCtrl_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft == 0)
            {
                timerCtrl.Stop();
                TimerStoppedSoundEffect();
                TimeIsUpForm messageform = new TimeIsUpForm();
                messageform.ShowDialog();
            }
            else
            {
                this.timeLeft--;
                Minutes.Text = (this.timeLeft / 60).ToString("00");
                Seconds.Text = (this.timeLeft % 60).ToString("00");
            }
        }
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TimerStarted();
            TimerControl();
        }

        //Start Button
        private void StartButton_MouseDown(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void StartButton_MouseUp(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y - 4);
        }

        //Stop Button
        private void StopButton_Click(object sender, EventArgs e)
        {
            TimerStoped();
        }

        private void StopButton_MouseDown(object sender, MouseEventArgs e)
        {
            StopButton.Location = new Point(StopButton.Location.X, StopButton.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void StopButton_MouseUp(object sender, MouseEventArgs e)
        {
            StopButton.Location = new Point(StopButton.Location.X, StopButton.Location.Y - 4);
        }

        
        //Pause Button
        private void PauseButon_Click(object sender, EventArgs e)
        {
            timerCtrl.Stop();
        }

        private void PauseButon_MouseDown(object sender, MouseEventArgs e)
        {
            PauseButon.Location = new Point(PauseButon.Location.X, PauseButon.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void PauseButon_MouseUp(object sender, MouseEventArgs e)
        {
            PauseButon.Location = new Point(PauseButon.Location.X, PauseButon.Location.Y - 4);
        }

        
        
        //Unpase Button
        private void UnpauseButon_Click(object sender, EventArgs e)
        {
            timerCtrl.Start();
        }

        private void UnpauseButon_MouseDown(object sender, MouseEventArgs e)
        {
            UnpauseButon.Location = new Point(UnpauseButon.Location.X, UnpauseButon.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void UnpauseButon_MouseUp(object sender, MouseEventArgs e)
        {
            UnpauseButon.Location = new Point(UnpauseButon.Location.X, UnpauseButon.Location.Y - 4);
        }

        
        //Short break button
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            TimerStarted();
            shortBreak();
        }

        private void guna2Button1_MouseDown(object sender, MouseEventArgs e)
        {
            guna2Button1.Location = new Point(guna2Button1.Location.X, guna2Button1.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void guna2Button1_MouseUp(object sender, MouseEventArgs e)
        {
            guna2Button1.Location = new Point(guna2Button1.Location.X, guna2Button1.Location.Y - 4);
        }



        //Long Break button
        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            TimerStarted();
            longBreak();
        }

        private void guna2Button2_MouseDown(object sender, MouseEventArgs e)
        {
            guna2Button2.Location = new Point(guna2Button2.Location.X, guna2Button2.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void guna2Button2_MouseUp(object sender, MouseEventArgs e)
        {
            guna2Button2.Location = new Point(guna2Button2.Location.X, guna2Button2.Location.Y - 4);
        }
    }
}
