namespace TextEditorApp
{
    partial class FormNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewUser));
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPasswordCNU = new System.Windows.Forms.TextBox();
            this.txtUsernameCNU = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRetypePassword = new System.Windows.Forms.Label();
            this.txtRetypePasswordCNU = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstnameCNU = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtLastnameCNU = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(166, 444);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(125, 23);
            this.btnCreateNewUser.TabIndex = 14;
            this.btnCreateNewUser.Text = "Create New User";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(141, 183);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 25);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Create New User";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(91, 254);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(87, 223);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // txtPasswordCNU
            // 
            this.txtPasswordCNU.Location = new System.Drawing.Point(166, 251);
            this.txtPasswordCNU.Name = "txtPasswordCNU";
            this.txtPasswordCNU.PasswordChar = '*';
            this.txtPasswordCNU.Size = new System.Drawing.Size(125, 22);
            this.txtPasswordCNU.TabIndex = 10;
            // 
            // txtUsernameCNU
            // 
            this.txtUsernameCNU.Location = new System.Drawing.Point(166, 223);
            this.txtUsernameCNU.Name = "txtUsernameCNU";
            this.txtUsernameCNU.Size = new System.Drawing.Size(125, 22);
            this.txtUsernameCNU.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(166, 473);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRetypePassword
            // 
            this.lblRetypePassword.AutoSize = true;
            this.lblRetypePassword.Location = new System.Drawing.Point(42, 282);
            this.lblRetypePassword.Name = "lblRetypePassword";
            this.lblRetypePassword.Size = new System.Drawing.Size(118, 17);
            this.lblRetypePassword.TabIndex = 17;
            this.lblRetypePassword.Text = "Retype Password";
            // 
            // txtRetypePasswordCNU
            // 
            this.txtRetypePasswordCNU.Location = new System.Drawing.Point(166, 279);
            this.txtRetypePasswordCNU.Name = "txtRetypePasswordCNU";
            this.txtRetypePasswordCNU.PasswordChar = '*';
            this.txtRetypePasswordCNU.Size = new System.Drawing.Size(125, 22);
            this.txtRetypePasswordCNU.TabIndex = 16;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(91, 310);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(70, 17);
            this.lblFirstname.TabIndex = 19;
            this.lblFirstname.Text = "Firstname";
            // 
            // txtFirstnameCNU
            // 
            this.txtFirstnameCNU.Location = new System.Drawing.Point(166, 307);
            this.txtFirstnameCNU.Name = "txtFirstnameCNU";
            this.txtFirstnameCNU.Size = new System.Drawing.Size(125, 22);
            this.txtFirstnameCNU.TabIndex = 18;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(91, 338);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(70, 17);
            this.lblLastname.TabIndex = 21;
            this.lblLastname.Text = "Lastname";
            // 
            // txtLastnameCNU
            // 
            this.txtLastnameCNU.Location = new System.Drawing.Point(166, 335);
            this.txtLastnameCNU.Name = "txtLastnameCNU";
            this.txtLastnameCNU.Size = new System.Drawing.Size(125, 22);
            this.txtLastnameCNU.TabIndex = 20;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(73, 367);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(87, 17);
            this.lblDateOfBirth.TabIndex = 22;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Location = new System.Drawing.Point(86, 396);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(74, 17);
            this.lblUserType.TabIndex = 23;
            this.lblUserType.Text = "User Type";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(166, 364);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(125, 22);
            this.dtpDateOfBirth.TabIndex = 24;
            // 
            // cmbUserType
            // 
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Items.AddRange(new object[] {
            "Edit",
            "View"});
            this.cmbUserType.Location = new System.Drawing.Point(166, 393);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(125, 24);
            this.cmbUserType.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TextEditorApp.Properties.Resources.Untitled_1_01;
            this.pictureBox1.Location = new System.Drawing.Point(157, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 541);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.txtLastnameCNU);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstnameCNU);
            this.Controls.Add(this.lblRetypePassword);
            this.Controls.Add(this.txtRetypePasswordCNU);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPasswordCNU);
            this.Controls.Add(this.txtUsernameCNU);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormNewUser";
            this.Text = "Create New User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPasswordCNU;
        private System.Windows.Forms.TextBox txtUsernameCNU;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRetypePassword;
        private System.Windows.Forms.TextBox txtRetypePasswordCNU;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstnameCNU;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtLastnameCNU;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}