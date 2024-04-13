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
    /// Логика взаимодействия для Fav.xaml
    /// </summary>
    public partial class Fav : Page
    {
        private readonly PassItemContext _context;
        public List<PassItem> FavoritePassItems { get; set; }

        
        public Fav()
        {
            InitializeComponent();
            _context = new PassItemContext();
            LoadPassItems();
            DataContext = this;
        }

        private void LoadPassItems()
        {
            FavoritePassItems = _context.passItem.Where(item => item.Category == "Favorites").ToList();
        }
        public event EventHandler<PassItemEvent> PassItemClicked;

        private void PassItem_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный PassItem
            PassItem selectedPassItem = ((Button)sender).DataContext as PassItem;

            // Вызываем событие, передавая информацию о выбранном пароле
            PassItemClicked?.Invoke(this, new PassItemEvent(selectedPassItem));
        }
    }
}
