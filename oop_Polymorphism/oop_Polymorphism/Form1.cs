using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace oop_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_nokia_Click(object sender, EventArgs e)
        {
            Nokia phone = new Nokia();
            phone.CallSound();

        }

        private void btn_samsung_Click(object sender, EventArgs e)
        {
            Samsung phone = new Samsung();
            phone.CallSound();
        }

        private void btn_iphone_Click(object sender, EventArgs e)
        {
            Iphone phone = new Iphone();
            phone.CallSound();
        }
    }
}
