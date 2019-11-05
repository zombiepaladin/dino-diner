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
    /// Interaction logic for SteakasaurusBurgerCustom.xaml
    /// </summary>
    public partial class SteakasaurusBurgerCustom : Page
    {
        public SteakasaurusBurgerCustom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldBun(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Done with special items sends you back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDone(object sender, RoutedEventArgs e)
        {
           
                NavigationService.Navigate(new CustomizeCombo());
            
        }
    }
}
