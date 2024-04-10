using PassSafe.data.events;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;
using PassSafe.data.model;

namespace PassSafe.model
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        private PassItemStorage passItemStorage;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PassItem> AllPassItems { get; private set; }

        public ItemsViewModel()
        {
            
            passItemStorage = new PassItemStorage();

            // Инициализируем коллекции для каждой категории
            AllPassItems = new ObservableCollection<PassItem>();
        }


        public void LoadPassItems()
        {
            // Загружаем все элементы из хранилища в соответствующую коллекцию
            AllPassItems.Clear();
            foreach (var category in passItemStorage.GetAllPassItems())
            {
                var passItems = passItemStorage.GetPassItemsByCategory(category.ToString());
                foreach (var passItem in passItems)
                {
                    AllPassItems.Add(passItem);
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

