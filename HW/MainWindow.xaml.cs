using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
//using System.Windows.Forms;
namespace HW
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sec;
        int min;
        int length = 5;
        List<Button> buttons;
        int sucessful_count;
        string[][] colors;
        System.Windows.Forms.Timer timer;
        System.Random rand = new System.Random();
        
        public MainWindow()
        {
            InitializeComponent();
            buttons = new List<Button>();
            timer = new System.Windows.Forms.Timer();
            timer.Tick += Timer_Tick;
            add_buttons(r_1);
            add_buttons(r_2);
            add_buttons(r_3);
            add_buttons(r_4);
            string[] red = { "`", "1", "2", "Q", "A", "Z", "9", "I", "K", "," };
            string[] yellow = { "3", "W", "S", "X", "0", "O", "L", "." };
            string[] green = { "4", "E", "D", "C", "P", "-", "=", "[", "]", "\\", ";", "'", "/" };
            string[] blue = { "5", "6", "R", "T", "F", "G", "V", "B" };
            string[] purple = { "Y", "U", "H", "J", "N", "M", "7", "8" };
            t_length.Text = length.ToString();
            colors = new string [][] { red, green, yellow, purple, blue };
            Restore_Colors();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            else sec++;
            time.Content = $"{min}:{sec}";           
        }
        private string generate()
        {
            string add;
            string str ="";
            for (int i = 0; i < length; i++)
            {
                add = buttons[rand.Next(0, buttons.Count)].Content.ToString().ToLower();
                while (add == "bck" || add == "tab" || add == "enter" || add == "caps" || add == "shift")
                    add = buttons[rand.Next(0, buttons.Count)].Content.ToString().ToLower();

                str += add;
            }
            return str;
        }

        private void Restore_Colors()
        {
            foreach (Button button in buttons)
            {
                for (int i = 0; i < colors.Length; i++)
                    for (int j = 0; j < colors[i].Length; j++)
                        if (button.Content.ToString() == colors[i][j])
                            switch (i)
                            {
                                case 0:
                                    button.Background = new SolidColorBrush(Colors.Red);
                                    break;
                                case 1:
                                    button.Background = new SolidColorBrush(Colors.Green);
                                    break;
                                case 2:
                                    button.Background = new SolidColorBrush(Colors.Yellow);
                                    button.Foreground = new SolidColorBrush(Colors.Black);
                                    break;
                                case 3:
                                    button.Background = new SolidColorBrush(Colors.Purple);
                                    break;
                                case 4:
                                    button.Background = new SolidColorBrush(Colors.Blue);
                                    break;
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

        private void text_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pressed = text_input.Text.ToUpper();
            Restore_Colors();
            for (int i =0; i < buttons.Count; i++)
            {            
                if (pressed.EndsWith((string)buttons[i].Content))
                {
                    buttons[i].Background = new SolidColorBrush(Colors.Black);
                    buttons[i].Foreground = new SolidColorBrush(Colors.White);
                }
            }
            if (text_input.Text == text_target.Text)
            {
                sucessful_count++;
                l_succesful.Content = sucessful_count;
                text_input.Text = "";
                text_target.Text = generate();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (start.Content == "stop")
            {
                timer.Stop();
                MessageBox.Show($"Успешно : {sucessful_count}\nВремя: {time.Content}");
                time.Content = "0:0";
                start.Content = "start";
                text_target.Text = text_input.Text = "";
            }
            else
            {
                min = 0;
                sec = 0;
                time.Content = "0:0";
                timer.Start();
                timer.Interval = 1000;
                sucessful_count = 0;
                l_succesful.Content = sucessful_count;
                start.Content = "stop";
                text_input.IsEnabled = true;
                text_target.Text = generate();
            }
        }

        private void t_length_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 1; i <= 9; i++) 
            {
                if (t_length.Text == i.ToString()) 
                {
                    length = System.Convert.ToInt32(t_length.Text); 
                    return; 
                }
            }
                t_length.Text = length.ToString();
                
            
                    
        }
    }
}
