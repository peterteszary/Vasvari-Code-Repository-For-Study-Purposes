using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamlista_szurese
{
    public partial class Form1 : Form
    {
        private List<int> kezdoLista;
        private List<int> szurtLista;

        public Form1()
        {
            InitializeComponent();
            kezdoLista = new List<int>();
            szurtLista = new List<int>();
        }

        //Generálás
        private void GeneralasGomb_Click(object sender, EventArgs e)
        {
            int kezdo = 0;
            int veg = 0;
            int darab = 0;

            if (int.TryParse(KezdoErtekTextBox.Text, out kezdo) &&
                int.TryParse(VegertekTextBox.Text, out veg) &&
                int.TryParse(DarabSzamTextBox.Text, out darab))
            {
                // ellenőrizzük, hogy a kezdőérték kisebb-e, mint a végérték
                if (kezdo <= veg)
                {
                    // generáljuk a számokat a tartományban
                    Random rnd = new Random();
                    kezdoLista.Clear();
                    for (int i = 0; i < darab; i++)
                    {
                        int szam = rnd.Next(kezdo, veg + 1);
                        kezdoLista.Add(szam);
                    }

                    // frissítjük a kezdő listát
                    KezdoLista.Items.Clear();
                    foreach (int szam in kezdoLista)
                    {
                        KezdoLista.Items.Add(szam);
                    }

                    MessageBox.Show($"Generált számok száma: {kezdoLista.Count}", "Generálás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("A kezdő érték nem lehet nagyobb, mint a végérték!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A bemeneti értékek nem lehetnek üresek, és csak egész számok lehetnek!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Szűrés
        private void SzuresGomb_Click(object sender, EventArgs e)
        {
            // töröljük az előző szűrési eredményeket
            szurtLista.Clear();
            SzurtLista.Items.Clear();

            // kiválasztjuk az aktuális szűrési feltételt
            if (ParosRadioButton.Checked)
            {
                foreach (int szam in kezdoLista)
                {
                    if (szam % 2 == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
            else if (ParatlanRadioButton.Checked)
            {
                foreach (int szam in kezdoLista)
                {
                    if (szam % 2 == 1)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
            else if (HarommalOszthatoRadioButton.Checked)
            {
                foreach (int szam in kezdoLista)
                {
                    if (szam % 3 == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
            else if (OttelOszthatoRadioButton.Checked)
            {
                foreach (int szam in kezdoLista)
                {
                    if (szam % 5 == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
            else if (HettelOszthatoRadioButton.Checked)
            {
                foreach (int szam in kezdoLista)
                {
                    if (szam % 7 == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }

            else if (OsztoValasztoComBox.SelectedIndex >= 0)
            {
                int oszto = int.Parse(OsztoValasztoComBox.SelectedItem.ToString());
                foreach (int szam in kezdoLista)
                {
                    if (szam % oszto == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy szűrési feltételt vagy adjon meg osztót a számok szűréséhez!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OsztoValasztoComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ha kiválasztunk egy osztót, szűrjük a számokat
            if (OsztoValasztoComBox.SelectedIndex >= 0)
            {
                int oszto = int.Parse(OsztoValasztoComBox.SelectedItem.ToString());
                szurtLista.Clear();
                SzurtLista.Items.Clear();

                foreach (int szam in kezdoLista)
                {
                    if (szam % oszto == 0)
                    {
                        szurtLista.Add(szam);
                        SzurtLista.Items.Add(szam);
                    }
                }
            }
        }

        
    }
}