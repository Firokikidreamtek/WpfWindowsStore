using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace WpfWindowsStore.Pages
{
    /// <summary>
    /// Interaction logic for DownloadsAndUpdates.xaml
    /// </summary>
    public partial class DownloadsAndUpdates : Page
    {
        public DownloadsAndUpdates()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HamburgerMenuControl_ItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs args)
        {
            HamburgerMenuControl.Content = args.InvokedItem;
        }
    }
}
