namespace ImageLibrary
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.browseButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.rotateClockwiseButton = new System.Windows.Forms.Button();
            this.rotateAntiClockwiseButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.imageResolutionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.indexStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.scaleStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageTimestampStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.browseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.browseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.browseButton.FlatAppearance.BorderSize = 2;
            this.browseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.Location = new System.Drawing.Point(386, 411);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextButton.FlatAppearance.BorderSize = 2;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(767, 411);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 29);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPictureBox.Location = new System.Drawing.Point(13, 27);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(854, 378);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Resize += new System.EventHandler(this.mainPictureBox_Resize);
            // 
            // rotateClockwiseButton
            // 
            this.rotateClockwiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rotateClockwiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateClockwiseButton.BackgroundImage")));
            this.rotateClockwiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateClockwiseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rotateClockwiseButton.FlatAppearance.BorderSize = 2;
            this.rotateClockwiseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rotateClockwiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateClockwiseButton.ForeColor = System.Drawing.Color.White;
            this.rotateClockwiseButton.Location = new System.Drawing.Point(619, 411);
            this.rotateClockwiseButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateClockwiseButton.Name = "rotateClockwiseButton";
            this.rotateClockwiseButton.Size = new System.Drawing.Size(29, 29);
            this.rotateClockwiseButton.TabIndex = 7;
            this.rotateClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateClockwiseButton.Click += new System.EventHandler(this.RotateClockwiseButton_Click);
            // 
            // rotateAntiClockwiseButton
            // 
            this.rotateAntiClockwiseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rotateAntiClockwiseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rotateAntiClockwiseButton.BackgroundImage")));
            this.rotateAntiClockwiseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateAntiClockwiseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rotateAntiClockwiseButton.FlatAppearance.BorderSize = 2;
            this.rotateAntiClockwiseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rotateAntiClockwiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rotateAntiClockwiseButton.ForeColor = System.Drawing.Color.White;
            this.rotateAntiClockwiseButton.Location = new System.Drawing.Point(228, 411);
            this.rotateAntiClockwiseButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateAntiClockwiseButton.Name = "rotateAntiClockwiseButton";
            this.rotateAntiClockwiseButton.Size = new System.Drawing.Size(29, 29);
            this.rotateAntiClockwiseButton.TabIndex = 8;
            this.rotateAntiClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateAntiClockwiseButton.Click += new System.EventHandler(this.RotateAntiClockwiseButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.previousButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.previousButton.FlatAppearance.BorderSize = 2;
            this.previousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.previousButton.ForeColor = System.Drawing.Color.White;
            this.previousButton.Location = new System.Drawing.Point(13, 411);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 29);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(880, 24);
            this.mainMenuStrip.TabIndex = 9;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.openFolderMenuItem,
            this.saveMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFileMenuItem.Text = "Open";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // openFolderMenuItem
            // 
            this.openFolderMenuItem.Name = "openFolderMenuItem";
            this.openFolderMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFolderMenuItem.Text = "Open folder";
            this.openFolderMenuItem.Click += new System.EventHandler(this.OpenFolderMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.ViewHelpMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageResolutionStatusLabel,
            this.indexStatusLabel,
            this.scaleStatusLabel,
            this.imageTimestampStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 441);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(880, 24);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // imageResolutionStatusLabel
            // 
            this.imageResolutionStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageResolutionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.imageResolutionStatusLabel.Name = "imageResolutionStatusLabel";
            this.imageResolutionStatusLabel.Size = new System.Drawing.Size(85, 19);
            this.imageResolutionStatusLabel.Text = "No file loaded";
            // 
            // indexStatusLabel
            // 
            this.indexStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.indexStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.indexStatusLabel.Name = "indexStatusLabel";
            this.indexStatusLabel.Size = new System.Drawing.Size(93, 19);
            this.indexStatusLabel.Text = "Unknown index";
            // 
            // scaleStatusLabel
            // 
            this.scaleStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.scaleStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.scaleStatusLabel.Name = "scaleStatusLabel";
            this.scaleStatusLabel.Size = new System.Drawing.Size(91, 19);
            this.scaleStatusLabel.Text = "Unknown scale";
            // 
            // imageTimestampStatusLabel
            // 
            this.imageTimestampStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageTimestampStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.imageTimestampStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.imageTimestampStatusLabel.Name = "imageTimestampStatusLabel";
            this.imageTimestampStatusLabel.Size = new System.Drawing.Size(87, 19);
            this.imageTimestampStatusLabel.Text = "No timestamp";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.rotateAntiClockwiseButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.rotateClockwiseButton);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.mainMenuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "View";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMPACtViewer";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button rotateClockwiseButton;
        private System.Windows.Forms.Button rotateAntiClockwiseButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel imageResolutionStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel indexStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel scaleStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel imageTimestampStatusLabel;
    }
}