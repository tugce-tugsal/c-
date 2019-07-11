using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    public partial class Personel_Arama : Form
    {
        public Personel_Arama()
        {
            InitializeComponent();
        }


      
        private void btn_ara_Click(object sender, EventArgs e)
        {
            //ProjeContext pc = new ProjeContext();
            //pc.Employees.Find(txt_tc_pa.Text);
            //var sonuc= dataGridView1.CurrentRow.Cells["TC"].Value.ToString() == txt_tc_pa.Text

            bool aranankayit = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells["TC"].Value.ToString() == txt_tc_pa.Text)
                {
                    aranankayit = true;
                    lbl_adi.Text = dataGridView1.Rows[i].Cells["Ad"].Value.ToString();
                    lbl_soyadi.Text = dataGridView1.Rows[i].Cells["Soyad"].Value.ToString();
                    lbl_telefon.Text = dataGridView1.Rows[i].Cells["Telefon"].Value.ToString();
                }
            }
        }



        private void Personel_Arama_Load(object sender, EventArgs e)
        {
            ProjeContext pc = new ProjeContext();
            dataGridView1.DataSource = pc.Employees.ToList();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            lbl_adi.Text = "";
            lbl_soyadi.Text = "";
            lbl_telefon.Text = "";
            txt_tc_pa.Text = "";

        }

        private void txt_tc_pa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void txt_adi_KeyPress(object sender, KeyPressEventArgs e)
        {           
                e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                            && !char.IsSeparator(e.KeyChar);
          
        }

        private void txt_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                           && !char.IsSeparator(e.KeyChar);

        }

        private void txt_telno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}


