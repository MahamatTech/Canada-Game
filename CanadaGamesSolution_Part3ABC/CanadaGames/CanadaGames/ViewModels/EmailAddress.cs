using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanadaGames.ViewModels
{
    public class EmailAddress
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddress>();
        }

        public List<EmailAddress> ToAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}

