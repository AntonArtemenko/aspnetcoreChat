using ChatikOnline.Models;
using ChatikOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using ChatikOnline.Views.Account.ViewModel;

namespace ChatikOnline.Services
{
    public class AccountService : IAccountService
    {
        private IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountService(IUserRepository userRepository, UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task Register(RegisterViewModel model)
        {
            User user = new User { Email = model.Email, UserName = model.UserName };
            await _userManager.CreateAsync(user, model.Password);
        }

        public async Task<bool> RegisterValidation(RegisterViewModel model, Action<string, string> AddModelError)
        {
            User user = await _userRepository.UserValidation(model);

            if (user == null)
            {
                return true;
            }

            if (user.Email != null)
            {
                AddModelError("Email", "Account with this email has already exist");
                return false;
            }

            if (user.UserName != null)
            {
                AddModelError("UserName", "Account with this username has already exist");
                return false;
            }

            return true;
        }

        public async Task<bool> Login(LoginViewModel model, Action<string, string> AddError)
        {
            var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                AddError("", "Wrong login or password");
                return false;
            }
        }

        public async Task LogOff()
        {
            await _signInManager.SignOutAsync();
        }
    }
}