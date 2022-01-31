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
    /// Логика взаимодействия для change_profil.xaml
    /// </summary>
    public partial class change_profil : Window
    {
        public change_profil()
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

        private void add(object sender, RoutedEventArgs e)
        {

        }
    }
}
