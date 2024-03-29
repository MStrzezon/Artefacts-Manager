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
using ArtefactsManager.BusinessLogic.AdminPanel;

namespace ArtefactsManager.View
{
    public partial class AddEditRole : Form
    {
        private Role role;
        private bool edit;
        private readonly AddEditRoleService addEditService;
        public AddEditRole(bool _edit, int roleId)
        {
            InitializeComponent();
            addEditService = new AddEditRoleService();
            if (_edit)
            {
                nameBox.ReadOnly = true;
                nameBox.Enabled = false;
                edit = _edit;
                role = addEditService.getRole(roleId);
                nameBox.Text = role.RoleName;
                loadPermissions();
            }
            loadCategories();
            loadTypes();
        }

        private void loadPermissions()
        {
            foreach (Permission permission in addEditService.getPermissionsForRole().ToList()) {
                dataGridViewPermissions.Rows.Add(permission.CategoryName, permission.TypeName, permission.Visible, permission.Editable, permission.Editable, "Delete");
            }
        }

        private void loadCategories()
        {
            foreach (Category category in addEditService.getCategories())
            {
                categoriesList.Items.Add(category.CategoryName);
            }
            categoriesList.Items.Add("All categories");
        }

        private void loadTypes()
        {
            foreach (ArtefactType artefactType in addEditService.getArtefactsTypes())
            {
                typesList.Items.Add(artefactType.TypeName);
            }
            typesList.Items.Add("All types");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!IsDuplicate())
            {
                dataGridViewPermissions.Rows.Add(categoriesList.Items[categoriesList.SelectedIndex].ToString(), typesList.Items[typesList.SelectedIndex].ToString(), visibleCheck.Checked, editableCheck.Checked, addCheck.Checked, "Delete");
            } else
            {
                MessageBox.Show("This row already exists!");
            }
        }

    private bool IsDuplicate()
    {
        for (int i = 0; i < dataGridViewPermissions.Rows.Count; i++)
        {
            if (categoriesList.Items[categoriesList.SelectedIndex].ToString() == dataGridViewPermissions.Rows[i].Cells[0].Value.ToString() && typesList.Items[typesList.SelectedIndex].ToString() == dataGridViewPermissions.Rows[i].Cells[1].Value.ToString() && visibleCheck.Checked == Convert.ToBoolean(dataGridViewPermissions.Rows[i].Cells[2].Value) && editableCheck.Checked == Convert.ToBoolean(dataGridViewPermissions.Rows[i].Cells[3].Value) &&  addCheck.Checked == Convert.ToBoolean(dataGridViewPermissions.Rows[i].Cells[4].Value))
            {
                return true;
            }
        }
        return false;
    }


    private void dataGridViewPermissions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    if (e.ColumnIndex == dataGridViewPermissions.Columns.Count - 1)
                    {
                        if (MessageBox.Show("Are you want to delete permission record?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            dataGridViewPermissions.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                addEditService.updateRole(dataGridViewPermissions.Rows);
                this.Close();

            } else
            {
                if (nameBox.Text == "") {
                    MessageBox.Show("Enter role name!");
                } else
                {
                    addEditService.addRole(nameBox.Text, dataGridViewPermissions.Rows);
                    this.Close();
                }
            }
        }
    }
}
