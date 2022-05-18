using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.DAO;
using ArtefactsManager.Data.Models;
using ArtefactsManager.BusinessLogic;

namespace ArtefactsManager.BusinessLogic
{
    public class CatalogService
    {
        private readonly ICategoryDAO categoryDAO;
        private readonly IArtefactDAO artefactDAO;
        private readonly IArtefactTypeDAO artefactTypeDAO;
        private readonly IAttributeDAO attributeDAO;
        private readonly IArtefactAttributeDAO artefactAttributeDAO;
        private readonly VisibilityService visibilityService;
        private readonly EditableService editableService;
        private readonly RemovableService removableService;

        public CatalogService()
        {
            categoryDAO = new CategoryDAO();
            artefactDAO = new ArtefactDAO();
            artefactTypeDAO = new ArtefactTypeDAO();
            attributeDAO = new AttributeDAO();
            artefactAttributeDAO = new ArtefactAttributeDAO();
            visibilityService = new VisibilityService();
            editableService = new EditableService();
            removableService = new RemovableService();
        }

        public IEnumerable<Category> getCategories()
        {
            return visibilityService.GetVisibleCategories(categoryDAO.GetAll().ToList());
        }

        public IEnumerable<Category> getCategoriesByArtefactName(string artefactName)
        {
            return visibilityService.GetVisibleCategories(categoryDAO.GetByArtefactName(artefactName).ToList());
        }

        public IEnumerable<ArtefactType> getTypes()
        {
            return visibilityService.GetVisibleTypes("All categories", artefactTypeDAO.GetAll().ToList());
        }

        public IEnumerable<ArtefactType> getTypesByCategory(int categoryId)
        {
            return visibilityService.GetVisibleTypes(categoryDAO.GetById(categoryId).CategoryName, artefactTypeDAO.GetByCategory(categoryId).ToList());
        }

        public IEnumerable<ArtefactType> getTypesByCategoryAndArtefactName(int categoryId, string artefactName)
        {
            return visibilityService.GetVisibleTypes(categoryDAO.GetById(categoryId).CategoryName, artefactTypeDAO.GetByCategoryAndArtefactName(categoryId, artefactName).ToList());
        }

        public IEnumerable<ArtefactType> getTypesByArtefactName(string artefactName)
        {
            return artefactTypeDAO.GetByArtefactName(artefactName);
        }

        public DataTable getDataTable(int categoryId, int typeId)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByCategoryAndType(categoryId, typeId).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, showingArtefacts);
            return dataTable;
        }


        public DataTable getDataTableByName(int categoryId, int typeId, string name)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByCategoryAndTypeAndName(categoryId, typeId, name).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, visibilityService.GetVisibleArtefacts(showingArtefacts));
            return dataTable;
        }

        public DataTable getDataTableByType(int typeId)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByType(typeId).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, visibilityService.GetVisibleArtefacts(showingArtefacts));
            return dataTable;
        }

        public DataTable getDataTableByTypeAndName(int typeId, string name)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByTypeAndName(typeId, name).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, showingArtefacts);
            return dataTable;
        }


        private void loadColumns(DataTable dataTable, IEnumerable<Data.Models.Attribute> attributes)
        {
            dataTable.Columns.Add("Id").ReadOnly = true;
            dataTable.Columns.Add("Category").ReadOnly = true;
            dataTable.Columns.Add("Name").ReadOnly = true;
            foreach (Data.Models.Attribute attribute in attributes)
            {
                dataTable.Columns.Add(attribute.Name).ReadOnly = true;
            }
            dataTable.Columns.Add("Created date").ReadOnly = true;
        }

        private void loadRows(DataTable dataTable, IEnumerable<Artefact> artefacts)
        {
            DataRow tmp;
            string columnName;
            foreach (Artefact artefact in artefacts)
            {
                tmp = dataTable.NewRow();
                tmp["Id"] = artefact.ArtefactId;
                tmp["Category"] = artefact.Category.CategoryName;
                tmp["Name"] = artefact.Name;
                for (int i = 0; i < dataTable.Columns.Count - 4; i++)
                {
                    columnName = dataTable.Columns[i + 3].ColumnName;
                    tmp[columnName] = artefactAttributeDAO.GetById(artefact.ArtefactId, attributeDAO.GetByName(columnName).AttributeId).Value;
                }
                tmp["Created date"] = artefact.Created;
                dataTable.Rows.Add(tmp);
            }
        }

        public IEnumerable<Artefact> getEditableArtefacts()
        {
            return editableService.GetEditableArtefacts(artefactDAO.GetAll().ToList());
        }

        public IEnumerable<Artefact> getRemovableArtefacts()
        {
            return removableService.GetRemovableArtefacts(artefactDAO.GetAll().ToList());
        }

        public void deleteArtefact(int artefactId)
        {
            artefactDAO.Delete(artefactId);
            artefactDAO.Save();
        }
    }
}
