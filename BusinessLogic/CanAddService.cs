using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic
{
    public class CanAddService
    {
        private readonly ICategoryDAO categoryDAO;
        private readonly IArtefactTypeDAO artefactTypeDAO;

        public CanAddService()
        {
            categoryDAO = new CategoryDAO();
            artefactTypeDAO = new ArtefactTypeDAO();
        }
        public IEnumerable<Category> canAddCategory()
        {
            if (UserPermissions.Permissions.Where(p => p.CanAdd == true).Select(p => p.CategoryName).ToList().Contains("All categories"))
            {
                return categoryDAO.GetAll();
            }
            return categoryDAO.GetByCategoryName(UserPermissions.Permissions.Where(p => p.CanAdd == true).Select(p => p.CategoryName).ToList());
        }

        public IEnumerable<ArtefactType> canAddType()
        {
            if (UserPermissions.Permissions.Where(p => p.CanAdd == true).Select(p => p.TypeName).ToList().Contains("All types"))
            {
                return artefactTypeDAO.GetAll();
            }
            return artefactTypeDAO.GetByArtefactsNames((UserPermissions.Permissions.Where(p => p.CanAdd == true).Select(p => p.TypeName).ToList())); 

        }
    }
}
