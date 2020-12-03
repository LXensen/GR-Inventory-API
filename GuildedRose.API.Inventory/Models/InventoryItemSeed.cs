using System;
namespace GuildedRose.API.Inventory.Models
{
    public static class InventoryItemSeed
    {
        public static void InitializeData(InventoryItemContext context)
        {
            _ = context.Items.Add(new InventoryItem
            {
                Id = "A11111",
                Name = "Widget One",
                InventoryCount = 1
            });

            _ = context.Items.Add(new InventoryItem
            {
                Id = "B22222",
                Name = "Whoozit Two",
                InventoryCount = 2

            });

            _ = context.Items.Add(new InventoryItem
            {
                Id = "C33333",
                Name = "Fizbit Three",
                InventoryCount = 3

            });

            _ = context.Items.Add(new InventoryItem
            {
                Id = "D44444",
                Name = "Fizbit One",
                InventoryCount = 5

            });

            _ = context.Items.Add(new InventoryItem
            {
                Id = "E55555",
                Name = "Widget Two",
                InventoryCount = 5

            });

            _ = context.Items.Add(new InventoryItem
            {
                Id = "F66666",
                Name = "Widget Three",
                InventoryCount = 5

            });

            context.SaveChanges();
        }
    }
}
