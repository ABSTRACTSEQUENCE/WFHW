using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace HW4
{
	public partial class bg_choise : Form
	{
		public Image pic { get; set; }
		DirectoryInfo di;
		OpenFileDialog fd;
		public bg_choise()
		{
			InitializeComponent();

			fd = new OpenFileDialog();

			/////////////переходим в директорию с фоновыми изображениями///(HW4/pics)/////////
			di = new DirectoryInfo(Directory.GetCurrentDirectory());//HW4/bin/debug
			di = di.Parent;//HW4/bin
			di = di.Parent;//HW4/
			foreach (DirectoryInfo i in di.GetDirectories())
				if (i.Name == "pics")//Ищем папку с фонами (pics)
					di = i;//нашли, сохранили в di			
		}
		public void localize(string loc)
        {
			///////////Локализация//////////////////////////////////////////////////
			switch (loc.ToLower())
			{
				case "ru":
					custom.Text = "Выбрать свой фон";
					Text = "Выбрать фон";
					fd.Filter = fd.Filter = "Изображение|*.jpg";
					fd.Title = "Выбрать изображение";
					break;

				case "eng":
					custom.Text = "Custom Background";
					Text = "Choose background";
					fd.Filter = "Image|*.jpg";
					fd.Title = "Choose Image";
					break;
			}
		}
		private void red_Click(object sender, EventArgs e)
		{
			pic = Image.FromFile(di.FullName + "\\red_bg.jpg");
			Close();
		}

		private void black_Click(object sender, EventArgs e)
		{
			pic = Image.FromFile(di.FullName + "\\black_bg.jpg");
			Close();
		}

		private void blue_Click(object sender, EventArgs e)
		{
			pic = Image.FromFile(di.FullName + "\\blue_bg.jpg");
			Close();
		}

		private void pink_Click(object sender, EventArgs e)
		{
			pic = Image.FromFile(di.FullName + "\\pink_bg.jpg");
			Close();
		}

		private void custom_Click(object sender, EventArgs e)
		{
			
			if (fd.ShowDialog() == DialogResult.OK)
			{
				pic = Image.FromFile(fd.FileName);
				Close();
			}
			else return;

		}
	}
}
