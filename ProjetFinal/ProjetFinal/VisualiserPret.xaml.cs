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
    public sealed partial class VisualiserPret : Page
    {
        internal static int index = -1;
        public VisualiserPret()
        {
            this.InitializeComponent();
            deleteButton.IsEnabled = false;
            editButton.IsEnabled = false;
           // gvPret.ItemsSource = GestionBD.getInstance().getPretVue();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AjouterPret));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            //index = gvPret.SelectedIndex;
            //ModifierPret dialog = new ModifierPret();
            //await dialog.ShowAsync();
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
                //Pret c = (Pret)gvPret.SelectedItem;
                //GestionBD.getInstance().supprimerPret(c);
            }
        }


        private void detailButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gvPret_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
