#pragma checksum "C:\Users\Utilisateur\Source\Repos\ProjetFinSession\ProjetFinal\ProjetFinal\AjouterMateriel.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66DCD8D25D3D43177ABAE325BB9ACAF14B6A5FC4167697AA3691318371D76C79"
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
    partial class AjouterMateriel : 
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
            case 1: // AjouterMateriel.xaml line 1
                {
                    global::Windows.UI.Xaml.Controls.ContentDialog element1 = (global::Windows.UI.Xaml.Controls.ContentDialog)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentDialog)element1).PrimaryButtonClick += this.ContentDialog_PrimaryButtonClick;
                }
                break;
            case 2: // AjouterMateriel.xaml line 21
                {
                    this.txtIDMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtIDMateriel).TextChanged += this.txtIDMateriel_TextChanged;
                }
                break;
            case 3: // AjouterMateriel.xaml line 22
                {
                    this.txtIDMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // AjouterMateriel.xaml line 23
                {
                    this.txtMarqueMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtMarqueMateriel).TextChanged += this.txtMarqueMateriel_TextChanged;
                }
                break;
            case 5: // AjouterMateriel.xaml line 24
                {
                    this.txtMarqueMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // AjouterMateriel.xaml line 25
                {
                    this.txtModelMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtModelMateriel).TextChanged += this.txtModelMateriel_TextChanged;
                }
                break;
            case 7: // AjouterMateriel.xaml line 26
                {
                    this.txtModelMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // AjouterMateriel.xaml line 27
                {
                    this.cbEtat = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.cbEtat).SelectionChanged += this.cbEtat_SelectionChanged;
                }
                break;
            case 9: // AjouterMateriel.xaml line 32
                {
                    this.txtEtatMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // AjouterMateriel.xaml line 33
                {
                    this.txtNoteMateriel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtNoteMateriel).TextChanged += this.txtNoteMateriel_TextChanged;
                }
                break;
            case 11: // AjouterMateriel.xaml line 34
                {
                    this.txtNoteMaterielErr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

