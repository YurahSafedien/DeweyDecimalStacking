
namespace DeweyDecimalStacking
{
    partial class Game1Chapters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1Chapters));
            this.btnEasy1 = new System.Windows.Forms.Button();
            this.btnMed1 = new System.Windows.Forms.Button();
            this.btnHard1 = new System.Windows.Forms.Button();
            this.btnHome2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEasy1
            // 
            this.btnEasy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEasy1.BackgroundImage")));
            this.btnEasy1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasy1.Location = new System.Drawing.Point(428, 187);
            this.btnEasy1.Name = "btnEasy1";
            this.btnEasy1.Size = new System.Drawing.Size(60, 49);
            this.btnEasy1.TabIndex = 0;
            this.btnEasy1.UseVisualStyleBackColor = true;
            this.btnEasy1.Click += new System.EventHandler(this.btnEasy1_Click);
            // 
            // btnMed1
            // 
            this.btnMed1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMed1.BackgroundImage")));
            this.btnMed1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMed1.Location = new System.Drawing.Point(428, 307);
            this.btnMed1.Name = "btnMed1";
            this.btnMed1.Size = new System.Drawing.Size(60, 49);
            this.btnMed1.TabIndex = 1;
            this.btnMed1.UseVisualStyleBackColor = true;
            // 
            // btnHard1
            // 
            this.btnHard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHard1.BackgroundImage")));
            this.btnHard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHard1.Location = new System.Drawing.Point(428, 434);
            this.btnHard1.Name = "btnHard1";
            this.btnHard1.Size = new System.Drawing.Size(60, 49);
            this.btnHard1.TabIndex = 2;
            this.btnHard1.UseVisualStyleBackColor = true;
            // 
            // btnHome2
            // 
            this.btnHome2.BackColor = System.Drawing.Color.Transparent;
            this.btnHome2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome2.BackgroundImage")));
            this.btnHome2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome2.Location = new System.Drawing.Point(441, 12);
            this.btnHome2.Name = "btnHome2";
            this.btnHome2.Size = new System.Drawing.Size(47, 44);
            this.btnHome2.TabIndex = 12;
            this.btnHome2.UseVisualStyleBackColor = false;
            this.btnHome2.Click += new System.EventHandler(this.btnHome2_Click);
            // 
            // Game1Chapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 495);
            this.Controls.Add(this.btnHome2);
            this.Controls.Add(this.btnHard1);
            this.Controls.Add(this.btnMed1);
            this.Controls.Add(this.btnEasy1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game1Chapters";
            this.Text = "Book Stacking ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEasy1;
        private System.Windows.Forms.Button btnMed1;
        private System.Windows.Forms.Button btnHard1;
        private System.Windows.Forms.Button btnHome2;
    }
}