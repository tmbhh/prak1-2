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

namespace zad3
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
            double r, d, l, s;
            int parametr = Convert.ToInt32(TbNumberA.Text);
            int znachenie = Convert.ToInt32(TbNumberB.Text);
           
            switch (parametr)
            {
                case 1:
                    r = znachenie;
                    s = PI * r * r;
                    d = 2 * r;
                    l = 2 * PI * r;
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;
                   
                case 2:
                    d = znachenie;
                    r =d/2;
                    s = PI * r * r;
                    
                    l = 2 * PI * r;
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;

                case 3:
                    l = znachenie;
                    r =l/(2*PI);
                    s = PI * r * r;
                    d = 2 * r;
               
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;

                case 4:
                    s = znachenie;
                    r =Sqrt(s/PI);
                    d = 2 * r;
                    l = 2 * PI * r;
                    TextBlockAnswer.Text = $"r={r}, s={s}, d={d},l={l}";
                    break;

            }
            


        }
    }
}
