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

namespace Wpf_Rassokhin_PR2_YP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void z_odin(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void z_dva(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show(); 
            
        }

        private void z_Tri(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void z_Herire(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void z_Payti(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void z_Shecti(object sender, RoutedEventArgs e)
        {
            Window6 window6 = new Window6();
            window6.Show();
        }

        private void z_Semi(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
        }

        private void z_Vosemi(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
        }

        private void z_Devyati(object sender, RoutedEventArgs e)
        {
            Window9 window9 = new Window9();
            window9.Show();
        }

        private void z_Desayti(object sender, RoutedEventArgs e)
        {
            Window10 window10 = new Window10();
            window10.Show();
        }

        private void z_Odinadhati(object sender, RoutedEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
        }

        private void z_Dvenadhati(object sender, RoutedEventArgs e)
        {
            Window12 window12 = new Window12();
            window12.Show();
        }

        private void z_CP_1(object sender, RoutedEventArgs e)
        {
            Window14 window14 = new Window14();
            window14.Show();
        }
    }
}
