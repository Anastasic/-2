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
    /// Логика взаимодействия для peson.xaml
    /// </summary>
    public partial class peson : Window
    {
        public peson()
        {
            InitializeComponent();
        }

        private void profi(object sender, RoutedEventArgs e)
        {
            profil pr = new profil();
            pr.Show();
            Close();
        }
    }
}
