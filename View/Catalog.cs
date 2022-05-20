using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.Catalog;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.View
{
    public partial class Catalog : Form
    {
        private CatalogService catalogService;

        public Catalog()
        {
            InitializeComponent();
            dataGridView.CellContentClick += dgv_CellContentClick;
            catalogService = new CatalogService();
            loadCategories();
            categoriesBox.SelectedIndex = categoriesBox.Items.Count - 1;
            typeBox.SelectedIndex = 0;
        }

        private void loadCategories()
        {
            categoriesBox.Items.Clear();
            typeBox.Items.Clear();
            categoriesBox.Tag = catalogService.getCategories();
            foreach (Category c in catalogService.getCategories())
            {
                categoriesBox.Items.Add(c.CategoryName);
            }
            categoriesBox.Items.Add("All categories");
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                if (categoriesBox.SelectedIndex == categoriesBox.Items.Count - 1)
                {
                    loadTypes();
                }
                else
                {
                    loadTypesByCategory();
                }
            }
            else
            {
                if (categoriesBox.SelectedIndex == categoriesBox.Items.Count - 1)
                {
                    loadTypesByName(searchBox.Text);
                }
                else
                {
                    loadTypesByNameAndCategory(searchBox.Text);
                }
            }
        }


        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                if (categoriesBox.SelectedIndex == categoriesBox.Items.Count - 1)
                {
                    loadTableByType(((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
                }
                else
                {
                    loadTableByCategoryAndName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
                }
            }
            else
            {
                if (categoriesBox.SelectedIndex == categoriesBox.Items.Count - 1)
                {
                    loadTableByTypeAndName(((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId, searchBox.Text);
                }
                else
                {
                    loadTableByName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId, searchBox.Text);
                }
            }
            createButtonColumns();
        }


        private void refreshTable()
        {
            if (categoriesBox.SelectedIndex != -1 && typeBox.SelectedIndex != -1)
            {
                try
                {
                    loadTableByCategoryAndName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
                } catch (ArgumentOutOfRangeException ex)
                {
                    loadTableByType(((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
                }
                createButtonColumns();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddArtefact addWindow = new AddArtefact();
            addWindow.ShowDialog();
            refreshTable();
            searchBox.Text = String.Empty;
        }


        private void createButtonColumns()
        {
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            editBtn.Text = "Edit";
            deleteBtn.Text = "Delete";
            dataGridView.Columns.Add(editBtn);
            dataGridView.Columns.Add(deleteBtn);

            lockEditButton();
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView.Columns.Count - 2 && (string)dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count-2].Value == "Edit")
                {
                    catalogService = null;
                    EditArtefact edit = new EditArtefact(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
                    edit.ShowDialog();
                    catalogService = new CatalogService();
                    refreshTable();
                }
                else if (e.ColumnIndex == dataGridView.Columns.Count - 1 && (string)dataGridView.Rows[e.RowIndex].Cells[dataGridView.Columns.Count - 1].Value == "Delete")
                {
                    if (MessageBox.Show("Are you want to delete student record?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        catalogService.deleteArtefact(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
                        dataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string typeName = getTypeName();
            string categoryName = getCategoryName();
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                dataGridView.Refresh();
                loadCategories();
                setCategoryIndex(categoryName);
                if (categoriesBox.SelectedIndex == categoriesBox.Items.Count - 1)
                {
                    loadTypes();
                }
                else
                {
                    loadTypesByCategory();
                }
                setTypeIndex(typeName);
            }
            else
            {
                categoriesBox.Items.Clear();
                typeBox.Items.Clear();
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                loadCategoriesByName(searchBox.Text);
                loadTypesByName(searchBox.Text);
                if (categoryName != null)
                {
                    setCategoryIndex(categoryName);
                }
                if (typeName != null)
                {
                    setTypeIndex(typeName);
                }
            }
        }

        private string getCategoryName()
        {
            if (categoriesBox.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                return categoriesBox.Items[categoriesBox.SelectedIndex].ToString();
            }
        }

        private string getTypeName()
        {
            if (typeBox.SelectedIndex == -1)
            {
                return null;
            }
            else
            {
                return typeBox.Items[typeBox.SelectedIndex].ToString();
            }
        }

        private void setCategoryIndex(string categoryName)
        {
            categoriesBox.SelectedIndex = categoriesBox.Items.IndexOf(categoryName);
        }

        private void setTypeIndex(string typeName)
        {
            if (typeName == null)
            {
                typeBox.SelectedIndex = 0;
            } else
            {
                typeBox.SelectedIndex = typeBox.Items.IndexOf((typeName));
            }
        }

        private void loadCategoriesByName(string name)
        {
            categoriesBox.Tag = catalogService.getCategoriesByArtefactName(name).ToList();
            foreach (Category category in catalogService.getCategoriesByArtefactName(name))
            {
                categoriesBox.Items.Add(category.CategoryName);
            }
            categoriesBox.Items.Add("All categories");
        }

        private void loadTypesByCategory()
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId);
            foreach (ArtefactType type in catalogService.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }

        private void loadTypes()
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypes();
            foreach (ArtefactType type in catalogService.getTypes())
            {
                typeBox.Items.Add(type.TypeName);
            }
        }


        private void loadTypesByName(string name)
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypesByArtefactName(name);
            foreach (ArtefactType type in catalogService.getTypesByArtefactName(name))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }

        private void loadTypesByNameAndCategory(string name)
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypesByCategoryAndArtefactName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, name);
            foreach (ArtefactType type in catalogService.getTypesByCategoryAndArtefactName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, name))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }


        private void loadTableByCategoryAndName(int categoryId, int typeId)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTable(categoryId, typeId);
            dataGridView.Columns[0].Visible = false;
        }

        private void loadTableByName(int categoryId, int typeId, string name)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTableByName(categoryId, typeId, name);
            dataGridView.Columns[0].Visible = false;
        }

        private void loadTableByType(int typeId)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTableByType(typeId);
            dataGridView.Columns[0].Visible = false;
        }

        private void loadTableByTypeAndName(int typeId, string name)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTableByTypeAndName(typeId, name);
            dataGridView.Columns[0].Visible = false;
        }

        private void lockEditButton()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (catalogService.getEditableArtefacts().Select(a => a.ArtefactId).Contains(Convert.ToInt32(row.Cells[0].Value)))
                {
                    ((DataGridViewButtonCell)row.Cells[dataGridView.Columns.Count - 2]).Value = "Edit";
                }
                if (catalogService.getRemovableArtefacts().Select(a => a.ArtefactId).Contains(Convert.ToInt32(row.Cells[0].Value)))
                {
                    ((DataGridViewButtonCell)row.Cells[dataGridView.Columns.Count - 1]).Value = "Delete";
                }
            }
        }

        private void Catalog_Shown(object sender, EventArgs e)
        {
            typeBox_SelectedIndexChanged(null, null);
        }
    }
}

