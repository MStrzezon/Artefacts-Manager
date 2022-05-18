using ArtefactsManager.BusinessLogic.UserAccount;
using ArtefactsManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtefactsManager.BusinessLogic.Login;

namespace ArtefactsManager.View
{
    public partial class Account : Form
    {
        AccountService accountService = new AccountService();
        public Account()
        {
            InitializeComponent();
            usernameBox.Text = LoggedUser.Username;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            btnPassword.Hide();
            label3.Show();
            label4.Show();
            confirmBox.Show();
            passwordBox.Show();
            saveBtn.Show();
            cancelBtn.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearAll();
            hideAll();
        }

        private void clearAll()
        {
            confirmBox.Text = "";
            passwordBox.Text = "";
        }

        private void hideAll()
        {
            btnPassword.Show();
            label3.Hide();
            label4.Hide();
            confirmBox.Hide();
            passwordBox.Hide();
            saveBtn.Hide();
            cancelBtn.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (accountService.validate(passwordBox.Text, confirmBox.Text)) {
                if (accountService.Save(passwordBox.Text))
                {
                    MessageBox.Show("Password changed successfully.");
                    clearAll();
                    hideAll();
                }
            } else
            {
                MessageBox.Show("Check the entered data");
            }
        }
    }
}
