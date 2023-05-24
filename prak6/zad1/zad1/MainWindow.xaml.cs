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
        public int minz(int a, int b)
        {
            int min = a;
            if (a > b) { min = b; }
            return min;
        }
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            
            int min1,min2,min;
            int leng = ListBoxData.Items.Count;
            int[] mass = new int[leng];
            for (int k = 0; k < leng; k++) mass[k] = Convert.ToInt32(ListBoxData.Items[k]);
            min1=minz(mass[0],mass[1]);
            min2 = minz(mass[2], mass[3]);
            min = minz(min1, min2);
            TextBlockAnswer.Text = $"{min}";
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text))) { return; }
            try { int xa = Convert.ToInt32(TbNumber.Text); }
            catch (FormatException) { MessageBox.Show("Введены не корректные данные"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ListBoxData.Items.Add(TbNumber.Text);
        }
        
    }
}
