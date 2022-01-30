using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace vpn
{
    /// <summary>
    /// Логика взаимодействия для Shortcut.xaml
    /// </summary>
    public partial class Shortcut : Page
    {
        private string startmenu_path;
        private string destination_path;

        public Shortcut(string destination_path, string startmenu_path)
        {
            this.destination_path = destination_path;
            this.startmenu_path = startmenu_path;
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartMenuFolder(destination_path, startmenu_path));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Complete());
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CancelConfirm cancelConfirm = new CancelConfirm();
            cancelConfirm.Owner = Window.GetWindow(this);
            cancelConfirm.ShowDialog();
        }
    }
}
