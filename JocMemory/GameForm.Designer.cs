namespace JocMemory
{
    partial class fGame
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
            this.pGame = new System.Windows.Forms.Panel();
            this.lTimer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lPlayerName = new System.Windows.Forms.Label();
            this.lCoins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pGame
            // 
            this.pGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pGame.Location = new System.Drawing.Point(42, 80);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(700, 400);
            this.pGame.TabIndex = 0;
            // 
            // lTimer
            // 
            this.lTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lTimer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTimer.Location = new System.Drawing.Point(42, 499);
            this.lTimer.Name = "lTimer";
            this.lTimer.Size = new System.Drawing.Size(100, 35);
            this.lTimer.TabIndex = 1;
            this.lTimer.Text = "Time";
            this.lTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Hint";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(595, 495);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(147, 39);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // lPlayerName
            // 
            this.lPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerName.Location = new System.Drawing.Point(557, 24);
            this.lPlayerName.Name = "lPlayerName";
            this.lPlayerName.Size = new System.Drawing.Size(185, 37);
            this.lPlayerName.TabIndex = 4;
            this.lPlayerName.Text = "Player Name";
            this.lPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCoins
            // 
            this.lCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lCoins.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoins.Location = new System.Drawing.Point(39, 24);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(146, 37);
            this.lCoins.TabIndex = 5;
            this.lCoins.Text = "Coins";
            // 
            // fGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lCoins);
            this.Controls.Add(this.lPlayerName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lTimer);
            this.Controls.Add(this.pGame);
            this.Name = "fGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pGame;
        private System.Windows.Forms.Label lTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lPlayerName;
        private System.Windows.Forms.Label lCoins;
    }
}

