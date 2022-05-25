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
    public partial class ArtefactsManager : Form
    {
        private Form activeForm;
        private Button currentButton;

        public ArtefactsManager()
        {
            InitializeComponent();
            OpenChildForm(new Home(), null);
            loadProperMenu();
        }

        private void loadProperMenu()
        {
            if (LoggedUser.userRoleName == "admin")
            {
                btnManagement.Visible = true;
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Turquoise;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 11.0F);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control control in panelMenu.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.DarkSlateGray;
                    control.Font = new Font("Microsoft Sans Serif", 10.0F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;

        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Catalog(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Account(), sender);
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            DisableButton();
            OpenChildForm(new Home(), sender);
        }

        private void ArtefactsManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new AdminPanel(), sender);   
        }
    }
}
