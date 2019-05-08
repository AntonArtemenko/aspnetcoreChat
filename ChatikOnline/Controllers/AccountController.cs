using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatikOnline.Models;
using ChatikOnline.Services;
using ChatikOnline.Views.Account.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ChatikOnline.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;
        public IActionResult Index()

        {
            return View("Index");
        }

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View("LoginPage");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("RegisterPage");
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            bool result = await _accountService.RegisterValidation(model, ModelState.AddModelError);
            if (result)
            { 
                await _accountService.Register(model);
                return RedirectToAction("Index", "Account");
            }
            return View("RegisterPage");
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            var result = await _accountService.Login(model, ModelState.AddModelError);
            if (result)
            {
                return RedirectToAction("Index", "Chat");
            }
            return View("LoginPage");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            // удаляем аутентификационные куки
            await _accountService.LogOff();
            return RedirectToAction("LoginPage", "Account");
        }
    }
}