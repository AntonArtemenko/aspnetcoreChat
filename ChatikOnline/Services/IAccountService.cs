using ChatikOnline.Models;
using ChatikOnline.Views.Account.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Services
{
    public interface IAccountService
    {
        Task Register(RegisterViewModel model);
        Task<bool> RegisterValidation(RegisterViewModel model, Action<string, string> AddModelError);
        Task<bool> Login(LoginViewModel model, Action<string, string> AddError);
        Task LogOff();
    }
}
