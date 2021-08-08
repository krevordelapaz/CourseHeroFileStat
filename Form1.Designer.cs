
namespace FileStat
{
    partial class FileStatForm
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.getStatsButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statRichTextBox = new System.Windows.Forms.RichTextBox();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(17, 16);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(141, 50);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // getStatsButton
            // 
            this.getStatsButton.Location = new System.Drawing.Point(17, 74);
            this.getStatsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getStatsButton.Name = "getStatsButton";
            this.getStatsButton.Size = new System.Drawing.Size(141, 50);
            this.getStatsButton.TabIndex = 1;
            this.getStatsButton.Text = "Get Stats";
            this.getStatsButton.UseVisualStyleBackColor = true;
            this.getStatsButton.Click += new System.EventHandler(this.getStatsButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(17, 203);
            this.findButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(141, 36);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(17, 246);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 65);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // statRichTextBox
            // 
            this.statRichTextBox.Location = new System.Drawing.Point(187, 16);
            this.statRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statRichTextBox.Name = "statRichTextBox";
            this.statRichTextBox.Size = new System.Drawing.Size(571, 294);
            this.statRichTextBox.TabIndex = 4;
            this.statRichTextBox.Text = "";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(17, 171);
            this.findTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(140, 22);
            this.findTextBox.TabIndex = 0;
            // 
            // FileStatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 325);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.statRichTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.getStatsButton);
            this.Controls.Add(this.openFileButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileStatForm";
            this.Text = "File Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button getStatsButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RichTextBox statRichTextBox;
        private System.Windows.Forms.TextBox findTextBox;
    }
}

