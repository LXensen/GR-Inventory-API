using System;
using GuildedRose.API.Inventory.Models;
using GuildedRose.API.Inventory.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GuildedRose.API.Inventory.Services
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly InventoryItemContext _context;

        public InventoryRepository(InventoryItemContext context)
        {
            _context = context;

            if (_context.Items.Any()) return;

            InventoryItemSeed.InitializeData(context);
        }

        public async Task<ActionResult<InventoryItem>> GetInventoryItem(string id)
        {
            var inventoryItem = await _context.Items.FindAsync(id);

            return inventoryItem;
        }

        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryItems(string Items, string id)
        {
            var inventoryItems = await _context.Items.Where(i => id.Contains(i.Id)).ToListAsync();

            return inventoryItems;
        }

        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetItems()
        {
            return await _context.Items.ToListAsync();
        }

        
}
}
