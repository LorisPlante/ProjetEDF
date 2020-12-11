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

namespace WpfEdf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        edfEntities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new edfEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtLogin.Text == "")
            {
                txtConnexion.Text = "Veuillez saisir un Login";
            }
            else if (txtMdp.Text == "")
            {
                txtConnexion.Text = "Veuillez saisir un Mot de passe";
            }
            else
            {
                controleur leCtrl = gst.controleur.ToList().Find(ctrl => ctrl.login == txtLogin.Text && ctrl.mdp == txtMdp.Text);
                if (leCtrl == null)
                {
                    txtConnexion.Text = "Controleur inexistant";
                }
                else if(leCtrl.statut == "admin")
                {
                    admin frm = new admin(gst);
                    frm.Show();
                }
                else
                {
                    controlleur frm = new controlleur(gst);
                    frm.Show();
                }
            }
        }
    }
}
