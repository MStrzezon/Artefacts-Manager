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
        private readonly UsersManagementService usersManagementService;
        public UsersManagement()
        {
            InitializeComponent();
            usersManagementService = new UsersManagementService();
            loadUserData();
        }

        private void loadUserData()
        {
            dataGridViewUser.DataSource = usersManagementService.loadUsers();
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;
            dataGridViewUser.Columns.Add(editBtn);
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}
