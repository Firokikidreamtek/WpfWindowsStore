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
    /// Interaction logic for OverView.xaml
    /// </summary>
    public partial class OverView : UserControl
    {
        public delegate void OnAppDetails_Clicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetails_Clicked AppClicked;


        public OverView()
        {
            InitializeComponent();
            AppsViewerInsideOwerviewTab.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
        }

        private void AppsViewerInsideOwerviewTab_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }
    }
}
