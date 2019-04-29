using ChatikOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        IEnumerable<User> Users { get; }
        Task<User> CheckLogin(User user);
    }
}
