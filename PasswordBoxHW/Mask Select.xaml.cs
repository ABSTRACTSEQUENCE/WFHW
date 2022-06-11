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

namespace PasswordBoxHW
{
    /// <summary>
    /// Логика взаимодействия для Mask_Select.xaml
    /// </summary>
    public partial class Mask_Select : Window
    {
        
        public char mask { get; set; }
        public Mask_Select()
        {
            InitializeComponent();
        }


        private void change(object sender, RoutedEventArgs e)
        {
            Button bt = (Button)sender;
            mask = bt.Content.ToString().ToCharArray()[0];
            Close();
        }
    }
}
