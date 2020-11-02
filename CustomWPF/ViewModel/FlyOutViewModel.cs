using System;
using System.Collections.Generic;
using System.Text;
using MahApps.Metro.Controls;

namespace CustomWPF.ViewModel
{
    public class FlyOutViewModel : FlyoutBaseViewModel
    {
        public FlyOutViewModel()
        {
            this.Header = "settings";
            this.Position = Position.Right;
        }
    }
}