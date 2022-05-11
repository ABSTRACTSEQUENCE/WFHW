
namespace HW4
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
            this.menuStrip_ru = new System.Windows.Forms.MenuStrip();
            this.ts_file = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_new = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_look = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_color = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_pic = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.ts_font = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.ts_load = new System.Windows.Forms.ToolStripButton();
            this.ts_lang = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ru = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_eng = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_ru.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_ru
            // 
            this.menuStrip_ru.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_file,
            this.ts_look});
            this.menuStrip_ru.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_ru.Name = "menuStrip_ru";
            this.menuStrip_ru.Size = new System.Drawing.Size(515, 24);
            this.menuStrip_ru.TabIndex = 0;
            this.menuStrip_ru.Text = "menuStrip1";
            // 
            // ts_file
            // 
            this.ts_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_new,
            this.ts_saveas,
            this.ts_save,
            this.ts_lang});
            this.ts_file.Name = "ts_file";
            this.ts_file.Size = new System.Drawing.Size(48, 20);
            this.ts_file.Text = "Файл";
            // 
            // ts_new
            // 
            this.ts_new.Name = "ts_new";
            this.ts_new.Size = new System.Drawing.Size(180, 22);
            this.ts_new.Text = "Создать";
            this.ts_new.Click += new System.EventHandler(this.ts_new_Click);
            // 
            // ts_saveas
            // 
            this.ts_saveas.Name = "ts_saveas";
            this.ts_saveas.Size = new System.Drawing.Size(180, 22);
            this.ts_saveas.Text = "Сохранить как";
            this.ts_saveas.Click += new System.EventHandler(this.ts_saveas_Click);
            // 
            // ts_save
            // 
            this.ts_save.Name = "ts_save";
            this.ts_save.Size = new System.Drawing.Size(180, 22);
            this.ts_save.Text = "Сохранить";
            this.ts_save.Click += new System.EventHandler(this.ts_save_Click);
            // 
            // ts_look
            // 
            this.ts_look.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_color,
            this.ts_pic});
            this.ts_look.Name = "ts_look";
            this.ts_look.Size = new System.Drawing.Size(39, 20);
            this.ts_look.Text = "Вид";
            // 
            // ts_color
            // 
            this.ts_color.Name = "ts_color";
            this.ts_color.Size = new System.Drawing.Size(180, 22);
            this.ts_color.Text = "Цвет";
            this.ts_color.Click += new System.EventHandler(this.ts_color_Click);
            // 
            // ts_pic
            // 
            this.ts_pic.Name = "ts_pic";
            this.ts_pic.Size = new System.Drawing.Size(180, 22);
            this.ts_pic.Text = "Избражение";
            this.ts_pic.Click += new System.EventHandler(this.ts_pic_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_save,
            this.ts_load,
            this.ts_font});
            this.toolStrip1.Location = new System.Drawing.Point(0, 439);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(515, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_save
            // 
            this.tsb_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "toolStripButton1";
            this.tsb_save.Click += new System.EventHandler(this.ts_save_Click);
            // 
            // ts_font
            // 
            this.ts_font.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_font.Image = ((System.Drawing.Image)(resources.GetObject("ts_font.Image")));
            this.ts_font.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_font.Name = "ts_font";
            this.ts_font.Size = new System.Drawing.Size(23, 22);
            this.ts_font.Text = "toolStripButton1";
            this.ts_font.Click += new System.EventHandler(this.ts_font_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 310);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "";
            // 
            // ts_load
            // 
            this.ts_load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_load.Image = ((System.Drawing.Image)(resources.GetObject("ts_load.Image")));
            this.ts_load.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_load.Name = "ts_load";
            this.ts_load.Size = new System.Drawing.Size(23, 22);
            this.ts_load.Text = "toolStripButton1";
            this.ts_load.Click += new System.EventHandler(this.ts_load_Click);
            // 
            // ts_lang
            // 
            this.ts_lang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ru,
            this.ts_eng});
            this.ts_lang.Name = "ts_lang";
            this.ts_lang.Size = new System.Drawing.Size(180, 22);
            this.ts_lang.Text = "Язык";
            // 
            // ts_ru
            // 
            this.ts_ru.Checked = true;
            this.ts_ru.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ts_ru.Name = "ts_ru";
            this.ts_ru.Size = new System.Drawing.Size(180, 22);
            this.ts_ru.Text = "Русский";
            this.ts_ru.Click += new System.EventHandler(this.ts_ru_Click);
            // 
            // ts_eng
            // 
            this.ts_eng.Name = "ts_eng";
            this.ts_eng.Size = new System.Drawing.Size(180, 22);
            this.ts_eng.Text = "English";
            this.ts_eng.Click += new System.EventHandler(this.ts_en_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(515, 464);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip_ru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_ru;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip_ru.ResumeLayout(false);
            this.menuStrip_ru.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_ru;
        private System.Windows.Forms.ToolStripMenuItem ts_file;
        private System.Windows.Forms.ToolStripMenuItem ts_new;
        private System.Windows.Forms.ToolStripMenuItem ts_saveas;
        private System.Windows.Forms.ToolStripMenuItem ts_save;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton ts_font;
        private System.Windows.Forms.ToolStripMenuItem ts_look;
        private System.Windows.Forms.ToolStripMenuItem ts_color;
        private System.Windows.Forms.ToolStripMenuItem ts_pic;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.ToolStripButton ts_load;
        private System.Windows.Forms.ToolStripMenuItem ts_lang;
        private System.Windows.Forms.ToolStripMenuItem ts_ru;
        private System.Windows.Forms.ToolStripMenuItem ts_eng;
    }
}

