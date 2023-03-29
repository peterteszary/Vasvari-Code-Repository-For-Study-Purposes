using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GeneralasGomb_Click(object sender, EventArgs e)
        {
            
        }


        private void kodok_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] nevlista = new string[] { "Ferenc", "Adél", "Sándor", "Helga", "József", "Péter", "Brigitta", "Félix", "Zoltán", "Géza" };

            Random r = new Random();
            for (int i = 0; i < 200; i++)
            {
                Lista.Items.Add(nevlista[r.Next(0, 10)]);
            }
            valasztottelem.Text = "Választott elem: " + Lista.GetItemText(Lista.SelectedItem).Substring(0, 3) + "-" + r.Next(1000, 10000);
        }
    }
}
