using ArtefactsManager.BusinessLogic;
using ArtefactsManager.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtefactsManager.View
{
    public partial class Edit : Form
    {
        private readonly CategoryService categoryService;
        private readonly CatalogService catalogService;
        private readonly ElementService elementService;
        public Edit(Artefact artefact)
        {
            InitializeComponent();
            categoryService = new CategoryService();
            catalogService = new CatalogService();
            elementService = new ElementService();
            loadData(artefact);
        }

        private void loadData(Artefact artefact)
        {
            nameBox.Text = artefact.Name;
            loadCategories(artefact.Category.CategoryName);
            load_textBoxes(artefact);
        }

        private void loadCategories(string categoryName)
        {
            categoryBox.Items.Clear();
            categoryBox.Tag = catalogService.getCategories();
            foreach (Category c in catalogService.getCategories())
            {
                categoryBox.Items.Add(c.CategoryName);
                if (c.CategoryName == categoryName)
                {
                    categoryBox.SelectedIndex = categoryBox.Items.Count - 1;
                }
            }
        }

        private void load_textBoxes(Artefact artefact)
        {
            flowLayoutPanel.Controls.Clear();
            TextBox[] textBoxes = elementService.loadTextBoxes(artefact.ArtefactType.TypeName).ToArray();
            Label[] labels = elementService.loadLabels(artefact.ArtefactType.TypeName).ToArray();
            for (int i = 0; i < labels.Length; i++)
            {
                flowLayoutPanel.Controls.Add(labels[i]);
                flowLayoutPanel.Controls.Add(textBoxes[i]);
                textBoxes[i].Text = artefact.ArtefactAttributes.ElementAt(i).Value;
            }
        }
    }
}
