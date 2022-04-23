
namespace HW2
{
    partial class Product_editor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_name = new System.Windows.Forms.TextBox();
            this.n_price = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_done = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(225, 185);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(189, 20);
            this.tb_name.TabIndex = 0;
            // 
            // n_price
            // 
            this.n_price.Location = new System.Drawing.Point(225, 233);
            this.n_price.Name = "n_price";
            this.n_price.Size = new System.Drawing.Size(189, 20);
            this.n_price.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 66);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Editor\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Цена";
            // 
            // bt_done
            // 
            this.bt_done.Location = new System.Drawing.Point(225, 278);
            this.bt_done.Name = "bt_done";
            this.bt_done.Size = new System.Drawing.Size(76, 23);
            this.bt_done.TabIndex = 6;
            this.bt_done.Text = "Готово";
            this.bt_done.UseVisualStyleBackColor = true;
            this.bt_done.Click += new System.EventHandler(this.bt_done_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(338, 278);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(76, 23);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Отмена";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Product_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 468);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.n_price);
            this.Controls.Add(this.tb_name);
            this.Name = "Product_editor";
            this.Text = "Product Editor";
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.NumericUpDown n_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_done;
        private System.Windows.Forms.Button bt_cancel;
    }
}

