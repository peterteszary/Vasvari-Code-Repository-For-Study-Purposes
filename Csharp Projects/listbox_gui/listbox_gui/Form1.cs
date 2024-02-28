using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox_gui
{
    public partial class listaexport : Form
    {
        public listaexport()
        {
            InitializeComponent();
        }

        private void generalas_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                lista.Items.Add(r.Next(1, 5001));
            }
            this.Text = "Számlista - " + lista.Items.Count + " elem";
            valasztottelem.Enabled = true;
            szamhozzaad.Enabled = true;
            elemhozzaadgomb.Enabled = true;
            torlesgomb.Enabled = true;
            listatorlesegomb.Enabled = true;
            listarendezesegomb.Enabled = true;

        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            valasztottelem.Text = lista.GetItemText("Választott elem: " + lista.SelectedItem);
            this.Text = "Számlista - " + lista.Items.Count + " elem";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void elemhozzaad_Click(object sender, EventArgs e)
        {
            lista.Items.Add(szamhozzaad.Text);
            this.Text = "Számlista - " + lista.Items.Count + " elem";

        }

        private void torlesgomb_Click(object sender, EventArgs e)
        {
            lista.Items.Remove(lista.SelectedItem);
            this.Text = "Számlista - " + lista.Items.Count + " elem";

        }

        private void listatorlesegomb_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            this.Text = "Számlista - " + lista.Items.Count + " elem";
            valasztottelem.Enabled = false;
            szamhozzaad.Enabled = false;
            elemhozzaadgomb.Enabled = false;
            torlesgomb.Enabled = false;
            listatorlesegomb.Enabled = false;
            listarendezesegomb.Enabled = false;
        }

        private void listarendezesegomb_Click(object sender, EventArgs e)
        {
            List<int> lista_szam = new List<int>();
            for (int i = 0; i < lista.Items.Count; i++)
            {
                lista_szam.Add(Convert.ToInt32(lista.Items[i]));
            }
            lista.Items.Clear();
            lista_szam.Sort();
            foreach (var item in lista_szam) 
            {
                lista.Items.Add(item);
            }


            lista.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
