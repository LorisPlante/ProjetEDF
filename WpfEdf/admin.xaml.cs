using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
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
    /// Logique d'interaction pour admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        edfEntities gst;
        public admin(edfEntities gstBDD)
        {
            InitializeComponent();
            gst = gstBDD;
        }

        private void btnAjoutClient_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomClient.Text == "")
            {
                MessageBox.Show("Saisissez un Nom", "erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPrenomClient.Text == "")
            {
                MessageBox.Show("Saisissez un Prenom", "erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //List<client> lesClients = gst.client.ToList();
                //var ajoutClient = from a in lesClients
                //                  where a.idcontroleur = (lstControleurs.SelectedItem as controleur).id
                //                  ;

                //    je n'ai pas reussi a trouver comment insérer un client


            }
        }

        private void btnAjoutControleur_Click(object sender, RoutedEventArgs e)
        {
            if (txtNomControleur.Text =="")
            {
                MessageBox.Show("Saisissez un Nom", "erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPrenomControleur.Text == "")
            {
                MessageBox.Show("Saisissez un Prenom", "erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                //List<controleur> lesControleurs = gst.controleur.ToList();
                //var ajoutControleur = from a in lesControleurs
                //                      ;

                //    je n'ai pas reussi a trouver comment insérer un controlleur
                                      
                                      
            }
        }

        private void lstControleurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstControleurs.SelectedItem != null)
            {
                lstClients.ItemsSource = from a in gst.client.ToList()
                                        where gst.client.ToList().FindAll(i => i.identifiant == (lstControleurs.SelectedItem as controleur).id).Any(ins => ins.identifiant == a.idcontroleur)
                                        select a;

                //var derReleve = from b in gst.client.ToList() 
                //                select b.dernierReleve;
                //var ancReleve = from c in gst.client.ToList()
                //                select c.ancienReleve;
                //int calculConso = Convert.ToInt32(derReleve) - Convert.ToInt32(ancReleve);

                //    je n'ai pas réussi a calculer la consomation
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lstControleurs.ItemsSource = gst.controleur.ToList();
        }
    }
}
