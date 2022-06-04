using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFListHW
{
    /// <summary>
    /// Логика взаимодействия для Data.xaml
    /// </summary>
    public partial class Data : Window
    {
        public Car send { get; set; }
        public Data()
        {
            InitializeComponent();
            
        }
        private void change(string what)
        {
            send = new Car();
            switch (what.ToLower())
            {
                case "name": 
                    send.name = tb_name.Text;
                    break;
                case "eng":
                    try
                    {
                        send.eng_power = Convert.ToDouble(tb_eng.Text);
                    }
                    catch (FormatException) 
                    {
                        tb_eng.Text = "";
                        MessageBox.Show("Доступны только числовые значения");
                    };
                    break;

            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            change("name");
        }

        private void tb_eng_TextChanged(object sender, TextChangedEventArgs e)
        {
            change("eng");
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
