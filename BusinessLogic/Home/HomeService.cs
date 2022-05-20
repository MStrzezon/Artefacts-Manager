using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtefactsManager.BusinessLogic.Home
{
    public class HomeService
    {
        private readonly ArtefactDAO artefactDAO;

        public HomeService()
        {
            artefactDAO = new ArtefactDAO();
        }

        public List<Artefact> Get5LastAddedArtefacts()
        {
            return artefactDAO.Get5LastAdded().ToList();
        }
    }
}
