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
        
        public ModifierUtilisateur()
        {
            this.InitializeComponent();
            
            c = GestionBD.getInstance().getListUtilisateur()[VisualiserUtilisateur.index];

            txtUsername.Text = c.Username;
            tbPrenom.Text = c.Prenom;
            tbNom.Text = c.Nom;
            tbPassword.Text = c.Password;
            vPrenom = vNom = vPassword = true;
        }
        Utilisateur c;
        bool vPrenom, vNom, vPassword;

        private void tbPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPrenom.Text.Trim().Equals(""))
            {
                tbErrorPrenom.Text = "Ne peut etre vide";
                vPrenom = false;
            }
            else
            {
                tbErrorPrenom.Text = "";
                c.Prenom = tbPrenom.Text;
                vPrenom = true;
            }

            validation();
        }

        private void tbNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNom.Text.Trim().Equals(""))
            {
                tbErrorNom.Text = "Ne peut etre vide";
                
                vNom = false;
            }
            else
            {
                tbErrorNom.Text = "";
                c.Nom = tbNom.Text;
                vNom = true;
            }

            validation();
        }

        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPassword.Text.Trim().Equals(""))
            {
                tbErrorPassword.Text = "Ne peut etre vide";
                vPassword = false;
            }
            else
            {
                tbErrorPassword.Text = "";
                c.Password = tbPassword.Text;
                vPassword = true;
            }

            validation();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            GestionBD.getInstance().modifierUtilisateur(c);

        }

        private void validation()
        {
            if(vPrenom && vNom && vPassword)
            {
                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
            }
        }
    }
}
