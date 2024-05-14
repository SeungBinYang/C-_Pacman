namespace pacMan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblScore = new Label();
            pictureBoxWall1 = new PictureBox();
            pictureBoxWall2 = new PictureBox();
            pictureBoxWall3 = new PictureBox();
            pictureBoxWall4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.ForeColor = SystemColors.ButtonHighlight;
            lblScore.Location = new Point(12, 525);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(48, 15);
            lblScore.TabIndex = 0;
            lblScore.Text = "Score : ";
            // 
            // pictureBoxWall1
            // 
            pictureBoxWall1.BackColor = Color.Navy;
            pictureBoxWall1.Location = new Point(12, 12);
            pictureBoxWall1.Name = "pictureBoxWall1";
            pictureBoxWall1.Size = new Size(500, 20);
            pictureBoxWall1.TabIndex = 2;
            pictureBoxWall1.TabStop = false;
            // 
            // pictureBoxWall2
            // 
            pictureBoxWall2.BackColor = Color.Navy;
            pictureBoxWall2.Location = new Point(12, 492);
            pictureBoxWall2.Name = "pictureBoxWall2";
            pictureBoxWall2.Size = new Size(500, 20);
            pictureBoxWall2.TabIndex = 3;
            pictureBoxWall2.TabStop = false;
            // 
            // pictureBoxWall3
            // 
            pictureBoxWall3.BackColor = Color.Navy;
            pictureBoxWall3.Location = new Point(12, 28);
            pictureBoxWall3.Name = "pictureBoxWall3";
            pictureBoxWall3.Size = new Size(20, 467);
            pictureBoxWall3.TabIndex = 4;
            pictureBoxWall3.TabStop = false;
            // 
            // pictureBoxWall4
            // 
            pictureBoxWall4.BackColor = Color.Navy;
            pictureBoxWall4.Location = new Point(492, 28);
            pictureBoxWall4.Name = "pictureBoxWall4";
            pictureBoxWall4.Size = new Size(20, 467);
            pictureBoxWall4.TabIndex = 5;
            pictureBoxWall4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 255);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Location = new Point(52, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 20);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Navy;
            pictureBox3.Location = new Point(290, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(182, 20);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(255, 335);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(20, 20);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(538, 550);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxWall4);
            Controls.Add(pictureBoxWall3);
            Controls.Add(pictureBoxWall2);
            Controls.Add(pictureBoxWall1);
            Controls.Add(lblScore);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pac-Man";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWall4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScore;
        private PictureBox pictureBoxWall1;
        private PictureBox pictureBoxWall2;
        private PictureBox pictureBoxWall3;
        private PictureBox pictureBoxWall4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}