using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
