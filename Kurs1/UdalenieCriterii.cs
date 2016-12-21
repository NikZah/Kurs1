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
    public partial class UdalenieCriterii : Form
    {
        public UdalenieCriterii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UdalenieFam frm11 = new UdalenieFam();
            frm11.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UdalenieNum frm12 = new UdalenieNum();
            frm12.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UdalenieSquare frm13 = new UdalenieSquare();
            frm13.Show();
            this.Hide();
        }
    }
}
