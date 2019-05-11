using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatikOnline.Models;
using ChatikOnline.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ChatikOnline.Controllers
{
    public class ChatController : Controller
    {
        private IChatService _chatRepository;
        

        public IActionResult Index()
        {
            return View();
        }

        public ChatController(IChatService chatService)
        {
            _chatRepository = chatService;
        }

        public async Task AddMessage(MessageHistory messageHistory)
        {
           await _chatRepository.Add(messageHistory);
        }

        [HttpPost]
        [Authorize]
        public async Task SendMessage(string message)
        {
            await _chatRepository.SendMessage(message);
        }
    }
}