using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.Home;

namespace ArtefactsManager.View
{
    public partial class Home : Form
    {
        private readonly HomeService homeService;
        public Home()
        {
            InitializeComponent();
            homeService = new HomeService();
            loadLastAdded();
        }

        private void loadLastAdded()
        {
            foreach (var artefact in homeService.Get5LastAddedArtefacts())
            {
                dataGridViewLast.Rows.Add(artefact.Name, artefact.Created.ToString());
            }
        }
    }
}
