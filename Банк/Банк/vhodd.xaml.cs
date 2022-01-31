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
    /// Логика взаимодействия для vhodd.xaml
    /// </summary>
    public partial class vhodd : Window
    {
        public vhodd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            peson ps = new peson();
            ps.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mn = new MainWindow();
            mn.Show();
            Close();
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
    }
}
