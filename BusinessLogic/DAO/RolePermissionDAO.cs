using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class RolePermissionDAO : IRolePermissionDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public RolePermissionDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public RolePermissionDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }
        public IEnumerable<RolePermission> GetAll()
        {
            return _context.RolesPermissions;
        }

        public RolePermission GetById(int roleId, int permissionId)
        {
            return _context.RolesPermissions.Find(roleId, permissionId);
        }

        public void Insert(RolePermission rolePermission)
        {
            _context.RolesPermissions.Add(rolePermission);
        }

        public void Update(RolePermission rolePermission)
        {
            _context.Entry(rolePermission).State = EntityState.Modified;
        }

        public void Delete(int roleId, int permissionId)
        {
            RolePermission rolePermission = _context.RolesPermissions.Find(roleId, permissionId);
            _context.RolesPermissions.Remove(rolePermission);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


    }
}
