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
    public partial class ChangeSpisok : Form
    {
        public ChangeSpisok()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (textBox4.Text != "")
            {
                foreach (Roomer f in RMList.collection)
                {
                    if (f.Fam == textBox1.Text)
                    {
                        f.Fam = textBox4.Text;
                        b = true;
                    }
                }
                if (!b) MessageBox.Show("Элемент не найден!");
            }
            else MessageBox.Show("Введите новую фамилию");

            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (textBox3.Text != "")
            {
                foreach (Roomer f in RMList.collection)
                {
                    if (f.Fam == textBox1.Text)
                    {
                        f.Num = Convert.ToInt32(textBox3.Text);
                        b = true;
                    }
                }
                if (!b) MessageBox.Show("Элемент не найден!");
            }
            else MessageBox.Show("Введите новый номер квартиры");
            textBox1.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (textBox2.Text != "")
            {
                foreach (Roomer f in RMList.collection)
                {
                    if (f.Fam == textBox1.Text)
                    {
                        f.Square = Convert.ToInt32(textBox2.Text);
                        b = true;
                    }
                }
                if (!b) MessageBox.Show("Элемент не найден!");
            }
            else MessageBox.Show("Введите новую площадь квартиры");
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "")
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите новую фамилию жильца");
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите новый номер квартиры");
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите новую площадь квартиры");
                }
            }
            else
            {
                foreach (Roomer f in RMList.collection)
                {
                    if (f.Fam == textBox1.Text)
                    {
                        f.Fam = textBox4.Text;
                        f.Num = Convert.ToInt32(textBox3.Text);
                        f.Square = Convert.ToInt32(textBox2.Text);
                        b = true;
                    }
                }
                if (!b) MessageBox.Show("Элемент не найден!");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpisokZhilcov frm4 = new SpisokZhilcov();
            frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlavnoeMenu frm1 = new GlavnoeMenu();
            frm1.Show();
            this.Hide();
        }
    }
}
