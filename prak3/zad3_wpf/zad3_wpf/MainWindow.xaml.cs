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

namespace zad3_wpf
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

            int a = Convert.ToInt32(TbNumberA.Text);
            int b = Convert.ToInt32(TbNumberB.Text);
            int c = Convert.ToInt32(TbNumberC.Text);
            int d = Convert.ToInt32(TbNumberD.Text);
            if (a == b && b == c && c != d) { TextBlockAnswer.Text = "4 порядковый номер"; }
            else if (a == b && b == d && d != c) { TextBlockAnswer.Text = "3 порядковый номер"; }
            else if (a == c && c == d && d != b) { TextBlockAnswer.Text = "2 порядковый номер"; }
            else if (d == b && b == c && c != a) { TextBlockAnswer.Text = "1 порядковый номер"; }
            else { TextBlockAnswer.Text = $"условия не выполнены "; }
        }
    }
}
