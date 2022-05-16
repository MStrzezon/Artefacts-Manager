using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using ArtefactsManager.Utils;

namespace ArtefactsManager.BusinessLogic
{
    public class AddUserService
    {
        private readonly UserDAO userDAO;
        private readonly RoleDAO roleDAO;

        public AddUserService()
        {
            userDAO = new UserDAO();
            roleDAO = new RoleDAO();
        }

        public IEnumerable<Role> getRoles()
        {
            return roleDAO.GetAll();
        }

        public bool validate(string username, string password, string confirmedPassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }
            if (password != confirmedPassword)
            {
                return false;
            }
            return true;
        }

        public bool saveUser(string username, string password, string roleName)
        {
            try
            {
                User user = createUser(username, password);
                userDAO.Insert(user);
                user.Role = roleDAO.GetByName(roleName);
                userDAO.Save();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private User createUser(string username, string password)
        {
            User user = new User();
            user.Username = username;
            user.Password = Encryption.ComputeMd5Hash(password);
            user.IsAdmin = false;
            return user;
        }
    }
}
