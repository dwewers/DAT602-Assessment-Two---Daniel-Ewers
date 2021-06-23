
namespace DAT602_Assessment_Game
{
    partial class AdminUpdateUserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdateUserForm));
            this.emailField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.passwordField = new System.Windows.Forms.TextBox();
            this.unlockAccCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailField
            // 
            this.emailField.BackColor = System.Drawing.Color.White;
            this.emailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailField.Location = new System.Drawing.Point(32, 135);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(136, 29);
            this.emailField.TabIndex = 39;
            this.emailField.Text = "Email";
            this.emailField.Enter += new System.EventHandler(this.EmailField_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "Edit User";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.confirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(65, 215);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 36);
            this.confirmBtn.TabIndex = 35;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.White;
            this.usernameField.Enabled = false;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.HideSelection = false;
            this.usernameField.Location = new System.Drawing.Point(32, 65);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(136, 29);
            this.usernameField.TabIndex = 34;
            this.usernameField.Text = "Username";
            this.usernameField.Enter += new System.EventHandler(this.UsernameField_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(575, -3);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 62);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.White;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(32, 100);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(136, 29);
            this.passwordField.TabIndex = 46;
            this.passwordField.Text = "Password";
            this.passwordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            // 
            // unlockAccCheckBox
            // 
            this.unlockAccCheckBox.AutoSize = true;
            this.unlockAccCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.unlockAccCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.unlockAccCheckBox.Location = new System.Drawing.Point(6, 14);
            this.unlockAccCheckBox.Name = "unlockAccCheckBox";
            this.unlockAccCheckBox.Size = new System.Drawing.Size(99, 17);
            this.unlockAccCheckBox.TabIndex = 44;
            this.unlockAccCheckBox.Text = "Account Status";
            this.unlockAccCheckBox.UseVisualStyleBackColor = false;
            this.unlockAccCheckBox.MouseHover += new System.EventHandler(this.UnlockAccCheckBox_MouseHover);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.adminCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminCheckBox.ForeColor = System.Drawing.Color.Transparent;
            this.adminCheckBox.Location = new System.Drawing.Point(111, 14);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(55, 17);
            this.adminCheckBox.TabIndex = 43;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = false;
            this.adminCheckBox.MouseHover += new System.EventHandler(this.AdminCheckBox_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.adminCheckBox);
            this.groupBox1.Controls.Add(this.unlockAccCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 39);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // AdminUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(629, 353);
            this.ControlBox = false;
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.emailField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminUpdateUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox emailField;
        public System.Windows.Forms.TextBox usernameField;
        public System.Windows.Forms.TextBox passwordField;
        public System.Windows.Forms.CheckBox unlockAccCheckBox;
        public System.Windows.Forms.CheckBox adminCheckBox;
    }
}