﻿using System;
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
    public partial class Add : Form
    {
        private readonly CategoryService categoryService;
        private readonly ElementService elementService;
        public Add()
        {
            InitializeComponent();
            categoryService = new CategoryService();
            elementService = new ElementService();
            loadtypes();
        }

        private void loadtypes()
        {
            TypeBox.Items.Clear();
            foreach (ArtefactType artefactType in elementService.getAllArtefactsTypes())
            {
                TypeBox.Items.Add(artefactType);
            }
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

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (categoryService.saveCategory(textBoxCategoryName.Text))
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
    }
}
