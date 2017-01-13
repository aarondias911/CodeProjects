using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common.Model
{
    public class NotificationMessage
    {
        public  string Header { get; set; }
        public string Type { get; set; }
        public string Message { get; set; }
    }
}
