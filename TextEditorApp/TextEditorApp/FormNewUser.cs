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
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
            cmbUserType.SelectedIndex = 0;
            dtpDateOfBirth.Value = DateTime.Today;
            MessageBox.Show(DateTime.Today.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpDateOfBirth.Value.ToString());
            //this.Hide();
            //LoginForm loginForm = new LoginForm();
            //loginForm.Show();
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            if(txtUsernameCNU.Text != "" && txtPasswordCNU.Text != "" && txtRetypePasswordCNU.Text != "" && txtFirstnameCNU.Text != "" && txtLastnameCNU.Text != "")
            {
                if(txtPasswordCNU.Text == txtRetypePasswordCNU.Text)
                {
                    User newUser = new User(txtUsernameCNU.Text, txtPasswordCNU.Text, txtFirstnameCNU.Text, txtLastnameCNU.Text, cmbUserType.SelectedItem.ToString(), dtpDateOfBirth.Value);
                    Authentication auth = new Authentication();
                    string result = auth.createNewUser(newUser);
                    switch(result)
                    {
                        case "0":
                            MessageBox.Show("Create new user is success");
                            break;
                        case "1":
                            MessageBox.Show("Username has been exist, try another username");
                            break;
                        default:
                            MessageBox.Show(result);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Input password and retype password is not match");
                }
            }
            else
            {
                MessageBox.Show("Please complete the form field");
            }
        }
    }
}
