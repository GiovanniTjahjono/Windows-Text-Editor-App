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
                Authentication auth = new Authentication(username, password);
                if (auth.Login())
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Gagal");
                }
            }
            
            
        }
    }
}
