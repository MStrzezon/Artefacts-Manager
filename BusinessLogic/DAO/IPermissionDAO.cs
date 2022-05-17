using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IPermissionDAO
    {
        IEnumerable<Permission> GetAll();
        Permission GetById(int permissionId);
        void Insert(Permission permission);
        void Update(Permission permission);
        void Delete(int permissionId);
        void Save();

        Permission GetByAttributes(string category, string type, bool visible, bool editable, bool canAdd);
    }
}
