using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using System.Threading.Tasks;
using System.Net;

namespace Tests.ShoppingService
{
    [TestFixture(Category = "ShoppingsApi")]
    public class ShoppingServiceTests : BaseServiceTests
    {
        [Test]
        public void CreateItem()
        {
            var createItemModel = TestHelper.CreateItem();
            var response = CheckoutClient.ShoppingService.CreateItem(createItemModel);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void UpdateItemByName()
        {
            var createItemModel = TestHelper.CreateForUpdateItemName();

            var updateItemModel = TestHelper.UpdateItemName();
            var response = CheckoutClient.ShoppingService.UpdateItem(createItemModel.ItemName, updateItemModel);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void UpdateItemByID()
        {
            var createItemModel = TestHelper.CreateForUpdateItemID();

            var updateItemModel = TestHelper.UpdateItemID();
            var response = CheckoutClient.ShoppingService.UpdateItem(createItemModel.ID, updateItemModel);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);

        }

        [Test]
        public void DeleteItem()
        {
            var createItemModel = TestHelper.CreateItem();
            var response = CheckoutClient.ShoppingService.DeleteItem(createItemModel.ItemName);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response.Model.Message.Should().BeEquivalentTo("Delete Successful");
        }

        [Test]
        public void GetShoppingList()
        {
            var response = CheckoutClient.ShoppingService.GetShoppingList();

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Test]
        public void GetItem()
        {
            var createItemModel = TestHelper.CreateItem();
            var response = CheckoutClient.ShoppingService.GetItem(createItemModel.ItemName);

            response.Should().NotBeNull();
            response.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response.Model.ID.Should().Be(createItemModel.ID);

        }
    }
}
