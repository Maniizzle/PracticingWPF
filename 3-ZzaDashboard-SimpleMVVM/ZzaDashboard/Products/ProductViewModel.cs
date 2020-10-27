using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zza.Data;
using ZzaDashboard.Services;

namespace ZzaDashboard.Products
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Product _product;
        private ICustomersRepository _repository = new CustomersRepository();

        public ProductViewModel()
        {
            SaveCommand = new RelayCommand(OnSave);
        }

        public Guid ProductId { get; set; }

        public Product Product
        {
            get { return _product; }
            set
            {
                if (value != _product)
                {
                    _product = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(Product)));
                }
            }
        }

        public ICommand SaveCommand { get; set; }

        public void LoadProduct()
        {
            Product = new Product { Name = "Eggroll", Image = "Egg", Type = "Scotch" };
        }

        private void OnSave()
        {
            Product = Product;
        }
    }
}