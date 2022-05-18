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
    public partial class AddArtefact : Form
    {
        private readonly CategoryService categoryService;
        private readonly ElementService elementService;
        private readonly CatalogService catalogService;
        public AddArtefact()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            elementService = new ElementService();
            catalogService = new CatalogService();
            loadtypes();
            loadCategories();
        }

        private void loadCategories()
        {
            categoryBox.Items.Clear();
            categoryBox.Tag = elementService.getCategories();
            foreach (Category c in elementService.getCategories())
            {
                categoryBox.Items.Add(c.CategoryName);
            }
        }

        private void loadtypes()
        {
            typeBox.Items.Clear();
            typeBox.Tag = elementService.getTypes();
            foreach (ArtefactType artefactType in elementService.getTypes())
            {
                typeBox.Items.Add(artefactType.TypeName);
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (chooseBox.Items.Count > 0 && typeBox.Items.Count > 0)
            {
                chooseBox.SelectedIndex = 0;
                typeBox.SelectedIndex = 0;
            }
        }

        private void load_textBoxes()
        {
            flowLayoutPanel.Controls.Clear();
            TextBox[] textBoxes = elementService.loadTextBoxes(typeBox.Text).ToArray();
            Label[] labels = elementService.loadLabels(typeBox.Text).ToArray(); 
            for (int i = 0; i < labels.Length; i++)
            {
                flowLayoutPanel.Controls.Add(labels[i]);
                flowLayoutPanel.Controls.Add(textBoxes[i]);
            }
        }

        private void chooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseBox.SelectedIndex == 0)
            {
                panelCategory.Visible = true;
                panelElement.Visible = false;
                Size = new Size(380, 328);
                panelCategory.Location = new Point(44, 51);
            }
            else
            {
                panelCategory.Visible=false;
                panelElement.Visible=true;
                Size = new Size(444, 553);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (textBoxCategoryName.Text == "")
            {
                MessageBox.Show("Podaj nazwę kategorii.");
            }
            else if (categoryService.saveCategory(textBoxCategoryName.Text))
            {
                this.Close();
            } else
            {
                MessageBox.Show("Kategoria o podanej nazwie już istnieje.");
            }
        }

        private void AddType_Click(object sender, EventArgs e)
        {
            AddType addType = new AddType();
            addType.ShowDialog();
            loadtypes();
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_textBoxes();
        }

        private void btnSaveArtefact_Click(object sender, EventArgs e)
        {
            List<ArtefactType> artefactTypes = (List<ArtefactType>)typeBox.Tag;
            List<Category> categories = (List<Category>)categoryBox.Tag;
            Dictionary<Data.Models.Attribute, string> attributes = new Dictionary<Data.Models.Attribute, string>();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    attributes[(Data.Models.Attribute)control.Tag] = control.Text;
                }
            }
            elementService.saveElement(artefactTypes.ElementAt(typeBox.SelectedIndex), nameBox.Text, attributes, categories.ElementAt(categoryBox.SelectedIndex));
            this.Close();
        }
    }
}
