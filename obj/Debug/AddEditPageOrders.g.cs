﻿#pragma checksum "..\..\AddEditPageOrders.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "271B8F0147DBE03B23BB2AC744A21F0A6164C94AAD243FF6AFECB8D7CA5A4201"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using КурсС4;


namespace КурсС4 {
    
    
    /// <summary>
    /// AddEditPageOrders
    /// </summary>
    public partial class AddEditPageOrders : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboType;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboClient1;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox duration;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numberofdays;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox number;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BDcost;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker startdate;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboManager;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\AddEditPageOrders.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/КурсС4;component/addeditpageorders.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEditPageOrders.xaml"
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
            
            #line 10 "..\..\AddEditPageOrders.xaml"
            ((КурсС4.AddEditPageOrders)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboClient1 = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.duration = ((System.Windows.Controls.ComboBox)(target));
            
            #line 46 "..\..\AddEditPageOrders.xaml"
            this.duration.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.duration_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.numberofdays = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\AddEditPageOrders.xaml"
            this.numberofdays.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.numberofdays_TextChanged);
            
            #line default
            #line hidden
            
            #line 56 "..\..\AddEditPageOrders.xaml"
            this.numberofdays.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numberofdays_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.number = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\AddEditPageOrders.xaml"
            this.number.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.number_PreviewTextInput);
            
            #line default
            #line hidden
            
            #line 57 "..\..\AddEditPageOrders.xaml"
            this.number.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.number_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BDcost = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.startdate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 10:
            this.ComboManager = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\AddEditPageOrders.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

