using System.Media;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int xal = 0;
        int bombaYeri = 0;
        int pisikSayi = 0;

        private void YeniOyunBaslat()
        {
            xal = 0;
            pisikSayi = 0;
            label2.Text = "0";

            pictureBox1.Enabled = true;
            pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            pictureBox2.Enabled = true;
            pictureBox2.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            pictureBox3.Enabled = true;
            pictureBox3.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            pictureBox4.Enabled = true;
            pictureBox4.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            pictureBox5.Enabled = true;
            pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            pictureBox6.Enabled = true;
            pictureBox6.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\images.png");

            Random rnd = new Random();
            bombaYeri = rnd.Next(1, 7);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void QalibiyyetiYoxla()
        {
            if (pisikSayi == 5)
            {
                MessageBox.Show("Oyunu qazandınız, Yeni oyun üçün ok düyməsinə basın", "Təbriklər", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniOyunBaslat();
            }
        }

        private void OyunlariKilitlə()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;

            if (bombaYeri == 1)
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Enabled = false;

            if (bombaYeri == 2)
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox2.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Enabled = false;

            if (bombaYeri == 3)
            {
                pictureBox3.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox3.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Enabled = false;

            if (bombaYeri == 4)
            {
                pictureBox4.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox4.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Enabled = false;

            if (bombaYeri == 5)
            {
                pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox5.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Enabled = false;

            if (bombaYeri == 6)
            {
                pictureBox6.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\bomba.png");

                SoundPlayer soundPlayer = new SoundPlayer("C:\\Users\\user\\Desktop\\Cat\\explosion.wav");
                soundPlayer.Play();

                MessageBox.Show("Oyun bitdi");
                OyunlariKilitlə();
            }
            else
            {
                pictureBox6.Image = Image.FromFile("C:\\Users\\user\\Desktop\\Cat\\cat.png");

                xal = xal + 1;
                pisikSayi++;
                label2.Text = xal.ToString();

                QalibiyyetiYoxla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
