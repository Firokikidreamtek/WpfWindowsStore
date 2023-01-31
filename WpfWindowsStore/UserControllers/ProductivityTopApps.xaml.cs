using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfWindowsStore.UserControllers
{
    /// <summary>
    /// Interaction logic for ProductivityTopApps.xaml
    /// </summary>
    public partial class ProductivityTopApps : UserControl
    {
        public delegate void OnAnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAnAppClicked AppClicked;

        public ProductivityTopApps()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //TODO: Step 2: Generate the name of the app based on the name of the 
            //image. This logic you already explaing in chapter 2
            string appName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase
            (
                (sender as Image).Source.ToString().Split('/').Last().Split('.').First().Split('-').Last().Split('.').First()
            );
            //Here we need to create a specific App, we can no longer user a random image
            //So you must create a new constructor in AnApp
            //GOTO: AnApp.xaml.cs
            AppClicked(new AnApp(appName, (sender as Image).Source), e);
        }
    }
}
