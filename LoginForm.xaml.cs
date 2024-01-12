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
        }

        private string stored_pass = "dima";

        private void Login_Button(object sender, RoutedEventArgs e)
        {
            var enteredPass = PassBox.Password;

            if(enteredPass != stored_pass)
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
