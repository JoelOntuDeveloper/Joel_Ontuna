using Data.Entities;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUserWithFewerPendingItems()
        {
            return await _context.Users.Where(user => !(user.Items.Count > 3 && user.Items.All(item => item.relevance.Equals("ALTA")))).OrderBy(user => user.Items.Count).ToListAsync();
        }
    }
}
