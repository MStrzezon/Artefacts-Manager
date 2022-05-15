﻿using System;
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

        public IEnumerable<Category> getCategoriesByArtefactName(string artefactName)
        {
            return categoryDAO.GetByArtefactName(artefactName);
        }

        public IEnumerable<ArtefactType> getTypesByCategoryAndArtefactName(int categoryId, string artefactName)
        {
            return artefactTypeDAO.GetByCategoryAndArtefactName(categoryId, artefactName);
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
                tmp["Name"] = artefact.Name;
                for (int i = 0; i < dataTable.Columns.Count - 3; i++)
                {
                    columnName = dataTable.Columns[i + 2].ColumnName;
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

    }
}
