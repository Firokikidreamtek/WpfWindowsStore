using MahApps.Metro.Controls;
using System.Windows;
using WpfWindowsStore.Pages;
using WpfWindowsStore.UserControllers;

namespace WpfWindowsStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private Main MainWindowContentPage;
        private TopAppsWrapped MyTopAppsWrappedPage;
        private DownloadsAndUpdates DownloadsAndUpdatesPage;


        public MainWindow()
        {
            InitializeComponent();
            MainWindowContentPage = new Main();
            MainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;
            MainWindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;
            MainWindowContentPage.DownloadsAndUpdatesClicked += MainWindowContentPage_DownloadsAndUpdatesClicked;

            MyTopAppsWrappedPage = new TopAppsWrapped();
            MyTopAppsWrappedPage.AnAppClicked += MainWindowContentPage_AppClicked;
            MyTopAppsWrappedPage.BackButtonClicked += BackButtonClicked;

            DownloadsAndUpdatesPage = new DownloadsAndUpdates();
            DownloadsAndUpdatesPage.BackButtonClicked += BackButtonClicked;
        }

        private void MainWindowContentPage_DownloadsAndUpdatesClicked()
        {
            MainWindowFrame.Content = DownloadsAndUpdatesPage;
        }

        private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            var myAppDetails = new AppDetails(sender);
            MainWindowFrame.Content = myAppDetails;
            myAppDetails.BackButtonClicked += BackButtonClicked;
            myAppDetails.AppClicked += MainWindowContentPage_AppClicked;

        }

        private void MainWindowContentPage_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MyTopAppsWrappedPage;
        }


        private void BackButtonClicked(object sender, RoutedEventArgs e)
        {
            if (MainWindowFrame.NavigationService.CanGoBack)
            {
                MainWindowFrame.NavigationService.GoBack();
            }
        }

        private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = MainWindowContentPage;
        }


    }
}
