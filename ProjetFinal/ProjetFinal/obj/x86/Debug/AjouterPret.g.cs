﻿#pragma checksum "C:\Users\Utilisateur\Source\Repos\ProjetFinSession\ProjetFinal\ProjetFinal\AjouterPret.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B175DBD618E6144B14455DD3E234289B570A7D67D910646D812BA5AABC02666"
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
    partial class AjouterPret : 
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
            case 2: // AjouterPret.xaml line 90
                {
                    this.btnAddPret = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddPret).Click += this.btnAddPret_Click;
                }
                break;
            case 3: // AjouterPret.xaml line 105
                {
                    this.grille = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                    ((global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)this.grille).SelectionChanged += this.grille_SelectionChanged;
                }
                break;
            case 4: // AjouterPret.xaml line 80
                {
                    this.btnSupprimer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnSupprimer).Click += this.btnSupprimer_Click;
                }
                break;
            case 5: // AjouterPret.xaml line 67
                {
                    this.boxMateriel = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.boxMateriel).TextChanged += this.boxMateriel_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.boxMateriel).SuggestionChosen += this.boxMateriel_SuggestionChosen;
                }
                break;
            case 6: // AjouterPret.xaml line 58
                {
                    this.btnValider = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnValider).Click += this.btnValider_Click;
                }
                break;
            case 7: // AjouterPret.xaml line 38
                {
                    this.boxUser = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.boxUser).TextChanged += this.boxUser_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.boxUser).SuggestionChosen += this.boxUser_SuggestionChosen;
                }
                break;
            case 8: // AjouterPret.xaml line 42
                {
                    this.nbrDuree = (global::Microsoft.UI.Xaml.Controls.NumberBox)(target);
                }
                break;
            case 9: // AjouterPret.xaml line 53
                {
                    this.toggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.toggleSwitch).Toggled += this.toggleSwitch_Toggled;
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

