using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayı1 = 0;
        int sayı2 = 0;
        int seviye = 0;
        Random rastgele = new Random();
        Random rastgele2 = new Random();
        private void button3_Click(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
            label4.BackColor = Color.Transparent;
            label4.Text = "-";
            button3.Text = "Devam";
            seviye++;
            label3.Text = seviye.ToString();
          
     
                if (seviye == 1)
                {
                    int rastgelesayı1 = rastgele.Next(1, 4);
                    if (rastgelesayı1 == 1)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 2)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                    }
                    if (rastgelesayı1 == 3)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                }
                if (seviye == 1)
                {
                    int rastgelesayı2 = rastgele2.Next(1, 7);
                    if (rastgelesayı2 == 1)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 2)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 3)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 4)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 5)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 6)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                }

                //seviye2
                if (seviye == 2)
                {
                    int rastgelesayı1 = rastgele.Next(1, 7);
                    if (rastgelesayı1 == 1)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 2)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "Leonardo DiCaprio";
                    }
                    if (rastgelesayı1 == 3)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                    if (rastgelesayı1 == 4)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 5)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                    }
                    if (rastgelesayı1 == 6)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                }
                //seviye 2
                if (seviye == 2)
                {
                    int rastgelesayı2 = rastgele2.Next(1, 4);
                    if (rastgelesayı2 == 1)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 2)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 3)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                   

                }
                //seviye 3
                if (seviye == 3)
                {
                    int rastgelesayı1 = rastgele.Next(1, 7);
                    if (rastgelesayı1 == 1)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 2)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "Leonardo DiCaprio";
                    }
                    if (rastgelesayı1 == 3)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                    if (rastgelesayı1 == 4)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 5)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                    }
                    if (rastgelesayı1 == 6)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                }
                //seviye 3
                if (seviye == 3)
                {
                    int rastgelesayı2 = rastgele2.Next(1, 7);
                    if (rastgelesayı2 == 1)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 2)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 3)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 4)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 5)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 6)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }

                }
                //seviye 4
                if (seviye == 4)
                {
                    int rastgelesayı1 = rastgele.Next(1, 7);
                    if (rastgelesayı1 == 1)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "A";
                    }
                    if (rastgelesayı1 == 2)
                    {
                        pictureBox1.ImageLocation = "foto/adınıyok.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "A";
                    }
                    if (rastgelesayı1 == 3)
                    {
                        pictureBox1.ImageLocation = "foto/ata.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                    if (rastgelesayı1 == 4)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 5)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                    }
                    if (rastgelesayı1 == 6)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                }
                //seviye 4
                if (seviye == 4)
                {
                    int rastgelesayı2 = rastgele2.Next(1, 7);
                    if (rastgelesayı2 == 1)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 2)
                    {
                        pictureBox2.ImageLocation = "foto/polat.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 3)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 4)
                    {
                        pictureBox2.ImageLocation = "foto/beyaz.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 5)
                    {
                        pictureBox2.ImageLocation = "foto/d.jpeg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 6)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }

                }
                //seviye 5
                if (seviye == 5)
                {
                    int rastgelesayı1 = rastgele.Next(1, 7);
                    if (rastgelesayı1 == 1)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "A";
                    }
                    if (rastgelesayı1 == 2)
                    {
                        pictureBox1.ImageLocation = "foto/adınıyok.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "A";
                    }
                    if (rastgelesayı1 == 3)
                    {
                        pictureBox1.ImageLocation = "foto/ata.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                    if (rastgelesayı1 == 4)
                    {
                        pictureBox1.ImageLocation = "foto/a.jpg";
                        sayı1 = 1000;
                        label1.Text = sayı1.ToString();
                        button1.Text = "TUPAC";
                    }
                    if (rastgelesayı1 == 5)
                    {
                        pictureBox1.ImageLocation = "foto/c.jpg";
                        sayı1 = 2000;
                        label1.Text = sayı1.ToString();
                    }
                    if (rastgelesayı1 == 6)
                    {
                        pictureBox1.ImageLocation = "foto/kenan.jpg";
                        sayı1 = 3000;
                        label1.Text = sayı1.ToString();

                    }
                }
                //seviye 5
                if (seviye == 5)
                {
                    int rastgelesayı2 = rastgele2.Next(1, 4);
                    if (rastgelesayı2 == 1)
                    {
                        pictureBox2.ImageLocation = "foto/b.jpg";
                        sayı2 = 200;
                        label2.Text = sayı2.ToString();
                    }
                    if (rastgelesayı2 == 2)
                    {
                        pictureBox2.ImageLocation = "foto/polat.jpg";
                        sayı2 = 300;
                        label2.Text = sayı2.ToString();
                    }

                    if (rastgelesayı2 == 3)
                    {
                        pictureBox2.ImageLocation = "foto/murat.jpg";
                        sayı2 = 400;
                        label2.Text = sayı2.ToString();
                    }
                   
                }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sayı1 > sayı2)
            {
                label4.Text = "Doğru";
                label4.BackColor = Color.Green;
            }
            else { label4.BackColor = Color.Red; label4.Text = "yanlış"; 
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sayı2 > sayı1)
            {
                label4.Text = "Doğru";
                label4.BackColor = Color.Green;
            }
            else
            {
                label4.BackColor = Color.Red; label4.Text = "yanlış";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayı1 = 0;
            sayı2 = 0; seviye = 0;
            button3.Text = "Başlat";
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            label4.Text = "-";
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
      
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("oyun sadece taslaktırDevam ettirilebilir ve 5.seviye'ye kadar yapılmıştırayriyetten bütün cevaplar "+"a"+" dır budun nedenı a dakı ınsanların sayısı daha fazla oldugu ıcın dogru bılgılı olan sayıyı girince oyuntamamlanmıs olur.");
        }
    }
}
