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
    public partial class SpisokZhilcov : Form
    {
        public SpisokZhilcov()
        {
            InitializeComponent();
            foreach (Roomer s in RMList.collection) //Вывод коллекции в таблицу
            {
                dataGridView1.Rows.Add(new object[] { s.Fam, s.Num, s.Square });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoiskCriterii frm6 = new PoiskCriterii();
            frm6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UdalenieCriterii frm10 = new UdalenieCriterii();
            frm10.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeSpisok frm14 = new ChangeSpisok();
            frm14.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.Column1, ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.Column2, ListSortDirection.Ascending);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.Column3, ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlavnoeMenu frm1 = new GlavnoeMenu();
            frm1.Show();
            this.Hide();
        }
    }
}
