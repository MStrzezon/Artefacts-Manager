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
    public class RoleDAO : IRoleDAO
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public RoleDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public RoleDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Role> GetAll()
        {
            return _context.Roles.ToList();
        }

        public Role GetById(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public void Insert(Role role)
        {
            _context.Roles.Add(role);
        }

        public void Update(Role role)
        {
            _context.Entry(role).State = EntityState.Modified;
        }

        public void Delete(int roleId)
        {
            Role role = _context.Roles.Find(roleId);
            _context.Roles.Remove(role);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
