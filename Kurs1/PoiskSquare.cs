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
    public partial class PoiskSquare : Form
    {
        public PoiskSquare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            bool b = false;
            foreach (Roomer a in RMList.collection)
            {
                if (a.Square == Convert.ToInt32(textBox1.Text))
                {
                    dataGridView1.Rows.Add(new object[] { a.Fam, a.Num, a.Square });
                    b = true;
                }
            }
            if (b == false)
                MessageBox.Show("Запись не найдена");
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SpisokZhilcov frm4 = new SpisokZhilcov();
            frm4.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
