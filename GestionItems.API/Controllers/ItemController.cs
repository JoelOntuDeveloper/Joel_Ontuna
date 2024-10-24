using Data.Entities;
using Data.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace ManageItems.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService) {
            _itemService = itemService;
        }

        [HttpGet("pendingItems")]
        public async Task<ActionResult<IEnumerable<Item>>> GetPendingItems() { 

            var pendingItems = await _itemService.GetPendingItems();

            return Ok(pendingItems);
        }
    }
}
