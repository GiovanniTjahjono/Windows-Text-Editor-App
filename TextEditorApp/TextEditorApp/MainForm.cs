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
    public partial class Idea : Form
    {
        private Operation operation;
        public Idea(String userType, String username)
        {
            InitializeComponent();
            operation = new Operation(rtbMainEditor);
            if(userType.ToUpper() == "EDIT")
            {
                tsLblUsername.Text = "Username: " + username + " (can edit)";
            }
            else
            {
                tsLblUsername.Text = "Username: " + username + " (view only)";
                tsbBtnSave.Enabled = false;
                stBtnSaveAs.Enabled = false;
                tsBtnNewFile.Enabled = false;
                tsBtnBoldText.Enabled = false;
                tsBtnItalic.Enabled = false;
                tsBtnUnderline.Enabled = false;
                tsCmbFontSize.Enabled = false;
                tsBtnCut.Enabled = false;
                tsBtnCopy.Enabled = false;
                tsBtnPaste.Enabled = false;
                tsmItemNewFile.Enabled = false;
                tsMenuItemSave.Enabled = false;
                tsMenuItemSaveAs.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                toolStrip2.Enabled = false;

                rtbMainEditor.ReadOnly = true;
            }
            

        }

        private void stBtnOpenFile_Click(object sender, EventArgs e)
        {
            
            operation.OpenFile();
        }
        public void NewFile()
        {
            
        }
        public void OpenFile()
        {
            //Open the file
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open rich text file";
            openFile.DefaultExt = "*.rtf";
            openFile.Filter = "RTF Files|*.rtf";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    rtbMainEditor.LoadFile(openFile.FileName);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
            else
            {
                MessageBox.Show("salah");
            }
            
        }
        public void SaveFile()
        {

        }

        private void tsmItemOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsbBtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(operation.SaveFile());
        }

        private void tsBtnCut_Click(object sender, EventArgs e)
        {
            operation.Cut();
        }

        private void tsBtnCopy_Click(object sender, EventArgs e)
        {
            operation.Copy();
        }

        private void tsBtnPaste_Click(object sender, EventArgs e)
        {
            operation.Paste();
        }

        private void tsBtnBoldText_Click(object sender, EventArgs e)
        {
            if(!tsBtnBoldText.Checked)
            {
                operation.Bold();
                tsBtnBoldText.Checked = true;
            }
            else
            {
                operation.Regular();
                tsBtnBoldText.Checked = false;
            }
        }

        private void tsBtnItalic_Click(object sender, EventArgs e)
        {
            if(!tsBtnItalic.Checked)
            {
                operation.Italic(); 
                tsBtnItalic.Checked = true;
            }
            else
            {
                operation.Regular();
                tsBtnItalic.Checked = false;
            }
        }

        private void tsMenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void stBtnSaveAs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(operation.SaveAs());
        }

        private void tsBtnNewFile_Click(object sender, EventArgs e)
        {
            operation.NewFile();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // Tool Tip
        }
    }
}
