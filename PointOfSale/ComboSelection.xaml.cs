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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// Initilizes window
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
            
        }

      
      

        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new BrontowurstCustom());
        }

        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DinoNuggetsCustom());
        }

        private void PBJ_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PrehistoricPBJCustom(new PrehistoricPBJ()));
        }

        private void PterodactylWings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PterodactyWingsCustom());
        }

        private void SteakosarusBurger_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SteakasaurusBurgerCustom());
        }

        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TRexKingBurgerCustom());
        }

        private void VelociWrap_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new VelociWarpCustom());
        }
    }
}
