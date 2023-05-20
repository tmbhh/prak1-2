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

namespace zaddop1_wpf
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

            int A = Convert.ToInt32(TbNumberA1.Text);
            int B = Convert.ToInt32(TbNumberB1.Text);
            int C = Convert.ToInt32(TbNumberC1.Text);
            int SSquare = C * C, count = 0, S = A * B;
            while (S >= SSquare)  {  S -= SSquare;  count++;  }
            TextBlockAnswer.Text = $"x =Mаксимальное число квадратов в прямоугольнике = {count}";  }

    }
}
