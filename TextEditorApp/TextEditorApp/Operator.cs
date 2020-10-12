﻿using System;
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
                    FileDirectory = openFile.InitialDirectory;
                }
                catch (Exception e)
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
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "RTF Files|*.rtf";
            saveFile.InitialDirectory = FileDirectory;
            DialogResult result = saveFile.ShowDialog();

            Stream fileStream;
            if (result == DialogResult.OK)
            {
                try
                {
                    mainEditor.SaveFile(FileDirectory, RichTextBoxStreamType.RichText);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
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
        public void Bold()
        {
            if(mainEditor.SelectionLength > 0) {
                mainEditor.SelectionFont = new Font(mainEditor.Font, FontStyle.Bold);
            } 
            else
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, FontStyle.Bold | mainEditor.SelectionFont.Style);
            }
           
        }
        public void Italic()
        {
            if(mainEditor.SelectionLength > 0)
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, FontStyle.Italic | mainEditor.SelectionFont.Style);
            }
            else
            {
                mainEditor.SelectionFont = new Font(mainEditor.Font, System.Drawing.FontStyle.Italic);
            }
           
        }
        public void Underline()
        {
            mainEditor.SelectionFont = new Font(mainEditor.Font, System.Drawing.FontStyle.Underline);
        }
        public void Regular()
        {
            if (mainEditor.SelectionLength > 0)
            {
                mainEditor.SelectionFont = new Font(mainEditor.SelectionFont, FontStyle.Regular | mainEditor.SelectionFont.Style);
            }
            else
            {
                mainEditor.SelectionFont = new Font(mainEditor.Font, System.Drawing.FontStyle.Bold);
            }

        }
        public void BoldAndItalic()
        {
            mainEditor.SelectionFont = new Font(mainEditor.Font, FontStyle.Italic | mainEditor.SelectionFont.Style);
        }
    }
}