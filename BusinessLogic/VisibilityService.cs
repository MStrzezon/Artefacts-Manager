using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtefactsManager.BusinessLogic;

namespace ArtefactsManager.BusinessLogic
{
    public class VisibilityService
    {

        public IEnumerable<Category> GetVisibleCategories(List<Category> categories)
        {
            List<Category> visibleCategories = new List<Category>();
            List<string> categoriesUnvisible = UserPermissions.Permissions.Where(u => u.Visible == false).Where(p => p.TypeName == "All types").Select(p => p.CategoryName).ToList();
            foreach (Category category in categories)
            {
                if (!categoriesUnvisible.Contains(category.CategoryName))
                {
                    visibleCategories.Add(category);
                }
            }
            return visibleCategories;
        }

        public IEnumerable<ArtefactType> GetVisibleTypes(string categoryName, List<ArtefactType> types)
        {
            List<ArtefactType> visibleTypes = new List<ArtefactType>();
            List<string> typesUnvisible = UserPermissions.Permissions.Where(u => u.Visible == false).Where(p => p.CategoryName == categoryName).Select(p => p.TypeName).ToList();
            foreach (ArtefactType type in types)
            {
                if (!typesUnvisible.Contains(type.TypeName))
                {
                    visibleTypes.Add(type);
                }
            }
            return visibleTypes;
        }

        public IEnumerable<Artefact> GetVisibleArtefacts(List<Artefact> artefacts)
        {
            List<Artefact> filtredArtefacts = new List<Artefact>();
            List<string> categoriesUnvisible = UserPermissions.Permissions.Where(u => u.Visible == false).Select(u => u.CategoryName).ToList();
            foreach (Artefact artefact in artefacts)
            {
                if (!categoriesUnvisible.Contains(artefact.Category.CategoryName))
                {
                    filtredArtefacts.Add(artefact);
                }
            }
            return filtredArtefacts;
        }
    }
}
