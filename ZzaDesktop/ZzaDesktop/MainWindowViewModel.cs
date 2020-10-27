﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;
using ZzaDesktop.Customers;
using ZzaDesktop.OrderPrep;
using ZzaDesktop.Orders;

namespace ZzaDesktop
{
    internal class MainWindowViewModel : BindableBase
    {
        private CustomerListViewModel _customerListViewModel = new CustomerListViewModel();
        private OrderPrepViewModel _orderPrepViewModel = new OrderPrepViewModel();
        private OrderViewModel _orderViewModel = new OrderViewModel();
        private AddEditCustomerViewModel _addEditViewModel = new AddEditCustomerViewModel();
        private BindableBase _CurrentViewModel;

        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }

            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public MainWindowViewModel()
        {
            NavCommand = new RelayCommand<string>(OnNav);
            _customerListViewModel.PlaceOlderRequested += NavToOrder;
            _customerListViewModel.AddCustomerRequested += NavToAddCustomer;
            _customerListViewModel.EditCustomerRequested += NavToEditCustomer;
        }

        private void NavToAddCustomer(Customer customer)
        {
            _addEditViewModel.EditMode = false;
            _addEditViewModel.SetCustomer(customer);
            CurrentViewModel = _addEditViewModel;
        }

        private void NavToEditCustomer(Customer customer)
        {
            _addEditViewModel.EditMode = true;
            _addEditViewModel.SetCustomer(customer);
            CurrentViewModel = _addEditViewModel;
        }

        private void NavToOrder(Guid customerId)
        {
            _orderViewModel.CustomerId = customerId;
            CurrentViewModel = _orderViewModel;
            // throw new NotImplementedException();
        }

        private void OnNav(string destination)
        {
            switch (destination)
            {
                case "orderprep":
                    CurrentViewModel = _orderPrepViewModel;
                    break;

                case "customers":
                    CurrentViewModel = _customerListViewModel;
                    break;
            }
        }

        public RelayCommand<string> NavCommand { get; private set; }
    }
}