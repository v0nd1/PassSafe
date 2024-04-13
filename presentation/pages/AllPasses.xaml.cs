using PassSafe.data.events;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PassSafe
{
    /// <summary>
    /// Логика взаимодействия для AllPasses.xaml
    /// </summary>
    public partial class AllPasses : Page
    {
        private readonly PassItemContext _context;

        // Свойство для привязки данных в XAML
        public List<PassItem> AllPassItems { get; set; }

        public event EventHandler<PassItemEvent> PassItemClicked;
        public AllPasses()
        {
            InitializeComponent();

            // Создаем экземпляр PassItemContext
            _context = new PassItemContext();

            // Загружаем PassItem из базы данных
            LoadPassItems();

            // Устанавливаем список PassItem в качестве контекста данных страницы
            DataContext = this;
        }

        private void LoadPassItems()
        {
            // Получаем все PassItem из базы данных
            AllPassItems = _context.passItem.ToList();
        }
        private void PassItem_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный PassItem
            PassItem selectedPassItem = ((Button)sender).DataContext as PassItem;

            // Вызываем событие, передавая информацию о выбранном пароле
            PassItemClicked?.Invoke(this, new PassItemEvent(selectedPassItem));
        }


    }
}
