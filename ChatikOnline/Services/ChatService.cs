using ChatikOnline.Models;
using ChatikOnline.Repositories;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Services
{
    public class ChatService: IChatService
    {
        private IMessageRepository _messageRepository;
        private IHubContext<ChatHub> hubContext;

        public ChatService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task Add(MessageHistory messageHistory)
        {
            await _messageRepository.Add(messageHistory);
        }
    }
}
