namespace JocMemory
{
    partial class fSingleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSingleGame));
            this.pGame = new System.Windows.Forms.Panel();
            this.lScore = new System.Windows.Forms.Label();
            this.btnHints = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lPlayerName = new System.Windows.Forms.Label();
            this.lCoins = new System.Windows.Forms.Label();
            this.listImages = new System.Windows.Forms.ImageList(this.components);
            this.tSwitch = new System.Windows.Forms.Timer(this.components);
            this.tSeconds = new System.Windows.Forms.Timer(this.components);
            this.tHints = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pGame
            // 
            this.pGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pGame.Location = new System.Drawing.Point(41, 80);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(700, 400);
            this.pGame.TabIndex = 0;
            // 
            // lScore
            // 
            this.lScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(41, 499);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(126, 35);
            this.lScore.TabIndex = 1;
            this.lScore.Text = "Score : ";
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHints
            // 
            this.btnHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHints.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHints.Location = new System.Drawing.Point(308, 495);
            this.btnHints.Name = "btnHints";
            this.btnHints.Size = new System.Drawing.Size(147, 39);
            this.btnHints.TabIndex = 2;
            this.btnHints.TabStop = false;
            this.btnHints.Text = "Hint";
            this.btnHints.UseVisualStyleBackColor = false;
            this.btnHints.Click += new System.EventHandler(this.btnHints_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(596, 495);
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
            this.lPlayerName.Location = new System.Drawing.Point(559, 24);
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
            this.lCoins.Location = new System.Drawing.Point(41, 24);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(146, 37);
            this.lCoins.TabIndex = 5;
            this.lCoins.Text = "Coins : ";
            this.lCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listImages
            // 
            this.listImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listImages.ImageStream")));
            this.listImages.TransparentColor = System.Drawing.Color.Transparent;
            this.listImages.Images.SetKeyName(0, "0.bmp");
            this.listImages.Images.SetKeyName(1, "1.bmp");
            this.listImages.Images.SetKeyName(2, "2.bmp");
            this.listImages.Images.SetKeyName(3, "3.bmp");
            this.listImages.Images.SetKeyName(4, "4.bmp");
            this.listImages.Images.SetKeyName(5, "5.bmp");
            this.listImages.Images.SetKeyName(6, "6.bmp");
            this.listImages.Images.SetKeyName(7, "7.bmp");
            this.listImages.Images.SetKeyName(8, "8.bmp");
            this.listImages.Images.SetKeyName(9, "9.bmp");
            this.listImages.Images.SetKeyName(10, "10.bmp");
            this.listImages.Images.SetKeyName(11, "11.bmp");
            this.listImages.Images.SetKeyName(12, "12.bmp");
            this.listImages.Images.SetKeyName(13, "13.bmp");
            this.listImages.Images.SetKeyName(14, "0.bmp");
            this.listImages.Images.SetKeyName(15, "1.bmp");
            this.listImages.Images.SetKeyName(16, "2.bmp");
            this.listImages.Images.SetKeyName(17, "3.bmp");
            this.listImages.Images.SetKeyName(18, "4.bmp");
            this.listImages.Images.SetKeyName(19, "5.bmp");
            this.listImages.Images.SetKeyName(20, "6.bmp");
            this.listImages.Images.SetKeyName(21, "7.bmp");
            this.listImages.Images.SetKeyName(22, "8.bmp");
            this.listImages.Images.SetKeyName(23, "9.bmp");
            this.listImages.Images.SetKeyName(24, "10.bmp");
            this.listImages.Images.SetKeyName(25, "11.bmp");
            this.listImages.Images.SetKeyName(26, "12.bmp");
            this.listImages.Images.SetKeyName(27, "13.bmp");
            // 
            // tSwitch
            // 
            this.tSwitch.Interval = 500;
            this.tSwitch.Tick += new System.EventHandler(this.tSwitch_Tick);
            // 
            // tSeconds
            // 
            this.tSeconds.Interval = 1000;
            this.tSeconds.Tick += new System.EventHandler(this.tSeconds_Tick);
            // 
            // tHints
            // 
            this.tHints.Interval = 1500;
            this.tHints.Tick += new System.EventHandler(this.tHints_Tick);
            // 
            // fSingleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lCoins);
            this.Controls.Add(this.lPlayerName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHints);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.pGame);
            this.Name = "fSingleGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.SinglePlayerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pGame;
        public System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Button btnHints;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lPlayerName;
        private System.Windows.Forms.Label lCoins;
        public System.Windows.Forms.ImageList listImages;
        private System.Windows.Forms.Timer tSeconds;
        private System.Windows.Forms.Timer tSwitch;
        private System.Windows.Forms.Timer tHints;
    }
}

