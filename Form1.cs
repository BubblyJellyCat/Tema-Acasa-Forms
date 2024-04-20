using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema6Forms
{
    public partial class Form1 : Form
    {
        int raspunsCorect;
        int nrIntreb = 1;
        int scor;
        int procent;
        int intrebariTotale;

        public Form1()
        {
            InitializeComponent();

            VerificareRaspunsCorect(nrIntreb);
            intrebariTotale = 6;
        }

        private void VerificareRaspunsForms(object sender, EventArgs e)
        {
            var objectSender = (Button)sender;

            int buttonTag = Convert.ToInt32((objectSender).Tag);

            if (buttonTag == raspunsCorect)
            {
                scor++;
            }
            if (nrIntreb == intrebariTotale)
            {
                button1.Show();
                button3.Show();
                nrIntreb = 0;
                scor = 0;
            }

            nrIntreb++;
            VerificareRaspunsCorect(nrIntreb);
        }

        private void VerificareRaspunsCorect(int nrIntreb)
        {
            switch (nrIntreb) 
            {
                case 1:
                    label1.Text = "Intrebarea numarul 1: ";
                    label2.Text = "Care este cel mai mare animal?";
                    button1.Text = "Elefantul";
                    button2.Text = "Soimul";
                    button3.Text = "Girafa";

                    raspunsCorect = 1;
                    
                    break;
                case 2:
                    label1.Text = "Intrebarea numarul 2: ";
                    label2.Text = "Care este cel mai rapid animal?";
                    button1.Text = "Leul";
                    button2.Text = "Ghepardul";
                    button3.Text = "Pisica";

                    raspunsCorect = 2;

                    break;
                case 3:
                    label1.Text = "Intrebarea numarul 3: ";
                    label2.Text = "Care este cel mai incet animal?";
                    button1.Text = "Elefantul";
                    button2.Text = "Girafa";
                    button3.Text = "Melcul";

                    raspunsCorect = 3;

                    break;
                case 4:
                    label1.Text = "Intrebarea numarul 4: ";
                    label2.Text = "Ce animal face Miau?";
                    button1.Text = "Pisica";
                    button2.Text = "Cainele";
                    button3.Text = "Leul";

                    raspunsCorect =1;

                    break;
                case 5:
                    label1.Text = "Intrebarea numarul 5: ";
                    label2.Text = "Ce animal este cel mai bun prieten al omului? ";
                    button1.Text = "Pisica";
                    button2.Text = "Cainele";
                    button3.Text = "Lupul";

                    raspunsCorect = 2;
                    break;
                case 6:
                    procent = (int)Math.Round((double)(scor * 100) / (intrebariTotale-1));
                    label1.Text = "Procentajul de raspunsuri corecte este: " + procent + "%";
                    label2.Text = "Ati raspuns la " + scor + " intrebari corect!";
                    button1.Hide();
                    button2.Text = "Incercati Din Nou";
                    button3.Hide();
                    raspunsCorect = 2;
                    break;
            }

        }
    }
}
