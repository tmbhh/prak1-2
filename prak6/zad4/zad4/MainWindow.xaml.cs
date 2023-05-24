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
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        public void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int leng = ListBoxData.Items.Count;
            int[] mass = new int[leng];
            int n1 =mass[0];  int n2 = mass[1]; int n3 = mass[2]; 
            double X = mass[3]; double Y = lokomotiv(n1, n2, n3, X);
            TextBlockAnswer.Text = $"Ответ:\nЗначение выражения: {Y}";
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text))) { return; }
            try { int xa = Convert.ToInt32(TbNumber.Text); }
            catch (FormatException) { MessageBox.Show("Введены не корректные данные"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ListBoxData.Items.Add(TbNumber.Text);
        }
        public static double lokomotiv(int A, int B, int n, double x)
        {
            double res = 0;
            for (int i = A; i <= B; i += n) { if (x < 0)  {  res = -4;  }  else if (x >= 1) {  res = 2;  } else { res = Math.Pow(x, 2); } }
            return res;
        }
    }
}
