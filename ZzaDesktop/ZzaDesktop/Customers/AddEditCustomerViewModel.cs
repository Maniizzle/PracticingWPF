using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zza.Data;

namespace ZzaDesktop.Customers
{
    public class AddEditCustomerViewModel : BindableBase
    {
        public string Name { get; set; } = "Add Edit View";
        private bool editMode;
        public bool EditMode { get { return editMode; } set { SetProperty(ref editMode, value); } }
        private Customer _editCustomer = null;

        public void SetCustomer(Customer customer)
        {
            _editCustomer = customer;
            Name = customer.FullName;
        }
    }
}