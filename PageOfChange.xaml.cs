using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace GuidingStarKursach
{
    /// <summary>
    /// Логика взаимодействия для PageOfChange.xaml
    /// </summary>
    public partial class PageOfChange : Page
    {
        public PageOfChange()
        {
            InitializeComponent();
        }

        private void Player_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlayerPage());
        }

        private void DungeonMaster_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DMPage());
        }
    }
}
