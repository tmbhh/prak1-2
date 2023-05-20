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

namespace zad4_wpf
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
        void BtnOK_Click(object sender, EventArgs e)
        {
            double? y = null;
            double x = Convert.ToDouble(TbNumberA.Text);
            if (x < 0) { y = x * x - 3 - Pow(PI - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y}"; }
            else if (0 <= x && x < 1) { y = x * x - 3 - Pow(PI - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y}"; }
            else if (x >= 1) { y = x * x - 3 - Pow(PI - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y}"; }
            else { TextBlockAnswer.Text = "vne znachenya"; }
        }
    }
}
