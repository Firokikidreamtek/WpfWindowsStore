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

namespace WpfWindowsStore.UserControllers.HamburgerMenuViews
{
    /// <summary>
    /// Interaction logic for HambugerMenuAppList.xaml
    /// </summary>
    public partial class HambugerMenuAppList : UserControl
    {
        public List<HamguerMenuApp> AllApps;
        public List<HamguerMenuApp> AppsOnFilter;
        public HambugerMenuAppList()
        {
            AllApps = new List<HamguerMenuApp>();
            AppsOnFilter = new List<HamguerMenuApp>();
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                AddNewHamApp();
            }
        }
        private void AddNewHamApp()
        {
            HamguerMenuApp anApp = new HamguerMenuApp();
            MainStackPanel.Children.Add(anApp);
            AllApps.Add(anApp);
        }
        //TODO: Step 14: Same with here AddToMainStackPanel
        public void FilterByType(string inFilter)
        {
            AppsOnFilter = AllApps.Where(p => p.Type == inFilter).ToList<HamguerMenuApp>();
            AddToMainStackPanel(AppsOnFilter);
        }
        //TODO: Step 13: You can make use of AddToMainStackPanel here as well
        public void AddAll()
        {
            AppsOnFilter = new List<HamguerMenuApp>();
            AddToMainStackPanel(AllApps);
        }
        //TODO: Step 12: Same idea as sort by Date, just need the if statement
        public void SortByName()
        {
            List<HamguerMenuApp> AllAppsSorted = new List<HamguerMenuApp>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderBy(p => p.AppName).ToList<HamguerMenuApp>();
            }
            else
            {
                AllAppsSorted = AppsOnFilter.OrderBy(p => p.AppName).ToList<HamguerMenuApp>();
            }
            AddToMainStackPanel(AllAppsSorted);
        }
        //TODO: Step 11: Refactor sort by date so that it includes this if statement
        //Here we need to check whether the list is already filtered, if it is
        //Then we want to sort the filtered list not the whole apps list
        //Lastly we make use of the newly created function that will be reused above as well
        public void SortByDate()
        {
            List<HamguerMenuApp> AllAppsSorted = new List<HamguerMenuApp>();
            if (AppsOnFilter.Count < 1)
            {
                AllAppsSorted = AllApps.OrderByDescending(p => p.Purchased).ToList<HamguerMenuApp>();
            }
            else
            {
                AllAppsSorted = AppsOnFilter.OrderByDescending(p => p.Purchased).ToList<HamguerMenuApp>();
            }
            AddToMainStackPanel(AllAppsSorted);
        }
        //TODO: Step 10: Add this function which will reduce lots of lines of code
        //Essentially this just displays a list to the main stack panel
        private void AddToMainStackPanel(List<HamguerMenuApp> inList)
        {
            MainStackPanel.Children.Clear();
            foreach (HamguerMenuApp item in inList)
            {
                MainStackPanel.Children.Add(item);
            }
        }

    }
}
