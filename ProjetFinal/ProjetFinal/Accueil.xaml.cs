﻿using System;
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
    public sealed partial class Accueil : Page
    {
        public Accueil()
        {
            this.InitializeComponent();

            MainPage objclass1 = new MainPage();

            if (GestionBD.getInstance().verifConnexion() == 0)
            {
                txtNomUsager.Text = "Bonjour " + "Stephane";
                objclass1.fonctionTEST("ALLO");
            }
            else
            {
                txtNomUsager.Text = "WTF";
                objclass1.fonctionTEST("TESTTEST");
            }

            dateHeure.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");

        }


    }
}
