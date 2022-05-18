using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.BusinessLogic.Catalog
{
    public class AddArtefactTypeService
    {
        private readonly IArtefactTypeDAO artefactTypeDAO;
        private readonly IAttributeDAO attributeDAO;

        public AddArtefactTypeService()
        {
            artefactTypeDAO = new ArtefactTypeDAO();
            attributeDAO = new AttributeDAO();
        }

        public bool SaveType(string typeName, ListBox.ObjectCollection _attributes)
        {
            ICollection<string> attributes = ObjectCollectionToCollection(_attributes);
            if (typeName != "" && attributes.Count > 0)
            {
                if (artefactTypeDAO.GetByName(typeName) == null)
                {
                    ArtefactType artefactType = new ArtefactType();
                    artefactType.TypeName = typeName;
                    artefactType.AttributeArtefactTypes = CreateAttributeArtefactTypes(artefactType, attributes);
                    artefactTypeDAO.Insert(artefactType);
                    artefactTypeDAO.Save();
                    return true;
                } else
                {
                    return false;
                }
            } else
            {
                return false;
            }
        }

        private List<AttributeArtefactType> CreateAttributeArtefactTypes(ArtefactType artefactType, ICollection<string> attributes)
        {
            List<AttributeArtefactType> attributeArtefactTypes = new List<AttributeArtefactType>();
            foreach (string attributeName in attributes)
            {
                if (attributeDAO.GetByName(attributeName) == null)
                {
                    attributeArtefactTypes.Add(new AttributeArtefactType { ArtefactType = artefactType, Attribute = new Data.Models.Attribute { Name = attributeName } });
                }
                else
                {
                    attributeArtefactTypes.Add(new AttributeArtefactType { ArtefactType = artefactType, AttributeId = attributeDAO.GetByName(attributeName).AttributeId });
                }
            }
            return attributeArtefactTypes;
        }

        private ICollection<string> ObjectCollectionToCollection(ListBox.ObjectCollection objectCollection)
        {
            ICollection<string> collection = new List<string>();
            foreach (var item in objectCollection)
            {
                collection.Add(item.ToString());
            }
            return collection;
        }
    }
}
