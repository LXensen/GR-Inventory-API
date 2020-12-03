using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GuildedRose.API.Inventory.Models;
using System.Collections.Generic;

namespace GuildedRose.API.Inventory.Interfaces
{
    public interface IInventoryService
    {
        Task<ActionResult<IEnumerable<InventoryItem>>> GetItems();

        Task<ActionResult<InventoryItem>> GetInventoryItem(string id);

        Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryItems(string Items, [FromQuery] string id);
    }
}
