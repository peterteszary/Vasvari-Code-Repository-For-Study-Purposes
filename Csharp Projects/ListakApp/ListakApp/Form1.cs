using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListakApp
{
    public partial class Form1 : Form
    {
        private List<string> elsoLista = new List<string>();
        private List<string> masodikLista = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ElsoHozzaAdGomb_Click(object sender, EventArgs e)
        {
            string szoveg = ElsoBevitelBox.Text.Trim();
            if (!string.IsNullOrEmpty(szoveg))
            {
                elsoLista.Add(szoveg);
                ElsoLista.Items.Add(szoveg);
            }
        }

        private void MasodikHozzaAdGomb_Click(object sender, EventArgs e)
        {
            string szoveg = MasodikBevitelBox.Text.Trim();
            if (!string.IsNullOrEmpty(szoveg))
            {
                masodikLista.Add(szoveg);
                MasodikLista.Items.Add(szoveg);
            }
        }

        private void JobbraGomb_Click(object sender, EventArgs e)
        {
            if (ElsoLista.SelectedItems.Count > 0)
            {
                foreach (object item in ElsoLista.SelectedItems)
                {
                    MasodikLista.Items.Add(item);
                }
                while (ElsoLista.SelectedItems.Count > 0)
                {
                    ElsoLista.Items.Remove(ElsoLista.SelectedItems[0]);
                }
            }
        }

        private void BalraGomb_Click(object sender, EventArgs e)
        {
            if (MasodikLista.SelectedItems.Count > 0)
            {
                foreach (object item in MasodikLista.SelectedItems)
                {
                    ElsoLista.Items.Add(item);
                }
                while (MasodikLista.SelectedItems.Count > 0)
                {
                    MasodikLista.Items.Remove(MasodikLista.SelectedItems[0]);
                }
            }
        }

        private void ElsoFelGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index > 0)
            {
                string szoveg = elsoLista[index];
                elsoLista.RemoveAt(index);
                ElsoLista.Items.RemoveAt(index);
                elsoLista.Insert(index - 1, szoveg);
                ElsoLista.Items.Insert(index - 1, szoveg);
                ElsoLista.SelectedIndex = index - 1;
            }
        }

        private void ElsoLeGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index != -1 && index < elsoLista.Count - 1)
            {
                string szoveg = elsoLista[index];
                elsoLista.RemoveAt(index);
                ElsoLista.Items.RemoveAt(index);
                elsoLista.Insert(index + 1, szoveg);
                ElsoLista.Items.Insert(index + 1, szoveg);
                ElsoLista.SelectedIndex = index + 1;
            }
        }

        private void Frissites()
        {
            elsoLista.Clear();
            masodikLista.Clear();
            foreach (var item in ElsoLista.Items)
            {
                elsoLista.Add(item.ToString());
            }
            foreach (var item in MasodikLista.Items)
            {
                masodikLista.Add(item.ToString());
            }
        }

        private void ElsoFelulra_Click(object sender, EventArgs e)
        {
            if (ElsoLista.SelectedItem != null)
            {
                string szoveg = ElsoLista.SelectedItem.ToString();
                elsoLista.Remove(szoveg);
                elsoLista.Insert(0, szoveg);
                Frissites();
            }
        }

        private void ElsoAlulraGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index != -1 && index < ElsoLista.Items.Count - 1)
            {
                object item = ElsoLista.SelectedItem;
                ElsoLista.Items.RemoveAt(index);
                ElsoLista.Items.Insert(index + 1, item);
                ElsoLista.SetSelected(index + 1, true);
            }
        }

        private void ElsoTorolGomb_Click(object sender, EventArgs e)
        {
            int index = ElsoLista.SelectedIndex;
            if (index != -1)
            {
                ElsoLista.Items.RemoveAt(index);
            }
        }

    

        private void MasodikFelGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (index > 0)
            {
                string szoveg = masodikLista[index];
                masodikLista.RemoveAt(index);
                MasodikLista.Items.RemoveAt(index);
                masodikLista.Insert(index - 1, szoveg);
                MasodikLista.Items.Insert(index - 1, szoveg);
                MasodikLista.SelectedIndex = index - 1;
            }
        }

        private void MasodikLeGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (index != -1 && index < masodikLista.Count - 1)
            {
                string szoveg = masodikLista[index];
                masodikLista.RemoveAt(index);
                MasodikLista.Items.RemoveAt(index);
                masodikLista.Insert(index + 1, szoveg);
                MasodikLista.Items.Insert(index + 1, szoveg);
                MasodikLista.SelectedIndex = index + 1;
            }
        }

        private void MasodikFelulraGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (index > 0)
            {
                string szoveg = masodikLista[index];
                masodikLista.RemoveAt(index);
                MasodikLista.Items.RemoveAt(index);
                masodikLista.Insert(0, szoveg);
                MasodikLista.Items.Insert(0, szoveg);
                MasodikLista.SelectedIndex = 0;
            }
        }

        private void MasodikAlulraGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (index != -1 && index < MasodikLista.Items.Count - 1)
            {
                object item = MasodikLista.SelectedItem;
                MasodikLista.Items.RemoveAt(index);
                MasodikLista.Items.Insert(index + 1, item);
                MasodikLista.SetSelected(index + 1, true);
            }
        }

        private void MasodikTorolGomb_Click(object sender, EventArgs e)
        {
            int index = MasodikLista.SelectedIndex;
            if (index != -1)
            {
                MasodikLista.Items.RemoveAt(index);
            }
        }

        private void MentGomb_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Szöveges fájlok (.txt)|.txt";
                sfd.Title = "Mentés";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(sfd.FileName))
                    {
                        foreach (string szoveg in elsoLista)
                        {
                            file.WriteLine(szoveg);
                        }
                        file.WriteLine("-----");
                        foreach (string szoveg in masodikLista)
                        {
                            file.WriteLine(szoveg);
                        }
                    }
                }
            }
        }


        private void MasolasGomb_Click(object sender, EventArgs e)
        {
            MasodikLista.Items.Clear();
            foreach (string szoveg in elsoLista)
            {
                MasodikLista.Items.Add(szoveg);
            }
            masodikLista = new List<string>(elsoLista);
        }

    }
}