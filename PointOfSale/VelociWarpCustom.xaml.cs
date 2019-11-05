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
    /// Interaction logic for VelociWarpCustom.xaml
    /// </summary>
    public partial class VelociWarpCustom : Page
    {
        public VelociWarpCustom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Sends you back when your done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDone(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
            else
            {
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
