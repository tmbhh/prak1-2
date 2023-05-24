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

namespace zad4
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
            double x = Convert.ToDouble(TbNumberA.Text);
            int n= Convert.ToInt32(TbNumberB.Text);
            if (Abs(x) < 1 && n > 0) 
            { 
                for(int i = 1; i <= n; i++)
                {
                    x=x+Pow(-1,i)*Pow(x,2*i+1)/(2*i+1);
                }
            }
            TextBlockAnswer.Text = Convert.ToString(x);
            
        }

        
    }
}
