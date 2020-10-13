using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace TextEditorApp
{
    class Operation
    {
        RichTextBox mainEditor;
        String fileDirectory;

        public RichTextBox MainEditor { get => mainEditor; set => mainEditor = value; }
        public string FileDirectory { get => fileDirectory; set => fileDirectory = value; }

        public Operation(RichTextBox mainEditor)
        {
            MainEditor = new RichTextBox();
            MainEditor = mainEditor;
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
                    MainEditor.LoadFile(openFile.FileName);
                    FileDirectory = openFile.FileName;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            else
            {
                // Do nothing
            }
        }
        public void SaveFile()
        {
            if(FileDirectory != null)
            {
                try
                {
                    mainEditor.SaveFile(FileDirectory,RichTextBoxStreamType.RichNoOleObjs);
                    MessageBox.Show("File is saved", "Idea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception e)
                {
                    MessageBox.Show("Failed to save file: " + e.Message, "Idea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "RTF Files|*.rtf";
                DialogResult result = saveFile.ShowDialog();
                if(result == DialogResult.OK)
                {
                    try
                    {
                        string fileDirectory = saveFile.FileName;
                        FileDirectory = fileDirectory;
                        mainEditor.SaveFile(fileDirectory, RichTextBoxStreamType.RichNoOleObjs);
                        MessageBox.Show("File is saved", "Idea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Failed to save file: " + e.Message, "Idea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
        }
        public void SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "RTF Files|*.rtf";
            DialogResult result = saveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    string fileDirectory = saveFile.FileName;
                    FileDirectory = fileDirectory;
                    mainEditor.SaveFile(fileDirectory, RichTextBoxStreamType.RichNoOleObjs);
                    MessageBox.Show("File is saved", "Idea", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed to save file: " + e.Message, "Idea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void NewFile()
        {
            if(mainEditor.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Do you want to save current document?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                if(result == DialogResult.Yes)
                {
                    SaveFile();
                    mainEditor.Clear();
                    fileDirectory = null;
                }
                else if(result == DialogResult.No)
                {
                    mainEditor.Clear();
                    fileDirectory = null;
                }
                else
                {
                    // Do Nothing
                }
                
            }
            else
            {
                mainEditor.Clear();
                fileDirectory = null;
            }
            
        }
        public void Cut()
        {
            mainEditor.Cut();
        }
        public void Copy()
        {
            mainEditor.Copy();
        }
        public void Paste()
        {
            mainEditor.Paste();
        }
        public void FontSize(int fontSize)
        {
            if(mainEditor.SelectionFont == null)
            {
                mainEditor.SelectionFont = new Font("Tahoma", fontSize);
            }
            else
            {
                mainEditor.SelectionFont = new Font("Tahoma", fontSize, mainEditor.SelectionFont.Style);
            }
           
        }
        public void Bold()
        {

            if(mainEditor.SelectionFont != null)
            {
                if (mainEditor.SelectionFont.Bold == false)
                {
                    mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style | FontStyle.Bold);
                }
                else
                {
                    mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style & ~FontStyle.Bold);
                }
            }
            
           
        }
        public void Italic()
        {
            if (mainEditor.SelectionFont.Italic == false)
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style | FontStyle.Italic);
            }
            else
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style & ~FontStyle.Italic);
            }
        }
        public void Underline()
        {
            if (mainEditor.SelectionFont.Underline == false)
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style | FontStyle.Underline);
            }
            else
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, mainEditor.SelectionFont.Style & ~FontStyle.Underline);
            }
        }
       
    }
}
