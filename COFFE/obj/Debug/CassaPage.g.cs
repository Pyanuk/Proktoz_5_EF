﻿#pragma checksum "..\..\CassaPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA2FACBCCF928DE976A114D6E4F8533187CF20E2FEF18F7A271C8489CABDCCEF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using COFFE;
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


namespace COFFE {
    
    
    /// <summary>
    /// CassaPage
    /// </summary>
    public partial class CassaPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid CoffeDatagrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ProductsDatagrid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox CartListBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Check;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PaidAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CheckComboBox;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalAmountTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\CassaPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ReceiptContentTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/COFFE;component/cassapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CassaPage.xaml"
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
            this.CoffeDatagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 11 "..\..\CassaPage.xaml"
            this.CoffeDatagrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CoffeDatagrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ProductsDatagrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\CassaPage.xaml"
            this.ProductsDatagrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ProductsDatagrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CartListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            case 4:
            
            #line 26 "..\..\CassaPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Check = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\CassaPage.xaml"
            this.Check.Click += new System.Windows.RoutedEventHandler(this.Check_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PaidAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.CheckComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\CassaPage.xaml"
            this.CheckComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CheckComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TotalAmountTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.ReceiptContentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

