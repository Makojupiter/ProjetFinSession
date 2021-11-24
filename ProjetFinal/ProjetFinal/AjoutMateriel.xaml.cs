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
    public sealed partial class AjoutMateriel : Page
    {
        public AjoutMateriel()
        {
            this.InitializeComponent();
            btnAddMateriel.IsEnabled = false;
            txtIDMateriel.MaxLength = 7;
            verifID = verifMarque = verifNote = verifModel = verifEtat = false;
        }

        bool verifID ,verifMarque , verifNote ,verifModel, verifEtat;
        string etats;




        private async void btnAddMateriel_Click(object sender, RoutedEventArgs e)
        {
            Materiel m = new Materiel(txtIDMateriel.Text, txtMarqueMateriel.Text, txtModelMateriel.Text, etats, txtNoteMateriel.Text);

            //Ajout au singletone

            ContentDialog ajout = new BoiteAjout();

            var result = await ajout.ShowAsync();

            Frame.Navigate(typeof(Accueil));
        }

        private void txtNoteMateriel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNoteMateriel.Text.Trim() == "")
            {
                txtNoteMaterielErr.Text = "Ne peut etre vide";
                verifNote = false;
            }
            else
            {
                txtNoteMaterielErr.Text = "";
                verifNote = true;
            }

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                btnAddMateriel.IsEnabled = true;
            }
            else
                btnAddMateriel.IsEnabled = false;
        }

        private void cbEtat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if(cbEtat.SelectedIndex != -1)
            {
                etats = e.AddedItems[0].ToString();
                verifEtat = true;
                txtEtatMaterielErr.Text = "";
            }

            if(cbEtat.SelectedIndex == -1)
            {
                verifEtat = false;
                txtEtatMaterielErr.Text = "Veillez choisir un etat dans la liste.";
            }

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                btnAddMateriel.IsEnabled = true;
            }
            else
                btnAddMateriel.IsEnabled = false;

        }

        private void txtModelMateriel_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtModelMateriel.Text.Trim() == "")
            {
                txtModelMaterielErr.Text = "Ne peut etre vide";
                verifModel = false;
            }
            else
            {
                txtModelMaterielErr.Text = "";
                verifModel = true;
            }

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                btnAddMateriel.IsEnabled = true;
            }
            else
                btnAddMateriel.IsEnabled = false;

        }

        private void txtMarqueMateriel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMarqueMateriel.Text.Trim() == "")
            {
                txtMarqueMaterielErr.Text = "Ne peut etre vide";
                verifMarque = false;
            }
            else
            {
                txtMarqueMaterielErr.Text = "";
                verifMarque = true;
            }

            if(verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                btnAddMateriel.IsEnabled = true;
            }
            else
                btnAddMateriel.IsEnabled = false;

        }

        private void txtIDMateriel_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtIDMateriel.Text.Trim() == "")
            {
                txtIDMaterielErr.Text = "Ne peut etre vide";
                verifID = false;
            }

            else if (txtIDMateriel.Text.Length > 7)
            {
                txtIDMaterielErr.Text = "Ne dois pas contenir plus de 7 caracteres";
                verifID = false;
            }
            else if (txtIDMateriel.Text.Length < 7)
            {
                txtIDMaterielErr.Text = "Dois contenir 7 caracteres";
                verifID = false;
            }
            else
            {
                txtIDMaterielErr.Text = "";
                verifID = true;
            }

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                btnAddMateriel.IsEnabled = true;
            }
            else
                btnAddMateriel.IsEnabled = false;

        }
    }
}
