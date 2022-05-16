using ArtefactsManager.BusinessLogic;
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
        public UsersManagement()
        {
            InitializeComponent();
            usersManagementService = new UsersManagementService();
            loadUserData();
        }

        private void loadUserData()
        {
            usersManagementService = new UsersManagementService();
            dataGridViewUser.Columns.Clear();
            dataGridViewUser.DataSource = usersManagementService.loadUsers();
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Text = "Delete";
            deleteBtn.UseColumnTextForButtonValue = true;
            dataGridViewUser.Columns.Add(editBtn);
            dataGridViewUser.Columns.Add(deleteBtn);
            dataGridViewUser.Columns[0].Visible = false;
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddEditUser addUser = new AddEditUser(false, -1);
            addUser.ShowDialog();
        }


        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) // 2,3,0,1
                {
                    AddEditUser addEditUser = new AddEditUser(true, Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells[2].Value));
                    addEditUser.ShowDialog();
                    loadUserData();
                }
                else if (e.ColumnIndex == 1)
                {

                }
            }
        }
    }
}
