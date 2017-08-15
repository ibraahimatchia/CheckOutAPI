using System;
using System.Collections.Generic;
using Checkout.ApiServices.SharedModels;


namespace Checkout.ApiServices.Shopping
{
    public class ShoppingList
    {
        public int Count { get; set; }
        public List<Shopping> Basket { get; set; }
    }
}
