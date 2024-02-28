using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace utolso_projekt
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton elsoRadioButton = GetSelectedRadioButton("elsoszakasz");
            RadioButton masodikRadioButton = GetSelectedRadioButton("masodikszakasz");

            if (elsoRadioButton != null && masodikRadioButton != null)
            {
                Color szin1 = GetSzinByRadioButton(elsoRadioButton);
                Color szin2 = GetSzinByRadioButton(masodikRadioButton);

                LinearGradientBrush gradiensKeverek = new LinearGradientBrush(szin1, szin2, 0);
                wrapPanel.Background = gradiensKeverek;
            }
        }

        private Color GetSzinByRadioButton(RadioButton radioButton)
        {
            switch (radioButton.Content.ToString())
            {
                case "Első":
                    return Colors.Red;
                case "Második":
                    return Colors.Green;
                case "Harmadik":
                    return Colors.Blue;
                case "Negyedik":
                    return Colors.Yellow;
                case "Ötödik":
                    return Colors.Orange;
                case "Hatodik":
                    return Colors.Purple;
                default:
                    return Colors.Black;
            }
        }

        private RadioButton GetSelectedRadioButton(string groupName)
        {
            foreach (var radioButton in FindVisualChildren<RadioButton>(this))
            {
                if (radioButton.GroupName == groupName && radioButton.IsChecked == true)
                    return radioButton;
            }
            return null;
        }

        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject dependencyObject) where T : DependencyObject
        {
            if (dependencyObject != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(dependencyObject); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(dependencyObject, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }
    }
}
