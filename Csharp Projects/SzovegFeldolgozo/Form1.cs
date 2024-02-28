using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SzovegFeldolgozo
{
    public partial class Form1 : Form
    {
        private List<string> words = new List<string>();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();

        }

        private void szovegTerulet_TextChanged(object sender, EventArgs e)
        {
            // Szövegmező tartalmának frissítése
            words = szovegTerulet.Text.Split(' ', '.', ',', '\n', '\r').ToList();
        }

        private void megnyitasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // OpenFileDialog beállításai
            openFileDialog.Filter = "Szövegfájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            openFileDialog.Title = "Szövegfájl megnyitása";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Kiválasztott fájl tartalmának beolvasása és megjelenítése a szövegmezőben
                    szovegTerulet.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                // Kivételek kezelése
                MessageBox.Show($"Hiba: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void beolvasasGomb_Click(object sender, EventArgs e)
        {
            // Szövegmező tartalmának beolvasása és szavakra bontása
            string[] inputWords = szovegTerulet.Text.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Az új szavak frissítése a szavak listájában
            words = inputWords.ToList();
        }

        private void feldolgozasGomb_Click(object sender, EventArgs e)
        {
            // Szavak listájának frissítése és a ListBox tartalmának törlése
            szavak.Items.Clear();
            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    szavak.Items.Add(word);
                }
            }
        }

        private void mentesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Új SaveFileDialog létrehozása
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Alapértelmezett fájlkiterjesztés és a kapcsolódó szűrő beállítása
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Szövegfájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*";

            // A felugró ablak megjelenítése
            DialogResult result = saveFileDialog1.ShowDialog();

            // Ha az OK gombra kattintott a felhasználó
            if (result == DialogResult.OK)
            {
                // A kiválasztott fájl nevének és elérési útvonalának megadása
                string fileName = saveFileDialog1.FileName;

                // Alapszöveg mentése teszt célból
                string textToSave = "Ide kerül a kimeneti szöveg";

                // A szöveg kiírása a fájlba
                System.IO.File.WriteAllText(fileName, textToSave);
            }
        }
    }
}
