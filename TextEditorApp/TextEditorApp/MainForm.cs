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
        public Idea(User user)
        {
            InitializeComponent();
            operation = new Operation(rtbMainEditor);
            tsCmbFontSize.SelectedIndex = 4;
            rtbMainEditor.ShortcutsEnabled = false;
            rtbMainEditor.KeyUp += new KeyEventHandler(rtbMainEditor_KeyDown);
            if (user.UserType.ToUpper() == "EDIT")
            {
                tsLblUsername.Text = "Username: " + user.Username + " (can edit)";
            }
            else
            {
                tsLblUsername.Text = "Username: " + user.Username + " (view only)";
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
            operation.SaveFile();
        }

        private void tsmItemOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsbBtnSave_Click(object sender, EventArgs e)
        {
            operation.SaveFile();
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
            operation.Bold();
        }

        private void tsBtnItalic_Click(object sender, EventArgs e)
        {
            operation.Italic();
        }

        private void tsMenuItemLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void stBtnSaveAs_Click(object sender, EventArgs e)
        {
            operation.SaveAs();
        }

        private void tsBtnNewFile_Click(object sender, EventArgs e)
        {
            operation.NewFile();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // Tool Tip
        }

        private void tsMenuItemAbout_Click(object sender, EventArgs e)
        {
            Form1 about = new Form1();
            about.Show();
        }

        private void Idea_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            
        }

        private void tsCmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            operation.FontSize(int.Parse(tsCmbFontSize.SelectedItem.ToString()));
        }

        private void tsBtnUnderline_Click(object sender, EventArgs e)
        {
            operation.Underline();
        }

        private void rtbMainEditor_KeyDown(object sender, KeyEventArgs e)
        {
            //Override default key shortcut
            if (e.Control == true && e.KeyCode == Keys.A)
            {
                rtbMainEditor.SelectAll();
                rtbMainEditor.Focus();
            }
            
        }

        private void Idea_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void tsmItemNewFile_Click(object sender, EventArgs e)
        {
            operation.OpenFile();
        }

        private void tsMenuItemSave_Click(object sender, EventArgs e)
        {
            operation.SaveFile();
        }

        private void tsMenuItemSaveAs_Click(object sender, EventArgs e)
        {
            operation.SaveAs();
        }

        private void tsMenuItemCut_Click(object sender, EventArgs e)
        {
            operation.Cut();
        }

        private void tsMenuItemCopy_Click(object sender, EventArgs e)
        {
            operation.Copy();
        }

        private void tsMenuItemPaste_Click(object sender, EventArgs e)
        {
            operation.Paste();
        }
    }
}

