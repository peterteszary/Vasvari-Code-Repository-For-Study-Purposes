using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using Microsoft.Win32;

namespace SzamElemzo
{
    public partial class MainWindow : Window
    {
        private List<int> szamok;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SzamokGenerálása_Click(object sender, RoutedEventArgs e)
        {
            szamok = VeletlenSzamokGeneralasa();
            SzamokSzamlalasaFrissitese();
            SzamokListBoxFrissitese();
        }

        private List<int> VeletlenSzamokGeneralasa()
        {
            Random random = new Random();
            return Enumerable.Range(1, 100)
                .Select(_ => random.Next(1, 1000))
                .ToList();
        }

        private void SzamokSzamlalasaFrissitese()
        {
            int parosSzamokSzama = szamok.Count(n => n % 2 == 0);
            int paratlanSzamokSzama = szamok.Count(n => n % 2 != 0);
            int primSzamokSzama = szamok.Count(IsPrim);

            parosSzamokTextBlock.Text = parosSzamokSzama.ToString();
            paratlanSzamokTextBlock.Text = paratlanSzamokSzama.ToString();
            primSzamokTextBlock.Text = primSzamokSzama.ToString();
        }

        private bool IsPrim(int szam)
        {
            if (szam < 2)
                return false;

            for (int i = 2; i * i <= szam; i++)
            {
                if (szam % i == 0)
                    return false;
            }

            return true;
        }

        private void SzamokListBoxFrissitese()
        {
            szamokListBox.ItemsSource = szamok;
        }

        private void SzamokMentése_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Szöveges fájlok|*.txt";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllLines(saveFileDialog.FileName, szamok.Select(n => n.ToString()));
                MessageBox.Show("Számok sikeresen mentve.");
            }
        }
    }
}
