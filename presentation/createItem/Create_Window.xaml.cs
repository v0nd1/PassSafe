using Microsoft.Win32;
using PassSafe.data.model;
using PassSafe.model;
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
    /// Логика взаимодействия для Create_Window.xaml
    /// </summary>
    public partial class Create_Window : Window
    {
        private readonly PassItemContext _context;
        public Create_Window()
        {
            InitializeComponent();
            _context = new PassItemContext();
        }

        private void BrowseImageButton(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;

                // Определяем путь к папке Images внутри директории проекта
                string projectPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string imagesPath = System.IO.Path.Combine(projectPath, "Images");

                // Если папка Images не существует, создаем ее
                if (!System.IO.Directory.Exists(imagesPath))
                {
                    System.IO.Directory.CreateDirectory(imagesPath);
                }

                // Формируем путь для сохранения выбранного файла изображения в папке Images
                string targetPath = System.IO.Path.Combine(imagesPath, System.IO.Path.GetFileName(imagePath));

                // Копируем выбранный файл изображения в папку Images
                System.IO.File.Copy(imagePath, targetPath, true);

                // Обновляем путь к изображению в ресурсе PlaceImage
                Uri newImageUri = new Uri(targetPath, UriKind.Absolute);
                var brush = (ImageBrush)this.Resources["PlaceImage"];
                brush.ImageSource = new BitmapImage(newImageUri);
            }
        }



        private void Create(object sender, RoutedEventArgs e)
        {
            // Получаем значения из текстовых полей
            string imageSource = "/Images/telegram.png";
            string title = TitleBox.Text;
            string login = LoginBox.Text;
            string password = PassBox.Text;
            string category = ((ComboBoxItem)CategoryComboBox.SelectedItem).Content.ToString();

            switch (category)
            {
                case "Все":
                    category = "AllPasses";
                    break;
                case "Избранное":
                    category = "Favorites";
                    break;
                case "Соц.Сети":
                    category = "SocialNetworks";
                    break;
                case "Карты":
                    category = "Cards";
                    break;
                case "Кошельки":
                    category = "Wallets";
                    break;
                case "Системы":
                    category = "Systems";
                    break;
                default:
                    MessageBox.Show("Заполните все поля");
                    break;
            }

            // Создаем новый объект PassItem
            PassItem newItem = new PassItem
            {
                ImageSource = imageSource,
                Title = title,
                Login = login,
                Password = password,
                Category = category
            };

            // Добавляем новый объект в контекст базы данных
            _context.passItem.Add(newItem);

            // Сохраняем изменения в базе данных
            _context.SaveChanges();

            // Закрываем окно создания пароля
            Close();
        }
    }
}
