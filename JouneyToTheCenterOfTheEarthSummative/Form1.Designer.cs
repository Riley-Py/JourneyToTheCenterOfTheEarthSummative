namespace JouneyToTheCenterOfTheEarthSummative
{
    partial class adventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adventureGame));
            this.firstTitle = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.pictureArea = new System.Windows.Forms.PictureBox();
            this.storyLabel = new System.Windows.Forms.Label();
            this.optionOneButton = new System.Windows.Forms.Button();
            this.optionTwoButton = new System.Windows.Forms.Button();
            this.optionThreeButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // firstTitle
            // 
            this.firstTitle.AutoSize = true;
            this.firstTitle.BackColor = System.Drawing.Color.Tan;
            this.firstTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.firstTitle.Location = new System.Drawing.Point(123, 49);
            this.firstTitle.Name = "firstTitle";
            this.firstTitle.Size = new System.Drawing.Size(330, 24);
            this.firstTitle.TabIndex = 0;
            this.firstTitle.Text = "Journey to the Center of the Earth!";
            // 
            // beginButton
            // 
            this.beginButton.BackColor = System.Drawing.Color.Tan;
            this.beginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginButton.ForeColor = System.Drawing.Color.Red;
            this.beginButton.Location = new System.Drawing.Point(159, 162);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(259, 90);
            this.beginButton.TabIndex = 1;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = false;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // pictureArea
            // 
            this.pictureArea.Location = new System.Drawing.Point(135, 39);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(318, 190);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArea.TabIndex = 2;
            this.pictureArea.TabStop = false;
            this.pictureArea.Visible = false;
            // 
            // storyLabel
            // 
            this.storyLabel.AutoSize = true;
            this.storyLabel.Font = new System.Drawing.Font("PMingLiU-ExtB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyLabel.Location = new System.Drawing.Point(55, 237);
            this.storyLabel.Name = "storyLabel";
            this.storyLabel.Size = new System.Drawing.Size(47, 15);
            this.storyLabel.TabIndex = 3;
            this.storyLabel.Text = "label1";
            this.storyLabel.Visible = false;
            // 
            // optionOneButton
            // 
            this.optionOneButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionOneButton.Location = new System.Drawing.Point(197, 288);
            this.optionOneButton.Name = "optionOneButton";
            this.optionOneButton.Size = new System.Drawing.Size(196, 23);
            this.optionOneButton.TabIndex = 4;
            this.optionOneButton.Text = "button1";
            this.optionOneButton.UseVisualStyleBackColor = true;
            this.optionOneButton.Visible = false;
            this.optionOneButton.Click += new System.EventHandler(this.optionOneButton_Click);
            // 
            // optionTwoButton
            // 
            this.optionTwoButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionTwoButton.Location = new System.Drawing.Point(197, 336);
            this.optionTwoButton.Name = "optionTwoButton";
            this.optionTwoButton.Size = new System.Drawing.Size(196, 23);
            this.optionTwoButton.TabIndex = 5;
            this.optionTwoButton.Text = "button2";
            this.optionTwoButton.UseVisualStyleBackColor = true;
            this.optionTwoButton.Visible = false;
            this.optionTwoButton.Click += new System.EventHandler(this.optionTwoButton_Click);
            // 
            // optionThreeButton
            // 
            this.optionThreeButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionThreeButton.Location = new System.Drawing.Point(197, 382);
            this.optionThreeButton.Name = "optionThreeButton";
            this.optionThreeButton.Size = new System.Drawing.Size(196, 23);
            this.optionThreeButton.TabIndex = 6;
            this.optionThreeButton.Text = "button3";
            this.optionThreeButton.UseVisualStyleBackColor = true;
            this.optionThreeButton.Visible = false;
            this.optionThreeButton.Click += new System.EventHandler(this.optionThreeButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("PMingLiU-ExtB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(163, 307);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(255, 23);
            this.continueButton.TabIndex = 8;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // adventureGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::JouneyToTheCenterOfTheEarthSummative.Properties.Resources.titlePhoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(618, 430);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.optionThreeButton);
            this.Controls.Add(this.optionTwoButton);
            this.Controls.Add(this.optionOneButton);
            this.Controls.Add(this.storyLabel);
            this.Controls.Add(this.pictureArea);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.firstTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adventureGame";
            this.Text = "Jouney to the Center of the Earth";
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstTitle;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.PictureBox pictureArea;
        private System.Windows.Forms.Label storyLabel;
        private System.Windows.Forms.Button optionOneButton;
        private System.Windows.Forms.Button optionTwoButton;
        private System.Windows.Forms.Button optionThreeButton;
        private System.Windows.Forms.Button continueButton;
    }
}

