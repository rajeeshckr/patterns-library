﻿#pragma checksum "C:\PS\Courses\EventAggregator\Orders_AfterEA\OrdersListView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "42D7CBB6D2F880DE3CC34727660632BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Orders_AfterEA {
    
    
    public partial class OrdersListView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.DataGrid OrdersList;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Orders_AfterEA;component/OrdersListView.xaml", System.UriKind.Relative));
            this.OrdersList = ((System.Windows.Controls.DataGrid)(this.FindName("OrdersList")));
        }
    }
}

