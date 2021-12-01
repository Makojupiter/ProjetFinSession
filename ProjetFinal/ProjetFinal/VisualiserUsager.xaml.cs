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
    public sealed partial class VisualiserUsager : Page
    {

        internal static int index = -1;
        public VisualiserUsager()
        {
            this.InitializeComponent();
            gvUtilisateur.ItemsSource = GestionBD.getInstance().getListUtilisateur();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //this.OnNavigatedTo(typeof(AjouterUsager));
        }

        private async void editButton_Click(object sender, RoutedEventArgs e)
        {
            index = gvUtilisateur.SelectedIndex;
            ModifierUtilisateur dialog = new ModifierUtilisateur();
            await dialog.ShowAsync();
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Confirmation de Suppression";
            dialog.Content = "Voulez-vous vraiment supprimer cet utilisateur?";
            dialog.PrimaryButtonText = "Oui";
            dialog.CloseButtonText = "Annuler";
            dialog.DefaultButton = ContentDialogButton.Primary;
            ContentDialogResult resultat = await dialog.ShowAsync();

            if (resultat == ContentDialogResult.None)
            {

            }
            else
            {
                Utilisateur c = (Utilisateur)gvUtilisateur.SelectedItem;
                GestionBD.getInstance().supprimerUtilisateur(c);
            }
        }
    }
}
