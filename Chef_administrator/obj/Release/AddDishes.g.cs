﻿#pragma checksum "..\..\AddDishes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5CF933625C9E0DA445313628484D403657E297C16BFD6CB285F896A8362E7D73"
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


namespace Chef_administrator {
    
    
    /// <summary>
    /// AddDishes
    /// </summary>
    public partial class AddDishes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxWeight;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxCount;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeList3;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeList4;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeList5;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TypeList;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\AddDishes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid goodsGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/Chef_administrator;component/adddishes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddDishes.xaml"
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
            
            #line 7 "..\..\AddDishes.xaml"
            ((Chef_administrator.AddDishes)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.textBoxName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.textBoxWeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.textBoxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxCount = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\AddDishes.xaml"
            this.textBoxCount.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textBoxCount_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TypeList3 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\AddDishes.xaml"
            this.TypeList3.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeList_SelectionChanged1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TypeList4 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 28 "..\..\AddDishes.xaml"
            this.TypeList4.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeList_SelectionChanged2);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TypeList5 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 35 "..\..\AddDishes.xaml"
            this.TypeList5.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeList_SelectionChanged3);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 46 "..\..\AddDishes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click_8);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 47 "..\..\AddDishes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonAdd_Click_9);
            
            #line default
            #line hidden
            return;
            case 11:
            this.TypeList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 49 "..\..\AddDishes.xaml"
            this.TypeList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TypeList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.goodsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

