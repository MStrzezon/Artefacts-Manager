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

        private void loadCategories()
        {
            categoriesBox.Items.Clear();
            foreach(Category c in catalog.getCategories())
            {
                categoriesBox.Items.Add(c.CategoryName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add addWindow = new Add();
            addWindow.ShowDialog();
            loadCategories();
        }


    }
}
