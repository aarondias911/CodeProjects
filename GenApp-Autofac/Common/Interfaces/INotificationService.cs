using System;
using System.Collections.Generic;
using Infrastructure.Common.Model;

namespace Infrastructure.Common.Interfaces
{
    public interface INotificationService
    {
        event Action<NotificationMessage> NotificationAdded;

        void AddNotification(string header, string message, NotificationType notificationType);
    }
}