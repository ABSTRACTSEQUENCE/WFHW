
namespace HW4
{
    partial class bg_choise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bg_choise));
            this.red = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.pink = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("red.BackgroundImage")));
            this.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.red.Location = new System.Drawing.Point(218, 4);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(252, 142);
            this.red.TabIndex = 0;
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // black
            // 
            this.black.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("black.BackgroundImage")));
            this.black.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.black.Location = new System.Drawing.Point(218, 152);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(252, 126);
            this.black.TabIndex = 1;
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // blue
            // 
            this.blue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blue.BackgroundImage")));
            this.blue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blue.Location = new System.Drawing.Point(218, 284);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(252, 114);
            this.blue.TabIndex = 2;
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // pink
            // 
            this.pink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pink.BackgroundImage")));
            this.pink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pink.Location = new System.Drawing.Point(476, 152);
            this.pink.Name = "pink";
            this.pink.Size = new System.Drawing.Size(237, 126);
            this.pink.TabIndex = 3;
            this.pink.UseVisualStyleBackColor = true;
            this.pink.Click += new System.EventHandler(this.pink_Click);
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(3, 344);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(110, 65);
            this.custom.TabIndex = 4;
            this.custom.Text = "Выбрать свой фон";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.Click += new System.EventHandler(this.custom_Click);
            // 
            // bg_choise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(725, 410);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.pink);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.black);
            this.Controls.Add(this.red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "bg_choise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать обои";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button pink;
        private System.Windows.Forms.Button custom;
    }
}