using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
	public partial class CV : Form
	{
		string[]//Массив городов для:
			ru, //России
			jp, //Японии
			us, //США
			ch; //Китая              

		public CV()
		{
			InitializeComponent();
			//Инициализация данных
			ru = new string[]
			{
				"Москва",
				"Санкт - Питербург",
				"Уфа",
				"Челябинск"
			};
			jp = new string[]
			{
				"Токио",
				"Иокогама",
				"Осака",
				"Нагоя"
			};
			us = new string[]
			{
				"Нью-Йорк",
				"Майами",
				"Лос-Анжлес",
				"Лас-Вегас"
			};
			ch = new string[]
			{
				"Шанхай",
				"Пекин",
				"Чэнду",
				"Гуанчжоу"
			};
		}
		private void Check(TextBox to_check)
        {
			if (to_check.Text == "")
				to_check.Text = "Неизвестно";
        }
		private void Check(ComboBox to_check)
        {
			if (to_check.SelectedItem == null)
				to_check.Text = "Неизвестно";
		}
		private void country_choice(string[] cities_arr)
        {
			//Метод создан для удобства и избежания дублирования кода
			city.Items.Clear();
			city.Text = "";
			city.Enabled = true;
			city.Items.AddRange(cities_arr);
		}
		private void country_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (country.SelectedItem)
			{
				case "Россия":
					country_choice(ru);
					break;
				case "США":
					country_choice(us);
					break;
				case "Япония":
					country_choice(jp);
					break;
				case "Китай":
					country_choice(ch);
					break;

			}
		}
		private void country_TextChanged(object sender, EventArgs e)
		{
			country.Text ="";
		}
		private void city_TextChanged(object sender, EventArgs e)
		{
			city.Text = "";
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Check(fname);
			Check(sname);
			Check(tname);
			Check(city);
			Check(country);
			MessageBox.Show($"" +
				$"Имя: {fname.Text}\n" +
				$"Фамилия: {sname.Text}\n" +
				$"Отчество: {tname.Text}\n" +
				$"Страна: {country.Text}\n" +
				$"Город: {city.Text}");
		}
	}
}
