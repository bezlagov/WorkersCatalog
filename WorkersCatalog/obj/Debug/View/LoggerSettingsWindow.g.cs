﻿#pragma checksum "..\..\..\View\LoggerSettingsWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8AFF8251F1D2F7A463A7EA7ADF5916B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WorkersCatalog.View {
    
    
    /// <summary>
    /// LoggerSettingsWindow
    /// </summary>
    public partial class LoggerSettingsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkTrace;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkDebug;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkWarning;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkError;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkFatal;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkAll;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkToText;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkToDatabase;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkToBinary;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkToAll;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\LoggerSettingsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
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
            System.Uri resourceLocater = new System.Uri("/WorkersCatalog;component/view/loggersettingswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\LoggerSettingsWindow.xaml"
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
            this.chkTrace = ((System.Windows.Controls.CheckBox)(target));
            
            #line 9 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkTrace.Unchecked += new System.Windows.RoutedEventHandler(this.OnUncheckTypeOfLogging);
            
            #line default
            #line hidden
            return;
            case 2:
            this.chkDebug = ((System.Windows.Controls.CheckBox)(target));
            
            #line 10 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkDebug.Unchecked += new System.Windows.RoutedEventHandler(this.OnUncheckTypeOfLogging);
            
            #line default
            #line hidden
            return;
            case 3:
            this.chkWarning = ((System.Windows.Controls.CheckBox)(target));
            
            #line 13 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkWarning.Unchecked += new System.Windows.RoutedEventHandler(this.OnUncheckTypeOfLogging);
            
            #line default
            #line hidden
            return;
            case 4:
            this.chkError = ((System.Windows.Controls.CheckBox)(target));
            
            #line 14 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkError.Unchecked += new System.Windows.RoutedEventHandler(this.OnUncheckTypeOfLogging);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkFatal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 17 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkFatal.Unchecked += new System.Windows.RoutedEventHandler(this.OnUncheckTypeOfLogging);
            
            #line default
            #line hidden
            return;
            case 6:
            this.chkAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 18 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkAll.Checked += new System.Windows.RoutedEventHandler(this.OnAllChackedClick);
            
            #line default
            #line hidden
            
            #line 18 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkAll.Unchecked += new System.Windows.RoutedEventHandler(this.OnAllUncheckedClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.chkToText = ((System.Windows.Controls.CheckBox)(target));
            
            #line 23 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkToText.Unchecked += new System.Windows.RoutedEventHandler(this.chkToText_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.chkToDatabase = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            this.chkToBinary = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.chkToAll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 26 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkToAll.Checked += new System.Windows.RoutedEventHandler(this.OnLoggingToAllClick);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.chkToAll.Unchecked += new System.Windows.RoutedEventHandler(this.OnUnloggingToAllClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.OnStartLogging);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\LoggerSettingsWindow.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.OnStopLiggingClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 32 "..\..\..\View\LoggerSettingsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnCancelClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
