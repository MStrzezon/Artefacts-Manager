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

        public CatalogService()
        {
            categoryDAO = new CategoryDAO();
            artefactDAO = new ArtefactDAO();
            artefactTypeDAO = new ArtefactTypeDAO();
            attributeDAO = new AttributeDAO();
            artefactAttributeDAO = new ArtefactAttributeDAO();
            visibilityService = new VisibilityService();
        }

        public IEnumerable<Category> getCategories()
        {
            return visibilityService.GetVisibleCategories(categoryDAO.GetAll().ToList());
        }

        public IEnumerable<ArtefactType> getTypes()
        {
            return artefactTypeDAO.GetAll();
        }

        public IEnumerable<ArtefactType> getTypesByCategory(int categoryId)
        {
            return visibilityService.GetVisibleTypes(categoryDAO.GetById(categoryId).CategoryName, artefactTypeDAO.GetByCategory(categoryId).ToList());
        }

        public IEnumerable<Category> getCategoriesByArtefactName(string artefactName)
        {
            return categoryDAO.GetByArtefactName(artefactName);
        }

        public IEnumerable<ArtefactType> getTypesByCategoryAndArtefactName(int categoryId, string artefactName)
        {
            return artefactTypeDAO.GetByCategoryAndArtefactName(categoryId, artefactName);
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

        public void deleteArtefact(int artefactId)
        {
            artefactDAO.Delete(artefactId);
            artefactDAO.Save();
        }

        public DataTable getDataTableByName(int categoryId, int typeId, string name)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByCategoryAndTypeAndName(categoryId, typeId, name).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, showingArtefacts);
            return dataTable;
        }

        public DataTable getDataTableByType(int typeId)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByType(typeId).ToList();
            List<Data.Models.Attribute> attributes = attributeDAO.GetByArtefactType(typeId).ToList();

            DataTable dataTable = new DataTable();
            loadColumns(dataTable, attributes);
            loadRows(dataTable, showingArtefacts);
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
    }
}
