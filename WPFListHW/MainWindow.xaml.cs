using System.Collections.Generic;
using System.Windows;

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
            cars = new List<Car> { new Car("Toyota Supra", 255, 250) };
            foreach (Car i in cars)
            {
                lview.Items.Add(i);
            }
        }

        private void bt_add_Click(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            data.ShowDialog();
            if (data.send != null)
                lview.Items.Add(data.send);

        }

        private void bt_remove_Click(object sender, RoutedEventArgs e)
        {
            if (lview.SelectedItem == null)
                MessageBox.Show("Элемент не выбран");
            else
                if (MessageBox.Show($"Вы действительно хотите удалить этот элемент?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                lview.Items.Remove(lview.SelectedItem);
            else return;
        }
    }

}
