using ChatikOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Services
{
    public interface IChatService
    {
        Task Add(MessageHistory messageHistory);
        Task SendMessage(string message);
    }
}
