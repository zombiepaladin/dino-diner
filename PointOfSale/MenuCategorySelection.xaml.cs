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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// Initilizes window
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ComboSelection s = new ComboSelection();
            NavigationService.Navigate(s);

        }
        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            EntreeSelection s = new EntreeSelection();
            NavigationService.Navigate(s);
        }
        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SideSelection s = new SideSelection();
            NavigationService.Navigate(s);
        }
        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            DrinkSelection s = new DrinkSelection();
            NavigationService.Navigate(s);
        }
    }
}
