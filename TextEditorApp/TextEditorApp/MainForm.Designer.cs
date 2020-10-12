namespace TextEditorApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsMenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnNewFile = new System.Windows.Forms.ToolStripButton();
            this.stBtnOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbBtnSave = new System.Windows.Forms.ToolStripButton();
            this.stBtnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnBoldText = new System.Windows.Forms.ToolStripButton();
            this.tsBtnItalic = new System.Windows.Forms.ToolStripButton();
            this.tsBtnUnderline = new System.Windows.Forms.ToolStripButton();
            this.tsCmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.tsLblUsername = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsBtnCut = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tsBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.rtbMainEditor = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Checked = true;
            this.fileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItemNewFile,
            this.tsmItemOpenFile,
            this.toolStripSeparator1,
            this.tsMenuItemSave,
            this.tsMenuItemSaveAs,
            this.toolStripSeparator2,
            this.tsMenuItemLogout});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmItemNewFile
            // 
            this.tsmItemNewFile.Image = global::TextEditorApp.Properties.Resources.new_file;
            this.tsmItemNewFile.Name = "tsmItemNewFile";
            this.tsmItemNewFile.Size = new System.Drawing.Size(224, 26);
            this.tsmItemNewFile.Tag = "";
            this.tsmItemNewFile.Text = "New           Ctrl + N";
            this.tsmItemNewFile.ToolTipText = "New File";
            // 
            // tsmItemOpenFile
            // 
            this.tsmItemOpenFile.Image = global::TextEditorApp.Properties.Resources.open;
            this.tsmItemOpenFile.Name = "tsmItemOpenFile";
            this.tsmItemOpenFile.Size = new System.Drawing.Size(224, 26);
            this.tsmItemOpenFile.Text = "Open          Ctrl + O";
            this.tsmItemOpenFile.ToolTipText = "Open File";
            this.tsmItemOpenFile.Click += new System.EventHandler(this.tsmItemOpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // tsMenuItemSave
            // 
            this.tsMenuItemSave.Image = global::TextEditorApp.Properties.Resources.save;
            this.tsMenuItemSave.Name = "tsMenuItemSave";
            this.tsMenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemSave.Text = "Save           Ctrl + S";
            // 
            // tsMenuItemSaveAs
            // 
            this.tsMenuItemSaveAs.Image = global::TextEditorApp.Properties.Resources.save_as;
            this.tsMenuItemSaveAs.Name = "tsMenuItemSaveAs";
            this.tsMenuItemSaveAs.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemSaveAs.Text = "Save As";
            this.tsMenuItemSaveAs.ToolTipText = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // tsMenuItemLogout
            // 
            this.tsMenuItemLogout.Image = global::TextEditorApp.Properties.Resources.logout;
            this.tsMenuItemLogout.Name = "tsMenuItemLogout";
            this.tsMenuItemLogout.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemLogout.Text = "Logout";
            this.tsMenuItemLogout.Click += new System.EventHandler(this.tsMenuItemLogout_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemCut,
            this.tsMenuItemCopy,
            this.tsMenuItemPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // tsMenuItemCut
            // 
            this.tsMenuItemCut.Image = global::TextEditorApp.Properties.Resources.cut;
            this.tsMenuItemCut.Name = "tsMenuItemCut";
            this.tsMenuItemCut.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemCut.Text = "Cut        Ctrl + X";
            // 
            // tsMenuItemCopy
            // 
            this.tsMenuItemCopy.Image = global::TextEditorApp.Properties.Resources.copy;
            this.tsMenuItemCopy.Name = "tsMenuItemCopy";
            this.tsMenuItemCopy.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemCopy.Text = "Copy     Ctrl + C";
            // 
            // tsMenuItemPaste
            // 
            this.tsMenuItemPaste.Image = global::TextEditorApp.Properties.Resources.paste;
            this.tsMenuItemPaste.Name = "tsMenuItemPaste";
            this.tsMenuItemPaste.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemPaste.Text = "Paste     Ctrl + X";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tsMenuItemAbout
            // 
            this.tsMenuItemAbout.Image = global::TextEditorApp.Properties.Resources.about;
            this.tsMenuItemAbout.Name = "tsMenuItemAbout";
            this.tsMenuItemAbout.Size = new System.Drawing.Size(224, 26);
            this.tsMenuItemAbout.Text = "About";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnNewFile,
            this.stBtnOpenFile,
            this.tsbBtnSave,
            this.stBtnSaveAs,
            this.toolStripSeparator3,
            this.tsBtnBoldText,
            this.tsBtnItalic,
            this.tsBtnUnderline,
            this.tsCmbFontSize,
            this.toolStripButton8,
            this.tsLblUsername});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnNewFile
            // 
            this.tsBtnNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNewFile.Image = global::TextEditorApp.Properties.Resources.new_file;
            this.tsBtnNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNewFile.Name = "tsBtnNewFile";
            this.tsBtnNewFile.Size = new System.Drawing.Size(29, 25);
            this.tsBtnNewFile.Text = "New FIle";
            this.tsBtnNewFile.ToolTipText = "New File";
            // 
            // stBtnOpenFile
            // 
            this.stBtnOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stBtnOpenFile.Image = global::TextEditorApp.Properties.Resources.open;
            this.stBtnOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnOpenFile.Name = "stBtnOpenFile";
            this.stBtnOpenFile.Size = new System.Drawing.Size(29, 25);
            this.stBtnOpenFile.Text = "Open File";
            this.stBtnOpenFile.Click += new System.EventHandler(this.stBtnOpenFile_Click);
            // 
            // tsbBtnSave
            // 
            this.tsbBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBtnSave.Image = global::TextEditorApp.Properties.Resources.save;
            this.tsbBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBtnSave.Name = "tsbBtnSave";
            this.tsbBtnSave.Size = new System.Drawing.Size(29, 25);
            this.tsbBtnSave.Text = "Save";
            this.tsbBtnSave.Click += new System.EventHandler(this.tsbBtnSave_Click);
            // 
            // stBtnSaveAs
            // 
            this.stBtnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stBtnSaveAs.Image = global::TextEditorApp.Properties.Resources.save_as;
            this.stBtnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stBtnSaveAs.Name = "stBtnSaveAs";
            this.stBtnSaveAs.Size = new System.Drawing.Size(29, 25);
            this.stBtnSaveAs.Text = "Save As";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // tsBtnBoldText
            // 
            this.tsBtnBoldText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBoldText.Image = global::TextEditorApp.Properties.Resources.bold;
            this.tsBtnBoldText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBoldText.Name = "tsBtnBoldText";
            this.tsBtnBoldText.Size = new System.Drawing.Size(29, 25);
            this.tsBtnBoldText.Text = "Bold Text";
            this.tsBtnBoldText.Click += new System.EventHandler(this.tsBtnBoldText_Click);
            // 
            // tsBtnItalic
            // 
            this.tsBtnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnItalic.Image = global::TextEditorApp.Properties.Resources.italic;
            this.tsBtnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnItalic.Name = "tsBtnItalic";
            this.tsBtnItalic.Size = new System.Drawing.Size(29, 25);
            this.tsBtnItalic.Text = "Italic";
            this.tsBtnItalic.Click += new System.EventHandler(this.tsBtnItalic_Click);
            // 
            // tsBtnUnderline
            // 
            this.tsBtnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnUnderline.Image = global::TextEditorApp.Properties.Resources.underline;
            this.tsBtnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnUnderline.Name = "tsBtnUnderline";
            this.tsBtnUnderline.Size = new System.Drawing.Size(29, 25);
            this.tsBtnUnderline.Text = "Underline";
            // 
            // tsCmbFontSize
            // 
            this.tsCmbFontSize.Name = "tsCmbFontSize";
            this.tsCmbFontSize.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::TextEditorApp.Properties.Resources.icons8_help_48;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 25);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // tsLblUsername
            // 
            this.tsLblUsername.Name = "tsLblUsername";
            this.tsLblUsername.Size = new System.Drawing.Size(108, 25);
            this.tsLblUsername.Text = "Username: jasa";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnCut,
            this.tsBtnCopy,
            this.tsBtnPaste});
            this.toolStrip2.Location = new System.Drawing.Point(0, 56);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(30, 394);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsBtnCut
            // 
            this.tsBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCut.Image = global::TextEditorApp.Properties.Resources.cut;
            this.tsBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCut.Name = "tsBtnCut";
            this.tsBtnCut.Size = new System.Drawing.Size(27, 24);
            this.tsBtnCut.Text = "Cut";
            this.tsBtnCut.Click += new System.EventHandler(this.tsBtnCut_Click);
            // 
            // tsBtnCopy
            // 
            this.tsBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCopy.Image = global::TextEditorApp.Properties.Resources.copy;
            this.tsBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCopy.Name = "tsBtnCopy";
            this.tsBtnCopy.Size = new System.Drawing.Size(27, 24);
            this.tsBtnCopy.Text = "Copy";
            this.tsBtnCopy.ToolTipText = "Copy";
            this.tsBtnCopy.Click += new System.EventHandler(this.tsBtnCopy_Click);
            // 
            // tsBtnPaste
            // 
            this.tsBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnPaste.Image = global::TextEditorApp.Properties.Resources.paste;
            this.tsBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnPaste.Name = "tsBtnPaste";
            this.tsBtnPaste.Size = new System.Drawing.Size(27, 24);
            this.tsBtnPaste.Text = "Paste";
            this.tsBtnPaste.Click += new System.EventHandler(this.tsBtnPaste_Click);
            // 
            // rtbMainEditor
            // 
            this.rtbMainEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMainEditor.Location = new System.Drawing.Point(33, 59);
            this.rtbMainEditor.Name = "rtbMainEditor";
            this.rtbMainEditor.Size = new System.Drawing.Size(755, 379);
            this.rtbMainEditor.TabIndex = 3;
            this.rtbMainEditor.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbMainEditor);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmItemNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmItemOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnNewFile;
        private System.Windows.Forms.ToolStripButton stBtnOpenFile;
        private System.Windows.Forms.ToolStripButton tsbBtnSave;
        private System.Windows.Forms.ToolStripButton stBtnSaveAs;
        private System.Windows.Forms.ToolStripButton tsBtnBoldText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnItalic;
        private System.Windows.Forms.ToolStripButton tsBtnUnderline;
        private System.Windows.Forms.ToolStripComboBox tsCmbFontSize;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel tsLblUsername;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsBtnCut;
        private System.Windows.Forms.ToolStripButton tsBtnCopy;
        private System.Windows.Forms.ToolStripButton tsBtnPaste;
        private System.Windows.Forms.RichTextBox rtbMainEditor;
    }
}