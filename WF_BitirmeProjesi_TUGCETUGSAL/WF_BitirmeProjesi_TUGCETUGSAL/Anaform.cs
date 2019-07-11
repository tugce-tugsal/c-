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
    public partial class Anaform : Form
    {

        ProjeContext db = new ProjeContext();

        
        public Anaform()
        {
            InitializeComponent();
            
        }
        
        void FormKontrol(Form form)
        {
            this.Width = form.Width + 22;
            this.Height = form.Height + 68;
            bool GelenFormAcikMi = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Text == form.Text)
                {
                    form.Activate();
                    GelenFormAcikMi = true;
                }
                else item.Close();
            }
            if (GelenFormAcikMi == false)
            {
                form.MdiParent = this;
                form.Show();
            }
        }
        

        

        private void Anaform_Load(object sender, EventArgs e)
        {
            var objects = db.Employees.ToList();
            
        }

        private void personelKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new Personel_Kayit_Form());
        }

        private void personelAramaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKontrol(new Personel_Arama());
        }

        private void departmanKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKontrol(new Departman_Kayit_Form());
        }

        private void pERSONELARAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
