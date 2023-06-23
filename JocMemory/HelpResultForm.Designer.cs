namespace JocMemory
{
    partial class fHelpResult
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
            this.lHelp = new System.Windows.Forms.Label();
            this.listSingleResults = new System.Windows.Forms.ListBox();
            this.listMultiResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lHelp
            // 
            this.lHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lHelp.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHelp.Location = new System.Drawing.Point(48, 45);
            this.lHelp.Name = "lHelp";
            this.lHelp.Size = new System.Drawing.Size(689, 88);
            this.lHelp.TabIndex = 0;
            this.lHelp.Text = "label1";
            // 
            // listSingleResults
            // 
            this.listSingleResults.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSingleResults.FormattingEnabled = true;
            this.listSingleResults.ItemHeight = 23;
            this.listSingleResults.Location = new System.Drawing.Point(49, 158);
            this.listSingleResults.Name = "listSingleResults";
            this.listSingleResults.Size = new System.Drawing.Size(325, 303);
            this.listSingleResults.TabIndex = 1;
            // 
            // listMultiResults
            // 
            this.listMultiResults.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMultiResults.FormattingEnabled = true;
            this.listMultiResults.ItemHeight = 23;
            this.listMultiResults.Location = new System.Drawing.Point(410, 158);
            this.listMultiResults.Name = "listMultiResults";
            this.listMultiResults.Size = new System.Drawing.Size(325, 303);
            this.listMultiResults.TabIndex = 2;
            // 
            // fHelpResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.listMultiResults);
            this.Controls.Add(this.listSingleResults);
            this.Controls.Add(this.lHelp);
            this.Name = "fHelpResult";
            this.Text = "HelpResultForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fHelpResult_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lHelp;
        private System.Windows.Forms.ListBox listSingleResults;
        private System.Windows.Forms.ListBox listMultiResults;
    }
}