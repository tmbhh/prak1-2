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
            int count;
            int k = Convert.ToInt32(TbNumberA1.Text);
            if (k >= 1 && k <= 365)
            { for (int i = 7; k >= i;) { k = k - i; } }
            count = k;
            if (count == 0) { TextBlockAnswer.Text = "номер дня недели 0"; }
            else if (count == 1) { TextBlockAnswer.Text = "номер дня недели 1"; }
            else if (count == 2) { TextBlockAnswer.Text = "номер дня недели 2"; }
            else if (count == 3) { TextBlockAnswer.Text = "номер дня недели 3"; }
            else if (count == 4) { TextBlockAnswer.Text = "номер дня недели 4"; }
            else if (count == 5) { TextBlockAnswer.Text = "номер дня недели 5"; }
            else if (count == 6) { TextBlockAnswer.Text = "номер дня недели 6"; } }
       
    }
}
