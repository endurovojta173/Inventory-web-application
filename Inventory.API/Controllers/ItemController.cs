using Inventory.API.Data;
using Inventory.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")] //Address: api/item
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly InventoryContext _context;
        public ItemController(InventoryContext context)
        {
            _context = context;
        }
        //Get api/items
        [HttpGet(Name = "AllItems")]
        public async Task<ActionResult<IEnumerable<Item>>> GetItems()
        {
            return await _context.Items.Include(i => i.Owner)
            .Include(i => i.Room)
            .Include(i => i.ItemType)
            .ToListAsync();
        }
    }
}