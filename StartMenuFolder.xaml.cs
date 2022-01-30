using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace vpn
{
    /// <summary>
    /// Логика взаимодействия для StartMenuFolder.xaml
    /// </summary>
    public partial class StartMenuFolder : Page
    {
        private string destination_path;

        public StartMenuFolder(string destination_path, string startmenu_path)
        {
            this.destination_path = destination_path;
            InitializeComponent();
            fillPath(startmenu_path);
        }

        private void fillPath(string startmenu_path)
        {
            if(startmenu_path == null)
            {
                Url.Text = "VPN Unlimited";
            }
            else
            {
                Url.Text = startmenu_path;
            }
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.Programs;
            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                Url.Text = folderBrowser.SelectedPath;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DestinationFolder(destination_path, Url.Text));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Url.Text))
            {
                //пустое поле директории
            }
            else
            {
                NavigationService.Navigate(new Shortcut(destination_path, Url.Text));
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CancelConfirm cancelConfirm = new CancelConfirm();
            cancelConfirm.Owner = Window.GetWindow(this);
            cancelConfirm.ShowDialog();
        }
    }
}
