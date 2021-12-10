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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjetFinal
{

    
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Accueil : Page
    {
        public Accueil()
        {
            this.InitializeComponent();

            txtNomUsager.Text = "Bonjour " + GestionBD.getInstance().getUsername();
            dateHeure.Text = DateTime.Now.ToString("dddd dd MMMM yyyy") + "\n" + DateTime.Now.ToString("H:m");

        }

        private void bouton1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AjouterPret));
        }

        private async void bouton2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VisualiserClient));
            AjouterClient dialog = new AjouterClient();
            await dialog.ShowAsync();
        }

        private async void bouton3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VisualiserMateriel));
            AjouterMateriel dialog = new AjouterMateriel();
            await dialog.ShowAsync();
        }

        private async void bouton6_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VisualiserUtilisateur));
            AjouterUtilisateur dialog = new AjouterUtilisateur();
            await dialog.ShowAsync();
        }
    }
}
