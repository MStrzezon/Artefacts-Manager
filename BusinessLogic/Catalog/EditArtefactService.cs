using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtefactsManager.BusinessLogic.Catalog
{
    public class EditArtefactService
    {
        private int artefactId;
        public Artefact artefact;
        private readonly CategoryDAO categoryDAO;
        private readonly ArtefactDAO artefactDAO;
        private readonly AttributeDAO attributeDAO;

        public EditArtefactService(int _artefactId)
        {
            categoryDAO = new CategoryDAO();
            artefactDAO = new ArtefactDAO();
            attributeDAO = new AttributeDAO();
            artefactId = _artefactId;
            artefact = artefactDAO.GetByIdWithAll(artefactId);
        }

        public string getAttributeName()
        {
            return artefact.Name;
        }

        public IEnumerable<Category> getCategories()
        {
            return categoryDAO.GetAll();
        }

        public int getCurrentCategoryIndex()
        {
            return getCategories().ToList().FindIndex(a => a.CategoryId == artefact.Category.CategoryId);
        }

        public IEnumerable<string> getAttributesValues()
        {
            List<string> values = new List<string>();
            for (int i = 0; i < attributeDAO.GetByArtefactType(artefact.ArtefactType.ArtefactTypeId).Count(); i++)
            { 
                values.Add(artefact.ArtefactAttributes.ElementAt(i).Value);
            }
            return values;
        }

        public IEnumerable<Data.Models.Attribute> getAttributes()
        {
            return attributeDAO.GetByArtefactType(artefact.ArtefactType.ArtefactTypeId);
        }

        public bool validateData(string name, IEnumerable<string> attributes)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            foreach (string attribute in attributes)
            {
                if (string.IsNullOrEmpty(attribute))
                {
                    return false;
                }
            }
            return true;
        }

        public bool UpdateArtefact(string name, IEnumerable<string> attributes, int categoryId)
        {
            try
            {
                artefact.Name = name;
                int idx = 0;
                foreach (string attributeValue in attributes)
                {
                    artefact.ArtefactAttributes.ElementAt(idx++).Value = attributeValue;
                }
                artefact.Category = getCategories().ElementAt(categoryId);
                artefactDAO.Update(artefact);
                artefactDAO.Save();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }
    }
}
