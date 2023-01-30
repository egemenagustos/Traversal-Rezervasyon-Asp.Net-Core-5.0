using System;

namespace Traversal_Rezervasyon_Asp.Net_Core_5._0.Models
{
    public class MailRequest
    {
        public string Name { get; set; }

        public string SenderMail { get; set; }

        public string ReceiverMail { get; set; }

        public string Subject { get; set; }

        public DateTime Date { get; set; }

        public string Body { get; set; }
    }
}
