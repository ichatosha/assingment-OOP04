using assingment_OOP04.Intertfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_OOP04
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"email sent to -> {recipient} and message is -> {message}");
        }

        
    }
}
