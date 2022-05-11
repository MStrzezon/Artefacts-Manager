using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using ArtefactsManager.Utils;

namespace ArtefactsManager.Presenters
{
    internal class Credentials
    {
        private UserDAO userDao;

        public Credentials()
        {
            userDao = new UserDAO();
        }
        public bool validate(string username, string password)
        {
            password = Encryption.ComputeMd5Hash(password);
            User user = userDao.getUser(username, password);
            if (user != null)
            {
                LoggedUser.Username = username;
                LoggedUser.UserId = user.UserId;
                LoggedUser.IsAdmin = user.IsAdmin;
                Console.WriteLine(user.IsAdmin);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
