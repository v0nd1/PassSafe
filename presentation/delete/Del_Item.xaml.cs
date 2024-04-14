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

namespace PassSafe.presentation.delete
{
    /// <summary>
    /// Логика взаимодействия для Del_Item.xaml
    /// </summary>
    public partial class Del_Item : Window
    {
        private readonly PassItemContext _context;
        public List<PassItem> AllPassItems { get; set; }
        public Del_Item()
        {
            InitializeComponent();
            _context = new PassItemContext();
            LoadPassItems();
            DataContext = this;
        }
        private void LoadPassItems()
        {
            AllPassItems = _context.passItem.ToList();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем кнопку, на которую нажали
            Button button = sender as Button;

            // Получаем элемент данных, соответствующий нажатой кнопке
            PassItem passItem = button.DataContext as PassItem;

            // Удаляем элемент из базы данных
            _context.passItem.Remove(passItem);

            // Удаляем элемент из коллекции для отображения
            AllPassItems.Remove(passItem);

            // Обновляем отображение списка элементов
            UpdatePassItems();

            // Сохраняем изменения в базе данных
            int affectedRows = _context.SaveChanges();

            // Проверяем, был ли элемент успешно удален
            if (affectedRows > 0)
            {
                // Если элемент удален успешно, показываем сообщение об успехе
                MessageBox.Show("Элемент успешно удален из базы данных.");
            }
            else
            {
                // Если элемент не был удален, показываем сообщение о неудаче
                MessageBox.Show("Не удалось удалить элемент из базы данных.");
            }
        }

        // Метод для обновления отображения списка элементов
        private void UpdatePassItems()
        {
            // Очищаем элементы отображения
            MyItemsControl.ItemsSource = null;

            // Устанавливаем новую коллекцию элементов для отображения
            MyItemsControl.ItemsSource = AllPassItems;
        }



    }
}
