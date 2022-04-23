
namespace HW
{
    partial class Product
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(61, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 264);
            this.listBox1.TabIndex = 0;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.Control;
            this.bt_add.Location = new System.Drawing.Point(61, 354);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(257, 23);
            this.bt_add.TabIndex = 1;
            this.bt_add.Text = "Добавить";
            this.bt_add.UseVisualStyleBackColor = false;
            // 
            // bt_edit
            // 
            this.bt_edit.BackColor = System.Drawing.SystemColors.Control;
            this.bt_edit.Location = new System.Drawing.Point(142, 325);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(95, 23);
            this.bt_edit.TabIndex = 2;
            this.bt_edit.Text = "Редактировать";
            this.bt_edit.UseVisualStyleBackColor = false;
            // 
            // bt_del
            // 
            this.bt_del.BackColor = System.Drawing.SystemColors.Control;
            this.bt_del.Location = new System.Drawing.Point(243, 325);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 23);
            this.bt_del.TabIndex = 3;
            this.bt_del.Text = "Удалить";
            this.bt_del.UseVisualStyleBackColor = false;
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(61, 325);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 4;
            this.bt_clear.Text = "Очистить";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 428);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Product";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_clear;
    }
}