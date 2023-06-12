using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slovicka
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            Pridat p = new Pridat();
            p.Show();
        }

        private void b_learn_Click(object sender, EventArgs e)
        {
            Ucit u = new Ucit();
            u.Show();
        }

        private void b_test_Click(object sender, EventArgs e)
        {
            handleSlovicka.number = Convert.ToInt32(textBox1.Text);
            Test t = new Test();
            t.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            handleSlovicka.cesky = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            handleSlovicka.cesky = true;
        }
    }
}
