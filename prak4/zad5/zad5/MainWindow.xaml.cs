﻿using System;
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

namespace zad5
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

            int p = Convert.ToInt32(TbNumberA.Text);//проценты0-25
            int k =0;//количество месяцев
            double s = 1000;//итоговый размер вклада 
            
            do
            {
                s = s+s * p/100;
                k++;
            }
            while (s<=1100);
            TextBlockAnswer.Text = $"месяцы ={k} ";

        }
    }
}
