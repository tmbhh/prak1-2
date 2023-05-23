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

namespace zaddop1
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
            int n = Convert.ToInt32(TbNumberA.Text);
            int k = Convert.ToInt32(TbNumberB.Text);
            double s = 0;
            for(int i=0; i<n; i++) {  s += Pow(i, k);  }
            TextBlockAnswer.Text = Convert.ToString(s);

        }
    }
}
