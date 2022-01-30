using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace vpn
{
    /// <summary>
    /// Логика взаимодействия для DestinationFolder.xaml
    /// </summary>
    public partial class DestinationFolder : Page
    {
        private string startmenu_path = null;

        public DestinationFolder(string destination_path, string startmenu_path)
        {
            this.startmenu_path = startmenu_path;
            InitializeComponent();
            fillPath(destination_path);
        }

        private void fillPath(string destination_path)
        {
            if(destination_path == null)
            {
                Url.Text = "C:\\Program Files (x86)\\VPN Unlimited";
            }
            else
            {
                Url.Text = destination_path;
            }
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                Url.Text = folderBrowser.SelectedPath;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LicenseAgreement(true));
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Url.Text))
            {
                //пустое поле директории
            }
            else
            {
                NavigationService.Navigate(new StartMenuFolder(Url.Text, startmenu_path));
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
