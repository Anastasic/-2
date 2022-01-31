using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Банк
{
    /// <summary>
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Window
    {
        public reg()
        {
            InitializeComponent();
        }

        private void pa(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[A-Za-z0-9.!]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
            base.OnPreviewTextInput(e);
        }

        private void lo(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^[A-Za-z0-9.]");
            if (!regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
            base.OnPreviewTextInput(e);
        }


        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void regist(object sender, RoutedEventArgs e)
        {


            ////Для того, чтобы поучить только дату, без времени.
            //if (dt.SelectedDate.HasValue)
            //{
            //    string formatted = dt.SelectedDate.Value.ToString("dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            //    rr.Text += formatted;
            //}

            vhodd vh = new vhodd();
            vh.Show();
            Close();

        }

        private void back(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            Close();
        }
    }
}
