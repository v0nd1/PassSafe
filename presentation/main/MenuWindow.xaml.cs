using System.Windows;

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
            FramePass.Content = new AllPasses();
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new Fav();
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new AllPasses();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new SocS();
        }

        private void Page4_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new Cards();
        }

        private void Page5_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new Wallet();
        }

        private void Page6_Click(object sender, RoutedEventArgs e)
        {
            FramePass.Content = new Systems();
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
    }
}
