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
    public sealed partial class ModifierClient : ContentDialog
    {
        Client c;
        public ModifierClient()
        {
            this.InitializeComponent();

            c = GestionBD.getInstance().getListClient()[VisualiserClient.index];

            tbNom.Text = c.Nom;
            tbEmail.Text = c.Email;
            tbNumTel.Text = c.NumTel;
            tbPoste.Text = c.Poste;
            tbNumBureau.Text = c.NumBureau;
            tbType.Text = c.Type;

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (tbNom.Text.Trim().Equals(""))
            {
                tbErrorNom.Text = "Veuillez entrer un nom!";
                args.Cancel = true;
            }
            if (tbEmail.Text.Trim().Equals(""))
            {
                tbErrorEmail.Text = "Veuillez entrer un email!";
                args.Cancel = true;
            }
            if (tbNumTel.Text.Trim().Equals(""))
            {
                tbErrorNumTel.Text = "Veuillez indiquer un numéro de téléphone!";
                args.Cancel = true;
            }
            if (tbPoste.Text.Trim().Equals(""))
            {
                tbErrorPoste.Text = "Veuillez entrer un poste!";
                args.Cancel = true;
            }
            if (tbNumBureau.Text.Trim().Equals(""))
            {
                tbErrorNumBureau.Text = "Veuillez entrer un poste!";
                args.Cancel = true;
            }
            if (tbType.Text.Trim().Equals(""))
            {
                tbErrorType.Text = "Veuillez entrer un type!";
                args.Cancel = true;
            }
            else
            {
                c.Nom = tbNom.Text;
                c.Email = tbEmail.Text;
                c.NumTel = tbNumTel.Text;
                c.Poste = tbPoste.Text;
                c.NumBureau = tbNumBureau.Text;
                c.Type = tbType.Text;

                GestionBD.getInstance().modifierClient(c);
            }
        }
    }
}
