using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassSafe.model
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PassItem> passItems;

        public ObservableCollection<PassItem> PassItems
        {
            get { return passItems; }
            set
            {
                passItems = value;
                OnPropertyChanged(nameof(PassItems));
            }
        }

        public ItemsViewModel()
        {
            PassItems = new ObservableCollection<PassItem>();
            PassItems.Add(new PassItem {
                Title = "Telegram", 
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem {
                Title = "Mail", 
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Telegram",
                ImageSource = "/Images/telegram.png",
                Password = "1234",
                Login = "Huggy"
            });
            PassItems.Add(new PassItem
            {
                Title = "Mail",
                ImageSource = "/Images/email.png",
                Password = "1234",
                Login = "Huggy"
            });
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

