using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public  class StaffAccount
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNomber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public string ProfileImg { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }

        public ICollection<StaffRole> StaffRoles { get; set; } = new HashSet<StaffRole>();
        public ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();
    }
}
