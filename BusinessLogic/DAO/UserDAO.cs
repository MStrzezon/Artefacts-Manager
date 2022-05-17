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
    public class UserDAO : IUserDao
    {
        private readonly ArtefactsManagerDatabaseContext _context;

        public UserDAO()
        {
            _context = new ArtefactsManagerDatabaseContext();
        }

        public UserDAO(ArtefactsManagerDatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Include(u => u.Role).ToList();
        }

        public User GetById(int userId)
        {
            return _context.Users.Include(u => u.Role).FirstOrDefault(u => u.UserId == userId);
        }

        public void Insert(User user)
        {
            _context.Users.Add(user);
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int userId)
        {
            User user = _context.Users.Find(userId);
            _context.Users.Remove(user);
        }

        public void Save()
        {
            _context.SaveChanges();
        }


        public User getUser(string username, string password)
        {
            return (from u in _context.Users where u.Username == username && u.Password == password select u).FirstOrDefault<User>();
        }

        public IEnumerable<User> getUsersByRole(int roleId)
        {
            return _context.Users.Where(u => u.Role.RoleId == roleId);
        }


    }
}
