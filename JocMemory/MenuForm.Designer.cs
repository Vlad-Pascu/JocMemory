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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.btnHelpResults = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listQuests = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory Cards";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSinglePlayer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(37, 263);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(150, 50);
            this.btnSinglePlayer.TabIndex = 1;
            this.btnSinglePlayer.TabStop = false;
            this.btnSinglePlayer.Text = "SinglePlayer";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnMultiPlayer.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiPlayer.Location = new System.Drawing.Point(37, 336);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(150, 50);
            this.btnMultiPlayer.TabIndex = 2;
            this.btnMultiPlayer.TabStop = false;
            this.btnMultiPlayer.Text = "MultiPlayer";
            this.btnMultiPlayer.UseVisualStyleBackColor = false;
            // 
            // btnHelpResults
            // 
            this.btnHelpResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnHelpResults.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpResults.Location = new System.Drawing.Point(37, 407);
            this.btnHelpResults.Name = "btnHelpResults";
            this.btnHelpResults.Size = new System.Drawing.Size(150, 50);
            this.btnHelpResults.TabIndex = 3;
            this.btnHelpResults.TabStop = false;
            this.btnHelpResults.Text = "Help/Results";
            this.btnHelpResults.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(37, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit Game";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // listQuests
            // 
            this.listQuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listQuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listQuests.HideSelection = false;
            this.listQuests.Location = new System.Drawing.Point(558, 263);
            this.listQuests.Name = "listQuests";
            this.listQuests.Size = new System.Drawing.Size(174, 264);
            this.listQuests.TabIndex = 5;
            this.listQuests.UseCompatibleStateImageBehavior = false;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listQuests);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelpResults);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.label1);
            this.Name = "fMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.Button btnHelpResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView listQuests;
    }
}