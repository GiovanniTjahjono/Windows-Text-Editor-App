using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
            cmbUserType.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Today;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
       
        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if(txtUsernameCNU.Text != "" && txtPasswordCNU.Text != "" && txtRetypePasswordCNU.Text != "" && txtFirstnameCNU.Text != "" && txtLastnameCNU.Text != "")
            {
                if(Convert.ToDateTime(dtpDateOfBirth.Value) <= DateTime.Today)
                {
                    if (txtPasswordCNU.Text == txtRetypePasswordCNU.Text)
                    {
                        User newUser = new User(txtUsernameCNU.Text, txtPasswordCNU.Text, txtFirstnameCNU.Text, txtLastnameCNU.Text, cmbUserType.SelectedItem.ToString(), dtpDateOfBirth.Value);
                        Users auth = new Users();
                        string result = auth.createNewUser(newUser);
                        switch (result)
                        {
                            case "0":
                                MessageBox.Show("Create new user is success", "New user is created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                Idea mainForm = new Idea(newUser);
                                mainForm.ShowDialog();
                                break;
                            case "1":
                                MessageBox.Show("Username has been exist, try another username", "Username is already exist", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtUsernameCNU.Focus();
                                txtUsernameCNU.SelectionStart = 0;
                                txtUsernameCNU.SelectionLength = txtUsernameCNU.Text.Length;
                                break;
                            default:
                                MessageBox.Show(result, "Errow Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtUsernameCNU.Focus();
                                txtUsernameCNU.SelectionStart = 0;
                                txtUsernameCNU.SelectionLength = txtUsernameCNU.Text.Length;
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input password and retype password is not match");
                        txtPasswordCNU.Focus();
                        txtPasswordCNU.Clear();
                        txtRetypePasswordCNU.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please input the date of birth smaller than today", "Date of Birth is wrong", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    dtpDateOfBirth.Focus();
                }
              
            }
            else
            {
                MessageBox.Show("Please complete the form field");
                txtUsernameCNU.Focus();
                txtUsernameCNU.SelectionStart = 0;
                txtUsernameCNU.SelectionLength = txtUsernameCNU.Text.Length;
            }
        }

        private void FormNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
