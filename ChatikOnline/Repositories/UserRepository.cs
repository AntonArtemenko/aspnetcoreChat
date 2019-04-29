using ChatikOnline.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Repositories
{
    public class UserRepository : IUserRepository
    {

        private ChatContext _context;

        public UserRepository(ChatContext chatContext)
        {
            _context = chatContext;
        }

        public IEnumerable<User> Users => _context.Users;

        public async Task AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<User> CheckLogin(User user) =>
        await _context.Users.FirstOrDefaultAsync(u => u.Login == user.Login);
    }
}
