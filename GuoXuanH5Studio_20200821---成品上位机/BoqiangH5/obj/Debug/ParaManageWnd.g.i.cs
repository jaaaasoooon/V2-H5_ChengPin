﻿#pragma checksum "..\..\ParaManageWnd.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8362574A83918B7B7EAC58BFA96ED4FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Core;
using DevExpress.Xpf.Bars;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Core.ConditionalFormatting;
using DevExpress.Xpf.Core.DataSources;
using DevExpress.Xpf.Core.Serialization;
using DevExpress.Xpf.Core.ServerMode;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.Editors.DataPager;
using DevExpress.Xpf.Editors.DateNavigator;
using DevExpress.Xpf.Editors.ExpressionEditor;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Editors.Flyout;
using DevExpress.Xpf.Editors.Popups;
using DevExpress.Xpf.Editors.Popups.Calendar;
using DevExpress.Xpf.Editors.RangeControl;
using DevExpress.Xpf.Editors.Settings;
using DevExpress.Xpf.Editors.Settings.Extension;
using DevExpress.Xpf.Editors.Validation;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Grid.ConditionalFormatting;
using DevExpress.Xpf.Grid.LookUp;
using DevExpress.Xpf.Grid.TreeList;
using DevExpress.Xpf.LayoutControl;
using GuoXuanH5;
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
    /// ParaManageWnd
    /// </summary>
    public partial class ParaManageWnd : DevExpress.Xpf.Core.DXWindow, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 31 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridMasterPara;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListBoxMasterSwitch;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnLoadMasterPara;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMasterParaSaveAs;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnGetAllMasterPara;
        
        #line default
        #line hidden
        
        
        #line 113 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSetAllMasterPara;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\ParaManageWnd.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnMasterParaCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/GuoXuanH5;component/paramanagewnd.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ParaManageWnd.xaml"
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
            
            #line 11 "..\..\ParaManageWnd.xaml"
            ((GuoXuanH5.ParaManageWnd)(target)).Loaded += new System.Windows.RoutedEventHandler(this.DXWindow_Loaded);
            
            #line default
            #line hidden
            
            #line 11 "..\..\ParaManageWnd.xaml"
            ((GuoXuanH5.ParaManageWnd)(target)).Closed += new System.EventHandler(this.DXWindow_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.DataGridMasterPara = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.ListBoxMasterSwitch = ((System.Windows.Controls.ListBox)(target));
            return;
            case 8:
            this.BtnLoadMasterPara = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\ParaManageWnd.xaml"
            this.BtnLoadMasterPara.Click += new System.Windows.RoutedEventHandler(this.BtnLoadMasterPara_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnMasterParaSaveAs = ((System.Windows.Controls.Button)(target));
            
            #line 110 "..\..\ParaManageWnd.xaml"
            this.BtnMasterParaSaveAs.Click += new System.Windows.RoutedEventHandler(this.BtnMasterParaSaveAs_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnGetAllMasterPara = ((System.Windows.Controls.Button)(target));
            
            #line 111 "..\..\ParaManageWnd.xaml"
            this.BtnGetAllMasterPara.Click += new System.Windows.RoutedEventHandler(this.BtnGetAllMasterPara_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.BtnSetAllMasterPara = ((System.Windows.Controls.Button)(target));
            
            #line 113 "..\..\ParaManageWnd.xaml"
            this.BtnSetAllMasterPara.Click += new System.Windows.RoutedEventHandler(this.BtnSetAllMasterPara_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.BtnMasterParaCancel = ((System.Windows.Controls.Button)(target));
            
            #line 114 "..\..\ParaManageWnd.xaml"
            this.BtnMasterParaCancel.Click += new System.Windows.RoutedEventHandler(this.BtnMasterParaCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 54 "..\..\ParaManageWnd.xaml"
            ((System.Windows.Controls.TextBox)(target)).LostFocus += new System.Windows.RoutedEventHandler(this.tbMasterPara_LostFocus);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 62 "..\..\ParaManageWnd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnGetMasterPara_Click);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 69 "..\..\ParaManageWnd.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnSetMasterPara_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

