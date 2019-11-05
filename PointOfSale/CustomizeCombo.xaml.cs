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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Initilizes window
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            DrinkSelection d = new DrinkSelection();
            NavigationService.Navigate(d);


        }
        /// <summary>
        /// Navigates to the desired window
        /// </summary>
        /// <param name="sender"> sends where it was clicked</param>
        /// <param name="e">and the event argument</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SideSelection d = new SideSelection();
            NavigationService.Navigate(d);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
