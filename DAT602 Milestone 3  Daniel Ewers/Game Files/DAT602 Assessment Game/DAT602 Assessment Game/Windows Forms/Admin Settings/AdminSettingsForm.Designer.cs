
namespace DAT602_Assessment_Game
{
    partial class AdminSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettingsForm));
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.resetScoreBtn = new System.Windows.Forms.Button();
            this.playerComboBx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.gameComboBx = new System.Windows.Forms.ComboBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.endGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.DarkRed;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBtn.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(24, 231);
            this.createBtn.Margin = new System.Windows.Forms.Padding(2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(128, 38);
            this.createBtn.TabIndex = 47;
            this.createBtn.Text = "Create Player";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.CreateBtn_Click_1);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.DarkRed;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(24, 186);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(128, 38);
            this.deleteBtn.TabIndex = 46;
            this.deleteBtn.Text = "Delete Player";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.DarkRed;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editBtn.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(24, 97);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(128, 38);
            this.editBtn.TabIndex = 45;
            this.editBtn.Text = "Edit Player";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // resetScoreBtn
            // 
            this.resetScoreBtn.BackColor = System.Drawing.Color.DarkRed;
            this.resetScoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetScoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetScoreBtn.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetScoreBtn.ForeColor = System.Drawing.Color.White;
            this.resetScoreBtn.Location = new System.Drawing.Point(24, 141);
            this.resetScoreBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetScoreBtn.Name = "resetScoreBtn";
            this.resetScoreBtn.Size = new System.Drawing.Size(128, 38);
            this.resetScoreBtn.TabIndex = 44;
            this.resetScoreBtn.Text = "Reset Scure";
            this.resetScoreBtn.UseVisualStyleBackColor = false;
            this.resetScoreBtn.Click += new System.EventHandler(this.ResetScoreBtn_Click_1);
            // 
            // playerComboBx
            // 
            this.playerComboBx.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerComboBx.FormattingEnabled = true;
            this.playerComboBx.Location = new System.Drawing.Point(8, 39);
            this.playerComboBx.Name = "playerComboBx";
            this.playerComboBx.Size = new System.Drawing.Size(152, 28);
            this.playerComboBx.TabIndex = 43;
            this.playerComboBx.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 34);
            this.label2.TabIndex = 42;
            this.label2.Text = "Player Controls";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(575, -3);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(51, 62);
            this.closeBtn.TabIndex = 41;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // gameComboBx
            // 
            this.gameComboBx.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameComboBx.FormattingEnabled = true;
            this.gameComboBx.Location = new System.Drawing.Point(434, 272);
            this.gameComboBx.Name = "gameComboBx";
            this.gameComboBx.Size = new System.Drawing.Size(184, 28);
            this.gameComboBx.TabIndex = 51;
            this.gameComboBx.Text = "Game";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.DarkRed;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetBtn.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Location = new System.Drawing.Point(526, 308);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(85, 38);
            this.resetBtn.TabIndex = 50;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // endGameBtn
            // 
            this.endGameBtn.BackColor = System.Drawing.Color.DarkRed;
            this.endGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endGameBtn.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameBtn.ForeColor = System.Drawing.Color.White;
            this.endGameBtn.Location = new System.Drawing.Point(432, 308);
            this.endGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(85, 38);
            this.endGameBtn.TabIndex = 49;
            this.endGameBtn.Text = "End";
            this.endGameBtn.UseVisualStyleBackColor = false;
            this.endGameBtn.Click += new System.EventHandler(this.EndGameBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 68);
            this.label1.TabIndex = 48;
            this.label1.Text = "Game \r\nControls";
            // 
            // AdminSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 357);
            this.ControlBox = false;
            this.Controls.Add(this.gameComboBx);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.endGameBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.resetScoreBtn);
            this.Controls.Add(this.playerComboBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button resetScoreBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button endGameBtn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox playerComboBx;
        public System.Windows.Forms.ComboBox gameComboBx;
    }
}