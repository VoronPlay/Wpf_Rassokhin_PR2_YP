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
using System.Windows.Shapes;

namespace Wpf_Rassokhin_PR2_YP
{
    /// <summary>
    /// Логика взаимодействия для Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        public Window14()
        {
            InitializeComponent();
        }

        private void closs(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void info(object sender, RoutedEventArgs e)
        {
            Window15 window15 = new Window15();
            window15.Show();
        }
        private void fon(object sender, RoutedEventArgs e)
        {
            menu.Background = Brushes.Green;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
