using ChatikOnline.Models;
using ChatikOnline.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Services
{
    public class ChatService : IChatService
    {
        private IMessageRepository _messageRepository;
        private IHubContext<ChatHub> _hubContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;

        public ChatService(IMessageRepository messageRepository, IHttpContextAccessor httpContextAccessor,
             UserManager<User> userManager, IHubContext<ChatHub> hubContext)
        {
            _messageRepository = messageRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _hubContext = hubContext;
        }


        public async Task Add(MessageHistory messageHistory)
        {
            await _messageRepository.Add(messageHistory);
        }

        [Authorize]
        public async Task SendMessage(string message)
        {
        }
        
        public async Task<User> getCurrentUser()
        {
            return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
        }
    }
}
