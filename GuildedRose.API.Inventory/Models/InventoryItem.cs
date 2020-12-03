using System;
namespace GuildedRose.API.Inventory.Models
{
    public class InventoryItem
    {
        public InventoryItem()
        {
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public int InventoryCount { get; set; }
    }
}
