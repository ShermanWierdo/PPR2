using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kaffeautomat
{
    public partial class Form1 : Form
    {
        public static double
        mocka = 7, chocklad = 8.5, expresso = 12.5, nyponsoppa = 11, fruktsoppa = 14, motorolja = 20, kaffe = 6,
        tiokrona, femkrona, enkrona, femtioore, vaxel, betalning, bestallt = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        

        private void btnTio_Click(object sender, EventArgs e)
        {
            tiokrona++;
            betalning += 10;
            KollaAllaPriser();
        }

        private void btnFem_Click(object sender, EventArgs e)
        {
            femkrona++;
            betalning += 5;
            KollaAllaPriser();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            enkrona++;
            betalning += 1;
            KollaAllaPriser();
        }

        private void btnFemtioore_Click(object sender, EventArgs e)
        {
            femtioore++;
            betalning += 0.5;
            KollaAllaPriser();
        }
        public void ResetForm()
        {
            Form1.tiokrona = 0;
            Form1.femkrona = 0;
            Form1.enkrona = 0;
            Form1.femtioore = 0;
            Form1.betalning = 0;
            Form1.vaxel = 0;
            bestallt = 0;
            lblVaxel.Text = "0";
            KollaAllaPriser();
            btnTio.Enabled = true;
            btnFem.Enabled = true;
            btnEn.Enabled = true;
            btnFemtioore.Enabled = true;
        }

        private void KollaAllaPriser()
        {

            PrisKoll(betalning, Form1.mocka, btnMocka);
            PrisKoll(betalning, Form1.chocklad, btnChocklad);
            PrisKoll(betalning, Form1.expresso, btnExpresso);
            PrisKoll(betalning, Form1.nyponsoppa, btnNyponsoppa);
            PrisKoll(betalning, Form1.fruktsoppa, btnFruktsoppa);
            PrisKoll(betalning, Form1.motorolja, btnMotorolja);
            PrisKoll(betalning, Form1.kaffe, btnKaffe);
        }
        private void PrisKoll(double pengar, double pris, Button button)
        {
            if (pengar >= pris)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void BeräknaVäxel(double betalat, double dryckpris)
        {
            vaxel = betalat - dryckpris;
            lblVaxel.Text = vaxel.ToString();
            btnTio.Enabled = false;
            btnFem.Enabled = false;
            btnEn.Enabled = false;
            btnFemtioore.Enabled = false;
            bestallt = 1;
        }

        private void btnMocka_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.mocka);
        }

        private void btnChocklad_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.chocklad);
        }

        private void btnExpresso_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.expresso);
        }

        private void btnNyponsoppa_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.nyponsoppa);
        }

        private void btnFruktsoppa_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.fruktsoppa);
        }

        private void Motorolja_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.motorolja);
        }

        private void btnKaffe_Click(object sender, EventArgs e)
        {
            BeräknaVäxel(Form1.betalning, Form1.kaffe);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
