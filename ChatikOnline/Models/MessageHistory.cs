using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatikOnline.Models
{
    public class MessageHistory
    {
        public int ID { get; set; }
        public string MessageText { get; set; }
        public string UserName { get; set; }
    }
}
