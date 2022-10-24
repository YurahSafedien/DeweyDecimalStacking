
namespace DeweyDecimalStacking
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
            this.welcomebook = new System.Windows.Forms.PictureBox();
            this.btnBookStack = new System.Windows.Forms.Button();
            this.btnCodeMatch = new System.Windows.Forms.Button();
            this.btnCodeFind = new System.Windows.Forms.Button();
            this.lnInstruct = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.welcomebook)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomebook
            // 
            this.welcomebook.BackColor = System.Drawing.Color.Transparent;
            this.welcomebook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomebook.BackgroundImage")));
            this.welcomebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.welcomebook.Location = new System.Drawing.Point(325, 51);
            this.welcomebook.Name = "welcomebook";
            this.welcomebook.Size = new System.Drawing.Size(390, 289);
            this.welcomebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomebook.TabIndex = 0;
            this.welcomebook.TabStop = false;
            // 
            // btnBookStack
            // 
            this.btnBookStack.BackColor = System.Drawing.Color.Transparent;
            this.btnBookStack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookStack.Image = ((System.Drawing.Image)(resources.GetObject("btnBookStack.Image")));
            this.btnBookStack.Location = new System.Drawing.Point(97, 316);
            this.btnBookStack.Name = "btnBookStack";
            this.btnBookStack.Size = new System.Drawing.Size(171, 202);
            this.btnBookStack.TabIndex = 1;
            this.btnBookStack.UseVisualStyleBackColor = false;
            this.btnBookStack.Click += new System.EventHandler(this.btnBookStack_Click);
            // 
            // btnCodeMatch
            // 
            this.btnCodeMatch.BackColor = System.Drawing.Color.Transparent;
            this.btnCodeMatch.Image = ((System.Drawing.Image)(resources.GetObject("btnCodeMatch.Image")));
            this.btnCodeMatch.Location = new System.Drawing.Point(414, 317);
            this.btnCodeMatch.Name = "btnCodeMatch";
            this.btnCodeMatch.Size = new System.Drawing.Size(171, 201);
            this.btnCodeMatch.TabIndex = 2;
            this.btnCodeMatch.UseVisualStyleBackColor = false;
            this.btnCodeMatch.Click += new System.EventHandler(this.btnCodeMatch_Click);
            // 
            // btnCodeFind
            // 
            this.btnCodeFind.BackColor = System.Drawing.Color.Transparent;
            this.btnCodeFind.Image = ((System.Drawing.Image)(resources.GetObject("btnCodeFind.Image")));
            this.btnCodeFind.Location = new System.Drawing.Point(745, 317);
            this.btnCodeFind.Name = "btnCodeFind";
            this.btnCodeFind.Size = new System.Drawing.Size(171, 201);
            this.btnCodeFind.TabIndex = 3;
            this.btnCodeFind.UseVisualStyleBackColor = false;
            this.btnCodeFind.Click += new System.EventHandler(this.btnCodeFind_Click);
            // 
            // lnInstruct
            // 
            this.lnInstruct.AutoSize = true;
            this.lnInstruct.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnInstruct.Location = new System.Drawing.Point(530, 217);
            this.lnInstruct.Name = "lnInstruct";
            this.lnInstruct.Size = new System.Drawing.Size(129, 18);
            this.lnInstruct.TabIndex = 4;
            this.lnInstruct.Text = "Please select a game:";
            this.lnInstruct.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 660);
            this.Controls.Add(this.lnInstruct);
            this.Controls.Add(this.btnCodeFind);
            this.Controls.Add(this.btnCodeMatch);
            this.Controls.Add(this.btnBookStack);
            this.Controls.Add(this.welcomebook);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dewey Decimal Game";
            ((System.ComponentModel.ISupportInitialize)(this.welcomebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox welcomebook;
        private System.Windows.Forms.Button btnBookStack;
        private System.Windows.Forms.Button btnCodeMatch;
        private System.Windows.Forms.Button btnCodeFind;
        private System.Windows.Forms.Label lnInstruct;
    }
}

