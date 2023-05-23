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

namespace zad1
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
        int m = Convert.ToInt32(TbNumberA.Text);
        int n = Convert.ToInt32(TbNumberB.Text);
           
            switch (n)
            {
                case 6: TextBlockAnswer.Text += "Шестерка ";
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 7: TextBlockAnswer.Text += "Семерка "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 8: TextBlockAnswer.Text += "Восьмерка "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 9: TextBlockAnswer.Text += "Девятка "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 10: TextBlockAnswer.Text += "Десятка "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 11: TextBlockAnswer.Text += "Валет "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 12: TextBlockAnswer.Text += "Дама "; 
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 13: TextBlockAnswer.Text += "Король ";
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;
                case 14: TextBlockAnswer.Text += "Туз ";
                    switch (m)
                    {
                        case 1:
                            TextBlockAnswer.Text += "Пики "; break;
                        case 2: TextBlockAnswer.Text += "Трефы "; break;
                        case 3: TextBlockAnswer.Text += "Бубны "; break;
                        case 4: TextBlockAnswer.Text += "Червы "; break;
                    }
                    break;

            }
            

        }
    }
}
