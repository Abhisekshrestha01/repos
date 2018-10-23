using BOL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NotificationManager
    {
        private NotificationService _notificationService = null; 
        public NotificationManager()
        {
            _notificationService = new NotificationService();
        }

        public List<Notification> GetAllUnSeenNotification(int userId)
        {
            return _notificationService.GetAllUnSeenNotification(userId);
        }
    }
}
