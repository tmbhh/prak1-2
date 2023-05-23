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
        public void BtnOK_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(TbNumberA.Text);
            int b = Convert.ToInt32(TbNumberB.Text);
            int cc = b;
       
            do
            {
                a = a - b;
            }
            while (a > b);



            
            TextBlockAnswer.Text = $"незанятая часть = {a}";

        }
    }
}
