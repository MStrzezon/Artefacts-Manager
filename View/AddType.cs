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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            attributesList.Items.Add(AttributeBox.Text);
            AttributeBox.Clear();
        }

        private void attributesList_DoubleClick(object sender, EventArgs e)
        {
            int selectedIndex = attributesList.SelectedIndex;
            attributesList.Items.RemoveAt(selectedIndex);
        }
    }
}
