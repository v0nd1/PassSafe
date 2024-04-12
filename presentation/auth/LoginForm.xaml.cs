using PassSafe.data.model;
using PassSafe.presentation.auth;
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
        private readonly PassItemContext _dbContext;
        public LoginForm()
        {
            InitializeComponent();
            _dbContext = new PassItemContext();
            PassBox.KeyDown += PassBox_KeyDown;
            TextBox.KeyDown += TextBox_KeyDown;
        }


        private void PassBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TryLogin();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TryLogin();
            }
        }

       
        private void TryLogin()
        {
            var enteredPass = PassBox.Password;

            var user = _dbContext.user.FirstOrDefault(u => u.Password == enteredPass);

            if (user == null)
            {
                MessageBox.Show("Ошибка входа");
            }
            else
            {
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                Close();
            }
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.IsChecked.HasValue)
            {
                if (checkBox.IsChecked.Value)
                {
                    TextBox.Text = PassBox.Password; 
                    TextBox.Visibility = Visibility.Visible; 
                    PassBox.Visibility = Visibility.Hidden;
                }
                else
                {
                    PassBox.Password = TextBox.Text; 
                    TextBox.Visibility = Visibility.Hidden; 
                    PassBox.Visibility = Visibility.Visible; 
                }
            }
        }
        private void To_Reg_Button(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }
    }
}
