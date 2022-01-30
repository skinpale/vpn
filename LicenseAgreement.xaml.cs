using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vpn
{
    /// <summary>
    /// Логика взаимодействия для LicenseAgreement.xaml
    /// </summary>
    public partial class LicenseAgreement : Page
    {
        public LicenseAgreement(bool license_checked)
        {
            InitializeComponent();
            Accept.IsChecked = license_checked;
            if (license_checked) Next.IsEnabled = true;
            else Next.IsEnabled = false;
            Method();
        }

        private void Method()
        {
            StreamReader rdr = new StreamReader("../../license.txt", Encoding.UTF8);
            License.Text += rdr.ReadToEnd();
            rdr.Close();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            Next.IsEnabled = true;
        }

        private void Not_accept_Click(object sender, RoutedEventArgs e)
        {
            Next.IsEnabled = false;
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DestinationFolder(null, null));
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            CancelConfirm cancelConfirm = new CancelConfirm();
            cancelConfirm.Owner = Window.GetWindow(this);
            cancelConfirm.ShowDialog();
        }
    }
}
