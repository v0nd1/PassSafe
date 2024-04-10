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
    /// Логика взаимодействия для Generator_Window.xaml
    /// </summary>
    public partial class Generator_Window : Window
    {
        public Generator_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Generate_Password(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(CharacterCountTextBox.Text, out int characterCount))
            {
                if (characterCount > 30)
                {
                    MessageBox.Show("Максимальное количество символов - 30");
                    return;
                }

                string password = GenerateRandomPassword(characterCount);
                CopyBox.Text = password;
            }
            else
            {
                MessageBox.Show("Введите корректное число символов");
            }
        }

        private string GenerateRandomPassword(int characterCount)
        {
            string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            Random random = new Random();
            char[] password = new char[characterCount];

            for (int i = 0; i < characterCount; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }

        private void CopyBox_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(CopyBox.Text))
            {
                Clipboard.SetText(CopyBox.Text);
                MessageBox.Show("Текст скопирован в буфер обмена");
            }
            else
            {
                MessageBox.Show("Нет текста для копирования");
            }
        }
    }
}
