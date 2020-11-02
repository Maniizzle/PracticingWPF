using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using CustomWPF.Core;
using CustomWPF.ViewModel;
using CustomWPF.Views;
using MahApps.Metro.Controls.Dialogs;

namespace CustomWPF
{
    public class MainWindowViewModel : BindableBase
    {
        private TestHarmburgerViewModel _harmburgerViewModel;// _customerListViewModel;
        private BindableBase _CurrentViewModel;
        private FlyoutBaseViewModel _flyOutViewModel;
        private readonly IDialogCoordinator dialog;

        // public ObservableCollection<FlyoutBaseViewModel> FlyOutViewModels;

        public MainWindowViewModel(IDialogCoordinator instance)
        {
            _harmburgerViewModel = new TestHarmburgerViewModel();
            NavCommand = new RelayCommand<string>(onNav);
            FlyOutCommand = new RelayCommand(onFlyOut);

            _flyOutViewModel = new FlyOutViewModel();
            this.dialog = instance;
            //  FlyOutViewModels = new ObservableCollection<FlyoutBaseViewModel>();
            //FlyOutViewModels.Add(new FlyOutViewModel());
        }

        private void onFlyOut()
        {
            _flyOutViewModel.IsOpen = !_flyOutViewModel.IsOpen;
        }

        public async void FooMessage()
        {
            await this.dialog.ShowMessageAsync(this, "Message Title", "Bar");
        }

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }

            set { SetProperty(ref _CurrentViewModel, value); }
        }

        private void onNav(string obj)
        {
            switch (obj)
            {
                case "flyout":
                    _flyOutViewModel.IsOpen = !_flyOutViewModel.IsOpen;
                    CurrentViewModel = _flyOutViewModel;

                    break;

                case "hamburger":
                    CurrentViewModel = _harmburgerViewModel; ;
                    break;

                default:
                    CurrentViewModel = _harmburgerViewModel; ;
                    break;
            }
            //CurrentViewModel = _harmburgerViewModel;
        }

        public RelayCommand<string> NavCommand { get; set; }
        public RelayCommand FlyOutCommand { get; set; }
    }
}