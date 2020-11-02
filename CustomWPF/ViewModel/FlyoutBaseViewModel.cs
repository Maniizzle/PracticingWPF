// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//using Caliburn.Micro;
using CustomWPF.Core;
using MahApps.Metro.Controls;

namespace CustomWPF.ViewModel
{
    public abstract class FlyoutBaseViewModel : BindableBase
    {
        private string header;
        private bool isOpen;
        private Position position;
        private FlyoutTheme theme = FlyoutTheme.Dark;

        public string Header
        {
            get { return this.header; }
            set
            {
                this.SetProperty(ref header, value);
            }
        }

        public bool IsOpen
        {
            get { return this.isOpen; }
            set
            {
                this.SetProperty(ref isOpen, value);
            }
        }

        public Position Position
        {
            get { return this.position; }
            set
            {
                this.SetProperty(ref position, value);
            }
        }

        public FlyoutTheme Theme
        {
            get { return this.theme; }
            set
            {
                this.SetProperty(ref theme, value);
            }
        }
    }
}