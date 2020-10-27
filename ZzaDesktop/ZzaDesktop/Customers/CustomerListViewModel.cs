using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;
using ZzaDesktop.Services;

namespace ZzaDesktop.Customers
{
    public class CustomerListViewModel : BindableBase
    {
        public ICustomersRepository repo = new CustomersRepository();

        public CustomerListViewModel()
        {
            PlaceOrderCommand = new RelayCommand<Customer>(OnPLaceOrder);
            AddCustomerCommand = new RelayCommand(OnAddCustomer);
            EditCustomerCommand = new RelayCommand<Customer>(OnEditCustomer);
        }

        private ObservableCollection<Customer> customers;

        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { SetProperty(ref customers, value); }
        }

        public RelayCommand<Customer> PlaceOrderCommand { get; private set; }
        public RelayCommand<Customer> EditCustomerCommand { get; private set; }
        public RelayCommand AddCustomerCommand { get; private set; }

        //use to pass info the parent
        public event Action<Guid> PlaceOlderRequested = delegate { };

        public event Action<Customer> AddCustomerRequested = delegate { };

        public event Action<Customer> EditCustomerRequested = delegate { };

        public async void LoadCustomers()
        {
            Customers = new ObservableCollection<Customer>(await repo.GetCustomersAsync());
        }

        private void OnPLaceOrder(Customer customer)
        {
            //raise event that parent view can handle.

            PlaceOlderRequested(customer.Id);
        }

        private void OnEditCustomer(Customer customer)
        {
            EditCustomerRequested(customer);
        }

        private void OnAddCustomer()
        {
            AddCustomerRequested(new Customer { Id = Guid.NewGuid(), FirstName = "BOlatito" });
            //   throw new NotImplementedException();
        }
    }
}