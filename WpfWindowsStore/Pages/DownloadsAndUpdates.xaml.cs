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
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public DownloadsAndUpdates()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        private void HamburgerMenuControl_ItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs args)
        {
            HamburgerMenuControl.Content = args.InvokedItem;
        }
    }
}
