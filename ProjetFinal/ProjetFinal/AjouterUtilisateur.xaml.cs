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
    public sealed partial class AjouterUtilisateur : ContentDialog
    {
        public AjouterUtilisateur()
        {
            this.InitializeComponent();
            IsPrimaryButtonEnabled = false;
            usernameV = nomV = prenomV = passWordV = false;
        }

        bool usernameV, nomV, prenomV, passWordV;
        Utilisateur u;

        

        private void pwdPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwdPassword.Password.Trim() == "")
            {
                txtPasswordErr.Text = "Ne peut etre vide";
                passWordV = false;
            }
            else
            {
                txtPasswordErr.Text = "";
                passWordV = true;
                u.Password = pwdPassword.Password;
            }

            validation();

        }

        private void txtNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNom.Text.Trim() == "")
            {
                txtNomErr.Text = "Ne peut etre vide";
                nomV = false;
            }
            else
            {
                txtNomErr.Text = "";
                nomV = true;
                u.Nom = txtNom.Text;
            }

            validation();

        }

        private void txtPrenom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPrenom.Text.Trim() == "")
            {
                txtPrenomErr.Text = "Ne peut etre vide";
                prenomV = false;
            }
            else
            {
                txtPrenomErr.Text = "";
                prenomV = true;
                u.Prenom = txtPrenom.Text;
            }

            validation();

        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                txtUserNameErr.Text = "Ne peut etre vide";
                usernameV = false;
            }
            else
            {
                txtUserNameErr.Text = "";
                usernameV = true;
                u.Username = txtUserName.Text;
            }

            validation();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            GestionBD.getInstance().AjouterUtilisateur(u);
        }

        private void validation()
        {
            if (usernameV && nomV && prenomV && passWordV)
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
