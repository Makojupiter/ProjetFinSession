using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ProjetFinal
{

        
    

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            mainFrame.Navigate(typeof(Accueil));
        }

        private void nvMenue_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            var item = (NavigationViewItem)args.SelectedItem;

            switch (item.Name)
            {
                case "Accueil":
                    mainFrame.Navigate(typeof(Accueil));
                    break;
                case "ViewMateriel":
                    mainFrame.Navigate(typeof(VisualiserMateriel));
                    break;
                case "ViewUsers":
                    mainFrame.Navigate(typeof(VisualiserUtilisateur));
                    break;
                case "ViewPrets":
                    mainFrame.Navigate(typeof(VisualiserPret));
                    break;
                case "ViewClients":
                    mainFrame.Navigate(typeof(VisualiserClient));
                    break;
                default:
                    break;
            }

        }

        private void nvMenue_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (mainFrame.CanGoBack)
                mainFrame.GoBack();
        }

        private void Deconnexion_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GestionBD.getInstance().logout();
            Frame.Navigate(typeof(PageConnexion));
        }

        private void Compte_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
}
