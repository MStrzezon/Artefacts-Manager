using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic
{
    public class ElementService
    {
        private readonly IArtefactTypeDAO artefactTypeDAO;

        public ElementService()
        {
            artefactTypeDAO = new ArtefactTypeDAO();
        }

        public IEnumerable<ArtefactType> getAllArtefactsTypes()
        {
            return artefactTypeDAO.GetAll();
        }
    }
}
