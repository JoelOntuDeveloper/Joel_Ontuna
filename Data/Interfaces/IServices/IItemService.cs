using Data.Entities;

namespace Data.Interfaces.IServices
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetPendingItems();
    }
}
