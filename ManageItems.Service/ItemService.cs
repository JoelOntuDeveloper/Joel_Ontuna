using Data.Entities;
using Data.Interfaces;
using Data.Interfaces.IServices;

namespace ManageItems.Service
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository repository)
        {
            _itemRepository = repository;
        }

        public async Task<IEnumerable<Item>> GetPendingItems()
        {
            var items = await _itemRepository.GetPendingUnassignedItems();
            return items;
        }
    }
}
