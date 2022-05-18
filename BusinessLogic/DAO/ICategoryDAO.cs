using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface ICategoryDAO
    {
        IEnumerable<Category> GetAll();
        Category GetById(int categoryId);
        void Insert(Category category);
        void Update(Category category);
        void Delete(int categoryId);
        void Save();

        Category GetByName(string name);

        IEnumerable<Category> GetByArtefactName(string artefactName);

        IEnumerable<Category> GetByCategoryName(List<string> categoriesNames);
    }
}
