using System;
using System.Collections.Generic;
using System.Text;
using CustomWPF.Views;

namespace CustomWPF
{
    public class MainWindowViewModel : BindableBase
    {
        private TestHarmburgerViewModel _harmburgerViewModel;// _customerListViewModel;
        private BindableBase _CurrentViewModel;

        public MainWindowViewModel()
        {
            _harmburgerViewModel = new TestHarmburgerViewModel();
            NavCommand = new RelayCommand<string>(onNav);
        }

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }

            set { SetProperty(ref _CurrentViewModel, value); }
        }

        private void onNav(string obj)
        {
            CurrentViewModel = _harmburgerViewModel;
        }

        public RelayCommand<string> NavCommand { get; set; }
    }
}