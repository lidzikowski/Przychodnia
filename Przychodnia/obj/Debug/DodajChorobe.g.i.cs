﻿#pragma checksum "..\..\DodajChorobe.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7F5845847E26BD4B9B57616BF3B7DE157099999EE7CB94F3D98A756C059D4C3"
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
    /// DodajChorobe
    /// </summary>
    public partial class DodajChorobe : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\DodajChorobe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem DodajLekContextMenu;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\DodajChorobe.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem UsunLekContextMenu;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\DodajChorobe.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Przychodnia;component/dodajchorobe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DodajChorobe.xaml"
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
            this.DodajLekContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 56 "..\..\DodajChorobe.xaml"
            this.DodajLekContextMenu.Click += new System.Windows.RoutedEventHandler(this.DodajLekContextMenu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UsunLekContextMenu = ((System.Windows.Controls.MenuItem)(target));
            
            #line 59 "..\..\DodajChorobe.xaml"
            this.UsunLekContextMenu.Click += new System.Windows.RoutedEventHandler(this.UsunLekContextMenu_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DodajButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\DodajChorobe.xaml"
            this.DodajButton.Click += new System.Windows.RoutedEventHandler(this.DodajButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
