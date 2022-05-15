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

namespace ArtefactsManager.BusinessLogic
{
    public class CatalogService
    {
        private readonly ICategoryDAO categoryDAO;
        private readonly IArtefactDAO artefactDAO;
        private readonly IArtefactTypeDAO artefactTypeDAO;
        private readonly IAttributeDAO attributeDAO;
        private readonly IArtefactAttributeDAO artefactAttributeDAO;

        public CatalogService()
        {
            categoryDAO = new CategoryDAO();
            artefactDAO = new ArtefactDAO();
            artefactTypeDAO = new ArtefactTypeDAO();
            attributeDAO = new AttributeDAO();
            artefactAttributeDAO = new ArtefactAttributeDAO();
        }

        public IEnumerable<Category> getCategories()
        {
            return categoryDAO.GetAll();
        }

        public IEnumerable<ArtefactType> getTypesByCategory(int categoryId)
        {
            return artefactTypeDAO.GetByCategory(categoryId);
        }

        public DataTable getDataTable(int categoryId, int typeId)
        {
            List<Artefact> showingArtefacts = artefactDAO.GetByCategoryAndType(categoryId, typeId).ToList();
            DataTable dataTable = new DataTable();
            List<int> attributesId = new List<int>();
            var attributes = attributeDAO.GetByArtefactType(typeId);
            dataTable.Columns.Add("Id").ReadOnly = true;
            dataTable.Columns.Add("Name").ReadOnly = true;
            foreach (Data.Models.Attribute attribute in attributes)
            {
                dataTable.Columns.Add(attribute.Name).ReadOnly = true;
                attributesId.Add(attribute.AttributeId);
            }
            dataTable.Columns.Add("Created date").ReadOnly = true;
            DataRow tmp;
            foreach (Artefact artefact in showingArtefacts)
            {
                tmp = dataTable.NewRow();
                tmp["Id"] = artefact.ArtefactId;
                tmp["Name"] = artefact.Name;
                for (int i = 0; i < attributesId.Count; i++)
                {
                    tmp[attributeDAO.GetByArtefactType(typeId).ElementAt(i).Name] = artefactAttributeDAO.GetById(artefact.ArtefactId, attributesId[i]).Value;
                }
                tmp["Created date"] = artefact.Created;
                dataTable.Rows.Add(tmp);
            }
            return dataTable;
        }

        public void createButtonColumns(DataGridView dataGridView)
        {
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Text = "Delete";
            deleteBtn.UseColumnTextForButtonValue = true;
            dataGridView.Columns.Add(editBtn);
            dataGridView.Columns.Add(deleteBtn);
        }



        public void deleteArtefact(int artefactId)
        {
            artefactDAO.Delete(artefactId);
            artefactDAO.Save();
        }

    }
}
