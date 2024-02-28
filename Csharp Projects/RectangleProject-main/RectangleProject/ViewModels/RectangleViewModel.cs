using RectangleProject.Models;
using System;
using System.Windows;
using ViewModels.BaseClass;

namespace RectangleProject.ViewModels
{
    public class RectangleViewModel : ViewModelBase
    {
        private Rectangle _rectangle;

        public RectangleViewModel()
        {
            _rectangle = new Rectangle(1, 1);
            CloseCommand = new RelayCommand(execute => CloseWindow());
            CalculationCommand = new RelayCommand(execute => Calculation());
        }

        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand CalculationCommand { get; private set; }

        public string SideA
        {
            get
            {
                return _rectangle.SideA.ToString();
            }
            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    _rectangle.SideA = side;
                }
                catch (Exception e)
                {
                }
            }
        }
        public string SideB
        {
            get
            {
                return _rectangle.SideB.ToString();
            }

            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    _rectangle.SideB = side;
                }
                catch (Exception e)
                {
                }
            }
        }

        public string Perimeter
        {
            get
            {
                double roundedPerimeter = Math.Round(_rectangle.Perimeter, 2);
                return "A téglalap kerülete: " + roundedPerimeter.ToString() + " méter.";
            }
        }

        public string Area
        {
            get
            {
                double roundedArea = Math.Round(_rectangle.Area, 2);
                return "A téglalap területe: " + roundedArea.ToString() + " négyzetméter.";
            }
        }

        private void CloseWindow()
        {
            Application.Current.Windows[0].Close();
        }

        private void Calculation()
        {
            OnPropertyChanged(nameof(Perimeter));
            OnPropertyChanged(nameof(Area));
        }
    }
}