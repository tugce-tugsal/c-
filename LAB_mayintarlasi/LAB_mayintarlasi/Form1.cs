using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_mayintarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<int> mayinindexler = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                int mayinindex = rnd.Next(0, 170);
                if (!mayinindexler.Contains(mayinindex))//dizide aynısı çıkmasın sayının istersek,ünlem işareti olmazsa form açılmaz çünkü i=-1 olur yukarı çıkar 0 değerini alır tekrar tekrar..
                {
                    mayinindexler.Add(mayinindex);
                        
                }
                else
                {
                    i--;
                }
            }

            
            for (int i = 0; i < 169; i++)
            {
                PictureBox pcb = new PictureBox();
                pcb.Name = "renklikutu" + i;
                pcb.Width = 30;
                pcb.Height = 30;
                // pcb.Size = new System.Drawing.Size(30, 30);
                pcb.Margin = new Padding(1);//dış kenarlık
                pcb.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
                //i nin o anki değeri mayınlarindex dizisinde yer alıyorsa mayın olarak işaretleyebilirz.
                if (mayinindexler.Contains(i))
                {
                    pcb.Tag = true; //int,string her değer olur.
                }
                else pcb.Tag = false;
                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);

            }
            timer1.Start();


        }

        private void Pcb_Click(object sender, EventArgs e)
        {
            //sender o an tıkladığımızda picturebox'ın tüm değerlerini bize teslim eder.
            PictureBox yakalananKutu = (PictureBox)sender;
            Color kutununRengi = yakalananKutu.BackColor;
            if ((bool)yakalananKutu.Tag)//=true
            {
                timer1.Stop();
                //yakalanan kutunun rengiyle tüm kutularu boyaylım
                foreach (var item in flowLayoutPanel1.Controls)
                {
                    ((PictureBox)item).BackColor = kutununRengi;
                }
                MessageBox.Show("mayına bastınız","OYUN BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                
            }
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var kutu in flowLayoutPanel1.Controls)
            {
               ((PictureBox) kutu).BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            }
        }
        //ödev  MessageBox.Show("mayına bastınız","OYUN BİTTİ",MessageBoxButtons.OK,MessageBoxIcon.Stop); kısmını oyuna tekrar dönmeli yap.

    }
}
