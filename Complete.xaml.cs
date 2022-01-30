using System.Windows;
using System.Windows.Controls;

namespace vpn
{
    /// <summary>
    /// Логика взаимодействия для Complete.xaml
    /// </summary>
    public partial class Complete : Page
    {
        public Complete()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            Window currentWindow = (Window)sender;
            currentWindow.Close();
        }
    }
}
