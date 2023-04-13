using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzamGeneraloLista
{

    
    public partial class Form1 : Form
    {

        private List<int> szamok = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }




        private void GeneraloGomb_Click(object sender, EventArgs e)
        {
            GeneraltSzamok.Items.Clear();
            szamok.Clear(); // Az összes korábban generált számot töröljük

            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int randomSzam = rand.Next(1, 10001);
                GeneraltSzamok.Items.Add(randomSzam);
                szamok.Add(randomSzam); // Az összes generált számot eltároljuk a listában
            }
        }

        private void GeneraltSzamok_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeneralasOpciok_Enter(object sender, EventArgs e)
        {

        }

        private void PrimRadioGomb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ParosRadioGomb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ParatlanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HarommalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HattalRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KilenccelRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NegyzetRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MutatButton_Click(object sender, EventArgs e)
        {
            HozzaadottLista.Items.Clear();

            // Szűrési feltétel lekérdezése a radiógombok állapotából
            int szuresiFeltetel = 0;
            if (ParosRadioGomb.Checked) szuresiFeltetel = 1;
            else if (ParatlanRadioButton.Checked) szuresiFeltetel = 2;
            else if (HarommalRadioButton.Checked) szuresiFeltetel = 3;
            else if (HattalRadioButton.Checked) szuresiFeltetel = 4;
            else if (NegyzetRadioButton.Checked) szuresiFeltetel = 5;
            else if (PrimRadioGomb.Checked) szuresiFeltetel = 6;
            else if (KilenccelRadioButton.Checked) szuresiFeltetel = 7;

            // Szűrjük a generált számokat a kiválasztott szűrési feltételnek megfelelően
            foreach (int szam in GeneraltSzamok.Items)
            {
                switch (szuresiFeltetel)
                {
                    case 1:
                        if (szam % 2 == 0) HozzaadottLista.Items.Add(szam);
                        break;
                    case 2:
                        if (szam % 2 == 1) HozzaadottLista.Items.Add(szam);
                        break;
                    case 3:
                        if (szam % 3 == 0) HozzaadottLista.Items.Add(szam);
                        break;
                    case 4:
                        if (szam % 6 == 0) HozzaadottLista.Items.Add(szam);
                        break;
                    case 5:
                        double negyzetgyok = Math.Sqrt(szam);
                        if (negyzetgyok == Math.Floor(negyzetgyok)) HozzaadottLista.Items.Add(szam);
                        break;
                    case 6:
                        bool prim = true;
                        for (int i = 2; i <= Math.Sqrt(szam); i++)
                        {
                            if (szam % i == 0)
                            {
                                prim = false;
                                break;
                            }
                        }
                        if (prim && szam != 1) HozzaadottLista.Items.Add(szam);
                        break;
                    case 7:
                        if (szam % 9 == 0) HozzaadottLista.Items.Add(szam);
                        break;
                    default:
                        break;


                }
            }
        }
        private void EredmenyLabel_Click(object sender, EventArgs e)
        {
            // Az eredetileg generált számok darabszáma
            int eredetiDarabszam = GeneraltSzamok.Items.Count;

            // A szűrési feltételnek megfelelő számok darabszáma
            int szurtDarabszam = HozzaadottLista.Items.Count;

            // Az eredmény string összeállítása
            string eredmeny = "Eredetileg generált számok darabszáma: " + eredetiDarabszam.ToString() +
                              " / Szűrési feltételnek megfelelő számok darabszáma: " + szurtDarabszam.ToString();

            // Az eredmény string beállítása az EredmenyLabel szövegének
            EredmenyLabel.Text = eredmeny;
        }

        private void HozzaadottLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
