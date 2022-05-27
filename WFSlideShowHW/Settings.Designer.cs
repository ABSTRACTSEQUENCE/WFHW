
namespace WFSlideShowHW
{
    partial class Settings
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
            this.interval = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.l_interval = new System.Windows.Forms.Label();
            this.b_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            this.SuspendLayout();
            // 
            // interval
            // 
            this.interval.LargeChange = 10;
            this.interval.Location = new System.Drawing.Point(187, 273);
            this.interval.Maximum = 30;
            this.interval.Minimum = 1;
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(409, 45);
            this.interval.TabIndex = 0;
            this.interval.Value = 1;
            this.interval.Scroll += new System.EventHandler(this.interval_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(305, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Интервал (сек)";
            // 
            // l_interval
            // 
            this.l_interval.AutoSize = true;
            this.l_interval.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_interval.Location = new System.Drawing.Point(358, 321);
            this.l_interval.Name = "l_interval";
            this.l_interval.Size = new System.Drawing.Size(23, 25);
            this.l_interval.TabIndex = 2;
            this.l_interval.Text = "1";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(321, 363);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(95, 38);
            this.b_ok.TabIndex = 3;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.l_interval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_interval;
        private System.Windows.Forms.Button b_ok;
    }
}