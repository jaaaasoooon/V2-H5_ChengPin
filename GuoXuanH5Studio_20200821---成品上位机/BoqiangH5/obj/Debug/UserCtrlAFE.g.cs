﻿#pragma checksum "..\..\UserCtrlAFE.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F305A604C1446FB8A941B9A939B8AC2271DB96FDD8CA41921F315494003E148"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using BoqiangH5;
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


namespace BoqiangH5 {
    
    
    /// <summary>
    /// UserCtrlAFE
    /// </summary>
    public partial class UserCtrlAFE : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReadEepromInfo;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEepromInfo;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReadOthersInfo;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOthersInfo;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReadAdjustParam;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\UserCtrlAFE.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgAdjustParam;
        
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
            System.Uri resourceLocater = new System.Uri("/BoqiangH5;component/userctrlafe.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserCtrlAFE.xaml"
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
            
            #line 8 "..\..\UserCtrlAFE.xaml"
            ((BoqiangH5.UserCtrlAFE)(target)).Loaded += new System.Windows.RoutedEventHandler(this.UserControl_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnReadEepromInfo = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\UserCtrlAFE.xaml"
            this.btnReadEepromInfo.Click += new System.Windows.RoutedEventHandler(this.btnReadEepromInfo_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dgEepromInfo = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.btnReadOthersInfo = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\UserCtrlAFE.xaml"
            this.btnReadOthersInfo.Click += new System.Windows.RoutedEventHandler(this.btnReadOthersInfo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgOthersInfo = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.btnReadAdjustParam = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\UserCtrlAFE.xaml"
            this.btnReadAdjustParam.Click += new System.Windows.RoutedEventHandler(this.btnReadAdjustParam_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgAdjustParam = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

