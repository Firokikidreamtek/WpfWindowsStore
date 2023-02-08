using System;
using System.Collections.Generic;
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

namespace WpfWindowsStore.UserControllers
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnApp> PresentedApps;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AppsViewer()
        {
            InitializeComponent();
            PresentedApps = new List<AnApp>();
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 16; i++)
            {
                AnApp curr = new AnApp();
                curr.AppClicked += Curr_AppClicked;
                PresentedApps.Add(curr);
            }
        }

        private void ScrollerLeftButton_Click(object sender, RoutedEventArgs e)
        {
            double widthOfOneApp = PresentedApps.First().ActualWidth + 2 * PresentedApps.First().Margin.Left;
            AppScrollView.ScrollToHorizontalOffset(AppScrollView.HorizontalOffset - 4 * widthOfOneApp);
        }

        private void ScrollerRightButton_Click(object sender, RoutedEventArgs e)
        {
            double widthOfOneApp = PresentedApps.First().ActualWidth + 2 * PresentedApps.First().Margin.Left;
            AppScrollView.ScrollToHorizontalOffset(AppScrollView.HorizontalOffset + 4 * widthOfOneApp);
        }


        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;
            var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
            eventArg.RoutedEvent = UIElement.MouseWheelEvent;
            eventArg.Source = sender;
            var parent = ((Control)sender).Parent as UIElement;
            parent.RaiseEvent(eventArg);
        }
    }
}
