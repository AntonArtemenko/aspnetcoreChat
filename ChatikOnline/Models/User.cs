using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Models
{
    public class User: IdentityUser
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
