using System.Windows;

namespace PasswordBoxHW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Microsoft.Win32.SaveFileDialog sf;
        int changes;
        char ddefault;
        public MainWindow()
        {
            InitializeComponent();
            sf = new Microsoft.Win32.SaveFileDialog();
            sf.FileOk += Sf_FileOk;
            sf.Filter = "Текстовые файлы|*.txt";
            ddefault = passbox.PasswordChar;
        }

        private void bt_clear_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить поле с паролем?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                passbox.Password = "";
        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {
            sf.ShowDialog();
        }

        private void Sf_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.IO.File.WriteAllText(sf.FileName, passbox.Password);
        }

        private void menu_copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(passbox.Password);
        }

        private void menu_paste_Click(object sender, RoutedEventArgs e)
        {
            passbox.Password += Clipboard.GetText();
        }

        private void passbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            changes++;
        }

        private void menu_mask_Click(object sender, RoutedEventArgs e)
        {
            Mask_Select ms = new Mask_Select();
            ms.ShowDialog();
            passbox.PasswordChar = ms.mask;
        }

        private void menu_max_Click(object sender, RoutedEventArgs e)
        {
            bt_max.Visibility = Visibility.Visible;
            max.Visibility = Visibility.Visible;
            l_max.Visibility = Visibility.Visible;
        }

        private void bt_max_Click(object sender, RoutedEventArgs e)
        {
           
            bt_max.Visibility = Visibility.Hidden;
            max.Visibility = Visibility.Hidden;
            l_max.Visibility = Visibility.Hidden;

        }

        private void max_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            //Работа над этим методом в разработке, к сожалению, не успел к дедлайну
        }
        /*TODO:
2)Макс. символов
3)Считывание изменений пароля*/
    }
}
