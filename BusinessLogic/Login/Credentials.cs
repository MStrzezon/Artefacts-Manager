using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data;
using ArtefactsManager.Data.Models;
using ArtefactsManager.Utils;

namespace ArtefactsManager.BusinessLogic.Login
{
    internal class Credentials
    {
        private UserDAO userDao;
        private PermissionDAO permissionDao;

        public Credentials()
        {
            userDao = new UserDAO();
            permissionDao = new PermissionDAO();
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
                UserPermissions.Permissions = permissionDao.GetByRole(user.Role.RoleId).ToList();
                return true;
            } else
            {
                return false;
            }
        }
    }
}
