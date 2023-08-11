namespace VidSlim_Compressor
{
    partial class CompressorGUI
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
            this.pageControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.videosConvertedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.selectAllBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.videoList = new MaterialSkin.Controls.MaterialListView();
            this.compressButton = new MaterialSkin.Controls.MaterialButton();
            this.discordSizeBox = new MaterialSkin.Controls.MaterialCheckbox();
            this.compressedSizeBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.pageControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageControl
            // 
            this.pageControl.Controls.Add(this.tabPage1);
            this.pageControl.Depth = 0;
            this.pageControl.Location = new System.Drawing.Point(-11, 67);
            this.pageControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.pageControl.Multiline = true;
            this.pageControl.Name = "pageControl";
            this.pageControl.SelectedIndex = 0;
            this.pageControl.Size = new System.Drawing.Size(816, 389);
            this.pageControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.videosConvertedLabel);
            this.tabPage1.Controls.Add(this.selectAllBox);
            this.tabPage1.Controls.Add(this.videoList);
            this.tabPage1.Controls.Add(this.compressButton);
            this.tabPage1.Controls.Add(this.discordSizeBox);
            this.tabPage1.Controls.Add(this.compressedSizeBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Page1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(25, 126);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(80, 36);
            this.materialButton2.TabIndex = 14;
            this.materialButton2.Text = "Browse";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // videosConvertedLabel
            // 
            this.videosConvertedLabel.AutoSize = true;
            this.videosConvertedLabel.Depth = 0;
            this.videosConvertedLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.videosConvertedLabel.Location = new System.Drawing.Point(399, 32);
            this.videosConvertedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.videosConvertedLabel.Name = "videosConvertedLabel";
            this.videosConvertedLabel.Size = new System.Drawing.Size(1, 0);
            this.videosConvertedLabel.TabIndex = 12;
            // 
            // selectAllBox
            // 
            this.selectAllBox.AutoSize = true;
            this.selectAllBox.Depth = 0;
            this.selectAllBox.Location = new System.Drawing.Point(695, 129);
            this.selectAllBox.Margin = new System.Windows.Forms.Padding(0);
            this.selectAllBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.selectAllBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectAllBox.Name = "selectAllBox";
            this.selectAllBox.ReadOnly = false;
            this.selectAllBox.Ripple = true;
            this.selectAllBox.Size = new System.Drawing.Size(99, 37);
            this.selectAllBox.TabIndex = 11;
            this.selectAllBox.Text = "Select all";
            this.selectAllBox.UseVisualStyleBackColor = true;
            this.selectAllBox.CheckedChanged += new System.EventHandler(this.selectAllBox_CheckedChanged);
            // 
            // videoList
            // 
            this.videoList.AutoSizeTable = false;
            this.videoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.videoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.videoList.CheckBoxes = true;
            this.videoList.Depth = 0;
            this.videoList.FullRowSelect = true;
            this.videoList.HideSelection = false;
            this.videoList.Location = new System.Drawing.Point(25, 169);
            this.videoList.MinimumSize = new System.Drawing.Size(200, 100);
            this.videoList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.videoList.MouseState = MaterialSkin.MouseState.OUT;
            this.videoList.Name = "videoList";
            this.videoList.OwnerDraw = true;
            this.videoList.Size = new System.Drawing.Size(769, 186);
            this.videoList.TabIndex = 10;
            this.videoList.UseCompatibleStateImageBehavior = false;
            this.videoList.View = System.Windows.Forms.View.Details;
            // 
            // compressButton
            // 
            this.compressButton.AutoSize = false;
            this.compressButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.compressButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.compressButton.Depth = 0;
            this.compressButton.HighEmphasis = true;
            this.compressButton.Icon = null;
            this.compressButton.Location = new System.Drawing.Point(261, 22);
            this.compressButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.compressButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.compressButton.Name = "compressButton";
            this.compressButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.compressButton.Size = new System.Drawing.Size(99, 36);
            this.compressButton.TabIndex = 3;
            this.compressButton.Text = "Compress";
            this.compressButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.compressButton.UseAccentColor = false;
            this.compressButton.UseVisualStyleBackColor = true;
            this.compressButton.Click += new System.EventHandler(this.compressButton_Click);
            // 
            // discordSizeBox
            // 
            this.discordSizeBox.AutoSize = true;
            this.discordSizeBox.Depth = 0;
            this.discordSizeBox.Location = new System.Drawing.Point(586, 23);
            this.discordSizeBox.Margin = new System.Windows.Forms.Padding(0);
            this.discordSizeBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.discordSizeBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.discordSizeBox.Name = "discordSizeBox";
            this.discordSizeBox.ReadOnly = false;
            this.discordSizeBox.Ripple = true;
            this.discordSizeBox.Size = new System.Drawing.Size(208, 37);
            this.discordSizeBox.TabIndex = 2;
            this.discordSizeBox.Text = "Discord file size (25 MB)";
            this.discordSizeBox.UseVisualStyleBackColor = true;
            this.discordSizeBox.CheckedChanged += new System.EventHandler(this.discordSizeBox_CheckedChanged);
            // 
            // compressedSizeBox
            // 
            this.compressedSizeBox.AnimateReadOnly = false;
            this.compressedSizeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.compressedSizeBox.Depth = 0;
            this.compressedSizeBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.compressedSizeBox.Hint = "Enter compressed file size";
            this.compressedSizeBox.LeadingIcon = null;
            this.compressedSizeBox.Location = new System.Drawing.Point(25, 23);
            this.compressedSizeBox.MaxLength = 50;
            this.compressedSizeBox.MouseState = MaterialSkin.MouseState.OUT;
            this.compressedSizeBox.Multiline = false;
            this.compressedSizeBox.Name = "compressedSizeBox";
            this.compressedSizeBox.Size = new System.Drawing.Size(220, 36);
            this.compressedSizeBox.TabIndex = 0;
            this.compressedSizeBox.Text = "";
            this.compressedSizeBox.TrailingIcon = null;
            this.compressedSizeBox.UseTallSize = false;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "cancelButton";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // CompressorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.pageControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CompressorGUI";
            this.Sizable = false;
            this.Text = "VidSlim";
            this.pageControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl pageControl;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTextBox compressedSizeBox;
        private MaterialSkin.Controls.MaterialCheckbox discordSizeBox;
        private MaterialSkin.Controls.MaterialButton compressButton;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialListView videoList;
        private MaterialSkin.Controls.MaterialCheckbox selectAllBox;
        private MaterialSkin.Controls.MaterialLabel videosConvertedLabel;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}

