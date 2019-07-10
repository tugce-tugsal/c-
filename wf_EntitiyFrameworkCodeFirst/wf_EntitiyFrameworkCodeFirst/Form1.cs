using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_EntitiyFrameworkCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProjeContext db = new ProjeContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            var objects = db.Categories.ToList();
        }
    }
}
