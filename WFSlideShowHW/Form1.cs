using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace WFSlideShowHW
{
	public partial class Form1 : Form
	{
		List<Image> imglist;//Массив со всеми картинками
		Timer t;//Таймер, отсчитывающий интервал, описанный строкой выше
		FolderBrowserDialog fd;

		public Form1()
		{
			InitializeComponent();
			////Инициализация вышеописанных полей
			t = new Timer();
			t.Interval = 1000;
			t.Tick += T_Tick;

			fd = new FolderBrowserDialog();

			imglist = new List<Image>();
			getpictures(Directory.GetCurrentDirectory()+"\\Pictures");
			l_counter_total.Text = imglist.Count.ToString();//Этот счётчик показывает максимальное количество изображений в каталоге с изображениями

		}

		private void T_Tick(object sender, EventArgs e)
		{
			t.Enabled = false;//Отключение таймера и возврат в функцию Toggle();
			Toggle();
		}

		private void getpictures(string dir)
		{
			//Метод ищет картинки в принимаемом каталоге и добавляет их в imglist
			//а так же очищает список если он не пуст
			if (imglist.Count > 0)
				while (imglist.Count>0)
				{
					imglist.Remove(imglist[0]); // Удаляем уже имеющиеся картинки
				}

			foreach (string i in Directory.GetFiles(dir))
			{
				try
				{
					imglist.Add(Image.FromFile(i));
				}
				catch (Exception) { };//Если среди файлов нет файла, который можно превратить в Image, вылезет исключение, данный обработчик исключений просто пропускает неподходящий файл
			}
			l_counter_total.Text = imglist.Count.ToString();
		}
		private void counter()
		{
			for (int i = 0; i < imglist.Count; i++)
			{
				if (imglist[i] == l_display.Image)
				{
					l_counter_current.Text = (i + 1).ToString();
					break;
					//В этом методе мы проходим по списку и ищем нашу картинку
					//После чего присваиваем её индекс +1(т.к. счёт идёт с нуля) к счётчику
				}
			}
		}
		private void bt_prev_Click(object sender, EventArgs e)
		{
			if (l_display.Image == null)
			{
				l_display.Image = imglist[0];
				l_counter_current.Text = "1";
				return;
				//Если изображённой картинки нет, то изображается первая картинка
			}
			else
			{
				//В противном случае ищем картинку в списке
				for (int i = 0; i < imglist.Count; i++)
				{
					if (imglist[i] == l_display.Image)
					{
						if (l_display.Image == imglist[0])
						{
							//Если это первое изображение в списке, тогда отображаем последнюю
							l_display.Image = imglist[imglist.Count - 1];
							l_counter_current.Text = (imglist.Count).ToString();
						}
						else
						{
							l_display.Image = imglist[i - 1];//Если не первое изображение, то выводим предыдущее
							l_counter_current.Text = (i).ToString();
						}
						break;
					}
				}
			}
		}

		private void bt_next_Click(object sender, EventArgs e)
		{
			//Работа этого метода аналогична методу bt_prev_Click
			if (l_display.Image == null)
			{
				l_display.Image = imglist[0];
				l_counter_current.Text = "1";
				return;
			}
			else if (l_display.Image == imglist[imglist.Count - 1])
				l_display.Image = imglist[0];
			else
			{
				for (int i = 0; i < imglist.Count; i++)
				{
					if (imglist[i] == l_display.Image)
					{
						l_display.Image = imglist[i + 1];
						break;
					}
				}
			}
			for (int i = 0; i < imglist.Count; i++)
			{
				if (imglist[i] == l_display.Image)
				{
					l_counter_current.Text = (i + 1).ToString();
					break;
				}
			}
		}

		private void ts_custom_Click(object sender, EventArgs e)
		{
			if (fd.ShowDialog() == DialogResult.OK)
			{
				bt_prev.Enabled = false;
				bt_next.Enabled = false;
				getpictures(fd.SelectedPath);
			}
		}

		private void Toggle()
		{
			
			if (bt_startstop.Text == "Stop")
			{
				Random rand = new Random();//Рандом для того, чтобы "достать" случайное изображение из массива
				Image next;//Изображение, которое должно быть следующим. Сразу изображение не появляется, чтобы избежать бага, в котором на экран выводится то же изображение что и было
			mark://Метка для того случая, в котором рандомно выбирается то же изображение, что и на экране
				next = imglist[rand.Next(0, imglist.Count)];//Присваивание рандомного изображения из списка
				if (l_display.Image == next)
					goto mark;//Данный if был сделан для того, чтобы случайно не выпадала одна и та же картинка
				l_display.Image = next;//Если изображение прошло проверку, то оно будет изображено
				counter();//метод, присваивающий значение в счётчик
				Update();
				t.Enabled = true;//Включение таймера
				t.Start();
			}
		}
		private void bt_startstop_Click(object sender, EventArgs e)
		{
			if (imglist.Count == 0)
			{
				bt_next.Enabled = false;
				bt_prev.Enabled = false;
				l_counter_current.Text = "Не найдено";
				l_display.Image = null;
				MessageBox.Show("Не удалось найти изображения в указаном каталоге");
				return;
			}
            else
            {
				bt_prev.Enabled = true;
				bt_next.Enabled = true;
				bt_startstop.Enabled = true;
            }
			if (bt_startstop.Text.ToLower() == "start")
			{
				bt_next.Enabled = false;
				bt_prev.Enabled = false;
				bt_startstop.Text = "Stop";
				Toggle();
			}
			else if (bt_startstop.Text.ToLower() == "stop")
			{
				bt_next.Enabled = true;
				bt_prev.Enabled = true;
				bt_startstop.Text = "Start";
			}
		}

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
			Settings s = new Settings();
			s.ShowDialog();
			t.Interval =  s.returnable * 1000;
        }
    }
}
