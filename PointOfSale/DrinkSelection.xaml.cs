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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Innitilizes window
        /// </summary>
        public DrinkSelection()
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
            FlavorSelection fl = new FlavorSelection();
            NavigationService.Navigate(fl);
        }
    }
}
