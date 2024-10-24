using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ItemRepository : IItemRepository
    {

        private readonly ApplicationDbContext _context;

        public ItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Item>> GetPendingUnassignedItems()
        {
            return await _context.Items.Where(item => !item.IsCompleted && item.userId == null).ToListAsync();
        }
    }
}
