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

namespace zad2
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
        public void BtnOK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TbNumberA.Text);
            switch (x)
            {
                case 1: TextBlockAnswer.Text = "Понедльник"; break;
                case 2: TextBlockAnswer.Text = "Вторник"; break;
                case 3: TextBlockAnswer.Text = "Среда"; break;
                case 4: TextBlockAnswer.Text = "Четверг"; break;
                case 5: TextBlockAnswer.Text = "Пятница"; break;
                case 6: TextBlockAnswer.Text = "Суббота"; break;
                case 7: TextBlockAnswer.Text = "Воскресенье"; break;
            }
        }
}
