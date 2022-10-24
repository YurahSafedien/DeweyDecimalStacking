
namespace DeweyDecimalStacking
{
    partial class MatchGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchGame));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_MatchHelp = new System.Windows.Forms.Button();
            this.btn_MatchHome = new System.Windows.Forms.Button();
            this.btn_MatchStart = new System.Windows.Forms.Button();
            this.btn_MatchHint = new System.Windows.Forms.Button();
            this.btn_MatchCheck = new System.Windows.Forms.Button();
            this.flp_Boxes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 475);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1016, 124);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_MatchHelp
            // 
            this.btn_MatchHelp.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Help__1_;
            this.btn_MatchHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatchHelp.Location = new System.Drawing.Point(884, 11);
            this.btn_MatchHelp.Name = "btn_MatchHelp";
            this.btn_MatchHelp.Size = new System.Drawing.Size(48, 46);
            this.btn_MatchHelp.TabIndex = 9;
            this.btn_MatchHelp.UseVisualStyleBackColor = true;
            // 
            // btn_MatchHome
            // 
            this.btn_MatchHome.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Home2;
            this.btn_MatchHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatchHome.Location = new System.Drawing.Point(962, 11);
            this.btn_MatchHome.Name = "btn_MatchHome";
            this.btn_MatchHome.Size = new System.Drawing.Size(48, 44);
            this.btn_MatchHome.TabIndex = 10;
            this.btn_MatchHome.UseVisualStyleBackColor = true;
            this.btn_MatchHome.Click += new System.EventHandler(this.btn_MatchHome_Click);
            // 
            // btn_MatchStart
            // 
            this.btn_MatchStart.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Play__2_;
            this.btn_MatchStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatchStart.Location = new System.Drawing.Point(57, 12);
            this.btn_MatchStart.Name = "btn_MatchStart";
            this.btn_MatchStart.Size = new System.Drawing.Size(48, 46);
            this.btn_MatchStart.TabIndex = 11;
            this.btn_MatchStart.UseVisualStyleBackColor = true;
            this.btn_MatchStart.Click += new System.EventHandler(this.btn_MatchStart_Click);
            // 
            // btn_MatchHint
            // 
            this.btn_MatchHint.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Hint;
            this.btn_MatchHint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatchHint.Location = new System.Drawing.Point(123, 11);
            this.btn_MatchHint.Name = "btn_MatchHint";
            this.btn_MatchHint.Size = new System.Drawing.Size(48, 46);
            this.btn_MatchHint.TabIndex = 12;
            this.btn_MatchHint.UseVisualStyleBackColor = true;
            // 
            // btn_MatchCheck
            // 
            this.btn_MatchCheck.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Check;
            this.btn_MatchCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_MatchCheck.Location = new System.Drawing.Point(193, 11);
            this.btn_MatchCheck.Name = "btn_MatchCheck";
            this.btn_MatchCheck.Size = new System.Drawing.Size(48, 45);
            this.btn_MatchCheck.TabIndex = 13;
            this.btn_MatchCheck.UseVisualStyleBackColor = true;
            // 
            // flp_Boxes
            // 
            this.flp_Boxes.BackColor = System.Drawing.Color.Transparent;
            this.flp_Boxes.Location = new System.Drawing.Point(38, 119);
            this.flp_Boxes.Name = "flp_Boxes";
            this.flp_Boxes.Size = new System.Drawing.Size(1008, 40);
            this.flp_Boxes.TabIndex = 14;
            // 
            // MatchGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::DeweyDecimalStacking.Properties.Resources.Bg_NewMatchBooks;
            this.ClientSize = new System.Drawing.Size(1040, 660);
            this.Controls.Add(this.flp_Boxes);
            this.Controls.Add(this.btn_MatchCheck);
            this.Controls.Add(this.btn_MatchHint);
            this.Controls.Add(this.btn_MatchStart);
            this.Controls.Add(this.btn_MatchHome);
            this.Controls.Add(this.btn_MatchHelp);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatchGame";
            this.Text = "MatchGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_MatchHelp;
        private System.Windows.Forms.Button btn_MatchHome;
        private System.Windows.Forms.Button btn_MatchStart;
        private System.Windows.Forms.Button btn_MatchHint;
        private System.Windows.Forms.Button btn_MatchCheck;
        private System.Windows.Forms.FlowLayoutPanel flp_Boxes;
    }
}