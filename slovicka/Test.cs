using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace slovicka
{
    public partial class Test : Form
    {

        int iterator = -1;
        bool wrong = false;
        bool first = true;
        string report = "";
        public Test()
        {
            InitializeComponent();
        }
        void Start()
        {
            handleSlovicka.Reset();
            handleSlovicka.filePath = Environment.CurrentDirectory;
            handleSlovicka.chechIfFileExists();
            handleSlovicka.loadSlovicka();
            if (!handleSlovicka.cesky)
            {
                List<string> tmp = handleSlovicka.slovickaCZ;
                handleSlovicka.slovickaCZ = handleSlovicka.slovickaEN;
                handleSlovicka.slovickaEN = tmp;
            }
            handleSlovicka.createSeed();
            Submit();
        }

        public void Submit()
        {
            if (iterator >= 0 && !wrong)
            {
                if (handleSlovicka.slovickaCZ[handleSlovicka.seed[iterator]].ToLower().Split('/').Contains(SlovickoCZ.Text.ToLower()))
                {
                    report += "O " + handleSlovicka.slovickaEN[handleSlovicka.seed[iterator]] + "\r\n";
                    slovickoEN.BackColor = Color.Green;
                    handleSlovicka.seed.RemoveAt(iterator);
                    iterator--;
                }
                else
                {
                    report += "X " + handleSlovicka.slovickaEN[handleSlovicka.seed[iterator]] + "  ==  " + SlovickoCZ.Text + "\r\n";
                    slovickoEN.Text += " == " + handleSlovicka.slovickaCZ[handleSlovicka.seed[iterator]];
                    slovickoEN.BackColor = Color.Red;
                    if(first)
                        handleSlovicka.spatne += 1;
                }
                wrong = true;
                return;
            }

            else
            {
                slovickoEN.BackColor = Color.White;
                wrong = false;
                iterator++;
                SlovickoCZ.Text = "";
                if (handleSlovicka.seed.Count == 0)
                {

                    float skore = (float)(100.0f - ((float)handleSlovicka.spatne / (float)handleSlovicka.number) * 100.0f);
                    handleSlovicka.WriteToHistory(skore);
                    report = handleSlovicka.number.ToString() + "\r\n" + skore.ToString() + "\r\n\r\n" + report;
                    SendToEmail();
                    this.Close();
                }
                else if (iterator < handleSlovicka.seed.Count)
                {
                    slovickoEN.Text = handleSlovicka.slovickaEN[handleSlovicka.seed[iterator]];
                }
                else
                {
                    first = false;
                    report += "\r\n\r\n";
                    iterator = 0;
                    slovickoEN.Text = handleSlovicka.slovickaEN[handleSlovicka.seed[iterator]];
                }

            }
        }

        public void SendToEmail()
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("matejhostek@seznam.cz"));
            message.To.Add(new MailboxAddress("jetamo@atlas.cz"));
            message.Subject = "Filip - test";

            BodyBuilder bBuilder = new BodyBuilder();
            bBuilder.TextBody = report;

            message.Body = bBuilder.ToMessageBody();

            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.seznam.cz", 465, true);
                client.Authenticate("login", "password");
                client.Send(message);
                client.Disconnect(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Test_Shown(object sender, EventArgs e)
        {
            Start();
        }
    }
}
