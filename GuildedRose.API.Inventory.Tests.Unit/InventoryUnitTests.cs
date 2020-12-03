using System.Collections.Generic;
using Xunit;
using GuildedRose.API.Inventory.Models;
using GuildedRose.API.Inventory.Services;
using Microsoft.EntityFrameworkCore;


namespace GuildedRose.API.Inventory.Tests.Unit
{
    public class InventoryUnitTests
    {
        const string singleItem = "A11111";
        const string listofItems = "A11111&id=B22222";

        [Fact]
        public void Get_ReturnsOkResult()
        {
            var options = new DbContextOptionsBuilder<InventoryItemContext>().UseInMemoryDatabase(databaseName: "InventoryItems").Options;


            using (var context = new InventoryItemContext(options))
            {
                InventoryRepository _controller = new InventoryRepository(context);
                var ok = _controller.GetInventoryItem(singleItem);

                var items = Assert.IsAssignableFrom<InventoryItem>(ok.Result.Value);

                Assert.Equal("Widget One", ok.Result.Value.Name);

            }
        }

        [Fact]
        public void Get_ReturnsListOfItems()
        {
            var options = new DbContextOptionsBuilder<InventoryItemContext>().UseInMemoryDatabase(databaseName: "InventoryItems").Options;

            //using (var context = new InventoryItemContext(options))
            //{
            //    context.Items.Add(new InventoryItem
            //    {
            //        Id = "A11111",
            //        Name = "Widget One",
            //        InventoryCount = 1
            //    });

            //    context.Items.Add(new InventoryItem
            //    {
            //        Id = "B22222",
            //        Name = "Whoozit Two",
            //        InventoryCount = 2
            //    });
            //}

            using (var context = new InventoryItemContext(options))
            {
                InventoryRepository _controller = new InventoryRepository(context);
                var ok = _controller.GetInventoryItems("Items", listofItems);

                var items = Assert.IsAssignableFrom<List<InventoryItem>>(ok.Result.Value);

                Assert.Equal(2, items.Count);
            }
        }
    }
}
