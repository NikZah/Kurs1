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
    public partial class UdalenieNum : Form
    {
        public UdalenieNum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") MessageBox.Show("Введите номер квартиры");
            else
            {
                List<Roomer> delcoll = new List<Roomer>();
                bool b = false;
                foreach (Roomer t in RMList.collection)
                {
                    if (t.Num != Convert.ToInt32(textBox3.Text))
                        delcoll.Add(t);
                }
                foreach (Roomer r in RMList.collection)
                {
                    if (r.Num == Convert.ToInt32(textBox3.Text)) b = true;
                }
                if (!b) MessageBox.Show("Запись не найдена");
                RMList.collection.Clear();
                RMList.collection = delcoll;

                SpisokZhilcov frm4 = new SpisokZhilcov();
                frm4.Show();
                this.Hide();
            }
            textBox3.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }
    }
}
