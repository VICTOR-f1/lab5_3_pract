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

namespace lab5_3
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            t3.Style = (Style)t3.FindResource("BIG");
            if (true)
            {
                t1.Style = (Style)t1.FindResource("SMALL");
                t2.Style = (Style)t2.FindResource("SMALL");

                t4.Style = (Style)t4.FindResource("SMALL");
                t5.Style = (Style)t5.FindResource("SMALL");
                t6.Style = (Style)t6.FindResource("SMALL");

            }

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            t1.Style = (Style)t1.FindResource("BIG");
            if (true)
            {
                t2.Style = (Style)t2.FindResource("SMALL");
                t3.Style = (Style)t3.FindResource("SMALL");

                t4.Style = (Style)t4.FindResource("SMALL");
                t5.Style = (Style)t5.FindResource("SMALL");
                t6.Style = (Style)t6.FindResource("SMALL");

            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            t5.Style = (Style)t5.FindResource("BIG");
            if (true)
            {
                t1.Style = (Style)t1.FindResource("SMALL");

                t2.Style = (Style)t2.FindResource("SMALL");
                t3.Style = (Style)t3.FindResource("SMALL");

                t4.Style = (Style)t4.FindResource("SMALL");
                t6.Style = (Style)t6.FindResource("SMALL");

            }
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            t6.Style = (Style)t6.FindResource("BIG");
            if (true)
            {
                t1.Style = (Style)t1.FindResource("SMALL");

                t2.Style = (Style)t2.FindResource("SMALL");
                t3.Style = (Style)t3.FindResource("SMALL");

                t4.Style = (Style)t4.FindResource("SMALL");
                t5.Style = (Style)t5.FindResource("SMALL");

            }

        }

        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e)
        {
            t2.Style = (Style)t2.FindResource("BIG");
            if (true)
            {
                t1.Style = (Style)t1.FindResource("SMALL");

                t3.Style = (Style)t3.FindResource("SMALL");
                t5.Style = (Style)t5.FindResource("SMALL");

                t4.Style = (Style)t4.FindResource("SMALL");
                t6.Style = (Style)t6.FindResource("SMALL");

            }
        }

        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e)
        {
            t4.Style = (Style)t4.FindResource("BIG");
            if (true)
            {
                t1.Style = (Style)t1.FindResource("SMALL");

                t2.Style = (Style)t2.FindResource("SMALL");
                t3.Style = (Style)t3.FindResource("SMALL");

                t5.Style = (Style)t5.FindResource("SMALL");
                t6.Style = (Style)t6.FindResource("SMALL");

            }
        }
    }
}
