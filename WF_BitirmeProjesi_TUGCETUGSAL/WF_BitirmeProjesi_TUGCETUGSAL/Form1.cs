using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    public partial class Form1 : Form
    {
        Personel_Kayit_Form Pkf = new Personel_Kayit_Form();
        Personel_Arama Pa = new Personel_Arama();
        Departman_Kayit_Form Dkp = new Departman_Kayit_Form();

        
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_personelkayit_Click(object sender, EventArgs e)
        {
            
            Pkf.ShowDialog();
            
        }

        private void btn_departmanKayit_Click(object sender, EventArgs e)
        {
            Dkp.ShowDialog();
           
        }

        private void btn_personelArama_Click(object sender, EventArgs e)
        {
            Pa.ShowDialog();
            
        }
    }
}
