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
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //connexion.Icon = new SymbolIcon(Symbol.LeaveChat);
            //connexion.Content = "test";
            //connexion.Foreground = new SolidColorBrush(Color."red")

            mainFrame.Navigate(typeof(PageConnexion));
        }

        private void nvMenue_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

            var item = (NavigationViewItem)args.SelectedItem;

            switch (item.Name)
            {
                case "AddMateriel":
                    mainFrame.Navigate(typeof(AjoutMateriel));
                    break;
                case "ViewMateriel":
                    mainFrame.Navigate(typeof(ViewMateriel));
                    break;
                case "AddUser":
                    mainFrame.Navigate(typeof(AjouterUsager));
                    break;
                case "ViewUsers":
                    mainFrame.Navigate(typeof(VisualiserUsager));
                    break;
                case "AddPret":
                    mainFrame.Navigate(typeof(AjouterPret));
                    break;
                case "ViewPrets":
                    mainFrame.Navigate(typeof(VisualiserPret));
                    break;
                case "AddClient":
                    mainFrame.Navigate(typeof(AjoutClient));
                    break;
                case "ViewClients":
                    mainFrame.Navigate(typeof(VisualiserClient));
                    break;
                default:
                    break;
            }

        }
    }
}
