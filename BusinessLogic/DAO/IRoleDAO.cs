using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IRoleDAO
    {
        IEnumerable<Role> GetAll();
        Role GetById(int roleId);
        void Insert(Role role);
        void Update(Role role);
        void Delete(int roleId);
        void Save();

        Role GetByName(string name);
    }
}
