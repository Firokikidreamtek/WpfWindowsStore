using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using WpfWindowsStore.UserControllers;

namespace WpfWindowsStore.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public delegate void OnDownloadsAndUpdatesClicked();
        public event OnDownloadsAndUpdatesClicked DownloadsAndUpdatesClicked;

        public Main()
        {
            InitializeComponent();

            DealsAppsViewer.AppClicked += AnAppClicked;

            ProductivityTopApps.AppClicked += AnAppClicked;

            ProductivityAppsL1.AppClicked += AnAppClicked;
            ProductivityAppsL2.AppClicked += AnAppClicked;
            ProductivityAppsL3.AppClicked += AnAppClicked;

            EntertainmentAppsViewer.AppClicked += AnAppClicked;

            GamingAppsViewer.AppClicked += AnAppClicked;

            TopApps.AppClicked += AnAppClicked;
            TopApps.TopAppButtonClicked += TopApps_TopAppButtonClicked;
            FeaturesAppsViewer.AppClicked += AnAppClicked;
            MostPopularAppsViewer.AppClicked += AnAppClicked;
            TopFreeAppsViewer.AppClicked += AnAppClicked;
            TopFreeGamesAppsViewer.AppClicked += AnAppClicked;

            RightHeaderButtons.HeaderRightButtonsDownloadButtonClick += RightHeaderButtons_HeaderRightButtonsDownloadButtonClick;
        }

        private void RightHeaderButtons_HeaderRightButtonsDownloadButtonClick(object sender, RoutedEventArgs e)
        {
            DownloadsAndUpdatesClicked();
        }

        private void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void TopApps_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked(sender, e);
        }

        private void MainScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            var element = (UIElement)sender;
            element.Opacity = 0;
            var animation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(new TimeSpan(0, 0, 2))
            };
            element.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        private void Page_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RightHeaderButtons.MouseDown_OutsideOfHeaderRightButtons();
        }
    }
}
