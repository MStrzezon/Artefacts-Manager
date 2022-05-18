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
using ArtefactsManager.BusinessLogic.AdminPanel;

namespace ArtefactsManager.View
{
    public partial class AddEditUser : Form
    {
        AddEditUserService addEditUserService;
        User user;
        bool edit = false;
        public AddEditUser(bool theEdit, int userId)
        {
            InitializeComponent();
            addEditUserService = new AddEditUserService();
            if (theEdit)
            {
                edit = true;
                user = addEditUserService.getUserById(userId);
                loadUser();
            } else
            {
                usernameBox.Enabled = true;
                usernameBox.ReadOnly = false;
                showPassword();
                cancelBtn.Hide();
                loadRolesForAdd();
            }
        }

        private void loadUser()
        {
            usernameBox.Text = user.Username;
            foreach (Role role in addEditUserService.getRoles())
            {
                roleBox.Items.Add(role.RoleName);
                if (role.RoleName == user.Role.RoleName)
                {
                    roleBox.SelectedIndex = roleBox.Items.Count - 1;
                }
            }
        }

        private void loadRolesForAdd()
        {
            foreach (Role role in addEditUserService.getRoles())
            {
                roleBox.Items.Add(role.RoleName);
            }
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            showPassword();
        }

        private void showPassword()
        {
            changePassBtn.Hide();
            label3.Show();
            label4.Show();
            confirmBox.Show();
            passwordBox.Show();
            saveBtn.Show();
            cancelBtn.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            passwordBox.Clear();
            confirmBox.Clear();
            passwordBox.Hide();
            confirmBox.Hide();
            cancelBtn.Hide();
            label3.Hide();
            label4.Hide();
            changePassBtn.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            if (edit)
            {
                if (addEditUserService.validate(usernameBox.Text, passwordBox.Text, confirmBox.Text, !changePassBtn.Visible))
                {
                    if (!addEditUserService.updateUser(user, passwordBox.Text, roleBox.Text))
                    {
                        MessageBox.Show("Update failed");
                    } else
                    {
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Check your input data");
                }
            }
            else
            {
                if (addEditUserService.validate(usernameBox.Text, passwordBox.Text, confirmBox.Text))
                {
                    if (!addEditUserService.saveUser(usernameBox.Text, passwordBox.Text, roleBox.Text))
                    {
                        MessageBox.Show("Saving failed");
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
