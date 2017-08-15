using Checkout.ApiServices.SharedModels;
using Checkout.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Shopping
{
    public class ShoppingService
    {
        //Post request
        public HttpResponse<Shopping> CreateItem(Shopping item)
        {
            return new ApiHttpClient().PostRequest<Shopping>(ApiUrls.Shoppings,null, item);
        }

        //Put Request by name
        public HttpResponse<OkResponse> UpdateItem(string itemName, Shopping item)
        {
            var updateShoppingUri = string.Format(ApiUrls.Shopping, itemName);
            return new ApiHttpClient().PutRequest<OkResponse>(updateShoppingUri, null, item);
        }

        //Put Request by id
        public HttpResponse<OkResponse> UpdateItem(int id, Shopping item)
        {
            var updateShoppingUri = string.Format(ApiUrls.Shopping, id);
            return new ApiHttpClient().PutRequest<OkResponse>(updateShoppingUri, null, item);
        }

        //Delete Request
        public HttpResponse<OkResponse> DeleteItem(string itemName)
        {
            var deleteShoppingUri = string.Format(ApiUrls.Shopping, itemName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteShoppingUri, null);
        }

        //Get Request by itemName
        public HttpResponse<Shopping> GetItem(string itemName)
        {
            var getShoppingUri = string.Format(ApiUrls.Shopping, itemName);
            return new ApiHttpClient().GetRequest<Shopping>(getShoppingUri, null);
        }

        //Get All items
        public HttpResponse<ShoppingList> GetShoppingList()
        {
            var getShoppingListUri = ApiUrls.Shoppings;
            return new ApiHttpClient().GetRequest<ShoppingList>(getShoppingListUri, null);
        }
    }
}
