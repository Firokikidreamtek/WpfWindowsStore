using System.Windows;
using System.Windows.Controls;

namespace WpfWindowsStore.UserControllers.HamburgerMenuViews
{
    public partial class AllOwned : UserControl
    {
        public AllOwned()
        {
            InitializeComponent();
            HamHeader.FilterMenuItemClicked += HamHeader_FilterMenuItemClicked;
            HamHeader.SortByMenuItemClicked += HamHeader_SortByMenuItemClicked;
        }

        private void HamHeader_SortByMenuItemClicked(object sender, RoutedEventArgs e)
        {
            //TODO: Step 5: Add the following if statement
            //Essentially here we get which tab item is selected forwarded form the
            //Menu header user conrol
            //In THIS user control we have access to both the selected filtering type
            //as well as the app list itself
            //Now all we have to do is set the correct filtering types as soon as the
            //user selects one, ie as soon as this event is fired
            if ((sender as MenuItem).Header.ToString().ToLower() == "all types")
            {
                HamAppsList.AddAll();
            }
            else
            {
                //Here we can just filter by the header, because the header already contains 
                //The string we want to sort by
                HamAppsList.FilterByType((sender as MenuItem).Header.ToString());
            }
        }

        private void HamHeader_FilterMenuItemClicked(object sender, RoutedEventArgs e)
        {
            //TODO: Step 6: Here there is only two options
            //we either sort by name of by date (most recent) , so we don't need to check 
            //both conditions. Important to point out this logic will break 
            //if we add more menu items For example sort by author, 
            //pushlisher etc. GOTO: MainWindow.xaml
            if ((sender as MenuItem).Header.ToString().ToLower() == "sort by name")
            {
                HamAppsList.SortByName();
            }
            else
            {
                HamAppsList.SortByDate();
            }
        }
    }

    
}
