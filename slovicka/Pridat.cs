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
    public partial class Pridat : Form
    {
        public Pridat()
        {
            InitializeComponent();
        }

        public void ulozitSlovicko()
        {
            string filePath = Environment.CurrentDirectory;
            handleSlovicka.filePath = Environment.CurrentDirectory;
            handleSlovicka.chechIfFileExists();


            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(filePath + @"\slovicka.txt", true))
            {
                file.WriteLine(tb_anglicky.Text + ";" + tb_cesky.Text);
            }
            tb_cesky.Text = "";
            tb_anglicky.Text = "";
        }

        private void b_pridat_Click(object sender, EventArgs e)
        {
            ulozitSlovicko();
        }
    }
}
