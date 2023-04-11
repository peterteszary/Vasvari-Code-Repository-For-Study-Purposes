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
        public Form1()
        {
            InitializeComponent();
        }




        private void GeneraloGomb_Click(object sender, EventArgs e)
        {
            // töröljük a korábban generált számokat a listából
            GeneraltSzamok.Items.Clear();

            // generálunk 1000 random számot és hozzáadjuk a listához
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int randomSzam = rand.Next(1, 10001);
                GeneraltSzamok.Items.Add(randomSzam);
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
          
        }   
    private void EredmenyLabel_Click(object sender, EventArgs e)
        {

        }

        private void HozzaadottLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
