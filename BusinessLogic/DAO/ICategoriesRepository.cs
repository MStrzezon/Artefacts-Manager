using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface ICateogoriesRepository
    {
        IEnumerable<Category> GetAll();
        Category GetById(int EmployeeID);
        void Insert(Category employee);
        void Update(Category employee);
        void Delete(int EmployeeID);
        void Save();
    }
}
