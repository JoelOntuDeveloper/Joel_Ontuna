using Data.Entities;

namespace Data.Interfaces.IServices
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersWithFewerPendingItems();
    }
}
