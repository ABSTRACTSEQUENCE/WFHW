using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> buttons;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button>();
            add_buttons(r_1);
            add_buttons(r_2);
            add_buttons(r_3);
            add_buttons(r_4);
            foreach (Button button in buttons)
            {
                SolidColorBrush bruh = new SolidColorBrush();
                string[] red = { "`", "1", "2", "Q", "A", "Z", "9", "I", "K", "," };
                string[] yellow = { "3", "W", "S", "X", "0", "O", "L", "." };
                string[] green = { "4", "E", "D", "C","P", "-", "=", "[", "]", "\\", ";", "'", "/" };
                string[] blue = { "5", "6", "R", "T", "F", "G", "V", "B" };
                string[] purple = { "Y", "U", "H", "J", "N", "M", "7","8"};
                for (int i = 0; i < red.Length; i++)
                    if (button.Content.ToString() == red[i])
                    {
                        bruh.Color = Colors.Red;
                        button.Background = bruh;
                    }

                for (int i = 0; i < yellow.Length; i++)
                    if (button.Content.ToString() == yellow[i])
                    {

                        bruh.Color = Colors.Black;
                        button.Foreground = new SolidColorBrush(Colors.Black);
                        bruh.Color = Colors.Yellow;
                        button.Background = bruh;
                    }

                for (int i = 0; i < green.Length; i++)
                    if (button.Content.ToString() == green[i])
                    {
                        bruh.Color = Colors.Green;
                        button.Background = bruh;
                    }

                for (int i = 0; i < blue.Length; i++)
                    if (button.Content.ToString() == blue[i])
                    {
                        bruh.Color = Colors.Blue;
                        button.Background = bruh;
                    }

                for (int i = 0; i < red.Length; i++)
                    if (button.Content.ToString() == red[i])
                    {
                        bruh.Color = Colors.Red;
                        button.Background = bruh;
                    }

                for (int i = 0; i < purple.Length; i++)
                    if (button.Content.ToString() == purple[i])
                    {
                        bruh.Color = Colors.Purple;
                        button.Background = bruh;
                    }

            }

        }
        private void add_buttons(StackPanel sp)
        {
            for (int i = 0; i < sp.Children.Count; i++)
            {
                buttons.Add((Button)sp.Children[i]);
            }
        }
     
    } 
}
