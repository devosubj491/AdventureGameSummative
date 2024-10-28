namespace AdventureGameSummative
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.optionLabel1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.optionLabel2 = new System.Windows.Forms.Label();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.optionButton1 = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // optionLabel1
            // 
            this.optionLabel1.BackColor = System.Drawing.Color.DarkGreen;
            this.optionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel1.Location = new System.Drawing.Point(109, 281);
            this.optionLabel1.Name = "optionLabel1";
            this.optionLabel1.Size = new System.Drawing.Size(369, 28);
            this.optionLabel1.TabIndex = 1;
            this.optionLabel1.Text = "optionLabel1";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Black;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(0, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(492, 49);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "outputLabel";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionLabel2
            // 
            this.optionLabel2.BackColor = System.Drawing.Color.DarkRed;
            this.optionLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionLabel2.Location = new System.Drawing.Point(109, 338);
            this.optionLabel2.Name = "optionLabel2";
            this.optionLabel2.Size = new System.Drawing.Size(369, 28);
            this.optionLabel2.TabIndex = 2;
            this.optionLabel2.Text = "optionLabel2";
            // 
            // optionButton2
            // 
            this.optionButton2.AutoSize = true;
            this.optionButton2.BackColor = System.Drawing.Color.Transparent;
            this.optionButton2.BackgroundImage = global::AdventureGameSummative.Properties.Resources.arrowRight;
            this.optionButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionButton2.FlatAppearance.BorderSize = 0;
            this.optionButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optionButton2.Location = new System.Drawing.Point(48, 326);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(55, 55);
            this.optionButton2.TabIndex = 4;
            this.optionButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optionButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.optionButton2.UseVisualStyleBackColor = false;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // optionButton1
            // 
            this.optionButton1.AutoSize = true;
            this.optionButton1.BackColor = System.Drawing.Color.Transparent;
            this.optionButton1.BackgroundImage = global::AdventureGameSummative.Properties.Resources.arrowRight;
            this.optionButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionButton1.FlatAppearance.BorderSize = 0;
            this.optionButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton1.ForeColor = System.Drawing.Color.Transparent;
            this.optionButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optionButton1.Location = new System.Drawing.Point(48, 265);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(55, 55);
            this.optionButton1.TabIndex = 3;
            this.optionButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.optionButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.optionButton1.UseVisualStyleBackColor = false;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(12, 52);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(466, 195);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(490, 390);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.optionButton1);
            this.Controls.Add(this.optionLabel2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.optionLabel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Going To Work";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label optionLabel1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label optionLabel2;
        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

