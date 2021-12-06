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
    public sealed partial class VisualiserClient : Page
    {
        internal static int index = -1;
        public VisualiserClient()
        {
            this.InitializeComponent();
            deleteButton.IsEnabled = false;
            editButton.IsEnabled = false;
            gvClient.ItemsSource = GestionBD.getInstance().getListClient();
        }

        private async void addButton_Click(object sender, RoutedEventArgs e)
        {
            AjouterClient dialog = new AjouterClient();
            await dialog.ShowAsync();
        }

        private async void editButton_Click(object sender, RoutedEventArgs e)
        {
            index = gvClient.SelectedIndex;
            ModifierClient dialog = new ModifierClient();
            await dialog.ShowAsync();
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Confirmation de Suppression";
            dialog.Content = "Voulez-vous vraiment supprimer ce client?";
            dialog.PrimaryButtonText = "Oui";
            dialog.CloseButtonText = "Annuler";
            dialog.DefaultButton = ContentDialogButton.Primary;
            ContentDialogResult resultat = await dialog.ShowAsync();

            if (resultat == ContentDialogResult.None)
            {

            }
            else
            {
                Client c = (Client)gvClient.SelectedItem;
                GestionBD.getInstance().supprimerClient(c);
            }
        }

        private void gvClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deleteButton.IsEnabled = true;
            editButton.IsEnabled = true;
        }
    }
}
