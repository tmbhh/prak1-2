using System;
using System.Collections.Generic;
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
using static System.Math;

namespace zad5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
          
            int i = 2;
            double a = 1;
            double g=0;
            while (i < 14)
            {
                g += a;
                i++;
                a = g + (a - 1) / (Pow(2, i - 1));
            }
            g += a;
            TextBlockAnswer.Text = Convert.ToString(g);
        }
    }
}
