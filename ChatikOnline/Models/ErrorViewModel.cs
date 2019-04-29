
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace ChatikOnline.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}