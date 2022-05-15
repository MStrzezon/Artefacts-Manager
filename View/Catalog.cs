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
        private readonly CatalogService catalog;

        public Catalog()
        {
            InitializeComponent();
            catalog = new CatalogService();
            loadCategories();
        }

        private void loadTable(int categoryId, int typeId)
        {
            dataGridView.Columns.Clear();
            dataGridView.DataSource = catalog.getDataTable(categoryId, typeId);
            dataGridView.Columns[0].Visible = false;
        }

        private void loadCategories()
        {
            categoriesBox.Items.Clear();
            categoriesBox.Tag = catalog.getCategories();
            foreach(Category c in catalog.getCategories())
            {
                categoriesBox.Items.Add(c.CategoryName);
            }
        }

        private void loadTypes()
        {
            typeBox.Items.Clear();
            typeBox.Tag = catalog.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId);
            foreach (ArtefactType type in catalog.getTypesByCategory(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId))
            {
                typeBox.Items.Add(type.TypeName);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add addWindow = new Add();
            addWindow.ShowDialog();
            loadCategories();
        }

        private void categoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            loadTypes();
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTable(((List<Category>)categoriesBox.Tag).ElementAt(categoriesBox.SelectedIndex).CategoryId, ((List<ArtefactType>)typeBox.Tag).ElementAt(typeBox.SelectedIndex).ArtefactTypeId);
            catalog.createButtonColumns(dataGridView);
            dataGridView.CellContentClick += dgv_CellContentClick;
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
                        catalog.deleteArtefact(Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value));
                        dataGridView.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
