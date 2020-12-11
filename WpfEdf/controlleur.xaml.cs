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

namespace WpfEdf
{
    /// <summary>
    /// Logique d'interaction pour controlleur.xaml
    /// </summary>
    public partial class controlleur : Window
    {
        edfEntities gst;
        public controlleur(edfEntities gstBDD)
        {
            InitializeComponent();
            gst = gstBDD;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //lstClients.ItemsSource = gst.client.ToList();
        }
    }
}
