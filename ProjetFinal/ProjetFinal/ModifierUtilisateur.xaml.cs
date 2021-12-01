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
    public sealed partial class ModifierUtilisateur : ContentDialog
    {
        Utilisateur c;
        public ModifierUtilisateur()
        {
            this.InitializeComponent();

            c = GestionBD.getInstance().getListUtilisateur()[VisualiserUtilisateur.index];

            tbUsername.Text = c.Username;
            tbPrenom.Text = c.Prenom;
            tbNom.Text = c.Nom;
            tbPassword.Text = c.Password;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if (tbUsername.Text.Trim().Equals(""))
            {
                tbErrorUsername.Text = "Veuillez entrer un titre!";
                args.Cancel = true;
            }
            if (tbPrenom.Text.Trim().Equals(""))
            {
                tbErrorPrenom.Text = "Veuillez indiquer un réalisateur!";
                args.Cancel = true;
            }
            if (tbNom.Text.Trim().Equals(""))
            {
                tbErrorNom.Text = "Veuillez indiquer un genre!";
                args.Cancel = true;
            }
            if (tbPassword.Text.Trim().Equals(""))
            {
                tbErrorPassword.Text = "Veuillez entrer l'url de l'affiche!";
                args.Cancel = true;
            }
            else
            {
                c.Username = tbUsername.Text;
                c.Prenom = tbPrenom.Text;
                c.Nom = tbNom.Text;
                c.Password = tbPassword.Text;

                GestionBD.getInstance().modifierUtilisateur(c);
            }
        }

    }
}
