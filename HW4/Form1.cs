using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
	
	public partial class Form1 : Form
	{
		SaveFileDialog sf;
		FontDialog fd;
		ColorDialog cd;
		OpenFileDialog od;
		bg_choise bg;
		bool new_file_flag = true; // определяет является файл новым или старым
		public Form1()
		{
			InitializeComponent();

			sf = new SaveFileDialog();
			sf.Filter = "Text files |*.txt|Document |*docx";
			sf.Title = "Сохранить как";
			sf.FileOk += Sf_FileOk;

			fd = new FontDialog();

			bg = new bg_choise();

			od = new OpenFileDialog();
			od.Filter = sf.Filter;
			od.Title = "Загрузить";
			cd = new ColorDialog();
		}

		private void localize(string language)
		{
			switch (language.ToLower())
			{
				case "rus":

					ts_eng.Checked = false;
					ts_ru.Checked = true;

					//Вкладка "Файл"
					ts_file.Text = "Файл";
					ts_new.Text = "Создать";
					ts_saveas.Text = "Сохранить как";
					ts_save.Text = "Сохранить";
					ts_lang.Text = "Язык";

					//Вкладка "Вид"
					ts_look.Text = "Вид";
					ts_color.Text = "Цвет";
					ts_pic.Text = "Изображение";

					//Локализация диалоговых окон
					sf.Title = "Сохранить как";
					od.Title = "Загрузить";
					bg.localize("ru");
					break;

				case "eng":

					ts_eng.Checked = true;
					ts_ru.Checked = false;

					//Вкладка "Файл"
					ts_file.Text = "File";
					ts_new.Text = "Create";
					ts_saveas.Text = "Save As";
					ts_save.Text = "Save";
					ts_lang.Text = "Language";

					//Вкладка "Вид"
					ts_look.Text = "Look";
					ts_color.Text = "Color";
					ts_pic.Text = "Image";

					//Локализация диалоговых окон
					sf.Title = "Save as";
					od.Title = "Load";
					bg.localize("eng");
					break;
			}
		}
		private void ts_saveas_Click(object sender, EventArgs e)
		{
			sf.ShowDialog();
		}

		private void Sf_FileOk(object sender, CancelEventArgs e)
		{
			System.IO.File.WriteAllText(sf.FileName, textBox1.Text);
			new_file_flag = false;
		}

		private void ts_save_Click(object sender, EventArgs e)
		{
			if (new_file_flag)
			{
				ts_saveas_Click(sender, e);
				new_file_flag = false;
			}
			else
				System.IO.File.WriteAllText(sf.FileName, textBox1.Text);

		}

		private void ts_new_Click(object sender, EventArgs e)
		{
			
			if (MessageBox.Show(
				"Хотите сохранить файл?",
				"Сохранить?",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Information) == DialogResult.Yes)
			{
				ts_saveas_Click(sender, e);
				new_file_flag = true;
				sf.FileName = "";
			}
			textBox1.Text = "";
			
		}

		private void ts_font_Click(object sender, EventArgs e)
		{
			fd.ShowDialog();
			textBox1.SelectionFont = fd.Font;
		}

		private void ts_color_Click(object sender, EventArgs e)
		{
			if (cd.ShowDialog() != DialogResult.Cancel)
			{
				BackgroundImage = null;
				BackColor = cd.Color;
			}
		}

		private void ts_pic_Click(object sender, EventArgs e)
		{
			
			bg.ShowDialog();
			BackgroundImage = bg.pic;
			
		}

		private void ts_load_Click(object sender, EventArgs e)
		{
			if(od.ShowDialog() != DialogResult.Cancel)
			{
				textBox1.Text = System.IO.File.ReadAllText(od.FileName);
				new_file_flag = false; 
			}
		}

		private void ts_ru_Click(object sender, EventArgs e)
		{
			if (ts_ru.Checked)
				return;
			else
			{
				localize("rus");
			}
				
		}

		private void ts_en_Click(object sender, EventArgs e)
		{
			if (ts_eng.Checked)
				return;
			else
			{
				localize("eng");
			}
		}
	}
}
