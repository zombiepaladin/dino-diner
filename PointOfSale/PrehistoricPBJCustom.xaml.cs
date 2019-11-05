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
    /// Interaction logic for PrehistoricPBJCustom.xaml
    /// </summary>
    public partial class PrehistoricPBJCustom : Page

    {

        private PrehistoricPBJ pbj;
        public PrehistoricPBJCustom(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Holds Item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldPBJ(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
        }

        /// <summary>
        /// Sends you back whe your done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHoldDone(object sender, RoutedEventArgs e)
        {
           
           
            
                NavigationService.Navigate(new CustomizeCombo());
            
        }


    }
}
