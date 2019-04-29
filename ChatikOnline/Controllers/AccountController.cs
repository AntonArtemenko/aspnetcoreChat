using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatikOnline.Models;
using ChatikOnline.Services;
using Microsoft.AspNetCore.Mvc;

namespace ChatikOnline.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;
        public IActionResult Index()

        {
            return View("RegisterPage");
        }

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task Registrate(User user)
        {
            await _accountService.Register(user);
        }
    }
}