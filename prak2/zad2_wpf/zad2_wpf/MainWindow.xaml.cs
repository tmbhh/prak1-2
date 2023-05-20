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

namespace zad2_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {  InitializeComponent();  }
        void BtnOK_Click(object sender, EventArgs e)  {  string str = TbNumberA1.Text;   char[] a = str.ToCharArray();            TextBlockAnswer.Text = $"{a[2]}{a[0]}{a[1]}";  }
    }
}
