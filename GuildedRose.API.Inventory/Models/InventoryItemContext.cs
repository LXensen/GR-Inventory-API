using Microsoft.EntityFrameworkCore;

namespace GuildedRose.API.Inventory.Models
{
    public class InventoryItemContext : DbContext
    {
        public InventoryItemContext(DbContextOptions<InventoryItemContext> options) : base(options)
        {
        }

        public DbSet<InventoryItem> Items { get; set; }
    }
}
