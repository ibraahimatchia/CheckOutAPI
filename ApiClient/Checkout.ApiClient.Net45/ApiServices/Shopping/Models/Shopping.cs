using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Shopping
{
    public class Shopping
    {
        public int ID { get; set; }
        public string ItemName { get; set; }
        public Nullable<int> Quantity { get; set; }
    }
}
