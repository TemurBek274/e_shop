using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool Seen { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime RecelueTime { get; set; } = DateTime.UtcNow;
        public DateTime NotifictionoExprlyDate { get; set; }

        public StaffAccount StaffAccount { get; set; }
    }
}
