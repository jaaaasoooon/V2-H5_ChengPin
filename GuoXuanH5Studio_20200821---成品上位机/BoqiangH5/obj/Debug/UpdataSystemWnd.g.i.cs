﻿#pragma checksum "..\..\UpdataSystemWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "442355CFD4C4C7530268DC1A9C74ADF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Windows.Themes;
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


namespace GuoXuanH5 {
    
    
    /// <summary>
    /// UpdataSystemWnd
    /// </summary>
    public partial class UpdataSystemWnd : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbTargetAddress;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbFileName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLoadFile;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar ProgressInfo;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateSys;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MultiFrame;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\UpdataSystemWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labUpdateProgress;
        
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
            System.Uri resourceLocater = new System.Uri("/GuoXuanH5;component/updatasystemwnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdataSystemWnd.xaml"
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
            
            #line 5 "..\..\UpdataSystemWnd.xaml"
            ((GuoXuanH5.UpdataSystemWnd)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tbTargetAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbFileName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnLoadFile = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\UpdataSystemWnd.xaml"
            this.btnLoadFile.Click += new System.Windows.RoutedEventHandler(this.btnLoadFile_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ProgressInfo = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 6:
            this.btnUpdateSys = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\UpdataSystemWnd.xaml"
            this.btnUpdateSys.Click += new System.Windows.RoutedEventHandler(this.btnUpdateSys_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MultiFrame = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\UpdataSystemWnd.xaml"
            this.MultiFrame.Click += new System.Windows.RoutedEventHandler(this.MultiFrame_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labUpdateProgress = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

