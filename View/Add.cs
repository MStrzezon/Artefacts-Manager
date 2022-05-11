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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            chooseBox.SelectedIndex = 0;
        }

        private void chooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseBox.SelectedIndex == 0)
            {
                panelCategory.Visible = true;
                panelElement.Visible = false;
            } else
            {
                panelCategory.Visible=false;
                panelElement.Visible=true;
            }
        }
    }
}
