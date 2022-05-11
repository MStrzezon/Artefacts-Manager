using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    internal class UserDAO
    {
        public User getUser(string username, string password)
        {
            User userToReturn;
            using (var ctx = new ArtefactsManagerDatabaseContext())
            {
                userToReturn = (from u in ctx.Users where u.Username == username && u.Password == password select u).FirstOrDefault<User>();
            }
            return userToReturn;
        }
    }
}
