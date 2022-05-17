using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IRolePermissionDAO
    {
        IEnumerable<RolePermission> GetAll();
        RolePermission GetById(int roleId, int permissionId);
        void Insert(RolePermission rolePermission);
        void Update(RolePermission rolePermission);
        void Delete(int roleId, int permissionId);
        void Save();
    }
}
