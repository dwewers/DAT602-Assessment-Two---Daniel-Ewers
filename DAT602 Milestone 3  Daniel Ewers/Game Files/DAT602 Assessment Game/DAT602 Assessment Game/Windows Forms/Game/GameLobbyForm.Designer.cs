
namespace DAT602_Assessment_Game
{
    partial class GameLobbyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameLobbyForm));
            this.closeBtn = new System.Windows.Forms.Button();
            this.joinBtn = new System.Windows.Forms.Button();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.characterCmbBox = new System.Windows.Forms.ComboBox();
            this.datagridViewActivePlayers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gameNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gamemodeCmbBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewActivePlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.DarkGreen;
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
            this.closeBtn.Location = new System.Drawing.Point(1064, -2);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(51, 62);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // joinBtn
            // 
            this.joinBtn.BackColor = System.Drawing.Color.DarkRed;
            this.joinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.joinBtn.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinBtn.ForeColor = System.Drawing.Color.White;
            this.joinBtn.Location = new System.Drawing.Point(113, 528);
            this.joinBtn.Margin = new System.Windows.Forms.Padding(2);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(144, 44);
            this.joinBtn.TabIndex = 14;
            this.joinBtn.Text = "Join Game";
            this.joinBtn.UseVisualStyleBackColor = false;
            this.joinBtn.Click += new System.EventHandler(this.JoinUsersGameButton_Click);
            // 
            // newGameBtn
            // 
            this.newGameBtn.BackColor = System.Drawing.Color.DarkRed;
            this.newGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newGameBtn.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameBtn.ForeColor = System.Drawing.Color.White;
            this.newGameBtn.Location = new System.Drawing.Point(936, 531);
            this.newGameBtn.Margin = new System.Windows.Forms.Padding(2);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(163, 38);
            this.newGameBtn.TabIndex = 16;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = false;
            this.newGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click_1);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Old English Text MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(0, -2);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(43, 44);
            this.refreshBtn.TabIndex = 18;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Active Players";
            // 
            // characterCmbBox
            // 
            this.characterCmbBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.characterCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.characterCmbBox.FormattingEnabled = true;
            this.characterCmbBox.Location = new System.Drawing.Point(936, 375);
            this.characterCmbBox.Name = "characterCmbBox";
            this.characterCmbBox.Size = new System.Drawing.Size(163, 21);
            this.characterCmbBox.TabIndex = 21;
            // 
            // datagridViewActivePlayers
            // 
            this.datagridViewActivePlayers.AllowUserToAddRows = false;
            this.datagridViewActivePlayers.AllowUserToDeleteRows = false;
            this.datagridViewActivePlayers.AllowUserToResizeColumns = false;
            this.datagridViewActivePlayers.AllowUserToResizeRows = false;
            this.datagridViewActivePlayers.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.datagridViewActivePlayers.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.datagridViewActivePlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagridViewActivePlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridViewActivePlayers.GridColor = System.Drawing.SystemColors.Control;
            this.datagridViewActivePlayers.Location = new System.Drawing.Point(12, 141);
            this.datagridViewActivePlayers.MultiSelect = false;
            this.datagridViewActivePlayers.Name = "datagridViewActivePlayers";
            this.datagridViewActivePlayers.ReadOnly = true;
            this.datagridViewActivePlayers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewActivePlayers.ShowCellErrors = false;
            this.datagridViewActivePlayers.ShowCellToolTips = false;
            this.datagridViewActivePlayers.ShowEditingIcon = false;
            this.datagridViewActivePlayers.ShowRowErrors = false;
            this.datagridViewActivePlayers.Size = new System.Drawing.Size(245, 382);
            this.datagridViewActivePlayers.TabIndex = 26;
            this.datagridViewActivePlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActivePlayers_CellClick);
            // 
            // Username
            // 
            this.Username.Cursor = System.Windows.Forms.Cursors.No;
            this.Username.Enabled = false;
            this.Username.Location = new System.Drawing.Point(0, 610);
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(934, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "Game Mode";
            // 
            // gameNumberTextBox
            // 
            this.gameNumberTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.gameNumberTextBox.Enabled = false;
            this.gameNumberTextBox.Location = new System.Drawing.Point(26, 552);
            this.gameNumberTextBox.Name = "gameNumberTextBox";
            this.gameNumberTextBox.ReadOnly = true;
            this.gameNumberTextBox.Size = new System.Drawing.Size(74, 20);
            this.gameNumberTextBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Game Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(948, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 38);
            this.label2.TabIndex = 33;
            this.label2.Text = "Character";
            // 
            // gamemodeCmbBox
            // 
            this.gamemodeCmbBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamemodeCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamemodeCmbBox.FormattingEnabled = true;
            this.gamemodeCmbBox.Location = new System.Drawing.Point(936, 455);
            this.gamemodeCmbBox.Name = "gamemodeCmbBox";
            this.gamemodeCmbBox.Size = new System.Drawing.Size(163, 21);
            this.gamemodeCmbBox.TabIndex = 34;
            // 
            // GameLobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 632);
            this.ControlBox = false;
            this.Controls.Add(this.gamemodeCmbBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gameNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.datagridViewActivePlayers);
            this.Controls.Add(this.characterCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameLobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewActivePlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button joinBtn;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox characterCmbBox;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gameNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gamemodeCmbBox;
        public System.Windows.Forms.DataGridView datagridViewActivePlayers;
    }
}