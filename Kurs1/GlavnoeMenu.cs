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
    public partial class GlavnoeMenu : Form
    {
        public GlavnoeMenu()
        {
            InitializeComponent();
        }

        //Добавить жильца
        private void button1_Click(object sender, EventArgs e)
        {
            DobavlenieZhilca frm3 = new DobavlenieZhilca();
            frm3.Show();
            this.Hide();
        }

        //Открыть список из файла
        private void button7_Click(object sender, EventArgs e)
        {
            Roomer.Deserialize();
        }

        //Просмотреть список жильцов
        private void button2_Click(object sender, EventArgs e)
        {
            SpisokZhilcov frm4 = new SpisokZhilcov();
            frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpisokZadolgennosti frm5 = new SpisokZadolgennosti();
            frm5.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RMList.collection.Clear();
            RMList.kommcollection.Clear();
            MessageBox.Show("Список пуст");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Roomer.Serialize();
            MessageBox.Show("Список жильцов сохранен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Exit frm17 = new Exit();
            frm17.Show();
            this.Hide();
        }
    }
}
