﻿#pragma checksum "..\..\Zaposljavanje.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3D3670F70D2598624A21EEE2469B6451248F693E7C2CE91EBF078FE5BB99BDD8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BasicUI;
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


namespace BasicUI {
    
    
    /// <summary>
    /// Zaposljavanje
    /// </summary>
    public partial class Zaposljavanje : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxIme;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxPrezime;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextboxKontakt;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboboxOdjel;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboboxZanimanja;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\Zaposljavanje.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GumbSpremi;
        
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
            System.Uri resourceLocater = new System.Uri("/BasicUI;component/zaposljavanje.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Zaposljavanje.xaml"
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
            this.TextboxIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TextboxPrezime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextboxKontakt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComboboxOdjel = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ComboboxZanimanja = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.GumbSpremi = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\Zaposljavanje.xaml"
            this.GumbSpremi.Click += new System.Windows.RoutedEventHandler(this.GumbSpremi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

