using System;
using System.Collections.Generic;
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
            //tbErrorEmail.Text = Convert.ToString( c.Id) ;
            if(c.Type == "Étudiant")
            {
                cbType.SelectedIndex = 0;
            }
            if (c.Type == "Professeur")
            {
                cbType.SelectedIndex = 1;
            }
            if (c.Type == "Employé du CÉGEP")
            {
                cbType.SelectedIndex = 2;
            }

            IsPrimaryButtonEnabled = false;
            NomV = telV = emailV = verifType = vtype = vposte =  numBureauV = true;

        }

        bool NomV, telV, emailV, verifType, vtype, numBureauV, vposte;

        private void tbNumBureau_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNumBureau.Text.Trim().Equals(""))
            {
                tbErrorNumBureau.Text = "Ne peut etre vide";
                numBureauV = false;
            }

            else
            {
                tbErrorNumBureau.Text = "";
                numBureauV = true;
                c.NumBureau = tbNumBureau.Text;
            }
        }

        private void tbPoste_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbPoste.Text.Trim().Equals(""))
            {
                tbErrorPoste.Text = "Ne peut etre vide";
                vposte = false;
            }

            else
            {
                tbErrorPoste.Text = "";
                vposte = true;
                c.Poste = tbPoste.Text;
            }
        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            c.Type = e.AddedItems[0].ToString(); 

        }

        private void tbNumTel_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (tbNumTel.Text.Trim() == "")
            {
                tbErrorNumTel.Text = "Ne peut etre vide";
                telV = false;
            }
            else if (tbNumTel.Text.Length == 14)
            {
                emailV = true;
                tbErrorNumTel.Text = "";
                c.NumTel = tbNumTel.Text;
            }
            else
            {
                tbErrorNumTel.Text = "Format non valide";
                telV = false;
            }

            validation();
        }

        private void tbEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            string expression = "(@[e]?[d]?[u]?\\.?cegeptr\\.qc\\.ca)$";


            if (tbEmail.Text.Trim() == "")
            {
                tbErrorEmail.Text = "Ne peut etre vide";
                emailV = false;
            }
            else if (Regex.IsMatch(tbEmail.Text, expression))
            {
                emailV = true;
                tbErrorEmail.Text = "";
                c.Email = tbEmail.Text;
            }
            else
            {
                tbErrorEmail.Text = "Format non valide";
                emailV = false;
            }

            validation();
        }

        private void tbNom_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNom.Text.Trim().Equals(""))
            {
                tbErrorNom.Text = "Ne peut etre vide";
                NomV = false;
                c.Nom = c.Nom;

            }
            else
            {
                tbErrorNom.Text = "";
                NomV = true;
            }

            validation();

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {

            GestionBD.getInstance().modifierClient(c);

        }

        public void validation()
        {
            if(NomV && telV && emailV && verifType && vtype && numBureauV)
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
