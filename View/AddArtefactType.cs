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
    public partial class AddArtefactType : Form
    {
        private readonly AddArtefactTypeService artefactTypeService;
        public AddArtefactType()
        {
            InitializeComponent();
            artefactTypeService = new AddArtefactTypeService();
        }

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            if (AttributeBox.Text != "" )
            {
                if (ListBox.NoMatches == attributesList.FindStringExact(AttributeBox.Text)) {
                    attributesList.Items.Add(AttributeBox.Text);
                    AttributeBox.Clear();
                } else
                {
                    MessageBox.Show("The attribute with that name has already been added.");
                }

            }

        }

        private void attributesList_DoubleClick(object sender, EventArgs e)
        {
            if (attributesList.Items.Count > 0 && attributesList.SelectedIndex != -1)
            {
                int selectedIndex = attributesList.SelectedIndex;
                attributesList.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (artefactTypeService.SaveType(textBoxCategoryName.Text, attributesList.Items))
            {
                this.Close();
            } else
            {
                MessageBox.Show("Upewnij się, że wszystkie pola zostały wypełnione oraz czy nie istnieje już taki typ.");
            }
        }
    }
}
