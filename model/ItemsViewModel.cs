using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PassSafe.model
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<PassItem> allPassItems;
        private ObservableCollection<PassItem> favoritePassItems;
        private ObservableCollection<PassItem> cardsPassItems;
        private ObservableCollection<PassItem> socsPassItem;
        private ObservableCollection<PassItem> systemsPassItem;
        private ObservableCollection<PassItem> walletPassItem;

        public ObservableCollection<PassItem> AllPassItems
        {
            get { return allPassItems; }
            set
            {
                allPassItems = value;
                OnPropertyChanged(nameof(AllPassItems));
            }
        }

        public ObservableCollection<PassItem> FavoritePassItems
        {
            get { return favoritePassItems; }
            set
            {
                favoritePassItems = value;
                OnPropertyChanged(nameof(FavoritePassItems));
            }
        }

        public ObservableCollection<PassItem> СardsPassItems
        {
            get { return cardsPassItems; }
            set
            {
                cardsPassItems = value;
                OnPropertyChanged(nameof(СardsPassItems));
            }
        }

        public ObservableCollection<PassItem> SystemsPassItem
        {
            get { return systemsPassItem; }
            set
            {
                systemsPassItem = value;
                OnPropertyChanged(nameof(SystemsPassItem));
            }
        }
        public ObservableCollection<PassItem> SocsPassItem
        {
            get { return socsPassItem; }
            set
            {
                socsPassItem = value;
                OnPropertyChanged(nameof(SocsPassItem));
            }
        }

        public ObservableCollection<PassItem> WalletPassItem
        {
            get { return walletPassItem; }
            set
            {
                walletPassItem = value;
                OnPropertyChanged(nameof(WalletPassItem));
            }
        }

        public ItemsViewModel()
        {
            AllPassItems = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Telegram",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Mail",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                }
            };
            FavoritePassItems = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "Рехаб",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ЖЕска",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ОГО",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
            };
            СardsPassItems = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "Нови",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Лови",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "Хах",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
            };
            SystemsPassItem = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "Нууу",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ОООА",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "УУУ",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
            };
            SocsPassItem = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "хэйхэй)",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ууу",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ааа",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
            };
            WalletPassItem = new ObservableCollection<PassItem>
            {
                new PassItem
                {
                    Title = "ytds)",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "уdfdsfdsfуу",
                    ImageSource = "/Images/email.png",
                    Password = "1234",
                    Login = "Huggy"
                },
                new PassItem
                {
                    Title = "ааsaaasdsadа",
                    ImageSource = "/Images/telegram.png",
                    Password = "1234",
                    Login = "Huggy"
                },
            };


        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}

