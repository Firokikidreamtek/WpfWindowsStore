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

namespace WpfWindowsStore.UserControllers.AppDetailsTabContent
{
    /// <summary>
    /// Interaction logic for Related.xaml
    /// </summary>
    public partial class Related : UserControl
    {
        public delegate void OnAppDetails_Clicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetails_Clicked AppClicked;

        public Related()
        {
            InitializeComponent();
            AppsViewer1.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
            AppsViewer2.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
            AppsViewer3.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
            AppsViewer4.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
            AppsViewer5.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;

        }

        private void AppsViewerInsideOwerviewTab_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}
