using ChatikOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private ChatContext _context;

        public MessageRepository(ChatContext context)
        {
            _context = context;
        }

        public IEnumerable<MessageHistory> Messages => _context.Messages;

        public async Task Add(MessageHistory messageHistory)
        {
            _context.Messages.Add(messageHistory);
            await _context.SaveChangesAsync();
        }
    }
}
