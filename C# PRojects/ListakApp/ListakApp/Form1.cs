using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListakApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Az első listához tartozó gombok

        private void ElsoHozzaAdGomb_Click(object sender, EventArgs e)
        {
            // Ellenőrzés, hogy a szövegbeviteli mező nem üres
            if (!string.IsNullOrEmpty(ElsoBevitelBox.Text))
            {
                // A szöveg hozzáadása az első listához
                ElsoLista.Items.Add(ElsoBevitelBox.Text);
                ElsoBevitelBox.Clear(); // A szövegbeviteli mező törlése
            }
        }

        private void ElsoFelGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index > 0)
            {
                string selected = ElsoLista.SelectedItem.ToString();
                ElsoLista.Items.RemoveAt(index);
                ElsoLista.Items.Insert(index - 1, selected);
                ElsoLista.SetSelected(index - 1, true);
            }
        }

        private void ElsoLeGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index >= 0 && index < ElsoLista.Items.Count - 1)
            {
                string selected = ElsoLista.SelectedItem.ToString();
                ElsoLista.Items.RemoveAt(index);
                ElsoLista.Items.Insert(index + 1, selected);
                ElsoLista.SetSelected(index + 1, true);
            }
        }

        private void ElsoAlulraGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index >= 0 && index < ElsoLista.Items.Count - 1)
            {
                string selected = ElsoLista.SelectedItem.ToString();
                ElsoLista.Items.RemoveAt(index);
                ElsoLista.Items.Add(selected);
                ElsoLista.SetSelected(ElsoLista.Items.Count - 1, true);
            }
        }

        private void ElsoTorolGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index >= 0)
            {
                ElsoLista.Items.RemoveAt(index);
            }
        }

        // A második listához tartozó gombok

        private void MasodikHozzaAdGomb_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(MasodikBevitelBox.Text))
            {
                MasodikLista.Items.Add(MasodikBevitelBox.Text);
                MasodikBevitelBox.Clear();
            }
        }

        private void MasodikFelulreGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItem != null)
            {
                int index = MasodikLista.SelectedIndex;
                MasodikLista.Items.Insert(0, MasodikLista.SelectedItem);
                MasodikLista.Items.RemoveAt(index + 1);
                MasodikLista.SetSelected(0, true);
            }
        }

        private void MasodikFelGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItem != null && MasodikLista.SelectedIndex > 0)
            {
                int index = MasodikLista.SelectedIndex;
                MasodikLista.Items.Insert(index - 1, MasodikLista.SelectedItem);
                MasodikLista.Items.RemoveAt(index + 1);
                MasodikLista.SetSelected(index - 1, true);
            }
        }

        private void MasodikLeGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (MasodikLista.SelectedItem != null && index < MasodikLista.Items.Count - 1)
            {
                MasodikLista.Items.Insert(index + 2, MasodikLista.SelectedItem);
                MasodikLista.Items.RemoveAt(index);
                MasodikLista.SetSelected(index + 1, true);
            }
        }

        private void MasodikAlulraGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItem != null)
            {
                int index = MasodikLista.SelectedIndex;
                MasodikLista.Items.Insert(MasodikLista.Items.Count, MasodikLista.SelectedItem);
                MasodikLista.Items.RemoveAt(index);
                MasodikLista.SetSelected(MasodikLista.Items.Count - 1, true);
            }
        }

        private void MasodikTorolGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItem != null)
            {
                MasodikLista.Items.Remove(MasodikLista.SelectedItem);
            }
        }

        private void BalraGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItem != null)
            {
                ElsoLista.Items.Add(MasodikLista.SelectedItem);
                MasodikLista.Items.Remove(MasodikLista.SelectedItem);
            }
        }

        private void JobbraGomb_Click(object sender, EventArgs e)
        {
            if (ElsoLista.SelectedItem != null)
            {
                MasodikLista.Items.Add(ElsoLista.SelectedItem);
                ElsoLista.Items.Remove(ElsoLista.SelectedItem);
            }
        }
    }
}