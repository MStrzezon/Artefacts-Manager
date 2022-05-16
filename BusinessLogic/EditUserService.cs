using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Utils;

namespace ArtefactsManager.BusinessLogic
{
    public class EditUserService
    {
        private readonly UserDAO userDAO;
        private readonly RoleDAO roleDAO;

        public EditUserService()
        {
            userDAO = new UserDAO();
            roleDAO = new RoleDAO();
        }
        public User getUserById(int userId)
        {
            return userDAO.GetById(userId);
        }

        public IEnumerable<Role> getRoles()
        {
            return roleDAO.GetAll();
        }


        public bool updateUser(User user, string password, string roleName)
        {
            try
            {
                if (!string.IsNullOrEmpty(password))
                {
                    user.Password = Encryption.ComputeMd5Hash(password);
                }
                if (user.Role.RoleId != roleDAO.GetByName(roleName).RoleId)
                {
                    user.Role = roleDAO.GetByName(roleName);
                }
                userDAO.Update(user);
                userDAO.Save();
                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool validate(string username, string password, string confirmedPassword, bool changePassword)
        {
            if (string.IsNullOrEmpty(username))
            {
                return false;
            }
            if (changePassword)
            {
                if (string.IsNullOrEmpty(password))
                {
                    return false;
                }
                if (password != confirmedPassword)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
