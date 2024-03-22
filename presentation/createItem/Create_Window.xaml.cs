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
        public Create_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Create_Window create_Window = new Create_Window();
            create_Window.Close();
        }
    }
}
