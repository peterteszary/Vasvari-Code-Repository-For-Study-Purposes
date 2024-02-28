using System;
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

namespace Gyakorlas_2023_05_31_tp
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

        // Stílusok

        private void elso_stilus_Click(object sender, RoutedEventArgs e)
        {
            foablak.Background = Brushes.Blue;
            Foreground = Brushes.White;
        }

        private void masodik_stilus_Click(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString
                ("#FFDFD991");
            foablak.Background = new SolidColorBrush(color);
        }

        private void harmadik_stilus_Click(object sender, RoutedEventArgs e)
        {
            Color color = (Color)ColorConverter.ConvertFromString
                ("#FFDFD991");
            foablak.Background = new SolidColorBrush(color);
        }


        //Új dokumentum
        private void ujdokumentum(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Szeretnéd törölni a szöveget", "Kérdés", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                szoveg.Document.Blocks.Clear();
            }
            else { }
        }


        //Megnyitás
        private void megnyitas(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == true)
            {
                TextRange range = new TextRange(szoveg.Document.ContentStart, szoveg.Document.ContentEnd);
                FileStream file = new FileStream(openFileDialog1.FileName, FileMode.Open);
                range.Load(file, System.Windows.DataFormats.Text);
                file.Close();
            }
        }

        //Mentés Másként
        private void mentesmaskent(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog saveFileDialog1 = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog1.Filter = "Szöveges állomány (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == true)
            {
                TextRange range = new TextRange(szoveg.Document.ContentStart, szoveg.Document.ContentEnd);
                FileStream file = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                range.Save(file, System.Windows.DataFormats.Text);
                file.Close();
            }
            //A kilépés gombra kattintva kérdezze meg biztosan kilép-e
            //Szerkesztés menü
            //Névjegy Messagebox-szal
            //Richtextbox-nak legyen 3 stílusa csak a hátteret változtatva
        }


        // Kilépés

        private void kilepes(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Szeretnél kilépni?", "Kérdés", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
            else { }
        }

        private void foablak_Activated(object sender, EventArgs e)
        {

        }

        private void foablak_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("A program bezáródik...", "Ablak");
        }

        private void foablak_Initialized(object sender, EventArgs e)
        {
            MessageBox.Show("A program elindul...", "Ablak");
        }

        // Névjegy

        private void nevjegy(object sender, RoutedEventArgs e)
        {
            string message = "Teszáry Péter";
            string title = "Névjegy";
            MessageBox.Show(message, title);
        }
    }
}


    

