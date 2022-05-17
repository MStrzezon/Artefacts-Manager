using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data.Models;
using ArtefactsManager.BusinessLogic.DAO;
using System.Data;

namespace ArtefactsManager.BusinessLogic
{
    public class UsersManagementService
    {
        private readonly UserDAO userDAO;

        public UsersManagementService()
        {
            userDAO = new UserDAO();
        }

        public IEnumerable<User> getAllUsers()
        {
            return userDAO.GetAll();
        }

        public bool deleteUser(int userId)
        {
            try
            {
                userDAO.Delete(userId);
                userDAO.Save();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}
