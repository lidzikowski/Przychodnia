﻿#pragma checksum "..\..\DodajPacjenta.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CC966A6A97DC678A844EC4C40068569600C61F560C2D72642B4C0DCA62589742"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Przychodnia;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Przychodnia {
    
    
    /// <summary>
    /// DodajPacjenta
    /// </summary>
    public partial class DodajPacjenta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 54 "..\..\DodajPacjenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DodajChorobeContextMenu;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\DodajPacjenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem UsunChorobeContextMenu;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\DodajPacjenta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DodajButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/dodajpacjenta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DodajPacjenta.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DodajChorobeContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 55 "..\..\DodajPacjenta.xaml"
            this.DodajChorobeContextMenu.Click += new System.Windows.RoutedEventHandler(this.DodajChorobeContextMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsunChorobeContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 58 "..\..\DodajPacjenta.xaml"
            this.UsunChorobeContextMenu.Click += new System.Windows.RoutedEventHandler(this.UsunChorobeContextMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DodajButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\DodajPacjenta.xaml"
            this.DodajButton.Click += new System.Windows.RoutedEventHandler(this.DodajButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
