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

namespace Банк
{
    /// <summary>
    /// Логика взаимодействия для profil.xaml
    /// </summary>
    public partial class profil : Window
    {
        public profil()
        {
            InitializeComponent();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            vhodd vh = new vhodd();
            vh.Show();
            Close();
        }

        private void chage(object sender, RoutedEventArgs e)
        {
            change_profil ch = new change_profil();
            ch.Show();
            Close();
        }
    }
}
