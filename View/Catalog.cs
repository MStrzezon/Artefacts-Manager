using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic;
using ArtefactsManager.Data.Models;

namespace ArtefactsManager.View
{
    public partial class Catalog : Form
    {
        private readonly CatalogService catalogService;

        public Catalog()
        {
            InitializeComponent();
            dataGridView.CellContentClick += dgv_CellContentClick;
            catalogService = new CatalogService();
            loadCategories();
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
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                loadTypes();
            }
            else
            {
                loadTypesByName(searchBox.Text);
            }
        }

        private void loadTypes()
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId);
            foreach (ArtefactType type in catalogService.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }
        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                loadTable(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
            } else
            {
                loadTableByName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId, searchBox.Text);
            }
            createButtonColumns();
        }

        private void loadTable(int categoryId, int typeId)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTable(categoryId, typeId);
            dataGridView.Columns[0].Visible = false;
        }

        private void refreshTable()
        {
            if (categoriesBox.SelectedIndex != -1 && typeBox.SelectedIndex != -1)
            {
                loadTable(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
                createButtonColumns();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add addWindow = new Add();
            addWindow.ShowDialog();
            refreshTable();
        }


        private void createButtonColumns()
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


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                if (e.ColumnIndex == dataGridView.Columns.Count-2)
                {
                    Edit edit = new Edit(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
                    edit.ShowDialog();
                }
                else if (e.ColumnIndex == dataGridView.Columns.Count-1)
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
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                dataGridView.Refresh();
                loadCategories();
            } else
            {
                categoriesBox.Items.Clear();
                typeBox.Items.Clear();
                dataGridView.DataSource = null;
                dataGridView.Columns.Clear();
                loadCategoriesByName(searchBox.Text);
            }
        }

        private void loadCategoriesByName(string name)
        {
            categoriesBox.Tag = catalogService.getCategoriesByArtefactName(name).ToList();
            foreach (Category category in catalogService.getCategoriesByArtefactName(name))
            {
                categoriesBox.Items.Add(category.CategoryName);
            }
        }

        private void loadTypesByName(string name)
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalogService.getTypesByCategoryAndArtefactName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, name);
            foreach (ArtefactType type in catalogService.getTypesByCategoryAndArtefactName(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, name))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }

        private void loadTableByName(int categoryId, int typeId, string name)
        {
            dataGridView.Columns.Clear();
            dataGridView.Refresh();
            dataGridView.DataSource = catalogService.getDataTableByName(categoryId, typeId, name);
            dataGridView.Columns[0].Visible = false;
        }
    }
}
