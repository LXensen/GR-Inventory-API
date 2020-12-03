using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GuildedRose.API.Inventory.Models;
using GuildedRose.API.Inventory.Interfaces;

namespace GuildedRose.API.Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryRepository _context;

        public InventoryController(IInventoryRepository context)
        {
            _context = context;
        }

        //// GET: api/Inventory
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetItems()
        {
            return NoContent();
        }

        // GET: api/Inventory/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryItem>> GetInventoryItem(string id)
        {
            var inventoryItem = await _context.GetInventoryItem(id);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }

        // GET: api/Inventory/5
        [HttpGet("Items")]
        public async Task<ActionResult<IEnumerable<InventoryItem>>> GetInventoryItems(string Items, [FromQuery] string id)
        {
            var inventoryItem = await _context.GetInventoryItems(Items, id);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }
        // PUT: api/Inventory/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInventoryItem(string id, InventoryItem inventoryItem)
        {
            // ***************************
            // Should be protected by AUTH
            // ***************************

            //if (id != inventoryItem.Id)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(inventoryItem).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!InventoryItemExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return NoContent();
        }

        // POST: api/Inventory
        [HttpPost]
        public async Task<ActionResult<InventoryItem>> PostInventoryItem(InventoryItem inventoryItem)
        {
            // ***************************
            // Should be protected by AUTH
            // ***************************

            //_context.Items.Add(inventoryItem);
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (InventoryItemExists(inventoryItem.Id))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            // return CreatedAtAction("GetInventoryItem", new { id = inventoryItem.Id }, inventoryItem);
            return NoContent();
        }

        // DELETE: api/Inventory/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventoryItem(string id)
        {
            // ***************************
            // Should be protected by AUTH
            // ***************************

            //var inventoryItem = await _context.Items.FindAsync(id);
            //if (inventoryItem == null)
            //{
            //    return NotFound();
            //}

            //_context.Items.Remove(inventoryItem);
            //await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
