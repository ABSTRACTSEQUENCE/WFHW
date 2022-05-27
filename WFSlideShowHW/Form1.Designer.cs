
namespace WFSlideShowHW
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l_display = new System.Windows.Forms.Label();
            this.bt_prev = new System.Windows.Forms.Button();
            this.bt_next = new System.Windows.Forms.Button();
            this.bt_startstop = new System.Windows.Forms.Button();
            this.l_counter_current = new System.Windows.Forms.Label();
            this.l_counter_total = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_custom = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_display
            // 
            this.l_display.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.l_display.Location = new System.Drawing.Point(-3, 25);
            this.l_display.Name = "l_display";
            this.l_display.Size = new System.Drawing.Size(804, 373);
            this.l_display.TabIndex = 0;
            // 
            // bt_prev
            // 
            this.bt_prev.Location = new System.Drawing.Point(0, 410);
            this.bt_prev.Name = "bt_prev";
            this.bt_prev.Size = new System.Drawing.Size(103, 37);
            this.bt_prev.TabIndex = 1;
            this.bt_prev.Text = "Prev";
            this.bt_prev.UseVisualStyleBackColor = true;
            this.bt_prev.Click += new System.EventHandler(this.bt_prev_Click);
            // 
            // bt_next
            // 
            this.bt_next.Location = new System.Drawing.Point(698, 410);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(103, 37);
            this.bt_next.TabIndex = 2;
            this.bt_next.Text = "Next";
            this.bt_next.UseVisualStyleBackColor = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
            // 
            // bt_startstop
            // 
            this.bt_startstop.Location = new System.Drawing.Point(347, 410);
            this.bt_startstop.Name = "bt_startstop";
            this.bt_startstop.Size = new System.Drawing.Size(139, 37);
            this.bt_startstop.TabIndex = 3;
            this.bt_startstop.Text = "Start";
            this.bt_startstop.UseVisualStyleBackColor = true;
            this.bt_startstop.Click += new System.EventHandler(this.bt_startstop_Click);
            // 
            // l_counter_current
            // 
            this.l_counter_current.AutoSize = true;
            this.l_counter_current.BackColor = System.Drawing.Color.Transparent;
            this.l_counter_current.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_counter_current.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_counter_current.Location = new System.Drawing.Point(169, 417);
            this.l_counter_current.Name = "l_counter_current";
            this.l_counter_current.Size = new System.Drawing.Size(98, 26);
            this.l_counter_current.TabIndex = 4;
            this.l_counter_current.Text = "Picture number ";
            // 
            // l_counter_total
            // 
            this.l_counter_total.AutoSize = true;
            this.l_counter_total.BackColor = System.Drawing.Color.Transparent;
            this.l_counter_total.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_counter_total.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.l_counter_total.Location = new System.Drawing.Point(544, 417);
            this.l_counter_total.Name = "l_counter_total";
            this.l_counter_total.Size = new System.Drawing.Size(43, 26);
            this.l_counter_total.TabIndex = 5;
            this.l_counter_total.Text = "Total:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_custom,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_custom
            // 
            this.ts_custom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_custom.Image = ((System.Drawing.Image)(resources.GetObject("ts_custom.Image")));
            this.ts_custom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_custom.Name = "ts_custom";
            this.ts_custom.Size = new System.Drawing.Size(23, 22);
            this.ts_custom.Text = "toolStripButton1";
            this.ts_custom.Click += new System.EventHandler(this.ts_custom_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WFSlideShowHW.Properties.Resources.settings;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "ts_settings";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.l_counter_total);
            this.Controls.Add(this.l_counter_current);
            this.Controls.Add(this.bt_startstop);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.bt_prev);
            this.Controls.Add(this.l_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слайд-шоу";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_display;
        private System.Windows.Forms.Button bt_prev;
        private System.Windows.Forms.Button bt_next;
        private System.Windows.Forms.Button bt_startstop;
        private System.Windows.Forms.Label l_counter_current;
        private System.Windows.Forms.Label l_counter_total;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_custom;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

