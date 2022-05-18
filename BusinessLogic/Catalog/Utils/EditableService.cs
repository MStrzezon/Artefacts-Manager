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
    public class EditableService
    {
        public List<Artefact> GetEditableArtefacts(List<Artefact> artefacts)
        {
            List<string> permissionsCategories = UserPermissions.Permissions.Where(p => p.Editable == true).Select(p => p.CategoryName).ToList();
            List<string> permissionsTypes = UserPermissions.Permissions.Where(p => p.Editable == true).Select(p => p.TypeName).ToList();
            List<Artefact> EditableArtefacts = new List<Artefact>();
            if (permissionsCategories.Contains("All categories"))
            {
                if (permissionsTypes.Contains("All types"))
                {
                    return artefacts;
                }
            }
            foreach (Artefact artefact in artefacts)
            {
                if (artefact.Owner.UserId == LoggedUser.UserId)
                {
                    EditableArtefacts.Add(artefact);
                }
                if (permissionsCategories.Contains(artefact.Category.CategoryName))
                {
                    if (permissionsTypes.Contains(artefact.ArtefactType.TypeName) || permissionsTypes.Contains("All types"))
                    {
                        EditableArtefacts.Add(artefact);
                    }
                }
            }
            return EditableArtefacts;
        }
    }
}
