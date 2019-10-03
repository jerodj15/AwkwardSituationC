using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwkardSituation
{
    public partial class Form1 : Form
    {
        
        static string applauseUrl = Path.GetFullPath("Sounds/applause3.wav");
        static string aweUrl = Path.GetFullPath("Sounds/awe");
        static string censorUrl = Path.GetFullPath("Sounds/censor");
        static string cricketsUrl = Path.GetFullPath("Sounds/cricket 2");
        static string dramaUrl = Path.GetFullPath("Sounds/dundundun");
        static string jokeDrumUrl = Path.GetFullPath("Sounds/JokeDrum");
        static string sadUrl = Path.GetFullPath("Sounds/sad");
        static string screamUrl = Path.GetFullPath("Sounds/scream");
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(applauseUrl);
            player.Play();
        }

        private void AweButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(aweUrl);
            player.Play();
        }

        private void CensorButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(censorUrl);
            player.Play();
        }

        private void CricketsButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(cricketsUrl);
            player.Play();
        }

        private void DramaButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(dramaUrl);
            player.Play();
        }

        private void JokeButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(jokeDrumUrl);
            player.Play();
        }

        private void SadButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(sadUrl);
            player.Play();
        }

        private void ScreamButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(screamUrl);
            player.Play();
        }
    }
}
