using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data;
using Microsoft.EntityFrameworkCore;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public class PermissionDAO : IPermissionDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public PermissionDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public PermissionDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Permission> GetAll()
        {
            return _context.Permissions.ToList();
        }

        public Permission GetById(int permissionId)
        {
            return _context.Permissions.Find(permissionId);
        }

        public void Insert(Permission permission)
        {
            _context.Permissions.Add(permission);
        }

        public void Update(Permission permission)
        {
            _context.Entry(permission).State = EntityState.Modified;

        }

        public void Delete(int permissionId)
        {
            Category category = _context.Categories.Find(permissionId);
            _context.Categories.Remove(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public Permission GetByAttributes(string category, string type, bool visible, bool editable, bool canAdd)
        {
            return _context.Permissions.Where(p => p.CategoryName == category).Where(p => p.TypeName == type).Where(p =>p.Visible == visible).Where(p => p.Editable == editable).Where(p => p.CanAdd == canAdd).FirstOrDefault();
        }

        public IEnumerable<Permission> GetByRole(int roleId)
        {
            List<int> permissionsId = _context.RolesPermissions.Where(p => p.RoleId == roleId).Select(p => p.PermissionId).ToList();
            return _context.Permissions.Where(p => permissionsId.Contains(p.PermissionId));
        }

    }
}
