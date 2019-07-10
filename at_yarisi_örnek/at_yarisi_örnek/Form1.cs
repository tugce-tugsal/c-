using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at_yarisi_örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_birinciyol_Click(object sender, EventArgs e)
        {

        }

        Random rst = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
           

            

        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
           
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            //Bir kontrolün left property'si o kontrolün sola olan uzaklığını verir.
            
            int bitisuzaklıgı = lbl_birinciyol.Width;
            picture_at1.Left += rst.Next(2, 30);
            picture_at2.Left += rst.Next(2, 30);
            picture_at3.Left += rst.Next(2, 30);


            if (picture_at1.Left <picture_at2.Left &&picture_at2.Left >picture_at3.Left)
            {
                lbl_tablo.Text = "2.At önde devam ediyor.";
            }
            if (picture_at3.Left > picture_at1.Left && picture_at3.Left > picture_at2.Left)
            {
            lbl_tablo.Text= "3.At önde devam ediyor.";
            }
            if (picture_at1.Left > picture_at2.Left && picture_at1.Left > picture_at3.Left)
            {
                lbl_tablo.Text = "1.At önde devam ediyor.";
            }
            

            if (picture_at1.Left > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("Birinci at yarışı kazandı");
            }
            else if (picture_at2.Left > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("İkinci at yarışı kazandı");
            }
            else if (picture_at3.Left > bitisuzaklıgı)
            {
                timer1.Stop();
                MessageBox.Show("Üçüncü at yarışı kazandı");
            }
        }

        private void btn_sıfırla_Click(object sender, EventArgs e)
        {
            picture_at1.Left = 0;
            picture_at2.Left = 0;
            picture_at3.Left = 0;

            timer1.Stop();
            lbl_tablo.Text = null;
        }
    }
}
