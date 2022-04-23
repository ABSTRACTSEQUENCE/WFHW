
namespace HW
{
    partial class CV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CV));
            this.sname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.ComboBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(312, 219);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(207, 20);
            this.sname.TabIndex = 0;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(312, 245);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(207, 20);
            this.fname.TabIndex = 1;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(312, 271);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(207, 20);
            this.tname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(271, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(250, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(252, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(263, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Страна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(263, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Город";
            // 
            // country
            // 
            this.country.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.country.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.country.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Япония",
            "Китай"});
            this.country.Location = new System.Drawing.Point(312, 297);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(207, 21);
            this.country.TabIndex = 10;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged);
            this.country.TextUpdate += new System.EventHandler(this.country_TextChanged);
            // 
            // city
            // 
            this.city.Enabled = false;
            this.city.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.city.FormattingEnabled = true;
            this.city.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.city.Location = new System.Drawing.Point(312, 324);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(207, 21);
            this.city.TabIndex = 11;
            this.city.TextUpdate += new System.EventHandler(this.city_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(344, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 48);
            this.label6.TabIndex = 13;
            this.label6.Text = "Анкета";
            // 
            // CV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 551);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.city);
            this.Controls.Add(this.country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.sname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}