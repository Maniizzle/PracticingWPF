﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CustomWPF.Views
{
    /// <summary>
    /// Interaction logic for TestHamburger.xaml
    /// </summary>
    public partial class TestHamburger : UserControl
    {
        public TestHamburger()
        {
            InitializeComponent();
        }

        public void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs e)
        {
            this.HamburgerMenuControl.Content = e.InvokedItem;
            if (!e.IsItemOptions && this.HamburgerMenuControl.IsPaneOpen)
            {
            }
        }
    }
}