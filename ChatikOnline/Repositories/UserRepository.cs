using ChatikOnline.Models;
using ChatikOnline.Views.Account.ViewModel;
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

        // Cheking for unique email and username. idk how do not write this code so shitty:). 
        public async Task<User> UserValidation(RegisterViewModel model)
        {
            User user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == model.UserName || u.Email == model.Email);
            return user;
        }
        
    }
}
