using ChatikOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Services
{
    public interface IAccountService
    {
        Task Register(User user);
    }
}
