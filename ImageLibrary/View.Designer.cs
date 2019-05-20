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
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
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
            this.browseButton.Location = new System.Drawing.Point(386, 424);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(100, 29);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
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
            this.nextButton.Location = new System.Drawing.Point(767, 424);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(100, 29);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPictureBox.Location = new System.Drawing.Point(13, 12);
            this.mainPictureBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(854, 403);
            this.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
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
            this.rotateClockwiseButton.Location = new System.Drawing.Point(619, 424);
            this.rotateClockwiseButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateClockwiseButton.Name = "rotateClockwiseButton";
            this.rotateClockwiseButton.Size = new System.Drawing.Size(29, 29);
            this.rotateClockwiseButton.TabIndex = 7;
            this.rotateClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateClockwiseButton.Click += new System.EventHandler(this.rotateClockwiseButton_Click);
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
            this.rotateAntiClockwiseButton.Location = new System.Drawing.Point(228, 424);
            this.rotateAntiClockwiseButton.Margin = new System.Windows.Forms.Padding(0);
            this.rotateAntiClockwiseButton.Name = "rotateAntiClockwiseButton";
            this.rotateAntiClockwiseButton.Size = new System.Drawing.Size(29, 29);
            this.rotateAntiClockwiseButton.TabIndex = 8;
            this.rotateAntiClockwiseButton.UseVisualStyleBackColor = true;
            this.rotateAntiClockwiseButton.Click += new System.EventHandler(this.rotateAntiClockwiseButton_Click);
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
            this.previousButton.Location = new System.Drawing.Point(13, 424);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(100, 29);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(880, 465);
            this.Controls.Add(this.rotateAntiClockwiseButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.rotateClockwiseButton);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "View";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMPACtViewer";
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.Button rotateClockwiseButton;
        private System.Windows.Forms.Button rotateAntiClockwiseButton;
        private System.Windows.Forms.Button previousButton;
    }
}