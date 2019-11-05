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
    /// Interaction logic for TRexKingBurgerCustom.xaml
    /// </summary>
    public partial class TRexKingBurgerCustom : Page
    {
        public TRexKingBurgerCustom()
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
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldTotmato(object sender, RoutedEventArgs e)
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
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Sends you back after your done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDone(object sender, RoutedEventArgs e)
        {
          
            
                NavigationService.Navigate(new CustomizeCombo());
            
        }
    }
}
