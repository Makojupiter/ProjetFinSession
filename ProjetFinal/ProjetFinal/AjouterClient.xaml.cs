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

// Pour plus d'informations sur le modèle d'élément Boîte de dialogue de contenu, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProjetFinal
{
    public sealed partial class AjouterClient : ContentDialog
    {
        public AjouterClient()
        {
            this.InitializeComponent();
            IsPrimaryButtonEnabled = false;
            NomV = telV = emailV = verifType = false;
        }

        bool NomV, telV, emailV, valideMail, valideMail2, verifType;
        string type;

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
                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
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
            else if (!valideMail || !valideMail2)
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
                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
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
                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
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
                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
            }

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Client c;

            string strType = cbType.SelectedItem.ToString();
            string strNom = txtNom.Text;
            string strNumTel = txtTel.Text;
            string strPoste = txtPoste.Text;
            string strEmail = txtEmail.Text;
            string strBureau = txtBureau.Text;

            c = new Client(strNom, strEmail, strNumTel, strPoste, strBureau, strType);

            GestionBD.getInstance().AjouterClient(c);
        }

    }
}
