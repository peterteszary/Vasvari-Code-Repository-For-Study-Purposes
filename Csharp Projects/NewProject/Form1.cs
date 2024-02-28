using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FeldolgozasGomb_Click(object sender, EventArgs e)
        {
            List<string> szovegLista = new List<string>();
            string[] szoveg = szovegmezo.Text.Split(' ');
            for (int i = 0; i < szoveg.Length; i++)
            {
               szovegLista.Add(szoveg[i]);
            }
        }

        private void szovegmezo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void szovegLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void betuValasztas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item szovegLista.Items)
            { 
            
            }
        }

     

        private void Kivalogat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
