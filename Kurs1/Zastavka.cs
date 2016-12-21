using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kurs1
{
    public partial class Zastavka : Form
    {
        public Zastavka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlavnoeMenu frm1 = new GlavnoeMenu();
            frm1.Show();
            this.Hide();
        }
    }
}
