using Microsoft.EntityFrameworkCore;
using PassSafe.data.model;
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

namespace PassSafe.presentation.auth
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        private readonly PassItemContext _dbContext;
        public Registration()
        {
            InitializeComponent();
            _dbContext = new PassItemContext();
        }


        private void CheckBox_Click1(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked.HasValue)
            {
                if (checkBox.IsChecked.Value)
                {
                    TextBox1.Text = PassBox1.Password;
                    TextBox1.Visibility = Visibility.Visible;
                    PassBox1.Visibility = Visibility.Hidden;
                }
                else
                {
                    PassBox1.Password = TextBox1.Text;
                    TextBox1.Visibility = Visibility.Hidden;
                    PassBox1.Visibility = Visibility.Visible;
                }
            }
        }

        private void CheckBox_Click2(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked.HasValue)
            {
                if (checkBox.IsChecked.Value)
                {
                    TextBox2.Text = PassBox2.Password;
                    TextBox2.Visibility = Visibility.Visible;
                    PassBox2.Visibility = Visibility.Hidden;
                }
                else
                {
                    PassBox2.Password = TextBox2.Text;
                    TextBox2.Visibility = Visibility.Hidden;
                    PassBox2.Visibility = Visibility.Visible;
                }
            }
        }
        private void To_Login_Button(object sender, RoutedEventArgs e)
        {
            LoginForm loginWindow = new LoginForm();
            loginWindow.Show();
            Close();
        }

        private void Reg_Button(object sender, RoutedEventArgs e)
        {
            var enteredLogin = LoginBox.Text; 
            var enteredPass1 = PassBox1.Password;
            var enteredTextPass1 = TextBox1.Text;

            var enteredPass2 = PassBox2.Password;
            var enteredTextPass2 = TextBox2.Text;

            if (string.IsNullOrEmpty(enteredLogin) || string.IsNullOrEmpty(enteredPass1) || string.IsNullOrEmpty(enteredPass2) || string.IsNullOrEmpty(enteredTextPass1) || string.IsNullOrEmpty(enteredTextPass2))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return; 
            }


            var newUser = new User { Login = enteredLogin, Password = enteredPass1 };

            if (enteredPass1 != enteredPass2 || enteredTextPass1 != enteredTextPass2)
            {
                MessageBox.Show("Введенные пароли не совпадают");
            }
            else
            {
                try
                {
                    _dbContext.user.Add(newUser);
                    _dbContext.SaveChanges();
                    LoginForm loginWindow = new LoginForm();
                    loginWindow.Show();
                    Close();
                }
                catch (DbUpdateException ex)
                {
                    // Выводим сообщение об ошибке
                    MessageBox.Show("Произошла ошибка при сохранении изменений в базе данных: " + ex.InnerException.Message);
                }
                
            }
        }
    }
}
