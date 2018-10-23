using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NotificationService
    {
        private ElectionDBEntities dbEntities = null;
        public NotificationService()
        {
            dbEntities = new ElectionDBEntities();
        }
        public List<Notification> GetAllUnSeenNotification(int userId)
        {
            var list=dbEntities.Notifications.Where(x => x.unseen == true && x.userId==userId).ToList();
            return list;
        }
    }
}
