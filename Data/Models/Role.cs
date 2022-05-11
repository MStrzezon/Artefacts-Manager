using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new List<UserRole>();
        }
        public int RoleId { get; set; }

        public string RoleName { get; set; }

        public ICollection<UserRole> Users { get; set; }
    }
}
