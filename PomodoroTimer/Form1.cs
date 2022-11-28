using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

//s - Start 
//e - End
//jf - Jump form
//jt - Jumo to

namespace PomodoroTimer
{
    public partial class Form1 : Form
    {
        //s Button control
        void TimerStarted()
        {
            StartButton.Hide();
            ButtonPanel.Hide();

            UnpauseButon.Show();
            PauseButon.Show();
            StopButton.Show();

            UnpausePanel.Show();
            StopPanel.Show();
            PlayPanel.Show();
        }

        void TimerStoped()
        {
            StartButton.Show();
            ButtonPanel.Show();

            UnpauseButon.Hide();
            PauseButon.Hide();
            StopButton.Hide();

            UnpausePanel.Hide();
            StopPanel.Hide();
            PlayPanel.Hide();
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
        //e Button control
























        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TimerStarted();
        }

        //s Анимация кнопки
        private void StartButton_MouseDown(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y + 4);
            ButtonSoundEffect();
        }

        private void StartButton_MouseUp(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y - 4);
        }
        //e Анимация кнопки



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
    }
}
