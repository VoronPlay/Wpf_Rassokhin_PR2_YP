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
    /// Логика взаимодействия для Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        public Window16()
        {
            InitializeComponent();
            mcolor = new ColorRGB();
            mcolor.red = 0;
            mcolor.green = 0;
            mcolor.blue = 0;
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
        }
        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }
        public ColorRGB mcolor { get; set; }

        public Color clr { get; set; }
        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name; //Определяем имя контрола, который покрутили
            double value = slider.Value; // Получаем значение контрола
                                         //В зависимости от выбранного контрола, меняем ту или иную компоненту и переводим ее в тип byte
            if (crlName.Equals("sld_RedColor"))
            {
                mcolor.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_GreenColor"))
            {
                mcolor.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sld_BlueColor"))
            {
                mcolor.blue = Convert.ToByte(value);
            }

            //Задаем значение переменной класса clr 
            clr = Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue);
            //Устанавливаем фон для контрола Label 
            this.lbl1.Background = new SolidColorBrush(Color.FromRgb(mcolor.red, mcolor.green, mcolor.blue));
            // Задаем цвет кисти для контрола InkCanvas
            this.inkCanvas1.DefaultDrawingAttributes.Color = clr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }

        private void btn_Select_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Select;
        }

        private void btn_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btn_AddText_Click(object sender, RoutedEventArgs e)
        {
            //Инициализация контрола tb типа TextBox
            TextBox tb = new TextBox
            {
                Width = 100,
                Height = 50,
                BorderThickness = new Thickness(),
                BorderBrush = new SolidColorBrush(Color.FromRgb(5, 5, 5)),
                Margin = new Thickness(20, 20, 0, 0)
            };
            //Добавление контрола tb
            this.inkCanvas1.Children.Add(tb);
            //Переключение фокуса на элемент, чтоб можно было сразу ввести текст с клавиатуры
            tb.Focus();
        }

        private void btn_kisti_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;

        }

        private void btn_lastik_Click(object sender, RoutedEventArgs e)
        {
            if (inkCanvas1.EditingMode == InkCanvasEditingMode.Ink)
                inkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
            else
                inkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
