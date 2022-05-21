
namespace HW5_Paint
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
            this.tools = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.Button_pen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_color = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_fill = new System.Windows.Forms.ToolStripMenuItem();
            this.db_width = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.button_eraser = new System.Windows.Forms.Button();
            this.tools.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_width)).BeginInit();
            this.SuspendLayout();
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tools.Controls.Add(this.button_eraser);
            this.tools.Controls.Add(this.label1);
            this.tools.Controls.Add(this.db_width);
            this.tools.Controls.Add(this.clear);
            this.tools.Controls.Add(this.button_rectangle);
            this.tools.Controls.Add(this.Button_pen);
            this.tools.Location = new System.Drawing.Point(661, -1);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(139, 451);
            this.tools.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(43, 425);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_rectangle.Location = new System.Drawing.Point(0, 44);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(45, 38);
            this.button_rectangle.TabIndex = 1;
            this.button_rectangle.UseVisualStyleBackColor = true;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // Button_pen
            // 
            this.Button_pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_pen.BackgroundImage")));
            this.Button_pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_pen.Location = new System.Drawing.Point(0, 0);
            this.Button_pen.Name = "Button_pen";
            this.Button_pen.Size = new System.Drawing.Size(45, 38);
            this.Button_pen.TabIndex = 0;
            this.Button_pen.UseVisualStyleBackColor = true;
            this.Button_pen.Click += new System.EventHandler(this.Button_pen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_color,
            this.ts_fill});
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            this.цветToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.цветToolStripMenuItem.Text = "Вид";
            // 
            // ts_color
            // 
            this.ts_color.Name = "ts_color";
            this.ts_color.Size = new System.Drawing.Size(180, 22);
            this.ts_color.Text = "Выбрать цвет";
            this.ts_color.Click += new System.EventHandler(this.ts_color_Click);
            // 
            // ts_fill
            // 
            this.ts_fill.Name = "ts_fill";
            this.ts_fill.Size = new System.Drawing.Size(180, 22);
            this.ts_fill.Text = "Заливать фигуры";
            this.ts_fill.Click += new System.EventHandler(this.ts_fill_Click);
            // 
            // db_width
            // 
            this.db_width.Location = new System.Drawing.Point(0, 216);
            this.db_width.Maximum = 50;
            this.db_width.Minimum = 1;
            this.db_width.Name = "db_width";
            this.db_width.Size = new System.Drawing.Size(139, 45);
            this.db_width.TabIndex = 3;
            this.db_width.Value = 1;
            this.db_width.Scroll += new System.EventHandler(this.db_width_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Толщина";
            // 
            // button_eraser
            // 
            this.button_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_eraser.Location = new System.Drawing.Point(0, 88);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(45, 38);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.UseVisualStyleBackColor = true;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(799, 449);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Editor";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawingPanel_MouseMove);
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_width)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tools;
        private System.Windows.Forms.Button Button_pen;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ts_color;
        private System.Windows.Forms.ToolStripMenuItem ts_fill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar db_width;
        private System.Windows.Forms.Button button_eraser;
    }
}

