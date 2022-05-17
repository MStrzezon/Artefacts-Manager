using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IUserDao
    {
        IEnumerable<User> GetAll();
        User GetById(int userId);
        void Insert(User user);
        void Update(User user);
        void Delete(int userId);
        void Save();
        User getUser(string username, string password);
        IEnumerable<User> getUsersByRole(int roleId);
    }
}
