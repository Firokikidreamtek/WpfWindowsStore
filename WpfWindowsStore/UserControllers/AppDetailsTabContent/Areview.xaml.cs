using MiscUtil;
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
    /// Interaction logic for Areview.xaml
    /// </summary>
    public partial class Areview : UserControl
    {
        //TODO: Step 5: Create a list of commentators as an attribute
        List<string> Names;
        public Areview()
        {
            InitializeComponent();
            Names = new List<string>() { "Viktoria", "Mike", "Zoltan", "Maria", "Daniel", "Emma" };
            //TODO: Step 6: Choose the name of the reviewer randomly
            string reviewerName = Names[StaticRandom.Next(Names.Count)];
            ReviewerNameLabel.Content = reviewerName;
            //TODO: Step 7: Assign the first letter of the name as the avatar
            AvatarLabel.Content = reviewerName[0];
            NumOfStarsLabel.Content = GetRandomNumOfStars();
            ReivewTitle.Content = GetReviewTitleBasedOnStars(NumOfStarsLabel.Content.ToString());
        }
        //TODO: Step 8: Write this methor that return a random number of stars
        private string GetRandomNumOfStars()
        {
            string content = "";
            for (int i = 0; i < StaticRandom.Next(1, 6); i++)
            {
                content += "★";
            }
            return content;
        }
        //TODO: Step 9: Write this method that creates a review based on the number of stars
        //GOTO: Create Reviews.xaml inside AppDetailsTabContent if not yet created and go to it
        private string GetReviewTitleBasedOnStars(string inStars)
        {
            string retStr = "";
            if (inStars.Length >= 4)
            {
                retStr = "This app is really awesome";
            }
            else if (inStars.Length == 3)
            {
                retStr = "This app is all right";
            }
            else
            {
                retStr = "This app is poor";
            }
            return retStr;
        }
    }
}
