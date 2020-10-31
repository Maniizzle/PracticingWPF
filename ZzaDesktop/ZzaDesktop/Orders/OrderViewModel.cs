using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZzaDesktop.Core;

namespace ZzaDesktop.Orders
{
    public class OrderViewModel : BindableBase
    {
        private Guid customerId;
        public Guid CustomerId { get { return customerId; } set { SetProperty(ref customerId, value); } }
    }
}