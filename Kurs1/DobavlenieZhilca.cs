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
    public partial class DobavlenieZhilca : Form
    {
        public DobavlenieZhilca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fam = textBox1.Text;
            int num = Convert.ToInt32(textBox2.Text);
            double water = Convert.ToDouble(textBox3.Text);
            double electricity = Convert.ToDouble(textBox4.Text);
            double gas = Convert.ToDouble(textBox5.Text);
            int square = Convert.ToInt32(textBox6.Text);
            double oplata = Convert.ToDouble(textBox7.Text);

            bool b = false;

            RMList.room1.Fam = fam;
            RMList.room1.Num = num;
            RMList.room1.Water = water;
            RMList.room1.Electricity = electricity;
            RMList.room1.Gas = gas;
            RMList.room1.Square = square;
            RMList.room1.Oplata = oplata;
            RMList.room1.X = num;

            double itogwater = RMList.room1.ItogWater(water);
            double itogelectricity = RMList.room1.ItogElec(electricity);
            double itoggas = RMList.room1.ItogGas(gas);
            double totalitog = RMList.room1.TotalItog(itogwater, itogelectricity, itoggas, oplata);

            foreach (Roomer v in RMList.collection)
            {
                if (num == v.Num) b = true;
            }

            if (!b)
            {
                RMList.collection.Add(new Roomer { Fam = fam, Num = num, Square = square, X = num });
                RMList.kommcollection.Add(new Roomer { Fam = fam, Num = num, Water = itogwater, Electricity = itogelectricity, Gas = itoggas, Oplata = oplata, Dolg = totalitog, X = num });
            }
            else MessageBox.Show("Номер этой квартиры уже занят. Запись не добавлена");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlavnoeMenu frm1 = new GlavnoeMenu();
            frm1.Show();
            this.Hide();
        }
    }
}
