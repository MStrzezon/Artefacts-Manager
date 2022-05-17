using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic
{
    public class RolesManagementService
    {
        private readonly RoleDAO roleDAO;
        private readonly UserDAO userDAO;

        public RolesManagementService()
        {
            roleDAO = new RoleDAO();
            userDAO = new UserDAO();
        }

        public IEnumerable<Role> getAllRoles()
        {
            return roleDAO.GetAll();
        }

        public bool deleteRole(int roleId)
        {
            try
            {
                foreach (User user in userDAO.getUsersByRole(roleId))
                {
                    userDAO.Delete(user.UserId);
                }
                userDAO.Save();
                roleDAO.Delete(roleId);
                roleDAO.Save();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
