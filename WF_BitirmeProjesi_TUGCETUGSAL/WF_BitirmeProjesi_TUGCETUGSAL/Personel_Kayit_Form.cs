using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    public partial class Personel_Kayit_Form : Form
    {
        public Personel_Kayit_Form()
        {

            InitializeComponent();

        }

        ProjeContext pc = new ProjeContext();//Projeconyext sınıfından pc nesnesi oluşturuyor.Tablolara pc aracılığıyla ulaşmış olduk.

        private void Personel_Kayit_Form_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = pc.Employees.ToList();
            cb_departman.DisplayMember = "DepartmanID";
            cb_departman.DataSource = pc.Departments.ToList();
            kayitsayisi();

        }
        Employee personel = new Employee();
        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            //Personel sınıfından personel oluşturduk tablonun prop larına ulaşabildik.

            //Girilmesi gereken değerlerin boş geçilmemesi için gerekli foreach döngüsü.
            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Tag + " " + "alanı boş bırakılamaz."));
                        return;
                    }
                }
            try
            {

            personel.Ad = txt_adi.Text;
            personel.Soyad = txt_soyadi.Text;
            personel.TC = txt_tc.Text;
                   
            personel.Mezuniyet = cb_mezun.SelectedItem.ToString();
            personel.Yas = Convert.ToInt32(txt_yas.Text);
            personel.Telefon = txt_telefon.Text;
            personel.DepartmanID = int.Parse(cb_departman.Text);
            if (radioButton1.Checked == true)
            {
                personel.Cinsiyet = radioButton1.Text;
            }

            else if (radioButton2.Checked == true)
            {
                personel.Cinsiyet = radioButton2.Text;
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyet seçiniz.");
                //return;
            }

            pc.Employees.Add(personel);
            pc.SaveChanges();//İşlemleri veritabanına yansıtır.silme kaydetme vb.Eğer yazmazsak program çalışır ama veritabanına kaydetmez.
            dataGridView2.DataSource = pc.Employees.ToList();
            MessageBox.Show("Personel Sisteme Kaydedildi.");
            kayitsayisi();

        }

            catch (Exception)
            {
                MessageBox.Show("Lütfen Bilgileri Tam Doldurunuz.TC ve TELEFON 11 Haneli olmalıdır.");
            }
        }
    private void btn_temizle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lbl_id.Text);

            try
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    Employee personel = pc.Employees.First(f => f.PersonelID == id);
                    pc.Employees.Remove(personel);
                    pc.SaveChanges();
                    MessageBox.Show("Personel silindi.");
                    dataGridView2.DataSource = pc.Employees.ToList();
                    kayitsayisi();

                }
                else MessageBox.Show("Personel silmekten vazgeçtiniz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Silinmedi.");
            }
        }
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(lbl_id.Text);
                Employee personel = pc.Employees.First(f => f.PersonelID == id);
                personel.Ad = txt_adi.Text;
                personel.Soyad = txt_soyadi.Text;
                personel.TC = txt_tc.Text;
                personel.Mezuniyet = cb_mezun.SelectedItem.ToString();
                personel.Yas = Convert.ToInt32(txt_yas.Text);
                personel.Telefon = txt_telefon.Text;
                personel.DepartmanID =int.Parse(cb_departman.Text);
                pc.SaveChanges();
                MessageBox.Show("Personel bilgisi güncellendi.");
                dataGridView2.DataSource = pc.Employees.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Bilgileri Tam Doldurunuz.TC ve TELEFON 11 Haneli olmalıdır.");
            }
        }
        private void btn_hepsinisil_Click(object sender, EventArgs e)
        {
            txt_adi.Text = "";
            txt_soyadi.Text = "";
            txt_tc.Text = "";
            lbl_id.Text = "";
            txt_telefon.Text = "";
            txt_yas.Text = "";
            cb_departman.Text = " ";
            cb_mezun.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_adi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_soyadi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_tc.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_yas.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            cb_mezun.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_telefon.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            cb_departman.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();

            if (dataGridView2.CurrentRow.Cells[8].Value.ToString()=="BAY")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = true;
            }
        }
        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_yas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void kayitsayisi()
        {
            int kayitsayisi = dataGridView2.RowCount;
            label10.Text = Convert.ToString(kayitsayisi);
        }

        
    }
}

    

