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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
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
    }
}
