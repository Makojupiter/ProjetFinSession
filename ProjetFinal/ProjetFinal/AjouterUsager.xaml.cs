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
    public sealed partial class AjouterUsager : Page
    {
        public AjouterUsager()
        {
            this.InitializeComponent();
            btnAjouter.IsEnabled = false;
            usernameV = nomV = prenomV = passWordV = false;
            
        }

        bool usernameV, nomV, prenomV, passWordV;

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
            }

            if (usernameV && nomV && prenomV && passWordV)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
        }

        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            //CODE ICI
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
            }

            if (usernameV && nomV && prenomV && passWordV)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
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
            }

            if (usernameV && nomV && prenomV && passWordV)
            {
                btnAjouter.IsEnabled = true;
            }
            else
            {
                btnAjouter.IsEnabled = false;
            }
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtUserName.Text.Trim() == "")
            {
                txtUserNameErr.Text = "Ne peut etre vide";
                usernameV = false;
            }
            else
            {
                txtUserNameErr.Text = "";
                usernameV = true;
            }

            if(usernameV && nomV && prenomV && passWordV)
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
