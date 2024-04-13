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
    /// Логика взаимодействия для Systems.xaml
    /// </summary>
    public partial class Systems : Page
    {
        private readonly PassItemContext _context;
        public List<PassItem> SystemsPassItem { get; set; }
        public Systems()
        {
            InitializeComponent();
            _context = new PassItemContext();
            LoadPassItems();
            DataContext = this;
        }
        private void LoadPassItems()
        {
            SystemsPassItem = _context.passItem.Where(item => item.Category == "Systems").ToList();
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
