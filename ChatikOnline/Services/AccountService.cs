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

namespace ChatikOnline.Services
{
    public class AccountService: IAccountService
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

        public async Task Register(User user)
        {
            User us = await _userRepository.CheckLogin(user);
            if (us == null)
            {
               var result = await _userManager.CreateAsync(user, user.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                }
            }
        }

        public async Task Login(User user)
        {
            await _signInManager.PasswordSignInAsync(user.Login, user.Password, true, false);
        }
    }
}
