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
        private void BtnCancelClick(object sender, RoutedEventArgs e) { Close(); }
        public void BtnOKClick(object sender, RoutedEventArgs e)
        {
            string leng = Convert.ToString(ListBoxData.Items[0]);
            string  leng1 = leng.ToString();
            string num = revers(leng1);
            int num1 = Convert.ToInt32(num);
            TextBlockAnswer.Text=$"{num1}";
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text))) { return; }
            try { string xa = Convert.ToString(TbNumber.Text); }
            catch (FormatException) { MessageBox.Show("Введены не корректные данные"); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            ListBoxData.Items.Add(TbNumber.Text);
        }
        public string revers(string a)
        {
            char[] a1 = a.ToCharArray();
            string mm1 = $"{a1[2]}{a1[1]}{a1[0]}";
            return mm1;
        }
    }
}
