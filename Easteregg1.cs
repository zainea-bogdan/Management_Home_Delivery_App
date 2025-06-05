using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatie_zainea_bogdan
{
    public partial class Easteregg1 : Form
    {
        Form1 mainFrame;
        public Easteregg1(Form1 mainFrame1,string nr)
        {
            InitializeComponent();
            mainFrame = mainFrame1;
            if(nr== "easteregg1")
            {
                axWindowsMediaPlayer1.URL = "/.Terry Crews and Ghost ( I need you, I miss you ) Song.mp4";
                axWindowsMediaPlayer1.settings.autoStart = true;
            }
            if(nr=="easteregg2")
            {
                axWindowsMediaPlayer1.URL = "./The Super Mario Bros. Movie.mp4";
                axWindowsMediaPlayer1.settings.autoStart = true;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainFrame.Show();
            this.Close();
        }
    }
}
