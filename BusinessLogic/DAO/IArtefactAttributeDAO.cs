using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IArtefactAttributeDAO
    {
        IEnumerable<ArtefactAttribute> GetAll();
        ArtefactAttribute GetById(int artefactId, int attributeId);
        void Insert(ArtefactAttribute artefactAttribute);
        void Update(ArtefactAttribute artefactAttribute);
        void Delete(int artefactId, int attributeId);
        void Save();
    }
}
