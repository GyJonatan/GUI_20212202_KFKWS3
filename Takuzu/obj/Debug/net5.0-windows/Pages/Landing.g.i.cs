﻿#pragma checksum "..\..\..\..\Pages\Landing.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "931B9B09E45D044D74C2D9422D64AF95AA4DE462"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Halcyon.TakuzuGame.Logic;
using Halcyon.TakuzuGame.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Halcyon.TakuzuGame.Pages {
    
    
    /// <summary>
    /// Landing
    /// </summary>
    public partial class Landing : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Four;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Six;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Eight;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Ten;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Twelve;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Pages\Landing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Halcyon.TakuzuGame.Logic.NavigationButton Back;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TakuzuGame;V1.0.0.0;component/pages/landing.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Landing.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 25 "..\..\..\..\Pages\Landing.xaml"
            ((System.Windows.Controls.Grid)(target)).AddHandler(System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new System.Windows.RoutedEventHandler(this.Grid_Click));
            
            #line default
            #line hidden
            return;
            case 2:
            this.Four = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            case 3:
            this.Six = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            case 4:
            this.Eight = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            case 5:
            this.Ten = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            case 6:
            this.Twelve = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            case 7:
            this.Back = ((Halcyon.TakuzuGame.Logic.NavigationButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

