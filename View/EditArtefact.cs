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
using ArtefactsManager.BusinessLogic.Catalog;

namespace ArtefactsManager.View
{
    public partial class EditArtefact : Form
    {
        private readonly EditArtefactService editService;
        public EditArtefact(int artefactId)
        {
            InitializeComponent();
            editService = new EditArtefactService(artefactId);
            loadData();
        }

        private void loadData()
        {
            nameBox.Text = editService.getAttributeName();
            loadCategories();
            loadTextBoxes();
        }

        private void loadCategories()
        {
            categoryBox.Items.Clear();
            categoryBox.Tag = editService.getCategories();
            foreach (Category c in editService.getCategories())
            {
                categoryBox.Items.Add(c.CategoryName);
            }
            categoryBox.SelectedIndex = editService.getCurrentCategoryIndex();
        }

        private void loadTextBoxes()
        {
            flowLayoutPanel.Controls.Clear();
            TextBox[] textBoxes = loadTextBoxes(editService.getAttributes().ToList()).ToArray();
            Label[] labels = loadLabels(editService.getAttributes().ToList()).ToArray();
            for (int i = 0; i < labels.Length; i++)
            {
                flowLayoutPanel.Controls.Add(labels[i]);
                flowLayoutPanel.Controls.Add(textBoxes[i]);
            }
            int j = 0;
            foreach (string val in editService.getAttributesValues())
            {
                textBoxes[j++].Text = val; 
            }
        }

        private List<TextBox> loadTextBoxes(List<Data.Models.Attribute> attributes)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            TextBox tmpTextBox;
            int start = 27;
            foreach (var att in attributes)
            {
                tmpTextBox = new TextBox();
                tmpTextBox.Tag = att;
                tmpTextBox.Location = new Point(start, 10);
                textBoxes.Add(tmpTextBox);
                start += 30;
            }
            return textBoxes;
        }

        private List<Label> loadLabels(List<Data.Models.Attribute> attributes)
        {
            List<Label> labels = new List<Label>();
            Label tmpLabel;
            int start = 10;
            foreach (var att in attributes)
            {
                tmpLabel = new Label();
                tmpLabel.Text = att.Name;
                tmpLabel.Tag = att;
                tmpLabel.Location = new Point(start, 10);
                labels.Add(tmpLabel);
                start += 30;
            }
            return labels;
        }

        private void btnSaveArtefact_Click(object sender, EventArgs e)
        {
            if (editService.validateData(nameBox.Text, getAttributesValues())) {
                if (editService.UpdateArtefact(nameBox.Text, getAttributesValues(), categoryBox.SelectedIndex))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error while updating artefact", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Fields cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private IEnumerable<string> getAttributesValues()
        {
            List<string> attributes = new List<string>();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is TextBox)
                {
                    attributes.Add(((TextBox)control).Text);
                }
            }
            return attributes;
        }
    }
}
