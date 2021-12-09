using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
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
    public sealed partial class AjouterPret : Page
    {
        
        int jourHeure = 1;
        string userActif, numTel, materiel;
        Client rClient;
        Materiel rMateriel;
        ObservableCollection<Materiel> listeMaterielTEMPO;
        Pret p;
        int index = 0;


        public AjouterPret()
        {
            this.InitializeComponent();
            btnValider.IsEnabled = false;
            boxMateriel.IsEnabled = false;

            listeMaterielTEMPO = new ObservableCollection<Materiel>();

            grille.ItemsSource = listeMaterielTEMPO;
        }
        


        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            if (toggleSwitch.IsOn)
            {
                nbrDuree.Header = "Nombre d'heures";
                nbrDuree.Maximum = 24;
                jourHeure = 0;
            }
            else
            {

                nbrDuree.Header = "Nombre de jours";
                nbrDuree.Maximum = 31;
                jourHeure = 1;
            }

        }

        private void boxUser_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            boxUser.ItemsSource = GestionBD.getInstance().RechercherClient(boxUser.Text);

        }

        private void boxUser_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

            string expression = ",";
            string[] tableau = Regex.Split(args.SelectedItem.ToString(), expression);

            numTel = tableau[1];

            rClient = new Client(GestionBD.getInstance().RechercherClient2("numTel"));

            btnValider.IsEnabled = true;
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            string retour="";

            DateTime testdate;

           if(jourHeure == 0)
            {
                testdate =   DateTime.Now.AddHours(Convert.ToInt32( nbrDuree.Text));

                retour = testdate.ToString("dd/MM/yyyy");

            }
            if (jourHeure == 1)
            {
                testdate = DateTime.Now.AddDays(Convert.ToInt32(nbrDuree.Text));
                retour = testdate.ToString("dd/MM/yyyy");
            }

            
            p = new Pret(rClient.Id,rClient.Id, GestionBD.getInstance().getId(),1, DateTime.Now.ToString("yyyy MM dd"), DateTime.Now.ToString("h:mm"), retour);

            
            boxMateriel.IsEnabled = true;


        }

        private void grille_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnSupprimer.IsEnabled = true;

            index = grille.SelectedIndex;

        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            listeMaterielTEMPO.RemoveAt(index);
            btnSupprimer.IsEnabled = false;
        }

        private void btnAddPret_Click(object sender, RoutedEventArgs e)
        {
            GestionBD.getInstance().AjouterPret(p, listeMaterielTEMPO);
        }

        private void boxMateriel_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // DOIT inclure seulement le materiel disponible  -------
            boxMateriel.ItemsSource = GestionBD.getInstance().RechercherMateriel(boxMateriel.Text);
        }

        private void boxMateriel_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {

           

            rMateriel = (Materiel)args.SelectedItem;
            listeMaterielTEMPO.Add(rMateriel);

            btnAddPret.IsEnabled = true;


        }



    }
}
