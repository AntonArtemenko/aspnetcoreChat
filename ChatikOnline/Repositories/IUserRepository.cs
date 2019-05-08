using ChatikOnline.Models;
using ChatikOnline.Views.Account.ViewModel;
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
        Task<User> UserValidation(RegisterViewModel model);
    }
}
