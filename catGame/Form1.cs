
using System;
using System.Media;
using System.Windows.Forms;

namespace catGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();

        int bomba;
        int xal = 0;

        bool oyunBitdi = false;

        bool[] acilib = new bool[6];

        PictureBox[] qutular;

        string sekilYolu = Application.StartupPath + @"\Images\";
        string sesYolu = Application.StartupPath + @"\Sound\explosion.wav";

        public Form1()
        {
            InitializeComponent();

            qutular = new PictureBox[]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6
            };

            bomba = r.Next(0, 6);

            for (int i = 0; i < 6; i++)
            {
                qutular[i].ImageLocation = sekilYolu + "pişik.png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xal = 0;
            label2.Text = xal.ToString();

            oyunBitdi = false;

            bomba = r.Next(0, 6);

            for (int i = 0; i < 6; i++)
            {
                acilib[i] = false;
                qutular[i].ImageLocation = sekilYolu + "pişik.png";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Oyundan çıxış edilsinmi?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (oyunBitdi == true)
            {
                return;
            }

            PictureBox p = (PictureBox)sender;

            int yer = Array.IndexOf(qutular, p);

            if (acilib[yer] == true)
            {
                return;
            }

            acilib[yer] = true;

            if (yer == bomba)
            {
                p.ImageLocation = sekilYolu + "bomba.png";

                SoundPlayer ses = new SoundPlayer(sesYolu);
                ses.Play();

                oyunBitdi = true;

                MessageBox.Show("Oyun bitdi!");
            }
            else
            {
                p.ImageLocation = sekilYolu + "cat.png";

                xal++;
                label2.Text = xal.ToString();

                if (xal == 5)
                {
                    oyunBitdi = true;

                    MessageBox.Show("Oyunu qazandınız! Yeni oyun üçün OK düyməsinə bas.");
                }
            }
        }
    }
}
