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
    public sealed partial class AjouterMateriel : ContentDialog
    {
        public AjouterMateriel()
        {
            this.InitializeComponent();
            IsPrimaryButtonEnabled = false;
            txtIDMateriel.MaxLength = 7;
            verifID = verifMarque = verifNote = verifModel = verifEtat = false;
        }

        bool verifID, verifMarque, verifNote, verifModel, verifEtat;
        string etat;

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
                IsPrimaryButtonEnabled = true;
            }
            else
                IsPrimaryButtonEnabled = false;
        }

        private void cbEtat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cbEtat.SelectedIndex != -1)
            {
                etat = e.AddedItems[0].ToString();
                verifEtat = true;
                txtEtatMaterielErr.Text = "";
            }

            if (cbEtat.SelectedIndex == -1)
            {
                verifEtat = false;
                txtEtatMaterielErr.Text = "Veillez choisir un etat dans la liste.";
            }

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                IsPrimaryButtonEnabled = true;
            }
            else
                IsPrimaryButtonEnabled = false;

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
                IsPrimaryButtonEnabled = true;
            }
            else
                IsPrimaryButtonEnabled = false;

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

            if (verifID && verifMarque && verifNote && verifModel && verifEtat)
            {
                IsPrimaryButtonEnabled = true;
            }
            else
                IsPrimaryButtonEnabled = false;

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
                IsPrimaryButtonEnabled = true;
            }
            else
                IsPrimaryButtonEnabled = false;

        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Materiel c;

            string strId = txtIDMateriel.Text;
            string strMarque = txtMarqueMateriel.Text;
            string strModel = txtModelMateriel.Text;
            string strEtat = cbEtat.SelectedItem.ToString();
            string strNote = txtNoteMateriel.Text;

            c = new Materiel(strId, strMarque, strModel, strEtat, strNote);

            GestionBD.getInstance().AjouterMateriel(c);
        }

    }
}
