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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        //s Анимация кнопки
        private void StartButton_MouseDown(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y + 4);

            //s Звук при нажатии кнопки
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"PomodoroTimer.pressedButtonSound.wav");
            SoundPlayer buttonSound = new SoundPlayer(resourceStream);
            buttonSound.Play();
            //e Звук при нажатии кнопки
        }

        private void StartButton_MouseUp(object sender, MouseEventArgs e)
        {
            StartButton.Location = new Point(StartButton.Location.X, StartButton.Location.Y - 4);
        }
        //e Анимация кнопки
    }
}
