using ChatikOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Repositories
{
    public interface IMessageRepository
    {
        IEnumerable<MessageHistory> Messages { get; }
        Task Add(MessageHistory messageHistory);
    }
}
