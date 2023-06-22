namespace JocMemory
{
    partial class fMultiGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMultiGame));
            this.lCoins = new System.Windows.Forms.Label();
            this.lPlayerName = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnHints = new System.Windows.Forms.Button();
            this.lScore = new System.Windows.Forms.Label();
            this.pGame = new System.Windows.Forms.Panel();
            this.listImages = new System.Windows.Forms.ImageList(this.components);
            this.tSwitch = new System.Windows.Forms.Timer(this.components);
            this.tHints = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lCoins
            // 
            this.lCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lCoins.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCoins.Location = new System.Drawing.Point(41, 25);
            this.lCoins.Name = "lCoins";
            this.lCoins.Size = new System.Drawing.Size(146, 37);
            this.lCoins.TabIndex = 11;
            this.lCoins.Text = "Coins : ";
            this.lCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lPlayerName
            // 
            this.lPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPlayerName.Location = new System.Drawing.Point(559, 25);
            this.lPlayerName.Name = "lPlayerName";
            this.lPlayerName.Size = new System.Drawing.Size(185, 37);
            this.lPlayerName.TabIndex = 10;
            this.lPlayerName.Text = "Player Name";
            this.lPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnQuit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(596, 498);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(147, 39);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.TabStop = false;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = false;
            // 
            // btnHints
            // 
            this.btnHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHints.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHints.Location = new System.Drawing.Point(423, 498);
            this.btnHints.Name = "btnHints";
            this.btnHints.Size = new System.Drawing.Size(147, 39);
            this.btnHints.TabIndex = 8;
            this.btnHints.TabStop = false;
            this.btnHints.Text = "Hint";
            this.btnHints.UseVisualStyleBackColor = false;
            this.btnHints.Click += new System.EventHandler(this.btnHints_Click);
            // 
            // lScore
            // 
            this.lScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(41, 498);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(126, 35);
            this.lScore.TabIndex = 7;
            this.lScore.Text = "Score : ";
            this.lScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pGame
            // 
            this.pGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pGame.Location = new System.Drawing.Point(41, 81);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(700, 400);
            this.pGame.TabIndex = 6;
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
            // 
            // tHints
            // 
            this.tHints.Interval = 1500;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(222, 498);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 39);
            this.btnStart.TabIndex = 12;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // fMultiGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lCoins);
            this.Controls.Add(this.lPlayerName);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnHints);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.pGame);
            this.Name = "fMultiGame";
            this.Text = "MultiPlayerForm";
            this.Load += new System.EventHandler(this.MultiPlayerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lCoins;
        private System.Windows.Forms.Label lPlayerName;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnHints;
        public System.Windows.Forms.Label lScore;
        public System.Windows.Forms.Panel pGame;
        public System.Windows.Forms.ImageList listImages;
        private System.Windows.Forms.Timer tSwitch;
        private System.Windows.Forms.Timer tHints;
        private System.Windows.Forms.Button btnStart;
    }
}