﻿#pragma checksum "C:\Users\Utilisateur\source\repos\ProjetFinSession\ProjetFinal\ProjetFinal\AjoutMateriel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "547A1E08ABA8ACFE28D924BC657202C82B9EE9D771A30343FA47F7D578BAC7E9"
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
    partial class AjoutMateriel : 
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
            case 2: // AjoutMateriel.xaml line 19
                {
                    this.txtIDMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtIDMateriel).TextChanged += this.txtIDMateriel_TextChanged;
                }
                break;
            case 3: // AjoutMateriel.xaml line 21
                {
                    this.txtIDMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // AjoutMateriel.xaml line 24
                {
                    this.txtMarqueMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtMarqueMateriel).TextChanged += this.txtMarqueMateriel_TextChanged;
                }
                break;
            case 5: // AjoutMateriel.xaml line 26
                {
                    this.txtMarqueMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // AjoutMateriel.xaml line 29
                {
                    this.txtModelMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtModelMateriel).TextChanged += this.txtModelMateriel_TextChanged;
                }
                break;
            case 7: // AjoutMateriel.xaml line 31
                {
                    this.txtModelMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // AjoutMateriel.xaml line 34
                {
                    this.cbEtat = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9: // AjoutMateriel.xaml line 49
                {
                    this.txtNoteMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtNoteMateriel).TextChanged += this.txtNoteMateriel_TextChanged;
                }
                break;
            case 10: // AjoutMateriel.xaml line 54
                {
                    this.txtNoteMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // AjoutMateriel.xaml line 57
                {
                    this.btnAddMateriel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAddMateriel).Click += this.btnAddMateriel_Click;
                }
                break;
            case 12: // AjoutMateriel.xaml line 39
                {
                    this.EDisponible = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 13: // AjoutMateriel.xaml line 41
                {
                    this.ELocation = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 14: // AjoutMateriel.xaml line 43
                {
                    this.EDefect = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
                }
                break;
            case 15: // AjoutMateriel.xaml line 45
                {
                    this.ERepair = (global::Windows.UI.Xaml.Controls.ComboBoxItem)(target);
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

