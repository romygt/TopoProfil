﻿#pragma checksum "..\..\Profil2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99D99274BD8471783ED283CC140D5D7A2334EF030CBF0CC696B5B8B9480D153E"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using new_interface;


namespace new_interface {
    
    
    /// <summary>
    /// Profil2
    /// </summary>
    public partial class Profil2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMain;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image src;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scvGraph;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas canGraph;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FulltileLayout;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mod;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zoom;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\Profil2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
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
            System.Uri resourceLocater = new System.Uri("/new_interface;component/profil2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Profil2.xaml"
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
            
            #line 9 "..\..\Profil2.xaml"
            ((new_interface.Profil2)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\Profil2.xaml"
            ((new_interface.Profil2)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.src = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.scvGraph = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.canGraph = ((System.Windows.Controls.Canvas)(target));
            
            #line 29 "..\..\Profil2.xaml"
            this.canGraph.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MouseDownClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FulltileLayout = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\Profil2.xaml"
            this.FulltileLayout.Click += new System.Windows.RoutedEventHandler(this.ButtonImprimer_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.mod = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Profil2.xaml"
            this.mod.Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            this.zoom = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\Profil2.xaml"
            this.zoom.Click += new System.Windows.RoutedEventHandler(this.zoomer);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 48 "..\..\Profil2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimise_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 52 "..\..\Profil2.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMaximise_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\Profil2.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

