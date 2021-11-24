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
    public sealed partial class AjoutClient : Page
    {
        public AjoutClient()
        {
            this.InitializeComponent();
            btnAjouter.IsEnabled = false;
            NomV = telV = emailV = verifType =  false;
        }

        bool NomV, telV, emailV, valideMail, valideMail2, verifType;
        string type;



        private async void btnAjouter_Click(object sender, RoutedEventArgs e)
        {

            Client c = new Client(txtNom.Text, txtEmail.Text, txtTel.Text, txtPoste.Text, txtBureau.Text, type);

            //Ajouter a la BD

            ContentDialog ajout = new BoiteAjout();

            var result = await ajout.ShowAsync();

            Frame.Navigate(typeof(Accueil));
        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbType.SelectedIndex != -1)
            {
                type = e.AddedItems[0].ToString();
                verifType = true;
                txtTypeErr.Text = "";
            }

            if (cbType.SelectedIndex == -1)
            {
                verifType = false;
                txtTypeErr.Text = "Veillez choisir un type de client dans la liste.";
            }

            if (cbType.SelectedIndex == 0)
            {
                txtBureau.Visibility = Visibility.Collapsed;
            }
            else
            {
                txtBureau.Visibility = Visibility.Visible;
            }

            if (NomV && telV && emailV && verifType)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

            valideMail = txtEmail.Text.Contains("@");
            valideMail2 = txtEmail.Text.EndsWith("cegeptr.qc.ca");

            if (txtEmail.Text.Trim() == "")
            {
                txtEmailErr.Text = "Ne peut etre vide";
                emailV = false;
            }
            else if(!valideMail || !valideMail2)
            {
                txtEmailErr.Text = "Email non valide";
                emailV = false;
            }
            else
            {
                txtEmailErr.Text = "";
                emailV = true;
                //interoger BD pour doublons
            }

            if (NomV && telV && emailV && verifType)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
        }

        private void txtTel_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtTel.Text.Trim() == "")
            {
                txtTellErr.Text = "Ne peut etre vide";
                telV = false;
            }
            else
            {
                txtTellErr.Text = "";
                telV = true;
            }

            if (NomV && telV && emailV && verifType)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }

        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNom.Text.Trim() == "")
            {
                txtNomErr.Text = "Ne peut etre vide";
                NomV = false;
            }
            else
            {
                txtNomErr.Text = "";
                NomV = true;
            }

            if (NomV && telV && emailV && verifType)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
                
        }
    }
}
