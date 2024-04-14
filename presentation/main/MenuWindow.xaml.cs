using PassSafe.data.events;
using PassSafe.data.model;
using PassSafe.model;
using PassSafe.presentation.delete;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace PassSafe
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();

            // Создайте экземпляры страниц
            AllPasses allPassesPage = new AllPasses();

            // Подпишитесь на события для каждой страницы
            allPassesPage.PassItemClicked += AllPassesPage_PassItemClicked;

            // Установите страницу Fav в качестве контента для FramePass по умолчанию
            FramePass.Content = allPassesPage;
        }

        private void AllPassesPage_PassItemClicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице AllPasses
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }

        private void FavPage_Clicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице Fav
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }
        private void WalletPage_Clicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице Fav
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }
        private void CardsPage_Clicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице Fav
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }
        private void SystemsPage_Clicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице Fav
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }

        private void SocSPage_Clicked(object sender, PassItemEvent e)
        {
            // Обработка нажатия на элемент на странице Fav
            PassItem selectedPassItem = e.SelectedPassItem;
            UpdateUI(selectedPassItem);
        }

        private void UpdateUI(PassItem selectedPassItem)
        {
            // Обновляем информацию в нижнем меню на основе выбранного пароля
            TitleBlock.Text = selectedPassItem.Title;
            Icon.Source = new BitmapImage(new Uri(selectedPassItem.ImageSource, UriKind.RelativeOrAbsolute));
            LoginBlock.Text = selectedPassItem.Login;
            PassBlock.Text = selectedPassItem.Password;
            // Обновите другие элементы интерфейса здесь
        }
        private void Frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.Content is AllPasses allPassesPage)
            {
                allPassesPage.PassItemClicked -= AllPassesPage_PassItemClicked;
            }
        }
       
        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            AllPasses allPassesPage = new AllPasses();
            allPassesPage.PassItemClicked += AllPassesPage_PassItemClicked;
            FramePass.Content = allPassesPage;
        }
        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Fav favPage = new Fav();
            favPage.PassItemClicked += FavPage_Clicked;
            FramePass.Content = favPage;
        }


        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            SocS socsPage = new SocS();
            socsPage.PassItemClicked += SocSPage_Clicked;
            FramePass.Content = socsPage;
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            Cards cardsPage = new Cards();
            cardsPage.PassItemClicked += CardsPage_Clicked;
            FramePass.Content = cardsPage;
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            Wallet walletPage = new Wallet();
            walletPage.PassItemClicked += WalletPage_Clicked;
            FramePass.Content = walletPage;
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            Systems systemsPage = new Systems();
            systemsPage.PassItemClicked += SystemsPage_Clicked;
            FramePass.Content = systemsPage;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            Create_Window create_Window = new Create_Window();
            create_Window.Show();
        }

        private void GenerPassButton_Click(object sender, RoutedEventArgs e)
        {
            Generator_Window generator_Window = new Generator_Window();
            generator_Window.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
           Del_Item del_Item = new Del_Item();  
           del_Item.Show();
        }
    }
}
