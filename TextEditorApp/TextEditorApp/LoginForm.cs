using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewUser newUser = new FormNewUser();
            newUser.Show();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;
            if(username == "" || password == "")
            {
                MessageBox.Show("Please input username and password");
            }
            else
            {
                Users user = new Users();
                User validUser = user.Login(username, password);
                if (validUser.Username != null)
                {
                    Idea mainForm = new Idea(validUser);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Combination or your username and password is wrong", "Credential is not valid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
