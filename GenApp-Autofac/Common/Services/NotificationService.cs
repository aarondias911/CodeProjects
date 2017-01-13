using Infrastructure.Common.Interfaces;
using Infrastructure.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common.Services
{
    public class NotificationService : INotificationService
    {
        public event Action<NotificationMessage> NotificationAdded;
      
        public NotificationService()
        {
            NotificationAdded = new Action<NotificationMessage>((x)=> { });
        }

        public void AddNotification(string header, string message, NotificationType notificationType)
        {
            NotificationAdded.Invoke(new NotificationMessage { Header = header, Message = message, Type = notificationType.ToString() });
        }
    }
}
