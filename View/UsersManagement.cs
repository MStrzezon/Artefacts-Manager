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
    public partial class UsersManagement : Form
    {
        private UsersManagementService usersManagementService;
        private RolesManagementService rolesManagementService;
        public UsersManagement()
        {
            InitializeComponent();
            loadUserData();
            loadRolesData();
        }

        private void loadUserData()
        {
            usersManagementService = new UsersManagementService();
            dataGridViewUser.Rows.Clear();
            foreach (User user in usersManagementService.getAllUsers())
            {
                dataGridViewUser.Rows.Add(user.UserId, user.Username, user.Role.RoleName, "Edit", "Delete");
            }
        }

        private void loadRolesData()
        {
            rolesManagementService = new RolesManagementService();
            dataGridViewRole.Rows.Clear();
            foreach (Role role in rolesManagementService.getAllRoles())
            {
                dataGridViewRole.Rows.Add(role.RoleId, role.RoleName, "Edit", "Delete");
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddEditUser addUser = new AddEditUser(false, -1);
            addUser.ShowDialog();
            loadUserData();
        }

        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            AddEditRole addEditRole = new AddEditRole(false, -1);
            addEditRole.ShowDialog();
            loadRolesData();
        }


        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3) 
                {
                    AddEditUser addEditUser = new AddEditUser(true, Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells[0].Value));
                    addEditUser.ShowDialog();
                }
                else if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("Are you want to delete user record?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        usersManagementService.deleteUser(Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells[0].Value));
                    }
                }
                loadUserData();
            }
        }

        private void dataGridViewRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 2) 
                {
                    AddEditRole addEditRole = new AddEditRole(true, Convert.ToInt32(dataGridViewRole.Rows[e.RowIndex].Cells[0].Value));
                    addEditRole.ShowDialog();
                }
                else if (e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Are you want to delete role record?", "Information", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        rolesManagementService.deleteRole(Convert.ToInt32(dataGridViewRole.Rows[e.RowIndex].Cells[0].Value));
                    }
                }
                loadUserData();
                loadRolesData();
            }
        }


    }
}
