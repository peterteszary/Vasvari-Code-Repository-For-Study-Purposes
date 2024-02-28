using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace TeruletKeruletSzamitas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            // Alapértelmezett értékek beállítása a beviteli mezőkbe
            txtSideA.Text = "10";
            txtSideB.Text = "20";
            txtSideC.Text = "15";

            // Adatkapcsolat hozzáadása a beviteli mezőkhöz a változások figyeléséhez
            txtSideA.TextChanged += InputTextChanged;
            txtSideB.TextChanged += InputTextChanged;
            txtSideC.TextChanged += InputTextChanged;

            // Kezdeti eredmény kiszámítása
            UpdateResults();
        }

        private void InputTextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateResults();
        }

        private void UpdateResults()
        {
            try
            {
                double aCM = Convert.ToDouble(txtSideA.Text);
                double bCM = Convert.ToDouble(txtSideB.Text);
                double cCM = Convert.ToDouble(txtSideC.Text);

                // Átváltás centiméterről méterre (1 méter = 100 centiméter)
                double a = aCM / 100.0;
                double b = bCM / 100.0;
                double c = cCM / 100.0;

                if (a + b > c && a + c > b && b + c > a)
                {
                    double keruletCM = (a + b + c) * 100.0; // Eredményt átváltjuk centiméterbe
                    double s = keruletCM / 2; // Félszélesség
                    double teruletCM2 = (Math.Sqrt(s * (s - a) * (s - b) * (s - c))) * 10000.0; // Eredményt átváltjuk négyzetcentiméterbe

                    lblKerulet.Text = keruletCM.ToString("F2");
                    lblTerulet.Text = teruletCM2.ToString("F2");
                }
                else
                {
                    lblKerulet.Text = "Nem háromszög!";
                    lblTerulet.Text = "";
                }
            }
            catch (FormatException)
            {
                lblKerulet.Text = "Hibás adatok!";
                lblTerulet.Text = "";
            }
        }
    }
}
