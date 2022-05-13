using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IAttributeDAO
    {
        IEnumerable<Data.Models.Attribute> GetAll();
        Data.Models.Attribute GetById(int attributeId);
        void Insert(Data.Models.Attribute attribute);
        void Update(Data.Models.Attribute attribute);
        void Delete(int attributeId);
        void Save();
    }
}
