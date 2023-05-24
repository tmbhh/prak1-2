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
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        public void BtnOKClick(object sender, RoutedEventArgs e)
        {
            int leng = ListBoxData.Items.Count;
            int[] mass = new int[leng];
            double a=mass[0];
            double b=mass[1];
            a = signx(a);
            b = signx(b);
            TextBlockAnswer.Text = $"{a+b}";
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text))) { return; }
            try { int xa = Convert.ToInt32(TbNumber.Text); }
            catch (FormatException) { MessageBox.Show("Введены не корректные данные"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ListBoxData.Items.Add(TbNumber.Text);
        }
        public double signx(double x)
        {
            if (x < 0) { x = -1; }
            else if (x > 0) { x = 1; }
            else { x = 0; }
            return x;
        }
    }
}
