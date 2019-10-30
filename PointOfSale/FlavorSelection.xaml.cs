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
using DinoDiner.Menu;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {

        private FlavorSelection Flavor { get; set; }

        public FlavorSelection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Navigates back to drinks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }

        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnCherry(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnVinilla(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnLime(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnChocolate(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnOrange(object sender, RoutedEventArgs e)
        {

        }


        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnCola(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Adds flavor to drink
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void onRootBeer(object sender, RoutedEventArgs e)
        {

        }
    }
}
