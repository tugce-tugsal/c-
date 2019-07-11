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
    public partial class Departman_Kayit_Form : Form
    {

        public Departman_Kayit_Form()
        {
            InitializeComponent();
        }
        ProjeContext pc = new ProjeContext();
        Department d = new Department();
        private void btn_kaydet_dkf_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txt_departmanadi_dkf.Text!="")
                {
                    if (label10.Text != "0")
                    {
                        if (txt_departmanadi_dkf.Text.ToUpper() == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                        {
                            MessageBox.Show("Yazılan Departman Adı kayıtlarda vardır.");
                            return;
                        }
                        else d.Departman = txt_departmanadi_dkf.Text;

                    }
                    else d.Departman = txt_departmanadi_dkf.Text;

                    d.Aciklama = txt_aciklama.Text;
                    pc.Departments.Add(d);
                    pc.SaveChanges();
                    dataGridView1.DataSource = pc.Departments.ToList();
                    kayitsayisi2();
                }
                else
                {
                    MessageBox.Show("Departman adı Boş Bırakılamaz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Departman İsmi Giriniz.");
                return;
            }         
        }

        private void btn_sil_dkf_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label10.Text);

            try
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istiyor musunuz?", "Silinsin mi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (dialogResult == DialogResult.Yes)
                {

                    Department d = pc.Departments.First(f => f.DepartmanID == id);
                    pc.Departments.Remove(d);
                    pc.SaveChanges();
                    MessageBox.Show("Personel silindi.");
                    dataGridView1.DataSource = pc.Departments.ToList();
                    kayitsayisi2();
                }
                else MessageBox.Show("Personel silmekten vazgeçtiniz.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt silinemedi.");
            }
           
          }            
           
            private void Departman_Kayit_Form_Load(object sender, EventArgs e)
            {
                
                dataGridView1.DataSource = pc.Departments.ToList();
            }
        private void btn_güncelle_dkf_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(label10.Text);
            try
            {
                Department d = pc.Departments.First(f => f.DepartmanID == id);
                d.Departman = txt_departmanadi_dkf.Text;
                d.Aciklama = txt_aciklama.Text;

                pc.SaveChanges();
                MessageBox.Show("Departman Bilgisi Güncellendi");
                dataGridView1.DataSource = pc.Departments.ToList();
            }
            catch (Exception )
            {
                MessageBox.Show("Kayıt Güncellenmedi.");
            }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_aciklama.Text = "";
            txt_departmanadi_dkf.Text = "";
            label10.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label10.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_departmanadi_dkf.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_aciklama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        private void kayitsayisi2()
        {
            int kayitsayisi = dataGridView1.RowCount;
            label10.Text = Convert.ToString(kayitsayisi);
        }
        private void txt_departmanadi_dkf_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        

    }
} 
