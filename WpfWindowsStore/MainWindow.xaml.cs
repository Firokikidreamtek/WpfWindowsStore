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
        }

        private void MainWindowContentPage_DownloadsAndUpdatesClicked()
        {
            //TODO: Step 17: Set the content of the Main Frame to DownloadsAndUpdates
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
            //TODO: Step 15: Set the content to the newly created user control
            //You can now run the app and see that the resolution is quite small
            //For the content that we are displaying
            //GOTO: MainWindow.xaml and change the height width of the window
            MainWindowFrame.Content = MainWindowContentPage;
        }


    }
}
