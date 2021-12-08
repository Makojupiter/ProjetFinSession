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
    public sealed partial class PageConnexion : Page
    {

        //MainPage objclass1 = new MainPage();
        public PageConnexion()
        {
            this.InitializeComponent();
            
        }
        
        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            
            if(GestionBD.getInstance().login(txtUserName.Text,pwdPassword.Password) == 1)
            {
                Frame.Navigate(typeof(MainPage));
            }
            else
            {
                Frame.Navigate(typeof(PageConnexion));
            }
        }
    }
}
