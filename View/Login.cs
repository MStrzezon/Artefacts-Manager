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
using ArtefactsManager.Utils;

namespace ArtefactsManager.View
{
    public partial class Login : Form
    {
        private Credentials credentials;
        private ArtefactsManager artefactsManager;
        public Login()
        {
            InitializeComponent();
            credentials = new Credentials();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                try
                {
                    if (credentials.validate(username.Text, password.Text))
                    {
                        artefactsManager = new ArtefactsManager();
                        this.Hide();
                        artefactsManager.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wprowadzono nie poprawne dane!");
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Database connection failure", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Application.Exit();
                }

            } else
            {
                MessageBox.Show("Wprowadź dane!");
            }

        }


    }
}
