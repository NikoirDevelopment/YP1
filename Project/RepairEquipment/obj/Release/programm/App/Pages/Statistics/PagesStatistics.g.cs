﻿#pragma checksum "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "978E74ACC0A61EA1E0E5A4EEC0621579DC22E9A3B8E0834040559FF7A3A5AAFE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RepairEquipment.programm.App.Pages.Statistics;
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


namespace RepairEquipment.programm.App.Pages.Statistics {
    
    
    /// <summary>
    /// PagesStatistics
    /// </summary>
    public partial class PagesStatistics : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnUpdate;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DtgApplicationHistory;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtTotal;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtTime;
        
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
            System.Uri resourceLocater = new System.Uri("/RepairEquipment;component/programm/app/pages/statistics/pagesstatistics.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
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
            this.BtnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\..\..\programm\App\Pages\Statistics\PagesStatistics.xaml"
            this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DtgApplicationHistory = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.TxtTotal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TxtTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

