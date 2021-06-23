
namespace DAT602_Assessment_Game
{
    partial class GameBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoardForm));
            this.sendBtn = new System.Windows.Forms.Button();
            this.chatInputBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leaveBtn = new System.Windows.Forms.Button();
            this.playerScoreTextBox = new System.Windows.Forms.TextBox();
            this.itemNumberTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.gameIDTextBox = new System.Windows.Forms.TextBox();
            this.gameNumberTextBox = new System.Windows.Forms.TextBox();
            this.tileLocationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chatListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.DarkRed;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendBtn.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(944, 602);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(89, 29);
            this.sendBtn.TabIndex = 13;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // chatInputBx
            // 
            this.chatInputBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatInputBx.Location = new System.Drawing.Point(838, 602);
            this.chatInputBx.Name = "chatInputBx";
            this.chatInputBx.Size = new System.Drawing.Size(100, 29);
            this.chatInputBx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(894, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "Items";
            // 
            // leaveBtn
            // 
            this.leaveBtn.BackColor = System.Drawing.Color.DarkRed;
            this.leaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leaveBtn.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaveBtn.ForeColor = System.Drawing.Color.White;
            this.leaveBtn.Location = new System.Drawing.Point(12, 602);
            this.leaveBtn.Name = "leaveBtn";
            this.leaveBtn.Size = new System.Drawing.Size(133, 34);
            this.leaveBtn.TabIndex = 28;
            this.leaveBtn.Text = "Leave Game";
            this.leaveBtn.UseVisualStyleBackColor = false;
            this.leaveBtn.Click += new System.EventHandler(this.leaveBtn_Click);
            // 
            // playerScoreTextBox
            // 
            this.playerScoreTextBox.Enabled = false;
            this.playerScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScoreTextBox.HideSelection = false;
            this.playerScoreTextBox.Location = new System.Drawing.Point(43, 199);
            this.playerScoreTextBox.Multiline = true;
            this.playerScoreTextBox.Name = "playerScoreTextBox";
            this.playerScoreTextBox.Size = new System.Drawing.Size(64, 28);
            this.playerScoreTextBox.TabIndex = 34;
            this.playerScoreTextBox.Text = "0";
            this.playerScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // itemNumberTeextBox
            // 
            this.itemNumberTextBox.Enabled = false;
            this.itemNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.itemNumberTextBox.HideSelection = false;
            this.itemNumberTextBox.Location = new System.Drawing.Point(43, 293);
            this.itemNumberTextBox.Multiline = true;
            this.itemNumberTextBox.Name = "itemNumberTeextBox";
            this.itemNumberTextBox.Size = new System.Drawing.Size(64, 28);
            this.itemNumberTextBox.TabIndex = 35;
            this.itemNumberTextBox.Text = "0";
            this.itemNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(-1, -1);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 36;
            // 
            // gameIDTextBox
            // 
            this.gameIDTextBox.Enabled = false;
            this.gameIDTextBox.Location = new System.Drawing.Point(-1, 25);
            this.gameIDTextBox.Name = "gameIDTextBox";
            this.gameIDTextBox.ReadOnly = true;
            this.gameIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameIDTextBox.TabIndex = 72;
            this.gameIDTextBox.Visible = false;
            // 
            // gameNumberTextBox
            // 
            this.gameNumberTextBox.Enabled = false;
            this.gameNumberTextBox.Location = new System.Drawing.Point(-1, 56);
            this.gameNumberTextBox.Name = "gameNumberTextBox";
            this.gameNumberTextBox.ReadOnly = true;
            this.gameNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.gameNumberTextBox.TabIndex = 73;
            this.gameNumberTextBox.Visible = false;
            // 
            // tileLocationTextBox
            // 
            this.tileLocationTextBox.Enabled = false;
            this.tileLocationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.tileLocationTextBox.HideSelection = false;
            this.tileLocationTextBox.Location = new System.Drawing.Point(41, 383);
            this.tileLocationTextBox.Multiline = true;
            this.tileLocationTextBox.Name = "tileLocationTextBox";
            this.tileLocationTextBox.Size = new System.Drawing.Size(64, 28);
            this.tileLocationTextBox.TabIndex = 79;
            this.tileLocationTextBox.Text = "0";
            this.tileLocationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 34);
            this.label6.TabIndex = 78;
            this.label6.Text = "Location";
            // 
            // chatListBox
            // 
            this.chatListBox.FormattingEnabled = true;
            this.chatListBox.Location = new System.Drawing.Point(848, 56);
            this.chatListBox.Name = "chatListBox";
            this.chatListBox.Size = new System.Drawing.Size(173, 524);
            this.chatListBox.TabIndex = 80;
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 648);
            this.ControlBox = false;
            this.Controls.Add(this.chatListBox);
            this.Controls.Add(this.tileLocationTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gameNumberTextBox);
            this.Controls.Add(this.gameIDTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.itemNumberTextBox);
            this.Controls.Add(this.playerScoreTextBox);
            this.Controls.Add(this.leaveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.chatInputBx);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox chatInputBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button leaveBtn;
        private System.Windows.Forms.TextBox tileLocationTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ListBox chatListBox;
        public System.Windows.Forms.TextBox usernameTextBox;
        public System.Windows.Forms.TextBox gameIDTextBox;
        public System.Windows.Forms.TextBox gameNumberTextBox;
        public System.Windows.Forms.TextBox playerScoreTextBox;
        public System.Windows.Forms.TextBox itemNumberTextBox;
    }
}