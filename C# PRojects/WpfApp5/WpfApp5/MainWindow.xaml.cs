﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void elso_stilus_Click(object sender, RoutedEventArgs e)
        {
            focim.Background = Brushes.Blue;
            Foreground = Brushes.White;
        }

        private void masodik_stilus_Click(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString
                ("#FFDFD991");
            focim.Background = new SolidColorBrush (color);
        }

        private void harmadik_stilus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string message = "Teszáry Péter";
            string title = "Névjegy";
            MessageBox.Show(message, title);
        }

        private void megnyitas_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(szoveg.Document.ContentStart, szoveg.Document.ContentEnd);
            FileStream file = new FileStream("valami.txt", FileMode.Open);
            text.Load(file, System.Windows.DataFormats.Text);
            file.Close();
        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {
            TextRange text = new TextRange(szoveg.Document.ContentStart, szoveg.Document.ContentEnd);
            FileStream file = new FileStream("valami.txt", FileMode.Create);
            text.Save(file, System.Windows.DataFormats.Text);
            file.Close();
        }


    }
}
