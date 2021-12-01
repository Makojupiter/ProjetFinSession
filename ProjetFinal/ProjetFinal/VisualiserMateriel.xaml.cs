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
    public sealed partial class VisualiserMateriel : Page
    {
        internal static int index = -1;
        public VisualiserMateriel()
        {
            this.InitializeComponent();
            gvMateriel.ItemsSource = GestionBD.getInstance().getListMateriel();
        }

        private async void addButton_Click(object sender, RoutedEventArgs e)
        {
            AjouterMateriel dialog = new AjouterMateriel();
            await dialog.ShowAsync();
        }

        private async void editButton_Click(object sender, RoutedEventArgs e)
        {
            index = gvMateriel.SelectedIndex;
            ModifierMateriel dialog = new ModifierMateriel();
            await dialog.ShowAsync();
        }

        private async void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.Title = "Confirmation de Suppression";
            dialog.Content = "Voulez-vous vraiment supprimer ce matériel?";
            dialog.PrimaryButtonText = "Oui";
            dialog.CloseButtonText = "Annuler";
            dialog.DefaultButton = ContentDialogButton.Primary;
            ContentDialogResult resultat = await dialog.ShowAsync();

            if (resultat == ContentDialogResult.None)
            {

            }
            else
            {
                Materiel c = (Materiel)gvMateriel.SelectedItem;
                GestionBD.getInstance().supprimerMateriel(c);
            }
        }
    }
}
