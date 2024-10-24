using Data.Entities;

namespace Data.Interfaces
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetPendingUnassignedItems();
    }
}
