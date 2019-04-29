using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Models
{
    public class ChatContext : IdentityDbContext<User>
    {
        public ChatContext(DbContextOptions<ChatContext> options)
            : base(options)
        {
        }
        public DbSet<MessageHistory> Messages { get; set; }
    }
}
