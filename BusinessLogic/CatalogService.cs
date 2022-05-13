using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic
{
    public class CatalogService
    {
        private readonly ICategoryDAO categoryDAO;

        public CatalogService()
        {
            categoryDAO = new CategoryDAO();
        }

        public IEnumerable<Category> getCategories()
        {
            return categoryDAO.GetAll();
        }
    }
}
