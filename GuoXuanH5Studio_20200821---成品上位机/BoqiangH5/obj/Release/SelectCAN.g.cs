#pragma checksum "..\..\SelectCAN.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "705B2B649F7EDD829D12290F5A7CDCB9"
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
using DevExpress.Xpf.LayoutControl;
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


namespace UDSStudio {
    
    
    /// <summary>
    /// SelectCAN
    /// </summary>
    public partial class SelectCAN : DevExpress.Xpf.Core.DXWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid selectGrid;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCanType;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCanIndex;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCanChannel;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.TextEdit teTimer0;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal DevExpress.Xpf.Editors.TextEdit teTimer1;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\SelectCAN.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbBaudRate;
        
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
            System.Uri resourceLocater = new System.Uri("/UDSStudio;component/selectcan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectCAN.xaml"
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
            this.selectGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.cbCanType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\SelectCAN.xaml"
            this.cbCanType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCanType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbCanIndex = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbCanChannel = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.teTimer0 = ((DevExpress.Xpf.Editors.TextEdit)(target));
            return;
            case 6:
            this.teTimer1 = ((DevExpress.Xpf.Editors.TextEdit)(target));
            return;
            case 7:
            this.cbBaudRate = ((System.Windows.Controls.ComboBox)(target));
            
            #line 100 "..\..\SelectCAN.xaml"
            this.cbBaudRate.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbBaudRate_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 138 "..\..\SelectCAN.xaml"
            ((DevExpress.Xpf.Core.SimpleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.OK_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 140 "..\..\SelectCAN.xaml"
            ((DevExpress.Xpf.Core.SimpleButton)(target)).Click += new System.Windows.RoutedEventHandler(this.Canel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

