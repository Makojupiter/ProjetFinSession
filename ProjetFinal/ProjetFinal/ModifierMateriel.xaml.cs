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
    public sealed partial class ModifierMateriel : ContentDialog
    {
        Materiel c;
        public ModifierMateriel()
        {
            this.InitializeComponent();

            c = GestionBD.getInstance().getListMateriel()[VisualiserMateriel.index];

            tbIdentifiant.Text = c.Identifiant;
            tbMarque.Text = c.Marque;
            tbModel.Text = c.Model;
            tbNote.Text = c.Note;

            if (c.Etat == "Disponible")
            {
                cbEtat.SelectedIndex = 0;
            }

            if (c.Etat == "En location")
            {
                cbEtat.SelectedIndex = 1;
            }

            if (c.Etat == "Défectueux")
            {
                cbEtat.SelectedIndex = 2;
            }

            if (c.Etat == "En Réparation")
            {
                cbEtat.SelectedIndex = 3;
            }

            vMarque = vModel = vNote = true;

        }

        bool vMarque, vModel, vNote;

        private void tbMarque_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbMarque.Text.Trim().Equals(""))
            {
                tbErrorMarque.Text = "Ne peut etre vide";
                vMarque = false;
            }
            else
            {
                tbErrorMarque.Text = "";
                c.Marque = tbMarque.Text;
                vMarque = true;
            }

            validation();
        }

        private void tbModel_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbModel.Text.Trim().Equals(""))
            {
                tbErrorModel.Text = "Ne peut etre vide";
                vModel = false;
            }
            else
            {
                tbErrorModel.Text = "";
                c.Model = tbModel.Text;
                vModel = true;
            }

            validation();
        }

        private void tbNote_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbNote.Text.Trim().Equals(""))
            {
                tbErrorNote.Text = "Ne peut etre vide";
                vNote = false;
            }
            else
            {
                tbErrorNote.Text = "";
                c.Note = tbNote.Text;
                vNote = true;
            }

            validation();
        }

        private void cbEtat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            c.Etat = e.AddedItems[0].ToString();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            GestionBD.getInstance().modifierMateriel(c);

        }

        private void validation()
        {
            if(vMarque && vModel && vNote)
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
