using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.DAO
{
    public interface IArtefactDAO
    {
        IEnumerable<Artefact> GetAll();
        Artefact GetById(int artefactId);
        void Insert(Artefact artefact);
        void Update(Artefact artefact);
        void Delete(int artefactId);
        void Save();

        IEnumerable<Artefact> GetByCategoryAndType(int categoryId, int typeId);

        Artefact GetByIdWithAll(int artefactId);

        IEnumerable<Artefact> GetByCategoryAndTypeAndName(int categoryId, int typeId, string name);

        IEnumerable<Artefact> GetByType(int typeId);

        IEnumerable<Artefact> GetByTypeAndName(int typeId, string name);

        IEnumerable<Artefact> Get5LastAdded();
    }
}
