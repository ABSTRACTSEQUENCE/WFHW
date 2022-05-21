using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace HW5_Paint
{
	/*TODO:
	1) Pen tool --------- DONE
	2) Line tool
	3) Figures (square/rectangle, circle)----DONE
	4) Color picker for tools above----DONE
	
	OPTIONAL:
	1) Themes
	2) Text tool*/
	public partial class Form1 : Form
	{
		Graphics g;
		Brush bruh;
		Image pen;
		Image pen_active;
		Image rect;
		Image rect_active;
		Image eraser;
		Image eraser_active;
		Color color;
		float width;
		DirectoryInfo di;
		Rectangle rectangle; //Прямоугольник, который будет рисовать пользователь
		Point start;//Стартовая точка откуда будут рисоваться фигуры
		public Form1()
		{
			InitializeComponent();
			g = CreateGraphics();//Создание объекта, отвечающего за графику
			di = new DirectoryInfo(Directory.GetCurrentDirectory())//HW\bin\Debug
			.Parent//bin
			.Parent;//HW

			width = db_width.Value;

			color = Color.Black;//Цвет по умолчанию - чёрный

			pen = Image.FromFile(di.FullName + "\\Pictures\\Pen icon.png");//Определение картинки инструмента "Ручка"
			Button_pen.BackgroundImage = pen;//Помещение изображения на кнопку
			pen_active = Image.FromFile(di.FullName + "\\Pictures\\Pen active.png");//Определение картинки инструмента "Ручка" в активном состоянии

			rect = Image.FromFile(di.FullName + "\\Pictures\\Rect.png");//Определение картинки инструмента "Прямоугольник"
			button_rectangle.BackgroundImage = rect;//Помещение изображения на кнопку
			rect_active = Image.FromFile(di.FullName + "\\Pictures\\Rect active.png");//Определение картинки прямоугольника в активном состоянии

			eraser = Image.FromFile(di.FullName + "\\Pictures\\Eraser.png");
			button_eraser.BackgroundImage = eraser;
			eraser_active = Image.FromFile(di.FullName + "\\Pictures\\Eraser active.png");
		}

		private void Button_pen_Click(object sender, EventArgs e)
		{
			if (button_rectangle.BackgroundImage == rect_active)
				button_rectangle.BackgroundImage = rect;
			if (button_eraser.BackgroundImage == eraser_active)
				button_eraser.BackgroundImage = eraser;
			if (Button_pen.BackgroundImage == pen)
			{
				Button_pen.BackgroundImage = pen_active;
				bruh = new SolidBrush(color);
			}
			else
			{
				Button_pen.BackgroundImage = pen;
				bruh.Dispose();
				bruh = null;
			}

		}

		private void button_rectangle_Click(object sender, EventArgs e)
		{
			if(Button_pen.BackgroundImage == pen_active)
				Button_pen.BackgroundImage = pen;
			if (button_eraser.BackgroundImage == eraser_active)
				button_eraser.BackgroundImage = eraser;
			if (button_rectangle.BackgroundImage != rect_active)
			{
				button_rectangle.BackgroundImage = rect_active;
				bruh = new SolidBrush(color);//Инициализация кисти
				rectangle = new Rectangle();//Инициализация прямоугольника
				start = new Point();//Инициализация стартовой точки
			}
			else button_rectangle.BackgroundImage = rect;
		}
		
		
		private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (bruh != null)
			{
				if (MouseButtons == MouseButtons.Left)
				{
					if (button_rectangle.BackgroundImage == rect_active)
					{
						if(!ts_fill.Checked)
						g.DrawRectangle(new Pen(BackColor, width), rectangle);//Удаляем прошлый прямоугольник
						rectangle.Width = e.X - start.X;//Настраиваем ширину
						rectangle.Height = e.Y - start.Y;//Настраиваем высоту
						g.DrawRectangle(new Pen(bruh, width), rectangle);//Рисуем прямоугольник
						if (ts_fill.Checked)
							g.FillRectangle(bruh, rectangle);
						else
						g.FillRectangle(new SolidBrush(BackColor), rectangle);//Заполняем его чтобы избежать коллизии с другими фигурами
					}
					if(button_eraser.BackgroundImage == eraser_active)
						g.FillRectangle(new SolidBrush(BackColor), e.X, e.Y, width, width);
					if (Button_pen.BackgroundImage == pen_active)
						g.FillRectangle(bruh, e.X, e.Y, width, width);
				}
			}
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			start = e.Location;
			rectangle.Location = e.Location;
		}

		private void clear_Click(object sender, EventArgs e)
		{
			g.Clear(BackColor);
		}

		private void ts_color_Click(object sender, EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) 
			{
				color = cd.Color;
				bruh = new SolidBrush(color);
			};
		}

		private void ts_fill_Click(object sender, EventArgs e)
		{
			if (!ts_fill.Checked)
				 ts_fill.Checked = true;
			else ts_fill.Checked = false;
		}

		private void db_width_Scroll(object sender, EventArgs e)
		{
			width = db_width.Value;
		}

		private void button_eraser_Click(object sender, EventArgs e)
		{
			Color prev_color = color;
			if (Button_pen.BackgroundImage == pen_active)
				Button_pen.BackgroundImage = pen;
			if (button_rectangle.BackgroundImage == rect_active)
				button_rectangle.BackgroundImage = rect;
			if (button_eraser.BackgroundImage != eraser_active)
				button_eraser.BackgroundImage = eraser_active;
		}

      
    }
}
