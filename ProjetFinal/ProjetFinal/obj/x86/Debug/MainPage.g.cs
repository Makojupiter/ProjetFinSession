﻿#pragma checksum "C:\Users\Utilisateur\Source\Repos\ProjetFinSession\ProjetFinal\ProjetFinal\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C39B64FEEB5C36967D3E12C6BAA5F1BEB36B0EDDFD0F7F02EDF6C9150EB83A0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetFinal
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 13
                {
                    this.nvMenue = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvMenue).SelectionChanged += this.nvMenue_SelectionChanged;
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.Accueil = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // MainPage.xaml line 20
                {
                    this.AddMateriel = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 21
                {
                    this.AddUser = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 22
                {
                    this.AddPret = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 23
                {
                    this.AddClient = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 26
                {
                    this.ViewMateriel = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 9: // MainPage.xaml line 27
                {
                    this.ViewUsers = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 10: // MainPage.xaml line 28
                {
                    this.ViewPrets = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 11: // MainPage.xaml line 29
                {
                    this.ViewClients = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 12: // MainPage.xaml line 37
                {
                    this.connexion = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 13: // MainPage.xaml line 40
                {
                    this.mainFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

