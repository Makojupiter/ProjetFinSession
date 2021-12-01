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
        tbEtat.Text = c.Etat;
        tbNote.Text = c.Note;

    }

    private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
    {
        if (tbIdentifiant.Text.Trim().Equals(""))
        {
            tbErrorIdentifiant.Text = "Veuillez entrer un identifiant!";
            args.Cancel = true;
        }
        if (tbMarque.Text.Trim().Equals(""))
        {
            tbErrorMarque.Text = "Veuillez entrer une marque!";
            args.Cancel = true;
        }
        if (tbModel.Text.Trim().Equals(""))
        {
            tbErrorModel.Text = "Veuillez indiquer un modèle!";
            args.Cancel = true;
        }
        if (tbEtat.Text.Trim().Equals(""))
        {
            tbErrorEtat.Text = "Veuillez entrer un état!";
            args.Cancel = true;
        }
        if (tbNote.Text.Trim().Equals(""))
        {
            tbErrorNote.Text = "Veuillez entrer une note!";
            args.Cancel = true;
        }

        else
        {
            c.Identifiant = tbIdentifiant.Text;
            c.Marque = tbMarque.Text;
            c.Model = tbModel.Text;
            c.Etat = tbEtat.Text;
            c.Note = tbNote.Text;

            GestionBD.getInstance().modifierMateriel(c);
        }
    }
}
}
