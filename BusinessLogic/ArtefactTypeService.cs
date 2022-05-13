using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic.DAO;

namespace ArtefactsManager.BusinessLogic
{
    public class ArtefactTypeService
    {
        private readonly IArtefactTypeDAO artefactTypeDAO;

        public ArtefactTypeService()
        {
            artefactTypeDAO = new ArtefactTypeDAO();
        }

        public bool saveType(string typeName, ICollection<string> attributes)
        {
            if (typeName != "" && attributes.Count > 0)
            {
                
            } else
            {
                return false;
            }
        }
    }
}
