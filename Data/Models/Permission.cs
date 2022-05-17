using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.Data.Models
{
    public class Permission
    {
        public int PermissionId { get; set; }

        public string CategoryName { get; set; }

        public string TypeName { get; set; }

        public bool Visible { get; set; }

        public bool Editable { get; set; }

        public bool CanAdd { get; set; }

        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
