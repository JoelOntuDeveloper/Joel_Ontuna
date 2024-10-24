using Data.Entities;
using Data.Interfaces;
using Data.Interfaces.IServices;

namespace ManageUsers.Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository repository)
        {
            _userRepository = repository;
        }
        public async Task<IEnumerable<User>> GetUsersWithFewerPendingItems()
        {
            return await _userRepository.GetUserWithFewerPendingItems();
        }
    }
}
