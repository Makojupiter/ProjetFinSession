﻿#pragma checksum "C:\Users\makoj\source\repos\ProjetFinSession\ProjetFinal\ProjetFinal\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87309D895D66BF4DBE3FFC9A9545F0E513C160A30AA411D4B6AB04004CB23DAA"
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
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.nvMenue).BackRequested += this.nvMenue_BackRequested;
                }
                break;
            case 3: // MainPage.xaml line 21
                {
                    this.Accueil = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // MainPage.xaml line 23
                {
                    this.ViewMateriel = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 24
                {
                    this.ViewUsers = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 25
                {
                    this.ViewPrets = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 26
                {
                    this.ViewClients = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 36
                {
                    this.Deconnexion = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationViewItem)this.Deconnexion).Tapped += this.Deconnexion_Tapped;
                }
                break;
            case 9: // MainPage.xaml line 39
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

