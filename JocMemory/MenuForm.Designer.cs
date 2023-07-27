namespace JocMemory
{
    partial class fMenu
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
            this.lTitle = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.btnHelpResults = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lCoins = new System.Windows.Forms.Label();
            this.lPlayerName = new System.Windows.Forms.Label();
            this.btnQuests = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(143, 98);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(499, 106);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Memory Cards";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSinglePlayer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(39, 263);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(150, 50);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.TabStop = false;
            this.btnSinglePlayer.Text = "SinglePlayer";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMultiPlayer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiPlayer.Location = new System.Drawing.Point(39, 334);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnMultiPlayer.TabIndex = 2;
            this.btnMultiPlayer.TabStop = false;
            this.btnMultiPlayer.Text = "MultiPlayer";
            this.btnMultiPlayer.UseVisualStyleBackColor = false;
            this.btnMultiPlayer.Click += new System.EventHandler(this.btnMultiPlayer_Click);
            // 
            // btnHelpResults
            // 
            this.btnHelpResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHelpResults.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpResults.Location = new System.Drawing.Point(39, 405);
            this.btnHelpResults.Name = "btnHelpResults";
            this.btnHelpResults.Size = new System.Drawing.Size(150, 50);
            this.btnHelpResults.TabIndex = 3;
            this.btnHelpResults.TabStop = false;
            this.btnHelpResults.Text = "Help/Results";
            this.btnHelpResults.UseVisualStyleBackColor = false;
            this.btnHelpResults.Click += new System.EventHandler(this.btnHelpResults_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(39, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lCoins
            // 
            this.lCoins.AutoSize = true;
            this.lCoins.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoins.Location = new System.Drawing.Point(39, 37);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(66, 27);
            this.lCoins.TabIndex = 5;
            this.lCoins.Text = "Coins:";
            // 
            // lPlayerName
            // 
            this.lPlayerName.AutoSize = true;
            this.lPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerName.Location = new System.Drawing.Point(649, 36);
            this.lPlayerName.Name = "lPlayerName";
            this.lPlayerName.Size = new System.Drawing.Size(0, 27);
            this.lPlayerName.TabIndex = 6;
            // 
            // btnQuests
            // 
            this.btnQuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuests.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuests.Location = new System.Drawing.Point(600, 407);
            this.btnQuests.Name = "btnQuests";
            this.btnQuests.Size = new System.Drawing.Size(150, 50);
            this.btnQuests.TabIndex = 7;
            this.btnQuests.TabStop = false;
            this.btnQuests.Text = "Quests";
            this.btnQuests.UseVisualStyleBackColor = false;
            this.btnQuests.Click += new System.EventHandler(this.btnQuests_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(600, 477);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.TabStop = false;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnQuests);
            this.Controls.Add(this.lPlayerName);
            this.Controls.Add(this.lCoins);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelpResults);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.lTitle);
            this.Name = "fMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fMenu_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.Button btnHelpResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lCoins;
        private System.Windows.Forms.Label lPlayerName;
        private System.Windows.Forms.Button btnQuests;
        private System.Windows.Forms.Button btnLogout;
    }
}