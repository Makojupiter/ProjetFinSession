﻿#pragma checksum "C:\Users\makoj\source\repos\ProjetFinSession\ProjetFinal\ProjetFinal\ModifierUtilisateur.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0AB1FFBB5875294392C5E4A9B42BBF512435FA6931830D3C1A921B2E1757F0A2"
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
    partial class ModifierUtilisateur : 
        global::Windows.UI.Xaml.Controls.ContentDialog, 
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
            case 1: // ModifierUtilisateur.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                }
                break;
            case 2: // ModifierUtilisateur.xaml line 21
                {
                    this.tbUsername = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // ModifierUtilisateur.xaml line 22
                {
                    this.tbErrorUsername = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // ModifierUtilisateur.xaml line 23
                {
                    this.tbPrenom = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // ModifierUtilisateur.xaml line 24
                {
                    this.tbErrorPrenom = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // ModifierUtilisateur.xaml line 25
                {
                    this.tbNom = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // ModifierUtilisateur.xaml line 26
                {
                    this.tbErrorNom = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // ModifierUtilisateur.xaml line 27
                {
                    this.tbPassword = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // ModifierUtilisateur.xaml line 28
                {
                    this.tbErrorPassword = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

