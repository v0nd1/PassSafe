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

namespace PassSafe
{
    /// <summary>
    /// Логика взаимодействия для LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {

        
        public LoginForm()
        {
            InitializeComponent();
            //TextBox.Visibility = Visibility.Hidden;
        }

        private string stored_pass = "dima";

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked.HasValue)
            {
                if (checkBox.IsChecked.Value)
                {
                    TextBox.Text = PassBox.Password; // скопируем в TextBox из PasswordBox
                    TextBox.Visibility = Visibility.Visible; // TextBox - отобразить
                    PassBox.Visibility = Visibility.Hidden; // PasswordBox - скрыть
                }
                else
                {
                    PassBox.Password = TextBox.Text; // скопируем в PasswordBox из TextBox 
                    TextBox.Visibility = Visibility.Hidden; // TextBox - скрыть
                    PassBox.Visibility = Visibility.Visible; // PasswordBox - отобразить
                }
            }
        }


        private void Login_Button(object sender, RoutedEventArgs e)
        {
            var enteredPass = PassBox.Password;
            var enteredTextPass = TextBox.Text;

            if (enteredPass != stored_pass && enteredTextPass != stored_pass)
            {
                MessageBox.Show("Ошибка пароля");
            }
            else
            {
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                Close();

            }
        }
    }
}
