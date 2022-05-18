using ArtefactsManager.Data.Models;
using ArtefactsManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.Login;

namespace ArtefactsManager.BusinessLogic.Catalog.Utils
{
    public class RemovableService
    {
        public List<Artefact> GetRemovableArtefacts(List<Artefact> artefacts)
        {
            List<Artefact> RemovableArtefacts = new List<Artefact>();
            foreach (Artefact artefact in artefacts)
            {
                if (artefact.Owner.UserId == LoggedUser.UserId)
                {
                    RemovableArtefacts.Add(artefact);
                }

            }
            return RemovableArtefacts;
        }
    }
}
