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
    public partial class Ucit : Form
    {
        public Ucit()
        {
            InitializeComponent();
            Start();
        }

        int i = -1;
        bool next = true;
        void Start()
        {
            handleSlovicka.filePath = Environment.CurrentDirectory;
            handleSlovicka.chechIfFileExists();
            handleSlovicka.loadSlovicka();
            GoNext();
        }
        public void GoNext()
        {
            if (next)
            {
                i++;
                label1.Text = handleSlovicka.slovickaEN[i];
                label2.Text = "";
                next = false;
                label3.Text = (i + 1).ToString() + "/" + handleSlovicka.slovickaEN.Count.ToString();
            }
            else
            {
                label2.Text = handleSlovicka.slovickaCZ[i];
                next = true;
                if (i >= handleSlovicka.slovickaEN.Count - 1)
                    i = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoNext();
        }
    }
}
