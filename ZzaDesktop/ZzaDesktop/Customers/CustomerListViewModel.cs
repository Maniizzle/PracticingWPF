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
        public ICustomersRepository repo;// = new CustomersRepository();

        public CustomerListViewModel(ICustomersRepository repository)
        {
            repo = repository;
            PlaceOrderCommand = new RelayCommand<Customer>(OnPLaceOrder);
            AddCustomerCommand = new RelayCommand(OnAddCustomer);
            EditCustomerCommand = new RelayCommand<Customer>(OnEditCustomer);
            ClearSearchCommand = new RelayCommand(OnClearSearch);
        }

        private void OnClearSearch()
        {
            SearchInput = null;
        }

        private ObservableCollection<Customer> customers;

        /// <summary>
        /// customers that respond to filter request
        /// </summary>
        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { SetProperty(ref customers, value); }
        }

        private string _searchInput;

        /// <summary>
        /// all the customers gotten from the datastore
        /// </summary>
        private List<Customer> _allCustomers;

        public string SearchInput
        {
            get { return _searchInput; }
            set
            {
                SetProperty(ref _searchInput, value);
                FilterCustomers(_searchInput);
            }
        }

        private void FilterCustomers(string searchInput)
        {
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                Customers = new ObservableCollection<Customer>(_allCustomers);
                return;
            }
            else
            {
                Customers = new ObservableCollection<Customer>(_allCustomers.Where(c => c.FullName.ToLower().Contains(searchInput)));
            }
            throw new NotImplementedException();
        }

        public RelayCommand<Customer> PlaceOrderCommand { get; private set; }
        public RelayCommand<Customer> EditCustomerCommand { get; private set; }
        public RelayCommand AddCustomerCommand { get; private set; }
        public RelayCommand ClearSearchCommand { get; private set; }

        //use to pass info the parent
        public event Action<Guid> PlaceOlderRequested = delegate { };

        public event Action<Customer> AddCustomerRequested = delegate { };

        public event Action<Customer> EditCustomerRequested = delegate { };

        public async void LoadCustomers()
        {
            _allCustomers = await repo.GetCustomersAsync();
            Customers = new ObservableCollection<Customer>(_allCustomers);
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