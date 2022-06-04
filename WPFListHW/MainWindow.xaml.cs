using System.Windows;
using System.Collections.Generic;
using System.Collections;

namespace WPFListHW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> cars;
    public MainWindow()
        {
            InitializeComponent();
            cars = new List<Car> { new Car("supra", 255, 250) };
            lview.ItemsSource = cars;
            
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            data.ShowDialog();
            if (data.send != null)
               cars.Add(data.send);
            /*Простите за не выполненное ДЗ, я так и не понял как добавлять элементы в ListView
             При попытке добавить напрямую вылезает исключение, если добавлять через словарь, объявленный в
            xaml, то там при добавлении элемент добавляется в новый ключ, а наши машины находятся в ключе cars и поэтому их не будет отображать
            При попытке добавить через список, по неизвестной для меня причине, элемент не добавляется в ListView (хотя в список добавляется спокойно)
            */

        }
    }

}
