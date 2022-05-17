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

        public RolesManagementService()
        {
            roleDAO = new RoleDAO();
        }

        public IEnumerable<Role> getAllRoles()
        {
            return roleDAO.GetAll();
        }

        public bool deleteRole(int roleId)
        {
            try
            {
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
