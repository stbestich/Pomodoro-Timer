using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PomodoroTimer
{
    public partial class TimeIsUpForm : Form
    {
        public TimeIsUpForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKButton_MouseDown(object sender, MouseEventArgs e)
        {
            OKButton.Location = new Point(OKButton.Location.X, OKButton.Location.Y + 4);
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            System.IO.Stream resourceStream = assembly.GetManifestResourceStream(@"PomodoroTimer.pressedButtonSound.wav");
            SoundPlayer buttonSound = new SoundPlayer(resourceStream);
            buttonSound.Play();
        }

        private void OKButton_MouseUp(object sender, MouseEventArgs e)
        {
            OKButton.Location = new Point(OKButton.Location.X, OKButton.Location.Y - 4);
        }

        private void OKButton_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++) 
            {
                OKButton.Size = new Size(OKButton.Width + 1, OKButton.Height);
            }
        }

        private void TimeIsUpForm_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void OKButton_MouseEnter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                OKButton.Size = new Size(OKButton.Width - 1, OKButton.Height);
            }
        }
    }
}
