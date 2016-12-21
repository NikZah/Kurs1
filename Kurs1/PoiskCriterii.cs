using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs1
{
    public partial class PoiskCriterii : Form
    {
        public PoiskCriterii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoiskFam frm7 = new PoiskFam();
            frm7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoiskNum frm8 = new PoiskNum();
            frm8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PoiskSquare frm9 = new PoiskSquare();
            frm9.Show();
            this.Hide();
        }
    }
}
